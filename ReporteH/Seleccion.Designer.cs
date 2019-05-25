namespace ReporteH
{
    partial class Seleccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.Semana = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelAño = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioT = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.Semana.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnRegresar.Location = new System.Drawing.Point(66, 262);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 32);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBuscar.Location = new System.Drawing.Point(171, 262);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 32);
            this.btBuscar.TabIndex = 44;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // Semana
            // 
            this.Semana.Controls.Add(this.dateTimePicker2);
            this.Semana.Controls.Add(this.dateTimePicker1);
            this.Semana.Controls.Add(this.label1);
            this.Semana.Controls.Add(this.label2);
            this.Semana.Font = new System.Drawing.Font("Corbel", 11F);
            this.Semana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Semana.Location = new System.Drawing.Point(12, 12);
            this.Semana.Margin = new System.Windows.Forms.Padding(2);
            this.Semana.Name = "Semana";
            this.Semana.Padding = new System.Windows.Forms.Padding(2);
            this.Semana.Size = new System.Drawing.Size(260, 97);
            this.Semana.TabIndex = 42;
            this.Semana.TabStop = false;
            this.Semana.Text = "Semana";
            this.Semana.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 25);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.labelAño);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 11F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 97);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mensual";
            this.groupBox3.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 11F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 97);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diario";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(45, 24);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker4.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(5, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Día";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comboBox2.Location = new System.Drawing.Point(45, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 26);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.Text = "2019";
            this.comboBox2.Visible = false;
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Corbel", 11F);
            this.labelAño.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAño.Location = new System.Drawing.Point(5, 28);
            this.labelAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(34, 18);
            this.labelAño.TabIndex = 37;
            this.labelAño.Text = "Año";
            this.labelAño.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(45, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 26);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mes";
            this.label3.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 25);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "A partir del día:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hasta el día:";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioT);
            this.groupBox2.Controls.Add(this.radioB);
            this.groupBox2.Controls.Add(this.radioA);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 11F);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 113);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // radioT
            // 
            this.radioT.AutoSize = true;
            this.radioT.Checked = true;
            this.radioT.Location = new System.Drawing.Point(6, 23);
            this.radioT.Name = "radioT";
            this.radioT.Size = new System.Drawing.Size(63, 22);
            this.radioT.TabIndex = 9;
            this.radioT.TabStop = true;
            this.radioT.Text = "Todos";
            this.radioT.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(6, 79);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(103, 22);
            this.radioB.TabIndex = 8;
            this.radioB.TabStop = true;
            this.radioB.Text = "No Atendido";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(6, 51);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(83, 22);
            this.radioA.TabIndex = 7;
            this.radioA.TabStop = true;
            this.radioA.Text = "Atendido";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Semana);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.Load += new System.EventHandler(this.Seleccion_Load);
            this.Semana.ResumeLayout(false);
            this.Semana.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox Semana;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioT;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label5;
    }
}