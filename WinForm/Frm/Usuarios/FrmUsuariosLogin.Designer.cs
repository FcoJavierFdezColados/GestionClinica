namespace WinForm.Frm.Usuarios
{
    partial class FrmUsuariosLogin
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
            btnCancelarFrmUsuariosLogin = new Button();
            btnAceptarFrmUsuariosLogin = new Button();
            tbPasswordFrmUsuariosLogin = new TextBox();
            tbUserNameFrmUsuariosLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancelarFrmUsuariosLogin
            // 
            btnCancelarFrmUsuariosLogin.DialogResult = DialogResult.Cancel;
            btnCancelarFrmUsuariosLogin.Location = new Point(502, 296);
            btnCancelarFrmUsuariosLogin.Name = "btnCancelarFrmUsuariosLogin";
            btnCancelarFrmUsuariosLogin.Size = new Size(75, 23);
            btnCancelarFrmUsuariosLogin.TabIndex = 15;
            btnCancelarFrmUsuariosLogin.Text = "Cancelar";
            btnCancelarFrmUsuariosLogin.UseVisualStyleBackColor = true;
            btnCancelarFrmUsuariosLogin.Click += btnCancelarFrmUsuariosLogin_Click;
            // 
            // btnAceptarFrmUsuariosLogin
            // 
            btnAceptarFrmUsuariosLogin.DialogResult = DialogResult.OK;
            btnAceptarFrmUsuariosLogin.Location = new Point(251, 296);
            btnAceptarFrmUsuariosLogin.Name = "btnAceptarFrmUsuariosLogin";
            btnAceptarFrmUsuariosLogin.Size = new Size(75, 23);
            btnAceptarFrmUsuariosLogin.TabIndex = 14;
            btnAceptarFrmUsuariosLogin.Text = "Aceptar";
            btnAceptarFrmUsuariosLogin.UseVisualStyleBackColor = true;
            btnAceptarFrmUsuariosLogin.Click += btnAceptarFrmUsuariosLogin_Click;
            // 
            // tbPasswordFrmUsuariosLogin
            // 
            tbPasswordFrmUsuariosLogin.Location = new Point(128, 172);
            tbPasswordFrmUsuariosLogin.Name = "tbPasswordFrmUsuariosLogin";
            tbPasswordFrmUsuariosLogin.Size = new Size(660, 23);
            tbPasswordFrmUsuariosLogin.TabIndex = 13;
            tbPasswordFrmUsuariosLogin.UseSystemPasswordChar = true;
            // 
            // tbUserNameFrmUsuariosLogin
            // 
            tbUserNameFrmUsuariosLogin.Location = new Point(128, 132);
            tbUserNameFrmUsuariosLogin.Name = "tbUserNameFrmUsuariosLogin";
            tbUserNameFrmUsuariosLogin.Size = new Size(660, 23);
            tbUserNameFrmUsuariosLogin.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 175);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre de Usuario";
            // 
            // FrmUsuariosLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarFrmUsuariosLogin);
            Controls.Add(btnAceptarFrmUsuariosLogin);
            Controls.Add(tbPasswordFrmUsuariosLogin);
            Controls.Add(tbUserNameFrmUsuariosLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "FrmUsuariosLogin";
            Text = "FrmUsuariosLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarFrmUsuariosLogin;
        private Button btnAceptarFrmUsuariosLogin;
        private TextBox tbPasswordFrmUsuariosLogin;
        private TextBox tbUserNameFrmUsuariosLogin;
        private Label label4;
        private Label label3;
    }
}