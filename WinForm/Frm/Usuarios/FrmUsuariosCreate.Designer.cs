namespace WinForm.Frm.Usuarios
{
    partial class FrmUsuariosCreate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNombreFrmUsuariosCreate = new TextBox();
            tbApellidosFrmUsuariosCreate = new TextBox();
            tbUserNameFrmUsuariosCreate = new TextBox();
            tbPasswordFrmUsuariosCreate = new TextBox();
            btnAceptarFrmUsuariosCreate = new Button();
            btnCancelarFrmUsuariosCreate = new Button();
            tbConfirmPassFrmUsuariosCreate = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 83);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 132);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 172);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // tbNombreFrmUsuariosCreate
            // 
            tbNombreFrmUsuariosCreate.Location = new Point(142, 37);
            tbNombreFrmUsuariosCreate.Name = "tbNombreFrmUsuariosCreate";
            tbNombreFrmUsuariosCreate.Size = new Size(646, 23);
            tbNombreFrmUsuariosCreate.TabIndex = 4;
            // 
            // tbApellidosFrmUsuariosCreate
            // 
            tbApellidosFrmUsuariosCreate.Location = new Point(142, 80);
            tbApellidosFrmUsuariosCreate.Name = "tbApellidosFrmUsuariosCreate";
            tbApellidosFrmUsuariosCreate.Size = new Size(646, 23);
            tbApellidosFrmUsuariosCreate.TabIndex = 5;
            // 
            // tbUserNameFrmUsuariosCreate
            // 
            tbUserNameFrmUsuariosCreate.Location = new Point(142, 129);
            tbUserNameFrmUsuariosCreate.Name = "tbUserNameFrmUsuariosCreate";
            tbUserNameFrmUsuariosCreate.Size = new Size(646, 23);
            tbUserNameFrmUsuariosCreate.TabIndex = 6;
            // 
            // tbPasswordFrmUsuariosCreate
            // 
            tbPasswordFrmUsuariosCreate.Location = new Point(142, 169);
            tbPasswordFrmUsuariosCreate.Name = "tbPasswordFrmUsuariosCreate";
            tbPasswordFrmUsuariosCreate.Size = new Size(646, 23);
            tbPasswordFrmUsuariosCreate.TabIndex = 7;
            tbPasswordFrmUsuariosCreate.UseSystemPasswordChar = true;
            // 
            // btnAceptarFrmUsuariosCreate
            // 
            btnAceptarFrmUsuariosCreate.DialogResult = DialogResult.OK;
            btnAceptarFrmUsuariosCreate.Location = new Point(251, 293);
            btnAceptarFrmUsuariosCreate.Name = "btnAceptarFrmUsuariosCreate";
            btnAceptarFrmUsuariosCreate.Size = new Size(75, 23);
            btnAceptarFrmUsuariosCreate.TabIndex = 8;
            btnAceptarFrmUsuariosCreate.Text = "Aceptar";
            btnAceptarFrmUsuariosCreate.UseVisualStyleBackColor = true;
            btnAceptarFrmUsuariosCreate.Click += btnAceptarFrmUsuariosCreate_Click;
            // 
            // btnCancelarFrmUsuariosCreate
            // 
            btnCancelarFrmUsuariosCreate.DialogResult = DialogResult.Cancel;
            btnCancelarFrmUsuariosCreate.Location = new Point(502, 293);
            btnCancelarFrmUsuariosCreate.Name = "btnCancelarFrmUsuariosCreate";
            btnCancelarFrmUsuariosCreate.Size = new Size(75, 23);
            btnCancelarFrmUsuariosCreate.TabIndex = 9;
            btnCancelarFrmUsuariosCreate.Text = "Cancelar";
            btnCancelarFrmUsuariosCreate.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassFrmUsuariosCreate
            // 
            tbConfirmPassFrmUsuariosCreate.Location = new Point(142, 212);
            tbConfirmPassFrmUsuariosCreate.Name = "tbConfirmPassFrmUsuariosCreate";
            tbConfirmPassFrmUsuariosCreate.Size = new Size(646, 23);
            tbConfirmPassFrmUsuariosCreate.TabIndex = 11;
            tbConfirmPassFrmUsuariosCreate.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 10;
            label5.Text = "Confirmar Contraseña";
            // 
            // FrmUsuariosCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbConfirmPassFrmUsuariosCreate);
            Controls.Add(label5);
            Controls.Add(btnCancelarFrmUsuariosCreate);
            Controls.Add(btnAceptarFrmUsuariosCreate);
            Controls.Add(tbPasswordFrmUsuariosCreate);
            Controls.Add(tbUserNameFrmUsuariosCreate);
            Controls.Add(tbApellidosFrmUsuariosCreate);
            Controls.Add(tbNombreFrmUsuariosCreate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUsuariosCreate";
            Text = "FrmUsuariosCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNombreFrmUsuariosCreate;
        private TextBox tbApellidosFrmUsuariosCreate;
        private TextBox tbUserNameFrmUsuariosCreate;
        private TextBox tbPasswordFrmUsuariosCreate;
        private Button btnAceptarFrmUsuariosCreate;
        private Button btnCancelarFrmUsuariosCreate;
        private TextBox tbConfirmPassFrmUsuariosCreate;
        private Label label5;
    }
}