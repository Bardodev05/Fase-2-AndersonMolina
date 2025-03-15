namespace Fase_2_AndersonMolina
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTecnica = new System.Windows.Forms.Label();
            this.lblNumClases = new System.Windows.Forms.Label();
            this.lblCostoClase = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.btnCerrar_Click = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "nombre";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(6, 116);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 20);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "genero";
            // 
            // lblTecnica
            // 
            this.lblTecnica.AutoSize = true;
            this.lblTecnica.Location = new System.Drawing.Point(9, 160);
            this.lblTecnica.Name = "lblTecnica";
            this.lblTecnica.Size = new System.Drawing.Size(63, 20);
            this.lblTecnica.TabIndex = 3;
            this.lblTecnica.Text = "tecnica";
            // 
            // lblNumClases
            // 
            this.lblNumClases.AutoSize = true;
            this.lblNumClases.Location = new System.Drawing.Point(6, 208);
            this.lblNumClases.Name = "lblNumClases";
            this.lblNumClases.Size = new System.Drawing.Size(142, 20);
            this.lblNumClases.TabIndex = 4;
            this.lblNumClases.Text = "numero de clases";
            // 
            // lblCostoClase
            // 
            this.lblCostoClase.AutoSize = true;
            this.lblCostoClase.Location = new System.Drawing.Point(273, 36);
            this.lblCostoClase.Name = "lblCostoClase";
            this.lblCostoClase.Size = new System.Drawing.Size(135, 20);
            this.lblCostoClase.TabIndex = 5;
            this.lblCostoClase.Text = "Costo por Clase:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(300, 208);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(100, 20);
            this.lblCostoTotal.TabIndex = 6;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // btnCerrar_Click
            // 
            this.btnCerrar_Click.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar_Click.ForeColor = System.Drawing.Color.Snow;
            this.btnCerrar_Click.Location = new System.Drawing.Point(520, 303);
            this.btnCerrar_Click.Name = "btnCerrar_Click";
            this.btnCerrar_Click.Size = new System.Drawing.Size(93, 45);
            this.btnCerrar_Click.TabIndex = 7;
            this.btnCerrar_Click.Text = "cerrar";
            this.btnCerrar_Click.UseVisualStyleBackColor = false;
            this.btnCerrar_Click.Click += new System.EventHandler(this.btnCerrar_Click_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblCostoTotal);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblCostoClase);
            this.groupBox1.Controls.Add(this.lblTecnica);
            this.groupBox1.Controls.Add(this.lblNumClases);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 272);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "reporte";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar_Click);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTecnica;
        private System.Windows.Forms.Label lblNumClases;
        private System.Windows.Forms.Label lblCostoClase;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Button btnCerrar_Click;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}