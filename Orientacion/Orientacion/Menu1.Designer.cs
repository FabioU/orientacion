namespace Orientacion
{
    partial class Menu1
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
            this.btn_Estudiantes = new System.Windows.Forms.Button();
            this.btn_Eventos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Estudiantes
            // 
            this.btn_Estudiantes.Location = new System.Drawing.Point(198, 66);
            this.btn_Estudiantes.Name = "btn_Estudiantes";
            this.btn_Estudiantes.Size = new System.Drawing.Size(121, 41);
            this.btn_Estudiantes.TabIndex = 0;
            this.btn_Estudiantes.Text = "Estudiantes";
            this.btn_Estudiantes.UseVisualStyleBackColor = true;
            this.btn_Estudiantes.Click += new System.EventHandler(this.btn_Estudiantes_Click);
            // 
            // btn_Eventos
            // 
            this.btn_Eventos.Location = new System.Drawing.Point(198, 162);
            this.btn_Eventos.Name = "btn_Eventos";
            this.btn_Eventos.Size = new System.Drawing.Size(121, 41);
            this.btn_Eventos.TabIndex = 1;
            this.btn_Eventos.Text = "Eventos";
            this.btn_Eventos.UseVisualStyleBackColor = true;
            this.btn_Eventos.Click += new System.EventHandler(this.btn_Eventos_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 364);
            this.Controls.Add(this.btn_Eventos);
            this.Controls.Add(this.btn_Estudiantes);
            this.Name = "Menu1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Estudiantes;
        private System.Windows.Forms.Button btn_Eventos;
    }
}