using Data;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RealEstateMap
{

    public partial class Map : Form, IMapView
    {
        // Dictionary to hold county coordinate boundariers
        private Dictionary<string, List<string>> CountyCoordinates;

        // Dictionary to hold overlays
        private static List<GMapOverlay> overlays = new List<GMapOverlay>();

        /// <summary>
        /// Fired when enter button is selected
        /// </summary>
        public event Action<int[]> EnterEvent;

        /// <summary>
        /// Fired when the map view value changes
        /// </summary>
        public event Action MapViewEvent;

        /// <summary>
        /// view constructor
        /// Creates a new real estate data map and loads in the county boundary data
        /// </summary>
        public Map()
        {
            InitializeComponent();
            loadMap();
            //CountyCoordinates = RealEstateData.LoadLocations();
            //loadIncome();
            //loadSales();
        }

        /// <summary>
        /// Loads the map and centers it over the united states, with desired default size metrics
        /// </summary>
        private void loadMap()
        {
            // Initialize map:
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            // Center map over the US
            gmap.Position = new PointLatLng(40, -98);
            this.Size = new Size(1360, 665);
            this.MinimumSize = new Size(1000, 600);
        }



        public void DrawOverlays(Dictionary<string, County> counties)
        {
            // draw points on map
            foreach (KeyValuePair<string, County> county in counties)
            {

                string location = county.Value.location;
                List<string> coords = county.Value.coords;
                double income = county.Value.income;
                double sales = county.Value.sales;
                double scaled = county.Value.scaled;

                // plot data
                GMapOverlay polygons = new GMapOverlay("polygons");
                List<PointLatLng> points = new List<PointLatLng>();

                // split coordinates into lat and long
                foreach (string p in coords)
                {
                    string[] c = p.Split(',');
                    points.Add(new PointLatLng(double.Parse(c[1]), double.Parse(c[0])));
                }

                GMapPolygon polygon = new GMapPolygon(points, location);
                polygons.Polygons.Add(polygon);
                gmap.Overlays.Add(polygons);

                // fill depends on volume of transactions
                //double fill;
                //if (scaled > .66)
                //{
                //    fill = 255 * scaled;
                //    if (fill > 255) fill = 255;
                //    polygon.Fill = new SolidBrush(Color.FromArgb(Convert.ToInt32(fill), Color.Green));
                //    polygon.Stroke = new Pen(Color.Green, 1);
                //}
                //else if (scaled >= .33 && scaled < .66)
                //{
                //    fill = 255 * scaled;
                //    if (fill > 255) fill = 255;
                //    polygon.Fill = new SolidBrush(Color.FromArgb(Convert.ToInt32(fill), Color.GreenYellow));
                //    polygon.Stroke = new Pen(Color.GreenYellow, 1);
                //}
                //else if (scaled < .33)
                //{
                //    fill = 255 * scaled;
                //    if (fill > 255) fill = 255;
                //    polygon.Fill = new SolidBrush(Color.FromArgb(Convert.ToInt32(fill), Color.Yellow));
                //    polygon.Stroke = new Pen(Color.Yellow, 1);
                //}
                double fill = 500 * scaled;
                if (fill > 255) fill = 235;
                else if (fill < 20) fill = 20;
                polygon.Fill = new SolidBrush(Color.FromArgb(Convert.ToInt32(fill), HeatMap((decimal)scaled, 0, (decimal)1)));
                polygon.Stroke = new Pen(Color.FromArgb(Convert.ToInt32(fill), HeatMap((decimal)scaled, 0, (decimal)1)));
                overlays.Add(polygons);
            }

        }

        /// <summary>
        /// Method to determine the color for an inputed value and range
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public Color HeatMap(decimal value, decimal min, decimal max)
        {
            decimal val = (value - min) / (max - min);
            int A, B, R, G;
            A = 255;
            R = Convert.ToByte(255 * val);
            B = Convert.ToByte(255 * (1 - val));
            G = 0;
            return Color.FromArgb(A, R, G, B);
        }


        /// <summary>
        /// Clears all current overlays on the map
        /// </summary>
        public void clearOverlays()
        {
            foreach (GMapOverlay o in overlays)
            {
                o.Polygons.Clear();
                clearTopRegions();
            }
            // reset overlay list
            overlays.Clear();
        }

        /// <summary>
        /// Collects the weights for each metric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void weightButton_Click(object sender, EventArgs e)
        {
            int[] weights = new int[6];
            weights[0] = Convert.ToInt32(salesVolumeWeight.Value);
            weights[1] = Convert.ToInt32(seasonalityWeight.Value); // change to new housing units
            weights[2] = Convert.ToInt32(millenialsWeight.Value); // spell correctly
            weights[3] = Convert.ToInt32(educationWeight.Value); // 
            weights[4] = Convert.ToInt32(incomeWeight.Value); 
            weights[5] = Convert.ToInt32(populationGrowthWeight.Value);

            EnterEvent?.Invoke(weights);
            //MessageBox.Show(gmap.ViewArea.ToString());
        }

        /// <summary>
        /// Displays the top regions to the textbox
        /// </summary>
        /// <param name="state"></param>
        /// <param name="county"></param>
        /// <param name="metric"></param>
        public void DisplayTopRegions(List<string> regions)
        {
            int i = 0;
            foreach (string location in regions)
            {
                if (i < 200)
                {
                    topRegions.Text += location + "\r\n";
                    i++;
                }
            }
            //List<Location> locations = new List<Location>();
            //for (int i = 0; i < 200; i++ )
            //{
            //    locations.Add(new Location { Metric = metric[i], State = state[i], County = county[i] });
            //}
            //var ordered = locations.OrderByDescending(x => x.Metric);
            //int j = 1;
            //foreach (Location l in ordered)
            //{
            //    topRegions.Text += j.ToString() + ". " + l.County + ", " + l.State + ":  " +  l.Metric + "\r\n";
            //    j++;
            //}
        }

        /// <summary>
        /// Clears the textbox cointaing the top regions
        /// </summary>
        private void clearTopRegions()
        {
            topRegions.Text = String.Empty;
        }

        //private class Location
        //{
        //    public double Metric { get; set; }
        //    public string State { get; set; }
        //    public string County { get; set; }
        //}

        /// <summary>
        /// Fired when the value of the map view changes
        /// 0 - county view
        /// 1 - city view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapView_ValueChanged(object sender, EventArgs e)
        {
            MapViewEvent?.Invoke();
            if (mapView.Value == 1)
            {
                clearOverlays();
            }
            else if (mapView.Value == 0)
            {
                overlays.Clear();
                //loadIncome();
                //loadSales();
            }
        }
    }
}
