namespace Orientacion
{
    partial class Estudiantes
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
            this.cmb_Carreras = new System.Windows.Forms.ComboBox();
            this.cmb_Semestres = new System.Windows.Forms.ComboBox();
            this.lb_Carreras = new System.Windows.Forms.Label();
            this.lb_Semestre = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Carreras
            // 
            this.cmb_Carreras.FormattingEnabled = true;
            this.cmb_Carreras.Items.AddRange(new object[] {
            "ING. COMERCIAL",
            "ING. FINANCIERA",
            "ADMINISTRACION DE EMPRESAS",
            "ECONOMÍA",
            "MARKETING Y LOGÍSTICA",
            "DISEÑO GRÁFICO",
            "DERECHO",
            "COMUNICACION",
            "ING. DE LA PRODUCCIÓN",
            "ING. CÍVIL",
            "ING. DE SISTEMAS COMPUTACIONALES",
            "ING. ELECTROMECANICA",
            "ING. PETROLERA",
            "ING. INDUSTRIAL Y DE SISTEMAS"});
            this.cmb_Carreras.Location = new System.Drawing.Point(30, 55);
            this.cmb_Carreras.Name = "cmb_Carreras";
            this.cmb_Carreras.Size = new System.Drawing.Size(201, 21);
            this.cmb_Carreras.TabIndex = 0;
            // 
            // cmb_Semestres
            // 
            this.cmb_Semestres.FormattingEnabled = true;
            this.cmb_Semestres.Items.AddRange(new object[] {
            "SEGUNDO 2018",
            "PRIMERO 2018",
            "SEGUNDO 2017",
            "PRIMERO 2017",
            "SEGUNDO 2016",
            "PRIMERO 2016"});
            this.cmb_Semestres.Location = new System.Drawing.Point(30, 129);
            this.cmb_Semestres.Name = "cmb_Semestres";
            this.cmb_Semestres.Size = new System.Drawing.Size(201, 21);
            this.cmb_Semestres.TabIndex = 1;
            // 
            // lb_Carreras
            // 
            this.lb_Carreras.AutoSize = true;
            this.lb_Carreras.Location = new System.Drawing.Point(31, 29);
            this.lb_Carreras.Name = "lb_Carreras";
            this.lb_Carreras.Size = new System.Drawing.Size(41, 13);
            this.lb_Carreras.TabIndex = 2;
            this.lb_Carreras.Text = "Carrera";
            // 
            // lb_Semestre
            // 
            this.lb_Semestre.AutoSize = true;
            this.lb_Semestre.Location = new System.Drawing.Point(31, 104);
            this.lb_Semestre.Name = "lb_Semestre";
            this.lb_Semestre.Size = new System.Drawing.Size(51, 13);
            this.lb_Semestre.TabIndex = 3;
            this.lb_Semestre.Text = "Semestre";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(497, 17);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(103, 38);
            this.btn_Regresar.TabIndex = 4;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lb_Semestre);
            this.Controls.Add(this.lb_Carreras);
            this.Controls.Add(this.cmb_Semestres);
            this.Controls.Add(this.cmb_Carreras);
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Carreras;
        private System.Windows.Forms.ComboBox cmb_Semestres;
        private System.Windows.Forms.Label lb_Carreras;
        private System.Windows.Forms.Label lb_Semestre;
        private System.Windows.Forms.Button btn_Regresar;
    }
}