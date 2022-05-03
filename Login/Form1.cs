using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            Usuario = "Carlos";
            
            string contra;
            contra = "123456";
           
            
                if (textBox1.Text == Usuario & textBox2.Text == contra)
                {
                    MessageBox.Show("Has iniciado sesión");
                }

              else
              {
                MessageBox.Show("Datos incorrectos");
              }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             this.Hide()
            Form2 registrarse = new Form2
            registrarse.ShowDialog();
        }
    }
}
