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
    public partial class FormSeguridad : Form
    {
        private string busqueda; //Acumulador de String para hacer consultas
        BaseDeDatos bd = new BaseDeDatos();
        mapConnect.mapTeh mapa = new mapConnect.mapTeh();
        mapConnect.mapDB ciclos = new mapConnect.mapDB();

        public FormSeguridad()
        {
            InitializeComponent();
        }
        public FormSeguridad(string consulta)
        {
            busqueda = consulta;
            MessageBox.Show(consulta + " Ya llegaste al constructor --------------- \n" + busqueda);
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSeguridad_Load(object sender, EventArgs e)
        {
            mapa.mapConexion(gMapControl1);
            dataGridView1.DataSource = bd.SelectDataTable("select " +
                        " ID_REPORTE AS 'Número de Reporte', " +
                        " DATE_FORMAT(FECHA,'%d/%m/%Y') AS 'Fecha', " +
                        " DESCRIPCION as 'Descripción' ," +
                        " ID_TIPO_REPORTE  " +
                        " from REPORTE " +
                        " where ID_TIPO_REPORTE = 1  " +
                        " ORDER BY 2 DESC, 1 desc");
            //ciclos.cicloMarcas(gMapControl1, a.consultam);
        }
        private void Btaceptar2_Click(object sender, EventArgs e)
        {
            /*  if (radioT.Checked)
              {
                  busqueda = "select  id_reporte as 'Número de Reporte', DATE_FORMAT(fecha,'%d/%m/%Y') AS Fecha, descripcion as 'Descripción' from REPORTE where DATE_FORMAT(fecha,'%d/%m/%Y') between'" + dateTimePicker1.Text + "'and '" + dateTimePicker2.Text + "'";
                  //' and MONTh(fecha) between'"+ texd3.Text+"'and '"+texd4.Text+"'";
                  String cad = dateTimePicker1.Text;
                  //MessageBox.Show(cad);
              }*/
            dataGridView1.DataSource = bd.SelectDataTable(busqueda);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int numero = 3;
            Seleccion frm = new Seleccion(numero.ToString());
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int numero = 2;
            Seleccion frm = new Seleccion(numero.ToString());
            frm.ShowDialog();
        }

        private void Acptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                //AbrirFormEnPanel<FormReporte>();

            }
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            int numero = 4;
            Seleccion frm = new Seleccion(numero.ToString());
            frm.ShowDialog();
        }

        public void llenaTabla(string txt)
        {
            dataGridView1.DataSource = bd.SelectDataTable(txt);
        }

      /*  private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MessageBox.Show("Estoy en la primera", "first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //dataGridView1.DataSource = bd.SelectDataTable(this.busqueda);
                // dataGridView1.DataSource = bd.SelectDataTable(busqueda + " and ID_TIPO_REPORTE = 1");
                MessageBox.Show("Estoy en la segunda", "first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
        private void Button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(busqueda);
            //FormSeguridad a = new FormSeguridad();
            gMapControl1.Width = 620;
            dataGridView1.DataSource = bd.SelectDataTable("SELECT DISTINCT REPORTE.ID_REPORTE, ESTADO, FECHA, DIRECCION, DESCRIPCION, USUARIO.NOMBRE, USUARIO.APELLIDOP,SEGURIDAD.VIOLENCIA,DELITO.DELITO, IMAGEN FROM REPORTE JOIN  USUARIO ON REPORTE.ID_USUARIO = USUARIO.ID_USUARIO JOIN SEGURIDAD ON SEGURIDAD.ID_REPORTE = REPORTE.ID_REPORTE JOIN DELITO ON SEGURIDAD.ID_DELITO = DELITO.ID_DELITO WHERE REPORTE.ID_REPORTE = 56 AND ID_TIPO_REPORTE = 1");
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id;
            if(dataGridView1.SelectedRows.Count == 1)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                FormReporte a = new FormReporte(id, "seguridad");
                a.ShowDialog();
            }
        }
    }
}
