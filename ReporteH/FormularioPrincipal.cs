using ReporteH.mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ReporteH
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("datasource=206.189.167.218; port=3306; username=remoto; password=Re-123456789; database=REPORTEH");
        # region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Capturar Posicion y tamaño antes de maximizar para restaurar 
        int lx, ly;
        int sw, sh;

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void PanelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void Ingresar_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conexion.obtenerConexion();
            MessageBox.Show("Conexión exitosa");
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault(); //Busca en la colecciòn el formulario
            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
            }
        }

        public void logear (string usuario,string contraseña)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format( "SELECT USUARIO.nombre, apellidoP, ROL.NOMBRE FROM USUARIO JOIN ROL ON USUARIO.ID_ROL = ROL.ID_ROL  where email ='{0}' and clave='{1}'", usuario, contraseña),conexion.obtenerConexion());
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                String Almacena;
                sda.Fill(dt);
                if (dt.Rows.Count ==1)
                {
                    {
                        if(dt.Rows[0][2].ToString()=="SEGURIDAD")
                        {
                            AbrirFormEnPanel<FormSeguridad>();
                            Almacena = "Bienvenido señor" + " " + "\n" + dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                            MessageBox.Show(Almacena,"Bienvenido", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else if (dt.Rows[0][2].ToString() == "LUZ")
                        {
                           Almacena = "Bienvenido señor" + " "+"\n"+dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                            MessageBox.Show(Almacena, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AbrirFormEnPanel<FormLuminaria>();
                        }
                        else if (dt.Rows[0][2].ToString() == "BACHES")
                        {
                            Almacena = "Bienvenido señor" + " " + "\n" + dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                            MessageBox.Show(Almacena, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AbrirFormEnPanel<FormBaches>();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conectar.Close();
            }
        }
    }
}
