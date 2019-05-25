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

namespace ReporteH
{
    public partial class FormLuminaria : Form
    {
        public FormLuminaria()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        string busqueda = "";
        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int numero = 0;
        mapConnect.mapTeh mapa = new mapConnect.mapTeh();
        mapConnect.mapDB ciclos = new mapConnect.mapDB();
        private void FormLuminaria_Load(object sender, EventArgs e)
        {
            mapa.mapConexion(gMapControl1);
            dataGridView1.DataSource = bd.SelectDataTable("select " +
                        " ID_REPORTE AS 'Número de Reporte', " +
                        " DATE_FORMAT(FECHA,'%d/%m/%Y') AS 'Fecha', " +
                        " DESCRIPCION as 'Descripción' ," +
                        " ID_TIPO_REPORTE  " +
                        " from REPORTE " +
                        " where ID_TIPO_REPORTE = 2  " +
                        " ORDER BY 2 DESC, 1 desc");
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                FormReporte a = new FormReporte(id, "luz");
                a.ShowDialog();
            }
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                FormReporte a = new FormReporte(id, "luz");
                a.ShowDialog();
            }
        }
    }
}
