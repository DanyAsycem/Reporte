using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace ReporteH.mapConnect
{
    class mapTeh
    {
        public void mapConexion(GMapControl mapa)
        {
            mapa.DragButton = System.Windows.Forms.MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.Position = new PointLatLng(18.462951, -97.394218);
            mapa.SetPositionByKeywords("Tehuacán, Puebla, México");
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 13;
            mapa.AutoScroll = true;
            mapa.MarkersEnabled = true;
            mapa.Zoom++;
            mapa.Zoom--;

            CargarTehuacán(mapa);
        }

        private void CargarTehuacán(GMapControl mapa)
        {
            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(18.507840, -97.428465));
            points.Add(new PointLatLng(18.505926, -97.388431));
            points.Add(new PointLatLng(18.416369, -97.359112));
            points.Add(new PointLatLng(18.441066, -97.382116));
            points.Add(new PointLatLng(18.430634, -97.399800));
            points.Add(new PointLatLng(18.415451, -97.408144));
            points.Add(new PointLatLng(18.447417, -97.434482));
            points.Add(new PointLatLng(18.491337, -97.454722));
            points.Add(new PointLatLng(18.481405, -97.435836));
            GMapPolygon polygon = new GMapPolygon(points, "Tehuacán");
            polygons.Polygons.Add(polygon);
            mapa.Overlays.Add(polygons);
            mapa.Zoom++;
            mapa.Zoom--;
        }

        public void obtenerConsulta(GMapMarker item, System.Windows.Forms.MouseEventArgs e, double latitud, double longitud, GMapControl mapa)
        {
            latitud = mapa.FromLocalToLatLng(e.X, e.Y).Lat;
            longitud = mapa.FromLocalToLatLng(e.X, e.Y).Lng;
        }


    }
}
