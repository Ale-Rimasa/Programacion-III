using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("CIAO BAMBINO");
            string texto = txtNombre.Text;
            lblSaludo.Text = "Hola " + texto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Benvenuto");
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Grazie per aver utilizzato la nostra app");
        }
    }
}
