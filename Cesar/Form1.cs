using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCifrado.Enabled = false;
            btnLimpiar.Enabled = false;
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void comparar(char e)
        {
            
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            
            List<char> alfabeto = new List<char>();

            char[] abecedario = "abcdefghijklmnñopqrstuvwxyz".ToCharArray();
            alfabeto.AddRange(abecedario);
            
            if (txtPlano.Text != null )
            {
                btnComenzar.Enabled = false;
                int desplazamiento =Convert.ToInt32( txtDesplazamiento.Value);
                char[] entrada = new char[txtPlano.Text.Length];
                string cifrado = null;
               entrada= txtPlano.Text.ToLower().ToCharArray();
                foreach(char let in entrada)
                {
                    int posicion=alfabeto.IndexOf(let);
                    int mov = (posicion + desplazamiento) % 27;
                    char aux = alfabeto[mov];
                    cifrado = cifrado + aux;
                    
                }

                MessageBox.Show("Texto cifrado   " + cifrado);
                txtCifrado.Text = cifrado;
                btnLimpiar.Enabled = true;

            }
            else
            {
                MessageBox.Show("Nada que cifrar");
            }
        }

        private void txtPlano_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPlano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCifrado.Text = null;
            txtDesplazamiento.Value = 1;
            txtPlano.Text = null;
            btnComenzar.Enabled = true;
            btnLimpiar.Enabled = false;
        }
    }
}
