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
            btnDoctoresUpdateAceptar = new Button();
            btnDoctoresUpdateCancel = new Button();
            lblNombreFrmDocUpdate = new Label();
            lblApellidosFrmDocUpdate = new Label();
            lblNumColegiadoFrmDocUpdate = new Label();
            tbNumColegiadoFrmDocUpdate = new TextBox();
            tbApellidosFrmDocUpdate = new TextBox();
            tbNombreFrmDocUpdate = new TextBox();
            SuspendLayout();
            // 
            // btnDoctoresUpdateAceptar
            // 
            btnDoctoresUpdateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDoctoresUpdateAceptar.DialogResult = DialogResult.OK;
            btnDoctoresUpdateAceptar.Location = new Point(229, 348);
            btnDoctoresUpdateAceptar.Name = "btnDoctoresUpdateAceptar";
            btnDoctoresUpdateAceptar.Size = new Size(75, 23);
            btnDoctoresUpdateAceptar.TabIndex = 0;
            btnDoctoresUpdateAceptar.Text = "Aceptar";
            btnDoctoresUpdateAceptar.UseVisualStyleBackColor = true;
            btnDoctoresUpdateAceptar.Click += btnDoctoresUpdateAceptar_Click;
            // 
            // btnDoctoresUpdateCancel
            // 
            btnDoctoresUpdateCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDoctoresUpdateCancel.DialogResult = DialogResult.Cancel;
            btnDoctoresUpdateCancel.Location = new Point(484, 348);
            btnDoctoresUpdateCancel.Name = "btnDoctoresUpdateCancel";
            btnDoctoresUpdateCancel.Size = new Size(75, 23);
            btnDoctoresUpdateCancel.TabIndex = 1;
            btnDoctoresUpdateCancel.Text = "Cancelar";
            btnDoctoresUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // lblNombreFrmDocUpdate
            // 
            lblNombreFrmDocUpdate.AutoSize = true;
            lblNombreFrmDocUpdate.Location = new Point(85, 63);
            lblNombreFrmDocUpdate.Name = "lblNombreFrmDocUpdate";
            lblNombreFrmDocUpdate.Size = new Size(51, 15);
            lblNombreFrmDocUpdate.TabIndex = 2;
            lblNombreFrmDocUpdate.Text = "Nombre";
            // 
            // lblApellidosFrmDocUpdate
            // 
            lblApellidosFrmDocUpdate.AutoSize = true;
            lblApellidosFrmDocUpdate.Location = new Point(80, 123);
            lblApellidosFrmDocUpdate.Name = "lblApellidosFrmDocUpdate";
            lblApellidosFrmDocUpdate.Size = new Size(56, 15);
            lblApellidosFrmDocUpdate.TabIndex = 3;
            lblApellidosFrmDocUpdate.Text = "Apellidos";
            // 
            // lblNumColegiadoFrmDocUpdate
            // 
            lblNumColegiadoFrmDocUpdate.AutoSize = true;
            lblNumColegiadoFrmDocUpdate.Location = new Point(12, 184);
            lblNumColegiadoFrmDocUpdate.Name = "lblNumColegiadoFrmDocUpdate";
            lblNumColegiadoFrmDocUpdate.Size = new Size(124, 15);
            lblNumColegiadoFrmDocUpdate.TabIndex = 4;
            lblNumColegiadoFrmDocUpdate.Text = "Número de Colegiado";
            // 
            // tbNumColegiadoFrmDocUpdate
            // 
            tbNumColegiadoFrmDocUpdate.Location = new Point(142, 181);
            tbNumColegiadoFrmDocUpdate.Name = "tbNumColegiadoFrmDocUpdate";
            tbNumColegiadoFrmDocUpdate.Size = new Size(646, 23);
            tbNumColegiadoFrmDocUpdate.TabIndex = 5;
            // 
            // tbApellidosFrmDocUpdate
            // 
            tbApellidosFrmDocUpdate.Location = new Point(142, 120);
            tbApellidosFrmDocUpdate.Name = "tbApellidosFrmDocUpdate";
            tbApellidosFrmDocUpdate.Size = new Size(646, 23);
            tbApellidosFrmDocUpdate.TabIndex = 6;
            // 
            // tbNombreFrmDocUpdate
            // 
            tbNombreFrmDocUpdate.Location = new Point(142, 60);
            tbNombreFrmDocUpdate.Name = "tbNombreFrmDocUpdate";
            tbNombreFrmDocUpdate.Size = new Size(646, 23);
            tbNombreFrmDocUpdate.TabIndex = 7;
            // 
            // FrmDoctoresUpdate
            // 
            AcceptButton = btnDoctoresUpdateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnDoctoresUpdateCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNombreFrmDocUpdate);
            Controls.Add(tbApellidosFrmDocUpdate);
            Controls.Add(tbNumColegiadoFrmDocUpdate);
            Controls.Add(lblNumColegiadoFrmDocUpdate);
            Controls.Add(lblApellidosFrmDocUpdate);
            Controls.Add(lblNombreFrmDocUpdate);
            Controls.Add(btnDoctoresUpdateCancel);
            Controls.Add(btnDoctoresUpdateAceptar);
            Name = "FrmDoctoresUpdate";
            Text = "FrmDoctoresUpdate";
            Load += FrmDoctoresUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoctoresUpdateAceptar;
        private Button btnDoctoresUpdateCancel;
        private Label lblNombreFrmDocUpdate;
        private Label lblApellidosFrmDocUpdate;
        private Label lblNumColegiadoFrmDocUpdate;
        private TextBox tbNumColegiadoFrmDocUpdate;
        private TextBox tbApellidosFrmDocUpdate;
        private TextBox tbNombreFrmDocUpdate;
    }
}