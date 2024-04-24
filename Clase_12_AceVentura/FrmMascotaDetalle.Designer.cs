namespace Clase_12_AceVentura
{
    partial class FrmMascotaDetalle
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
            groupBox1 = new GroupBox();
            txtNumeroChip = new TextBox();
            groupBox2 = new GroupBox();
            txtNombreDueno = new TextBox();
            btnDeclararEncontrada = new Button();
            btnDeclararEntregada = new Button();
            btnGuardar = new Button();
            groupBox3 = new GroupBox();
            txtNombreAnimal = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumeroChip);
            groupBox1.Location = new Point(18, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 57);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numero de Chip";
            // 
            // txtNumeroChip
            // 
            txtNumeroChip.Location = new Point(6, 22);
            txtNumeroChip.Name = "txtNumeroChip";
            txtNumeroChip.Size = new Size(209, 23);
            txtNumeroChip.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNombreDueno);
            groupBox2.Location = new Point(18, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 57);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nombre del Dueño";
            // 
            // txtNombreDueno
            // 
            txtNombreDueno.Location = new Point(6, 22);
            txtNombreDueno.Name = "txtNombreDueno";
            txtNombreDueno.Size = new Size(209, 23);
            txtNombreDueno.TabIndex = 0;
            // 
            // btnDeclararEncontrada
            // 
            btnDeclararEncontrada.Location = new Point(299, 44);
            btnDeclararEncontrada.Name = "btnDeclararEncontrada";
            btnDeclararEncontrada.Size = new Size(204, 23);
            btnDeclararEncontrada.TabIndex = 2;
            btnDeclararEncontrada.Text = "Declarar cómo \"Encontrada\"";
            btnDeclararEncontrada.UseVisualStyleBackColor = true;
            btnDeclararEncontrada.Click += btnDeclararEncontrada_Click;
            // 
            // btnDeclararEntregada
            // 
            btnDeclararEntregada.Location = new Point(299, 108);
            btnDeclararEntregada.Name = "btnDeclararEntregada";
            btnDeclararEntregada.Size = new Size(204, 23);
            btnDeclararEntregada.TabIndex = 3;
            btnDeclararEntregada.Text = "Declarar Cómo \"Entregada\"";
            btnDeclararEntregada.UseVisualStyleBackColor = true;
            btnDeclararEntregada.Click += btnDeclararEntregada_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(428, 180);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNombreAnimal);
            groupBox3.Location = new Point(18, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 57);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nombre del Animal";
            // 
            // txtNombreAnimal
            // 
            txtNombreAnimal.Location = new Point(6, 22);
            txtNombreAnimal.Name = "txtNombreAnimal";
            txtNombreAnimal.Size = new Size(209, 23);
            txtNombreAnimal.TabIndex = 0;
            // 
            // FrmMascotaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 228);
            Controls.Add(groupBox3);
            Controls.Add(btnGuardar);
            Controls.Add(btnDeclararEntregada);
            Controls.Add(btnDeclararEncontrada);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmMascotaDetalle";
            Text = "FrmMascotaDetalle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumeroChip;
        private GroupBox groupBox2;
        private TextBox txtNombreDueno;
        private Button btnDeclararEncontrada;
        private Button btnDeclararEntregada;
        private Button btnGuardar;
        private GroupBox groupBox3;
        private TextBox txtNombreAnimal;
    }
}