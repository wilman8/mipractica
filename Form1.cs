using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using repasoexamenDAO;

namespace repasoexamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Clave = textBox2.Text;
            loginusuarioDAO r = new loginusuarioDAO();
            bool result = r.ValidaUsuario(Usuario, Clave);
            if (result)
            {
                MessageBox.Show("bienvenido al sistema");



            }
            else
            {
                MessageBox.Show("error de autenticacion");
            }
        }
    }
}
