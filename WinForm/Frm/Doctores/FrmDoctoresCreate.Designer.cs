namespace WinForm.Frm.Doctores
{
    partial class FrmDoctoresCreate
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
            btnAceptarFrmDoctoresCreate = new Button();
            btnCancelFrmDoctoresCreate = new Button();
            lblNombrefrmDocCreate = new Label();
            lblApellidosFrmDocCreate = new Label();
            lblNumColegiadoFrmDocCreate = new Label();
            tbNombreFrmDocCreate = new TextBox();
            tbApellidosFrmDocCreate = new TextBox();
            tbNumColegiadoFrmDocCreate = new TextBox();
            SuspendLayout();
            // 
            // btnAceptarFrmDoctoresCreate
            // 
            btnAceptarFrmDoctoresCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptarFrmDoctoresCreate.DialogResult = DialogResult.OK;
            btnAceptarFrmDoctoresCreate.Location = new Point(207, 353);
            btnAceptarFrmDoctoresCreate.Name = "btnAceptarFrmDoctoresCreate";
            btnAceptarFrmDoctoresCreate.Size = new Size(75, 23);
            btnAceptarFrmDoctoresCreate.TabIndex = 0;
            btnAceptarFrmDoctoresCreate.Text = "Aceptar";
            btnAceptarFrmDoctoresCreate.UseVisualStyleBackColor = true;
            btnAceptarFrmDoctoresCreate.Click += btnAceptarFrmDoctoresCreate_Click;
            // 
            // btnCancelFrmDoctoresCreate
            // 
            btnCancelFrmDoctoresCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelFrmDoctoresCreate.DialogResult = DialogResult.Cancel;
            btnCancelFrmDoctoresCreate.Location = new Point(435, 353);
            btnCancelFrmDoctoresCreate.Name = "btnCancelFrmDoctoresCreate";
            btnCancelFrmDoctoresCreate.Size = new Size(75, 23);
            btnCancelFrmDoctoresCreate.TabIndex = 1;
            btnCancelFrmDoctoresCreate.Text = "Cancelar";
            btnCancelFrmDoctoresCreate.UseVisualStyleBackColor = true;
            // 
            // lblNombrefrmDocCreate
            // 
            lblNombrefrmDocCreate.AutoSize = true;
            lblNombrefrmDocCreate.Location = new Point(67, 66);
            lblNombrefrmDocCreate.Name = "lblNombrefrmDocCreate";
            lblNombrefrmDocCreate.Size = new Size(51, 15);
            lblNombrefrmDocCreate.TabIndex = 2;
            lblNombrefrmDocCreate.Text = "Nombre";
            // 
            // lblApellidosFrmDocCreate
            // 
            lblApellidosFrmDocCreate.AutoSize = true;
            lblApellidosFrmDocCreate.Location = new Point(62, 126);
            lblApellidosFrmDocCreate.Name = "lblApellidosFrmDocCreate";
            lblApellidosFrmDocCreate.Size = new Size(56, 15);
            lblApellidosFrmDocCreate.TabIndex = 3;
            lblApellidosFrmDocCreate.Text = "Apellidos";
            // 
            // lblNumColegiadoFrmDocCreate
            // 
            lblNumColegiadoFrmDocCreate.AutoSize = true;
            lblNumColegiadoFrmDocCreate.Location = new Point(12, 188);
            lblNumColegiadoFrmDocCreate.Name = "lblNumColegiadoFrmDocCreate";
            lblNumColegiadoFrmDocCreate.Size = new Size(106, 15);
            lblNumColegiadoFrmDocCreate.TabIndex = 4;
            lblNumColegiadoFrmDocCreate.Text = "Número colegiado";
            // 
            // tbNombreFrmDocCreate
            // 
            tbNombreFrmDocCreate.Location = new Point(124, 63);
            tbNombreFrmDocCreate.Name = "tbNombreFrmDocCreate";
            tbNombreFrmDocCreate.Size = new Size(664, 23);
            tbNombreFrmDocCreate.TabIndex = 5;
            // 
            // tbApellidosFrmDocCreate
            // 
            tbApellidosFrmDocCreate.Location = new Point(124, 123);
            tbApellidosFrmDocCreate.Name = "tbApellidosFrmDocCreate";
            tbApellidosFrmDocCreate.Size = new Size(664, 23);
            tbApellidosFrmDocCreate.TabIndex = 6;
            // 
            // tbNumColegiadoFrmDocCreate
            // 
            tbNumColegiadoFrmDocCreate.Location = new Point(124, 185);
            tbNumColegiadoFrmDocCreate.Name = "tbNumColegiadoFrmDocCreate";
            tbNumColegiadoFrmDocCreate.Size = new Size(664, 23);
            tbNumColegiadoFrmDocCreate.TabIndex = 7;
            // 
            // FrmDoctoresCreate
            // 
            AcceptButton = btnAceptarFrmDoctoresCreate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelFrmDoctoresCreate;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNumColegiadoFrmDocCreate);
            Controls.Add(tbApellidosFrmDocCreate);
            Controls.Add(tbNombreFrmDocCreate);
            Controls.Add(lblNumColegiadoFrmDocCreate);
            Controls.Add(lblApellidosFrmDocCreate);
            Controls.Add(lblNombrefrmDocCreate);
            Controls.Add(btnCancelFrmDoctoresCreate);
            Controls.Add(btnAceptarFrmDoctoresCreate);
            Name = "FrmDoctoresCreate";
            Text = "Añadir Doctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptarFrmDoctoresCreate;
        private Button btnCancelFrmDoctoresCreate;
        private Label lblNombrefrmDocCreate;
        private Label lblApellidosFrmDocCreate;
        private Label lblNumColegiadoFrmDocCreate;
        private TextBox tbNombreFrmDocCreate;
        private TextBox tbApellidosFrmDocCreate;
        private TextBox tbNumColegiadoFrmDocCreate;
    }
}