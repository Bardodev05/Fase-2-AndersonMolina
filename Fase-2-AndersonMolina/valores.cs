using System;
using System.Windows.Forms;

namespace Fase_2_AndersonMolina
{
    public partial class valores : Form
    {
        private GestionParticipantes gestionParticipantes;

        public valores()
        {
            InitializeComponent();
            InicializarFormulario();
            gestionParticipantes = new GestionParticipantes();
            cmbTecnicas.SelectedIndexChanged += cmbTecnicas_SelectedIndexChanged;
        }

        private void InicializarFormulario()
        {
            cmbTecnicas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTecnicas.Items.AddRange(new string[] { "Dibujo", "Pintura", "Escritura", "Fotografía", "Grabado" });
            txtCosto.Enabled = false;
            txtFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaRegistro.Enabled = false;
        }

        private void cmbTecnicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTecnicas.SelectedItem == null)
                return;

            int costo = ObtenerCostoPorTecnica(cmbTecnicas.SelectedItem.ToString());
            txtCosto.Text = costo.ToString("C0");
        }

        private int ObtenerCostoPorTecnica(string tecnica)
        {
            switch (tecnica)
            {
                case "Dibujo": return 70000;
                case "Pintura": return 85000;
                case "Escritura": return 100000;
                case "Fotografía": return 90000;
                case "Grabado": return 75000;
                default: return 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string identificacion = txtId.Text.Trim();
            string nombreCompleto = txtName.Text.Trim();
            string genero = rbtnMasculino.Checked ? "Masculino" : "Femenino";
            string tecnica = cmbTecnicas.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(identificacion) || string.IsNullOrEmpty(nombreCompleto))
            {
                MessageBox.Show("Los campos ID y Nombre son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tecnica))
            {
                MessageBox.Show("Debe seleccionar una técnica artística.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtNumneroClases.Text, out int numeroClases) || numeroClases < 1 || numeroClases > 9)
            {
                MessageBox.Show("Ingrese un número válido de clases (entre 1 y 9).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCosto.Text.Replace("$", "").Replace(".", "").Trim(), out int costoClase))
            {
                MessageBox.Show("El formato del costo por clase no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gestionParticipantes.GuardarRegistro(identificacion, nombreCompleto, genero, tecnica, numeroClases, costoClase);
            MessageBox.Show("Datos guardados correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumneroClases.Text, out int numeroClases) ||
                !int.TryParse(txtCosto.Text.Replace("$", "").Replace(".", "").Trim(), out int costoClase))
            {
                MessageBox.Show("Por favor, ingrese datos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int costoTotal = gestionParticipantes.CalcularCostoTotal(numeroClases, costoClase);

            // Abrir el nuevo formulario de reporte con los datos
            Reporte reporteForm = new Reporte(txtId.Text,
                txtName.Text,
        rbtnMasculino.Checked ? "Masculino" : "Femenino",
        cmbTecnicas.SelectedItem.ToString(),
        numeroClases,
        costoClase,
        costoTotal);
            reporteForm.ShowDialog(); // Muestra el formulario
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }
    }

    public class GestionParticipantes
    {
        public void GuardarRegistro(string id, string nombre, string genero, string tecnica, int numClases, int costoClase)
        {
            // Aquí se podría almacenar la información en una base de datos o en una lista interna
        }

        public int CalcularCostoTotal(int numClases, int costoClase)
        {
            return numClases * costoClase;
        }
    }
}
