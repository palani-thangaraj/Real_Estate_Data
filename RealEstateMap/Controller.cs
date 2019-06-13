using Data;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateMap
{
    public class Controller
    {
        // the window being controlled
        private IMapView map;

        // the model being used
        private RealEstateData data;

        public Controller(IMapView map)
        {
            this.map = map;
            this.data = new RealEstateData();
            map.EnterEvent += HandleUpdateMap;
            map.MapViewEvent += HandleUpdateView;
        }

        /// <summary>
        /// Updates the map to handle the desired variable weights
        /// </summary>
        /// <param name="weights"></param>
        private void HandleUpdateMap(int[] weights)
        {
            Dictionary<string, County> Counties = data.LoadData(weights);
            map.DisplayTopRegions(data.TopRegions(Counties));
            map.clearOverlays();
            map.DrawOverlays(Counties);
        }

        private void HandleUpdateView()
        {
        }

    }
}
