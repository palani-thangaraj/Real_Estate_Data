using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateMap
{
    public interface IMapView
    {
        /// <summary>
        /// The event  tions maps the view to the controller
        /// </summary>
        event Action<int[]> EnterEvent;
        event Action MapViewEvent;

        /// <summary>
        /// The event actions maps the controller to the view
        void DrawOverlays(Dictionary<string, County> Counties);
        void clearOverlays();
        void DisplayTopRegions(List<string> regions);
    }
}
