namespace GestionVacantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_EmpresasReclutamiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DocumentoReclutamiento = new System.Windows.Forms.TextBox();
            this.tb_NombreReclutamiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CelularReclutamiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_CargosReclutamiento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_FasesReclutamiento = new System.Windows.Forms.ComboBox();
            this.dt_FechaReclutamiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button_RegistrarReclutamiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECLUTAMIENTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_EmpresasReclutamiento
            // 
            this.cb_EmpresasReclutamiento.FormattingEnabled = true;
            this.cb_EmpresasReclutamiento.Items.AddRange(new object[] {
            "Marval",
            "Cajasan"});
            this.cb_EmpresasReclutamiento.Location = new System.Drawing.Point(132, 252);
            this.cb_EmpresasReclutamiento.Name = "cb_EmpresasReclutamiento";
            this.cb_EmpresasReclutamiento.Size = new System.Drawing.Size(124, 21);
            this.cb_EmpresasReclutamiento.TabIndex = 1;
            this.cb_EmpresasReclutamiento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Documento";
            // 
            // tb_DocumentoReclutamiento
            // 
            this.tb_DocumentoReclutamiento.Location = new System.Drawing.Point(132, 87);
            this.tb_DocumentoReclutamiento.Name = "tb_DocumentoReclutamiento";
            this.tb_DocumentoReclutamiento.Size = new System.Drawing.Size(123, 20);
            this.tb_DocumentoReclutamiento.TabIndex = 4;
            // 
            // tb_NombreReclutamiento
            // 
            this.tb_NombreReclutamiento.Location = new System.Drawing.Point(132, 124);
            this.tb_NombreReclutamiento.Name = "tb_NombreReclutamiento";
            this.tb_NombreReclutamiento.Size = new System.Drawing.Size(124, 20);
            this.tb_NombreReclutamiento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_CelularReclutamiento
            // 
            this.tb_CelularReclutamiento.Location = new System.Drawing.Point(132, 161);
            this.tb_CelularReclutamiento.Name = "tb_CelularReclutamiento";
            this.tb_CelularReclutamiento.Size = new System.Drawing.Size(123, 20);
            this.tb_CelularReclutamiento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Celular";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargos";
            // 
            // cb_CargosReclutamiento
            // 
            this.cb_CargosReclutamiento.FormattingEnabled = true;
            this.cb_CargosReclutamiento.Items.AddRange(new object[] {
            "Asesor comercial",
            "Ingeniero residente",
            "Operador de maquinaria pesada",
            "Agente comercial"});
            this.cb_CargosReclutamiento.Location = new System.Drawing.Point(132, 205);
            this.cb_CargosReclutamiento.Name = "cb_CargosReclutamiento";
            this.cb_CargosReclutamiento.Size = new System.Drawing.Size(124, 21);
            this.cb_CargosReclutamiento.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fases";
            // 
            // cb_FasesReclutamiento
            // 
            this.cb_FasesReclutamiento.FormattingEnabled = true;
            this.cb_FasesReclutamiento.Items.AddRange(new object[] {
            "Enviado",
            "Contratado",
            "Descartado",
            "Desiste"});
            this.cb_FasesReclutamiento.Location = new System.Drawing.Point(132, 300);
            this.cb_FasesReclutamiento.Name = "cb_FasesReclutamiento";
            this.cb_FasesReclutamiento.Size = new System.Drawing.Size(123, 21);
            this.cb_FasesReclutamiento.TabIndex = 11;
            // 
            // dt_FechaReclutamiento
            // 
            this.dt_FechaReclutamiento.Location = new System.Drawing.Point(132, 346);
            this.dt_FechaReclutamiento.Name = "dt_FechaReclutamiento";
            this.dt_FechaReclutamiento.Size = new System.Drawing.Size(200, 20);
            this.dt_FechaReclutamiento.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha";
            // 
            // button_RegistrarReclutamiento
            // 
            this.button_RegistrarReclutamiento.Location = new System.Drawing.Point(132, 415);
            this.button_RegistrarReclutamiento.Name = "button_RegistrarReclutamiento";
            this.button_RegistrarReclutamiento.Size = new System.Drawing.Size(75, 23);
            this.button_RegistrarReclutamiento.TabIndex = 15;
            this.button_RegistrarReclutamiento.Text = "Registrar";
            this.button_RegistrarReclutamiento.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.Controls.Add(this.button_RegistrarReclutamiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_FechaReclutamiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_FasesReclutamiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_CargosReclutamiento);
            this.Controls.Add(this.tb_CelularReclutamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_NombreReclutamiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_DocumentoReclutamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_EmpresasReclutamiento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_EmpresasReclutamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DocumentoReclutamiento;
        private System.Windows.Forms.TextBox tb_NombreReclutamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CelularReclutamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_CargosReclutamiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_FasesReclutamiento;
        private System.Windows.Forms.DateTimePicker dt_FechaReclutamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_RegistrarReclutamiento;
    }
}

