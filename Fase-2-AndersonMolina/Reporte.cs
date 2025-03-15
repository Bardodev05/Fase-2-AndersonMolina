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
    public partial class Reporte: Form
    {
        public Reporte(string id, string nombre, string genero, string tecnica, int numClases, int costoClase, int costoTotal)
        {
            InitializeComponent();

            lblId.Text = $"ID: {id}";
            lblNombre.Text = $"Nombre: {nombre}";
            lblGenero.Text = $"Género: {genero}";
            lblTecnica.Text = $"Técnica: {tecnica}";
            lblNumClases.Text = $"Número de Clases: {numClases}";
            lblCostoClase.Text = $"Costo por Clase: {costoClase:C0}";
            lblCostoTotal.Text = $"Costo Total: {costoTotal:C0}";
        }

        private void btnCerrar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
