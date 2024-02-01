using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string elemento= txtNombre.Text;
            lwElemento.Items.Add(elemento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFav.Items.Add("Rojo");
            cboColorFav.Items.Add("Verde");
            cboColorFav.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre= txtNombre.Text;
            DateTime fecha = dtpFecha.Value;
            //Operador ternario = IF en una sola linea
            string chocolate = ckbChocolate.Checked == true ? "Piace il ciocolato" : "Odia il ciocolato";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtMago.Checked)
                tipo = "Mago";
            else 
                tipo = "Squibs";

            //string colorFavorito=cboColorFav.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + " , es " + tipo + ", su número es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + ", " + mensaje);
        }
                //su color es: " + colorFavorito
    }
}
