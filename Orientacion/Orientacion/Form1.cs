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
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tLFAU5Gi7MtgCkoRKccFialJyhA7hxRzXuxe4yaf",
            BasePath = "https://orientacionbd.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        string Usuario = "admin";
        string Contraseña = "admin";

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string User = tx_Usuario.Text;
            string Password = tx_Contraseña.Text;
            
            if(User.Equals(Usuario))
            {
                if(Password.Equals(Contraseña))
                {
                    //Login exitoso
                    Menu1 formSiguiente= new Menu1();
                    this.Hide();
                    formSiguiente.Show();
                   
                }
                else
                {
                    //Falla por contraseña
                    MessageBox.Show("La coontraseña es incorrecta");
                }
            }
            else
            {
                //Falla por usuario
                MessageBox.Show("No se reconoce el usuario");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Conexion exitosa");
            }*/
        }
    }
}
