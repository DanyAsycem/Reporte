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
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ReporteH
{
    public partial class Seleccion : Form
    {
        private int numero;
        public string perro = "";
        public Seleccion(string n)
        {
            InitializeComponent();
            numero = Convert.ToInt32(n);
           // MessageBox.Show(n);
        }
        private void Seleccion_Load(object sender, EventArgs e)
        { 
            if (numero == 4)
            {
               // groupBox4.Visible = true;
                //dateTimePicker4.Visible = true;
                //label5.Visible = true;
            }
            else if (numero == 2)
            {
                Semana.Visible = true; 
                label1.Visible = true; 
                label2.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                groupBox4.Visible = false;
                dateTimePicker4.Visible = false;
                label5.Visible = false;

            }
            else if (numero == 3)
            {
                groupBox4.Visible = false;
                dateTimePicker4.Visible = false;
                label5.Visible = false;
                groupBox3.Visible = true;
                label3.Visible = true;
                labelAño.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
               
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string consulta="";
            string consultam="";
            if (radioT.Checked)
            {
                if (numero == 4) //Diario, TODOS
                {
                    consulta = "select " +
                        " id_reporte AS 'Numero de Reporte'," +
                        " DATE_FORMAT(fecha,'%d/%m/%Y')  AS 'Fecha', " +
                        " descripcion as 'Descripcion' " +
                        " from REPORTE where DATE_FORMAT(fecha,'%d/%m/%Y')='" + dateTimePicker4.Text + "'";
                    consultam = "TODOS";
                }
                else if(numero == 2) //Semanal, TODOS
                {
                    consulta = "select  " +
                        " id_reporte as 'Número de Reporte', " +
                        " DATE_FORMAT(fecha,'%d/%m/%Y') AS 'Fecha', " +
                        " descripcion as 'Descripción' " +
                        " from REPORTE " +
                        " where DATE_FORMAT(fecha,'%d/%m/%Y') between'" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'";
                    consultam = "TODOS";
                }
                else if (numero==3) //Mensual, TODOS
                {
                    consulta = "select " +
                        " id_reporte AS 'Número de Reporte," +
                        " fecha as 'Fecha'," +
                        " descripcion as 'Descripción' " +
                        " from REPORTE " +
                        " where MONTH(fecha)='" + comboBox1.Text + "' and YEAR(fecha)='"+comboBox2.Text+"'";
                    consultam = "TODOS";
                }
            }
            else if(radioA.Checked)
            {
                if (numero == 4) //Diario, Atendidos
                {
                    consulta = "select " +
                        " id_reporte AS 'Número de Reporte', " +
                        " DATE_FORMAT(fecha,'%d/%m/%Y') as 'Fecha' ," +
                        " descripcion as 'Descripción' " +
                        " from REPORTE where DATE_FORMAT(fecha,'%d/%m/%Y')='" + dateTimePicker4.Text + "' " +
                        " AND ESTADO = 'ATENDIDO'";
                    consultam = "ATENDIDO";
                }
                else if (numero == 2)
                {
                    consulta = "select  " +
                        " id_reporte as 'Número de Reporte', " +
                        " DATE_FORMAT(fecha,'%d/%m/%Y') AS 'Fecha', " +
                        " descripcion as 'Descripción' " +
                        " from REPORTE " +
                        " where DATE_FORMAT(fecha,'%d/%m/%Y') between'" + dateTimePicker1.Text + "'and '" + dateTimePicker2.Text + "' " +
                        " AND ESTADO = 'ATENDIDO'";
                    consultam = "ATENDIDO";
                }
                else if (numero == 3)
                {
                    consulta = "select " +
                        " id_reporte AS 'Número de Reporte," +
                        " fecha as 'Fecha'," +
                        " descripcion as 'Descripción'" +
                        " from REPORTE " +
                        " where MONTH(fecha)='" + comboBox1.Text + "' and YEAR(fecha)='" + comboBox2.Text + "' " +
                        " AND ESTADO = 'ATENDIDO'";
                    consultam = "ATENDIDO";
                }
            }
            else if(radioB.Checked) 
            {
                if (numero == 4) //Diario, NO ATENDIDOS
                {
                    consulta = "select " +
                       " id_reporte AS 'Número de Reporte'," +
                       " DATE_FORMAT(fecha,'%d/%m/%Y')  AS 'Fecha', " +
                       " descripcion as 'Descripción" +
                       " from REPORTE " +
                       " where DATE_FORMAT(fecha,'%d/%m/%Y')='" + dateTimePicker4.Text + "' " +
                       " and estado = 'NO ATENDIDO'";
                    consultam = "NO ATENDIDO";
                }
                else if (numero == 2)
                {
                    consulta = "select  " +
                        " id_reporte as 'Número de Reporte', " +
                        " DATE_FORMAT(fecha,'%d/%m/%Y') AS 'Fecha', " +
                        " descripcion as 'Descripción' " +
                        " from REPORTE " +
                        " where DATE_FORMAT(fecha,'%d/%m/%Y') between'" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' " +
                        " AND ESTADO = 'NO ATENDIDO'";
                    consultam = "NO ATENDIDO";
                }
                else if (numero == 3)
                {
                    consulta = "select " +
                        " id_reporte AS 'Número de Reporte," +
                        " DATE_FORMAT(fecha,'%d/%m/%Y') AS 'Fecha', " +
                        " descripcion as 'Descripción'" +
                        " from REPORTE " +
                        " where MONTH(fecha)='" + comboBox1.Text + "' and YEAR(fecha)='" + comboBox2.Text + "' " +
                        " AND ESTADO = 'NO ATENDIDO'";
                    consultam = "NO ATENDIDO";
                }
            }
            MessageBox.Show(consulta, consultam); 
            this.Hide();
            perro = consulta;
            FormSeguridad frm = new FormSeguridad(consulta);
            //frm.getConsulta(consulta);
           
        }
    }
}
