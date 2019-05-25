using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ReporteH.mysql;

namespace ReporteH.mapConnect
{
    class mapDB
    {
        BaseDeDatos bd = new BaseDeDatos();
        public void cargarMarcas(GMapControl perro, double lat, double longi)
        {
            PointLatLng point = new PointLatLng(lat, longi);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            perro.Overlays.Add(markers);
        }

        public void cicloMarcas(GMapControl mapa, string DONDE)
        {
            try
            {
                string contar="";
                int cuantos=0;
                string datos = "";
                string lat, longi;
                if(DONDE.Equals("TODOS"))
                {
                    MySqlCommand cmd = new MySqlCommand(String.Format("SELECT count(id_reporte) FROM REPORTE", contar), conexion.obtenerConexion());
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        datos = dt.Rows[0][0].ToString();
                        cuantos = Convert.ToInt32(datos);
                        for (int i = 0; i < cuantos; i++)
                        {
                            MySqlCommand cmd2 = new MySqlCommand(String.Format("SELECT latitud, longitud FROM REPORTE  where id_reporte = " + i), conexion.obtenerConexion());
                            MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);
                            if (dt2.Rows.Count == 1)
                            {
                                lat = dt2.Rows[0][0].ToString();
                                longi = dt2.Rows[0][1].ToString();
                                cargarMarcas(mapa, Convert.ToDouble(lat), Convert.ToDouble(longi));
                            }
                        }
                    }
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(String.Format("SELECT count(id_reporte) FROM REPORTE where ESTADO = '" + DONDE + "'", contar), conexion.obtenerConexion());
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        datos = dt.Rows[0][0].ToString();
                        cuantos = Convert.ToInt32(datos);
                        for (int i = 0; i < cuantos; i++)
                        {
                            MySqlCommand cmd2 = new MySqlCommand(String.Format("SELECT latitud, longitud FROM REPORTE  where id_reporte = " + i + " AND ESTADO = '" + DONDE + "'"), conexion.obtenerConexion());
                            MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);
                            if (dt2.Rows.Count == 1)
                            {
                                lat = dt2.Rows[0][0].ToString();
                                longi = dt2.Rows[0][1].ToString();
                                cargarMarcas(mapa, Convert.ToDouble(lat), Convert.ToDouble(longi));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
