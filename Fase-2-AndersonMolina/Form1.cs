using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase_2_AndersonMolina
{
    public partial class Form1: Form
    {
        private const string ValidKey = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            string inputKey = txtClave.Text.Trim();
            if (string.IsNullOrEmpty(inputKey))
            {
                MessageBox.Show("Por favor, ingresa la clave.");
            }
            else if (inputKey == ValidKey)
            {
                MessageBox.Show("Clave válida.");
                valores valoresForm = new valores();
                valoresForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Clave inválida. Inténtalo de nuevo.");
                txtClave.Clear();
                txtClave.Focus();
            }

            // Mover el enfoque al cuadro de texto solo si es necesario  
            if (!inputKey.Equals(ValidKey))
            {
                txtClave.Focus();
            }
        }
    }
}