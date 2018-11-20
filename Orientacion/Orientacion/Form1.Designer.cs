namespace Orientacion
{
    partial class Form1
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
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Contraseña = new System.Windows.Forms.Label();
            this.tx_Usuario = new System.Windows.Forms.TextBox();
            this.tx_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Location = new System.Drawing.Point(274, 72);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lb_Usuario.TabIndex = 0;
            this.lb_Usuario.Text = "Usuario";
            // 
            // lb_Contraseña
            // 
            this.lb_Contraseña.AutoSize = true;
            this.lb_Contraseña.Location = new System.Drawing.Point(274, 185);
            this.lb_Contraseña.Name = "lb_Contraseña";
            this.lb_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lb_Contraseña.TabIndex = 1;
            this.lb_Contraseña.Text = "Contraseña";
            // 
            // tx_Usuario
            // 
            this.tx_Usuario.Location = new System.Drawing.Point(277, 101);
            this.tx_Usuario.Name = "tx_Usuario";
            this.tx_Usuario.Size = new System.Drawing.Size(117, 20);
            this.tx_Usuario.TabIndex = 2;
            // 
            // tx_Contraseña
            // 
            this.tx_Contraseña.Location = new System.Drawing.Point(277, 224);
            this.tx_Contraseña.Name = "tx_Contraseña";
            this.tx_Contraseña.PasswordChar = '*';
            this.tx_Contraseña.Size = new System.Drawing.Size(117, 20);
            this.tx_Contraseña.TabIndex = 3;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(276, 302);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 411);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.tx_Contraseña);
            this.Controls.Add(this.tx_Usuario);
            this.Controls.Add(this.lb_Contraseña);
            this.Controls.Add(this.lb_Usuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.Label lb_Contraseña;
        private System.Windows.Forms.TextBox tx_Usuario;
        private System.Windows.Forms.TextBox tx_Contraseña;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}

