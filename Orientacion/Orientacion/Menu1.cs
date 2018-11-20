using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Orientacion
{
    public partial class Menu1 : Form
    {

        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tLFAU5Gi7MtgCkoRKccFialJyhA7hxRzXuxe4yaf",
            BasePath = "https://orientacionbd.firebaseio.com/"
        };

        IFirebaseClient client;

        public Menu1()
        {

            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();


        }

        private void btn_Estudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes formSiguiente = new Estudiantes();
            this.Hide();
            formSiguiente.ShowDialog();
        }

        private async void btn_Eventos_Click(object sender, EventArgs e)
        {
            



            FirebaseResponse response = await client.GetTaskAsync("Count/cnt");
            List_Eventos result = response.ResultAs<List_Eventos>();

          if(result.ID == "0")
            {
                Eventos formSiguiente = new Eventos();
                this.Hide();
                formSiguiente.Show();
               
            }
           else
            {
                ListaEventos formsi = new ListaEventos();
                this.Hide();
                formsi.Show();

            }

        }
    }
}
