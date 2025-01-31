﻿using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data
{
    public class RealEstateData
    {
        // Dictionary to hold county coordinate boundariers
        private Dictionary<string, List<string>> CountyCoordinates;

        // Dictionary to hold overlays
        private List<GMapOverlay> overlays = new List<GMapOverlay>();

        /// <summary>
        /// Default constructor
        /// </summary>
        public RealEstateData()
        {
        }


        // Read in county and zip boundaries and substitute county names for fips code
        // Figure out a c# api or call the python api somehow??????????????????


        // Load the user input data in and count how many locations were successfully read and how many were not
        // store the data in three separate dictionaries [zip, county, state], depending on how the data is inputted,
        // this may require some consolidation [i.e. matching zip codes to states]

        // As the code develops, need to start using sql to implement a database

        


        /// <summary>
        /// Method to read in all the data points for each data metric and return it to a hash table
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, County> LoadData(int[] weights)
        {
            // dictionary to hold all data for each county
            Dictionary<string, County> Counties = new Dictionary<string, County>();

            // if no weights selected, return empty dictionary
            if (weights.Average() == 0) return Counties;
            
            // load locations
            CountyCoordinates = LoadBoundaries();

            // load median income
            List<string> country = new List<string>();
            List<string> county = new List<string>();
            List<string> state = new List<string>();
            List<double> income = new List<double>();
            using (var reader = new StreamReader("County_Income_Data.csv"))
            {
                string headerLine = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    country.Add(values[1]);
                    county.Add(values[3]);
                    state.Add(values[2]);
                    income.Add(double.Parse(values[4]));
                }
            }
            // min and max data points
            double min_avg = income.Min();
            double max_avg = income.Max();

            // draw points on map
            for (int i = 0; i < county.Count; i++)
            {
                // scale data
                double scaled = ((income[i] - min_avg) / (max_avg - min_avg));

                // get coordinates
                string location = country[i] + state[i] + county[i];
                location = location.ToLower();
                location = Regex.Replace(location, @"[^\w]", string.Empty);
                location = location.Replace("county", string.Empty);
                List<string> coords = CountyCoordinates[location];
                County newCounty = new County(location, coords);
                newCounty.income = income[i];
                newCounty.scaled = scaled * weights[4]/100;
                if (Counties.ContainsKey(location))
                {
                    County currCounty = Counties[location];
                    currCounty.income = (currCounty.income + income[i]) / 2;
                    currCounty.scaled = (currCounty.scaled + scaled * weights[4]/100) / 2;
                }
                else
                {
                    Counties.Add(location, newCounty);
                }
            }

            // load sales volumes
            county = new List<string>();
            state = new List<string>();
            List<double> avg = new List<double>();
            using (var reader = new StreamReader("CompiledSalesData.csv"))
            {
                string headerLine = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    county.Add(values[2]);
                    state.Add(values[3]);
                    avg.Add(double.Parse(values[141]));
                }
            }
            // min and max data points
            min_avg = avg.Min();
            max_avg = avg.Max();

            // find second highest point since phoenix skews the data
            var secondMax_avg = avg.OrderByDescending(x => x).Skip(1).FirstOrDefault();

            // draw points on map
            for (int i = 0; i < county.Count; i++)
            {
                // scale data
                double scaled = ((avg[i] - min_avg) / (secondMax_avg - min_avg));
                if (scaled > 1) scaled = 1;
                // get coordinates
                string location = "United States" + state[i] + county[i];
                location = location.ToLower();
                location = Regex.Replace(location, @"[^\w]", string.Empty);
                location = location.Replace("county", string.Empty);
                List<string> coords = CountyCoordinates[location];
                if (Counties.ContainsKey(location))
                {
                    County currCounty = Counties[location];
                    currCounty.sales = avg[i];
                    currCounty.scaled = currCounty.scaled + scaled*weights[0]/100;
                }
                else
                {
                    County newCounty = new County(location, coords);
                    Counties.Add(location, newCounty);
                }
            }
            return Counties;
        }



        /// <summary>
        /// Method to load in the boundary coordinates for each county in America
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<string>> LoadBoundaries()
        {
            Dictionary<string, List<string>> CountyCoordinates = new Dictionary<string, List<string>>();
            List<string> locationList = new List<string>();
            var doc = XDocument.Load("gadm36_USA.kml");
            XNamespace ns = "http://www.opengis.net/kml/2.2";
            var result = doc.Root.Descendants(ns + "Placemark");

            List<XElement> simpleFields;
            List<XElement> extendedDatas = doc.Descendants(ns + "ExtendedData").ToList();

            // This is going to be the implementation I use
            using (var e1 = extendedDatas.GetEnumerator())
            using (var e2 = result.GetEnumerator())
            {
                while(e1.MoveNext() && e2.MoveNext())
                {
                    simpleFields = e1.Current.Descendants(ns + "SimpleData").ToList();
                    locationList = e2.Current.Element(ns + "MultiGeometry").Element(ns + "Polygon").Element(ns + "outerBoundaryIs").Element(ns + "LinearRing").Element(ns + "coordinates").Value.Split(' ').ToList();
                    var country = simpleFields[0].Value;
                    var state = simpleFields[1].Value;
                    var county = simpleFields[2].Value;
                }
            }

            // get the regions
            foreach (XElement extendedData in extendedDatas)
            {
                simpleFields = extendedData.Descendants(ns + "SimpleData").ToList();
                var country = simpleFields[0].Value;
                var state = simpleFields[1].Value;
                var county = simpleFields[2].Value; 
            }

            // get the coordinates
            foreach (XElement xmlInfo in result)
            {
                var test = xmlInfo.Element(ns + "ExtendedData");
                var region = xmlInfo.Element(ns + "ExtendedData").Element(ns + "SchemaData").Value;
                locationList = xmlInfo.Element(ns + "MultiGeometry").Element(ns + "Polygon").Element(ns + "outerBoundaryIs").Element(ns + "LinearRing").Element(ns + "coordinates").Value.Split(' ').ToList();
                region = region.ToLower();
                region = Regex.Replace(region, @"[^\w]", string.Empty);
                CountyCoordinates.Add(region, locationList);
            }
            return CountyCoordinates;
        }

        private List<string> getCoords(County county)
        {
            List<string> coords = new List<string>();


            return coords;
        }

        /// <summary>
        /// returs an ordered list of the top regions
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<string> TopRegions(Dictionary<string, County> data)
        {
            return data.OrderByDescending(x => x.Value.scaled).Select(x => x.Key).ToList();
        }
    }

    /// <summary>
    /// Class to hold Data metrics
    /// </summary>
    public class County
    {
        // county state
        public string state { get; set; }
        // county
        public string county { get; set; }
        // county location
        public string location { get; set; }
        // county coordinates
        public List<string> coords { get; set; }
        // county median income
        public double income { get; set; }
        // county sales volume
        public double sales { get; set; }
        // county scaled and weighed data metric
        public double scaled { get; set; }
        public County(string location, List<string> coords)
        {
            this.location = location;
            this.coords = coords;
        }

        public County (string state, string county)
        {
            this.state = state;
            this.county = county;
        }
    }
}
