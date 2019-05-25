using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using ReporteH.mysql;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ReporteH
{
    public partial class FormBaches : Form
    {
        private string busqueda; //Acumulador de String para hacer
        BaseDeDatos bd = new BaseDeDatos(); //Biblioteca de Clases
        mapConnect.mapTeh mapa = new mapConnect.mapTeh();
        mapConnect.mapDB ciclos = new mapConnect.mapDB();

        public FormBaches()
        {
            InitializeComponent();
        }
        public FormBaches(string consulta)
        {
            busqueda = consulta;
            MessageBox.Show(consulta + " Ya llegaste al constructor --------------- \n" + busqueda);
        }        
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int numero = 0;
        
        private void Acptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //MessageBox.Show("hola"+id);
            }
        }

        private void FormBaches_Load(object sender, EventArgs e)
        {
            mapa.mapConexion(gMapControl1);
            dataGridView1.DataSource = bd.SelectDataTable("select " +
                        " ID_REPORTE AS 'Número de Reporte', " +
                        " DATE_FORMAT(FECHA,'%d/%m/%Y') AS 'Fecha', " +
                        " DESCRIPCION as 'Descripción' ," +
                        " ID_TIPO_REPORTE  " +
                        " from REPORTE " +
                        " where ID_TIPO_REPORTE = 3  " +
                        " ORDER BY 2 DESC, 1 desc");
        }

       /* private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MessageBox.Show("Estoy en la primera", "first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // dataGridView1.DataSource = bd.SelectDataTable(busqueda + " and ID_TIPO_REPORTE = 1");
                MessageBox.Show("Estoy en la segunda", "first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id;
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    FormReporte a = new FormReporte(id, "bache");
                    a.ShowDialog();
                }
            }
            catch(System.InvalidCastException exc)
            {
                MessageBox.Show(""+exc);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
