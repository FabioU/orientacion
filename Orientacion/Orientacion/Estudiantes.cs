using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orientacion
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Menu1 formSiguiente = new Menu1();
            this.Hide();
            formSiguiente.ShowDialog();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
