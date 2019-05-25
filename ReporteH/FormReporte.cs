using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReporteH.mysql;
using MySql.Data.MySqlClient;

namespace ReporteH
{
    public partial class FormReporte : Form
    {
        private int id_reporte;
        private string tipot;
        public FormReporte(int id, string tipo)
        {
            id_reporte = id;
            tipot = tipo;
            MessageBox.Show(tipo+id);
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void FormReporte_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Wey, va chido. Y el tipo es: " + tipot);
                switch (tipot)
                {
                    case "seguridad":
                        string robo;
                        MySqlCommand cmd2 = new MySqlCommand(String.Format(
                            "SELECT DISTINCT " +
                            "DELITO FROM REPORTE " +
                            "JOIN USUARIO ON REPORTE.ID_USUARIO = USUARIO.ID_USUARIO " +
                            "JOIN SEGURIDAD ON SEGURIDAD.ID_REPORTE = REPORTE.ID_REPORTE " +
                            "JOIN DELITO ON SEGURIDAD.ID_DELITO = DELITO.ID_DELITO " +
                            "WHERE REPORTE.ID_REPORTE = "+id_reporte+" "), conexion.obtenerConexion());
                        MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        if (dt2.Rows.Count == 1)
                        {
                            robo = dt2.Rows[0][0].ToString();
                            MessageBox.Show("El delito es: "+robo);
                            if (robo.Equals("Robo"))
                            {
                                MySqlCommand cmd3 = new MySqlCommand(String.Format("SELECT REPORTE.ID_REPORTE, ESTADO, " +
                                    "FECHA, DIRECCION, DESCRIPCION, USUARIO.NOMBRE, USUARIO.APELLIDOP,SEGURIDAD.VIOLENCIA,DELITO.DELITO," +
                                    "SUBDELITO.SUBDELITO, IMAGEN FROM REPORTE JOIN  USUARIO ON REPORTE.ID_USUARIO = USUARIO.ID_USUARIO " +
                                    "JOIN SEGURIDAD ON SEGURIDAD.ID_REPORTE = REPORTE.ID_REPORTE " +
                                    "JOIN DELITO ON SEGURIDAD.ID_DELITO = DELITO.ID_DELITO " +
                                    "JOIN SUBDELITO ON DELITO.ID_SUBDELITO = SUBDELITO.ID_SUBDELITO WHERE REPORTE.ID_REPORTE = " + id_reporte), conexion.obtenerConexion());
                                MySqlDataAdapter sda3 = new MySqlDataAdapter(cmd3);
                                DataTable dt3 = new DataTable();
                                sda3.Fill(dt3);
                                if (dt3.Rows.Count == 1)
                                {
                                    if (robo.Equals("Robo"))
                                    { 
                                        reporteNo.Text = dt3.Rows[0][0].ToString(); //NÚMERO DE REPORTE
                                        label4.Text = dt3.Rows[0][1].ToString(); //ESTADO DEL REPORTE
                                        nombre.Text = dt3.Rows[0][5].ToString(); //NOMBRE DEL USUARIO
                                        apellido.Text = dt3.Rows[0][6].ToString(); //APELLIDOS DEL USUARIO
                                        direccion.Text = dt3.Rows[0][3].ToString(); //DIRECCIÓN DEL USUARIO
                                        fecha.Text = dt3.Rows[0][2].ToString(); //FECHA DEL REPORTE
                                        Desc.Text = dt3.Rows[0][4].ToString(); //DESCRIPCIÓN DEL REPORTE
                                    }
                                }
                            }
                            else
                            {
                                MySqlCommand cmd5 = new MySqlCommand(String.Format("SELECT DISTINCT REPORTE.ID_REPORTE, ESTADO, FECHA, " +
                                    "DIRECCION, DESCRIPCION, USUARIO.NOMBRE, " +
                                    "USUARIO.APELLIDOP,SEGURIDAD.VIOLENCIA,DELITO.DELITO, " +
                                    "IMAGEN FROM REPORTE JOIN  USUARIO ON REPORTE.ID_USUARIO = USUARIO.ID_USUARIO " +
                                    "JOIN SEGURIDAD ON SEGURIDAD.ID_REPORTE = REPORTE.ID_REPORTE " +
                                    "JOIN DELITO ON SEGURIDAD.ID_DELITO = DELITO.ID_DELITO WHERE REPORTE.ID_REPORTE = " + id_reporte), conexion.obtenerConexion());
                                MySqlDataAdapter sda5 = new MySqlDataAdapter(cmd5);
                                DataTable dt5 = new DataTable();
                                sda5.Fill(dt5);
                                if (dt5.Rows.Count == 1)
                                {
                                        reporteNo.Text = dt5.Rows[0][0].ToString(); //NÚMERO DE REPORTE
                                        label4.Text = dt5.Rows[0][1].ToString(); //ESTADO DEL REPORTE
                                        nombre.Text = dt5.Rows[0][5].ToString(); //NOMBRE DEL USUARIO
                                        apellido.Text = dt5.Rows[0][6].ToString(); //APELLIDOS DEL USUARIO
                                        direccion.Text = dt5.Rows[0][3].ToString(); //DIRECCIÓN DEL USUARIO
                                        fecha.Text = dt5.Rows[0][2].ToString(); //FECHA DEL REPORTE
                                        Desc.Text = dt5.Rows[0][4].ToString(); //DESCRIPCIÓN DEL REPORTE
                                }
                            }
                        }
                        break;
                    case "luz":
                        MySqlCommand cmd4 = new MySqlCommand(String.Format(
                            "SELECT DISTINCT " +
                            "REPORTE.ID_REPORTE, ESTADO, FECHA, DIRECCION, DESCRIPCION, " +
                            "USUARIO.NOMBRE, USUARIO.APELLIDOP, LUMINARIAS.NO_POSTE, " +
                            "IMAGEN " +
                            "FROM REPORTE JOIN  USUARIO ON REPORTE.ID_USUARIO = USUARIO.ID_USUARIO " +
                            "JOIN LUMINARIAS ON LUMINARIAS.ID_REPORTE = REPORTE.ID_REPORTE  " +
                            "WHERE REPORTE.ID_REPORTE = " + id_reporte + " "), conexion.obtenerConexion());
                        MySqlDataAdapter sda4 = new MySqlDataAdapter(cmd4);
                        DataTable dt4 = new DataTable();
                        sda4.Fill(dt4);
                        if (dt4.Rows.Count == 1)
                        {
                            nombre.Text = dt4.Rows[0][5].ToString();
                            apellido.Text = dt4.Rows[0][6].ToString();
                            reporteNo.Text = dt4.Rows[0][0].ToString();
                            fecha.Text = dt4.Rows[0][2].ToString();
                            Desc.Text = dt4.Rows[0][3].ToString();
                        }
                        break;
                    case "bache":
                        MySqlCommand cmd8 = new MySqlCommand(String.Format("SELECT DISTINCT REPORTE.ID_REPORTE, ESTADO, FECHA, " +
                            "DIRECCION, DESCRIPCION, USUARIO.NOMBRE, " +
                            "USUARIO.APELLIDOP, MATERIAL_BACHE.MATERIAL, IMAGEN " +
                            "FROM REPORTE JOIN  USUARIO ON REPORTE.ID_USUARIO = USUARIO.ID_USUARIO " +
                            "JOIN BACHES ON BACHES.ID_REPORTE = REPORTE.ID_REPORTE " +
                            "JOIN MATERIAL_BACHE ON MATERIAL_BACHE.ID_MATERIAL = BACHES.ID_MATERIAL WHERE REPORTE.ID_REPORTE = " + id_reporte + " "), conexion.obtenerConexion());
                        MySqlDataAdapter sda8= new MySqlDataAdapter(cmd8);
                        DataTable dt8 = new DataTable();
                        sda8.Fill(dt8);
                        if (dt8.Rows.Count == 1)
                        {
                            nombre.Text = dt8.Rows[0][5].ToString();
                            apellido.Text = dt8.Rows[0][6].ToString();
                            reporteNo.Text = dt8.Rows[0][0].ToString();
                            fecha.Text = dt8.Rows[0][2].ToString();
                            Desc.Text = dt8.Rows[0][3].ToString();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
