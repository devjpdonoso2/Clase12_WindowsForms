namespace Clase_12_AceVentura
{
    partial class FrmListarMascotas
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
            lstMascotasPerdidas = new ListView();
            idChip = new ColumnHeader();
            nombreMascota = new ColumnHeader();
            nombreDueno = new ColumnHeader();
            estaEncontrada = new ColumnHeader();
            estaEntregado = new ColumnHeader();
            btnNewPet = new Button();
            SuspendLayout();
            // 
            // lstMascotasPerdidas
            // 
            lstMascotasPerdidas.Columns.AddRange(new ColumnHeader[] { idChip, nombreMascota, nombreDueno, estaEncontrada, estaEntregado });
            lstMascotasPerdidas.FullRowSelect = true;
            lstMascotasPerdidas.GridLines = true;
            lstMascotasPerdidas.Location = new Point(12, 78);
            lstMascotasPerdidas.MultiSelect = false;
            lstMascotasPerdidas.Name = "lstMascotasPerdidas";
            lstMascotasPerdidas.Size = new Size(666, 316);
            lstMascotasPerdidas.TabIndex = 0;
            lstMascotasPerdidas.UseCompatibleStateImageBehavior = false;
            lstMascotasPerdidas.View = View.Details;
            lstMascotasPerdidas.SelectedIndexChanged += lstMascotasPerdidas_SelectedIndexChanged;
            // 
            // idChip
            // 
            idChip.Text = "ID Chip";
            // 
            // nombreMascota
            // 
            nombreMascota.Text = "NombreMascota";
            nombreMascota.Width = 150;
            // 
            // nombreDueno
            // 
            nombreDueno.Text = "Nombre Dueño";
            nombreDueno.Width = 150;
            // 
            // estaEncontrada
            // 
            estaEncontrada.Text = "Encontrado?";
            estaEncontrada.Width = 80;
            // 
            // estaEntregado
            // 
            estaEntregado.Text = "Entregado?";
            estaEntregado.Width = 80;
            // 
            // btnNewPet
            // 
            btnNewPet.Location = new Point(12, 12);
            btnNewPet.Name = "btnNewPet";
            btnNewPet.Size = new Size(111, 60);
            btnNewPet.TabIndex = 1;
            btnNewPet.Text = "Agregar nueva Mascota";
            btnNewPet.UseVisualStyleBackColor = true;
            btnNewPet.Click += btnNewPet_Click;
            // 
            // FrmListarMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 406);
            Controls.Add(btnNewPet);
            Controls.Add(lstMascotasPerdidas);
            Name = "FrmListarMascotas";
            Text = "FrmListarMascotas";
            ResumeLayout(false);
        }

        #endregion

        private ListView lstMascotasPerdidas;
        private ColumnHeader idChip;
        private ColumnHeader nombreMascota;
        private ColumnHeader nombreDueno;
        private ColumnHeader estaEncontrada;
        private ColumnHeader estaEntregado;
        private Button btnNewPet;
    }
}