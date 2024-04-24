namespace Clase_12_AceVentura
{
    partial class FrmLogin
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
            txtUsername = new TextBox();
            groupBox2 = new GroupBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 57);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nombre de Usuario";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(209, 23);
            txtUsername.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Location = new Point(12, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 57);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 22);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(209, 23);
            txtPassword.TabIndex = 0;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(159, 138);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 42);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 185);
            Controls.Add(btnIngresar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmLogin";
            Text = "Autenticación";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtUsername;
        private GroupBox groupBox2;
        private TextBox txtPassword;
        private Button btnIngresar;
    }
}