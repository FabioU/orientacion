using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Orientacion
{
    public partial class ListaEventos : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tLFAU5Gi7MtgCkoRKccFialJyhA7hxRzXuxe4yaf",
            BasePath = "https://orientacionbd.firebaseio.com/"
        };

        IFirebaseClient client;
        public ListaEventos()
        {
            
            InitializeComponent();

            client = new FireSharp.FirebaseClient(config);
           
            

            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre Evento");
            dt.Columns.Add("Fecha");

            dataGridView1.DataSource = dt;

            Update();


        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {

          
        }

        private async void export()
        {

            int i = 0;
            FirebaseResponse response1 = await client.GetTaskAsync("Eventos/node");
            List_Eventos obj1 = response1.ResultAs<List_Eventos>();


        }

        private void NEvento_Click(object sender, EventArgs e)
        {
            Eventos formSiguiente = new Eventos();
            this.Hide();
            formSiguiente.Show();
        }

        private void ListaEventos_Load(object sender, EventArgs e)
        {

        }

        private async void Update()
        {
            dt.Rows.Clear();
            int i = 0;
            FirebaseResponse resp = await client.GetTaskAsync("Count/cnt");
            List_Eventos ob = resp.ResultAs<List_Eventos>();
            int id = Convert.ToInt32(ob.ID);
            while (true)
            {
                if (i == id)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Eventos/" + i);
                    Data obj2 = resp2.ResultAs<Data>();
             
                     DataRow row = dt.NewRow();
                     row["ID"] = obj2.Id;
                     row["Nombre Evento"] = obj2.Nombre_Evento;
                     row["Fecha"] = obj2.Fecha;

                     dt.Rows.Add(row);

                }
                catch
                {

                }
                
            }
        }
    }
    
}
