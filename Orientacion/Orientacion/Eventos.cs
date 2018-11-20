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
    public partial class Eventos : Form

    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tLFAU5Gi7MtgCkoRKccFialJyhA7hxRzXuxe4yaf",
            BasePath = "https://orientacionbd.firebaseio.com/"
        };

        IFirebaseClient client;
        public Eventos()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            ListaEventos formSiguiente = new ListaEventos();
            this.Hide();
            formSiguiente.ShowDialog();
        }

        private async void btn_CrearEvento_Click(object sender, EventArgs e)
        {
            

          
            FirebaseResponse res = await client.GetTaskAsync("Count/cnt");
            List_Eventos get = res.ResultAs<List_Eventos>();

         
            var data = new Data
            {
                Nombre_Evento = textBox1.Text,
                Descripcion = richTextBox1.Text,
                Fecha = dateTimePicker1.Text,
                Id = (Convert.ToInt32(get.ID) +1).ToString() 

            
            };

            SetResponse response = await client.SetTaskAsync("Eventos/" + data.Id,data);
            Data result = response.ResultAs<Data>();

            var obj = new List_Eventos
            {
                ID = data.Id
            };

            SetResponse response1 = await client.SetTaskAsync("Count/cnt",obj);
            MessageBox.Show("Evento Creado!");

            ListaEventos formSiguiente = new ListaEventos();
            this.Hide();
            formSiguiente.Show();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            /*
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Conexion exitosa");
            }
            */
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
