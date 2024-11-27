namespace WinForm.Frm.Doctores
{
    partial class FrmDoctoresUpdate
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
            btnAceptarDoctoresUpdate = new Button();
            btnCancelarFrmDoctoresUpdate = new Button();
            lblNombreFrmDocUpdate = new Label();
            lblApellidosFrmDocUpdate = new Label();
            lblNumColegiadoFrmDocUpdate = new Label();
            tbNumColegiadoFrmDocUpdate = new TextBox();
            tbApellidosFrmDocUpdate = new TextBox();
            tbNombreFrmDocUpdate = new TextBox();
            SuspendLayout();
            // 
            // btnAceptarDoctoresUpdate
            // 
            btnAceptarDoctoresUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptarDoctoresUpdate.DialogResult = DialogResult.OK;
            btnAceptarDoctoresUpdate.Location = new Point(229, 348);
            btnAceptarDoctoresUpdate.Name = "btnAceptarDoctoresUpdate";
            btnAceptarDoctoresUpdate.Size = new Size(75, 23);
            btnAceptarDoctoresUpdate.TabIndex = 3;
            btnAceptarDoctoresUpdate.Text = "Aceptar";
            btnAceptarDoctoresUpdate.UseVisualStyleBackColor = true;
            btnAceptarDoctoresUpdate.Click += btnAceptarDoctoresUpdate_Click;
            // 
            // btnCancelarFrmDoctoresUpdate
            // 
            btnCancelarFrmDoctoresUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarFrmDoctoresUpdate.DialogResult = DialogResult.Cancel;
            btnCancelarFrmDoctoresUpdate.Location = new Point(484, 348);
            btnCancelarFrmDoctoresUpdate.Name = "btnCancelarFrmDoctoresUpdate";
            btnCancelarFrmDoctoresUpdate.Size = new Size(75, 23);
            btnCancelarFrmDoctoresUpdate.TabIndex = 4;
            btnCancelarFrmDoctoresUpdate.Text = "Cancelar";
            btnCancelarFrmDoctoresUpdate.UseVisualStyleBackColor = true;
            btnCancelarFrmDoctoresUpdate.Click += btnCancelarFrmDoctoresUpdate_Click;
            // 
            // lblNombreFrmDocUpdate
            // 
            lblNombreFrmDocUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreFrmDocUpdate.AutoSize = true;
            lblNombreFrmDocUpdate.Location = new Point(85, 63);
            lblNombreFrmDocUpdate.Name = "lblNombreFrmDocUpdate";
            lblNombreFrmDocUpdate.Size = new Size(51, 15);
            lblNombreFrmDocUpdate.TabIndex = 2;
            lblNombreFrmDocUpdate.Text = "Nombre";
            // 
            // lblApellidosFrmDocUpdate
            // 
            lblApellidosFrmDocUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApellidosFrmDocUpdate.AutoSize = true;
            lblApellidosFrmDocUpdate.Location = new Point(80, 123);
            lblApellidosFrmDocUpdate.Name = "lblApellidosFrmDocUpdate";
            lblApellidosFrmDocUpdate.Size = new Size(56, 15);
            lblApellidosFrmDocUpdate.TabIndex = 3;
            lblApellidosFrmDocUpdate.Text = "Apellidos";
            // 
            // lblNumColegiadoFrmDocUpdate
            // 
            lblNumColegiadoFrmDocUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumColegiadoFrmDocUpdate.AutoSize = true;
            lblNumColegiadoFrmDocUpdate.Location = new Point(12, 184);
            lblNumColegiadoFrmDocUpdate.Name = "lblNumColegiadoFrmDocUpdate";
            lblNumColegiadoFrmDocUpdate.Size = new Size(124, 15);
            lblNumColegiadoFrmDocUpdate.TabIndex = 4;
            lblNumColegiadoFrmDocUpdate.Text = "Número de Colegiado";
            // 
            // tbNumColegiadoFrmDocUpdate
            // 
            tbNumColegiadoFrmDocUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNumColegiadoFrmDocUpdate.Location = new Point(142, 181);
            tbNumColegiadoFrmDocUpdate.Name = "tbNumColegiadoFrmDocUpdate";
            tbNumColegiadoFrmDocUpdate.Size = new Size(646, 23);
            tbNumColegiadoFrmDocUpdate.TabIndex = 2;
            // 
            // tbApellidosFrmDocUpdate
            // 
            tbApellidosFrmDocUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbApellidosFrmDocUpdate.Location = new Point(142, 120);
            tbApellidosFrmDocUpdate.Name = "tbApellidosFrmDocUpdate";
            tbApellidosFrmDocUpdate.Size = new Size(646, 23);
            tbApellidosFrmDocUpdate.TabIndex = 1;
            // 
            // tbNombreFrmDocUpdate
            // 
            tbNombreFrmDocUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNombreFrmDocUpdate.Location = new Point(142, 60);
            tbNombreFrmDocUpdate.Name = "tbNombreFrmDocUpdate";
            tbNombreFrmDocUpdate.Size = new Size(646, 23);
            tbNombreFrmDocUpdate.TabIndex = 0;
            // 
            // FrmDoctoresUpdate
            // 
            AcceptButton = btnAceptarDoctoresUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelarFrmDoctoresUpdate;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNombreFrmDocUpdate);
            Controls.Add(tbApellidosFrmDocUpdate);
            Controls.Add(tbNumColegiadoFrmDocUpdate);
            Controls.Add(lblNumColegiadoFrmDocUpdate);
            Controls.Add(lblApellidosFrmDocUpdate);
            Controls.Add(lblNombreFrmDocUpdate);
            Controls.Add(btnCancelarFrmDoctoresUpdate);
            Controls.Add(btnAceptarDoctoresUpdate);
            Name = "FrmDoctoresUpdate";
            Text = "Actualizar doctor";
            Load += FrmDoctoresUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptarDoctoresUpdate;
        private Button btnCancelarFrmDoctoresUpdate;
        private Label lblNombreFrmDocUpdate;
        private Label lblApellidosFrmDocUpdate;
        private Label lblNumColegiadoFrmDocUpdate;
        private TextBox tbNumColegiadoFrmDocUpdate;
        private TextBox tbApellidosFrmDocUpdate;
        private TextBox tbNombreFrmDocUpdate;
    }
}