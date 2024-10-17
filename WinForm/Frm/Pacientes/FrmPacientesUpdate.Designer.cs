namespace WinForm.Frm.Pacientes
{
    partial class FrmPacientesUpdate
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
            btnFrmPacientesUpdateAceptar = new Button();
            btnPacientesUpdateCancelar = new Button();
            SuspendLayout();
            // 
            // btnFrmPacientesUpdateAceptar
            // 
            btnFrmPacientesUpdateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFrmPacientesUpdateAceptar.DialogResult = DialogResult.OK;
            btnFrmPacientesUpdateAceptar.Location = new Point(234, 380);
            btnFrmPacientesUpdateAceptar.Name = "btnFrmPacientesUpdateAceptar";
            btnFrmPacientesUpdateAceptar.Size = new Size(75, 23);
            btnFrmPacientesUpdateAceptar.TabIndex = 0;
            btnFrmPacientesUpdateAceptar.Text = "Aceptar";
            btnFrmPacientesUpdateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnPacientesUpdateCancelar
            // 
            btnPacientesUpdateCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPacientesUpdateCancelar.DialogResult = DialogResult.Cancel;
            btnPacientesUpdateCancelar.Location = new Point(483, 381);
            btnPacientesUpdateCancelar.Name = "btnPacientesUpdateCancelar";
            btnPacientesUpdateCancelar.Size = new Size(75, 23);
            btnPacientesUpdateCancelar.TabIndex = 1;
            btnPacientesUpdateCancelar.Text = "Cancelar";
            btnPacientesUpdateCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPacientesUpdate
            // 
            AcceptButton = btnFrmPacientesUpdateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnPacientesUpdateCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPacientesUpdateCancelar);
            Controls.Add(btnFrmPacientesUpdateAceptar);
            Name = "FrmPacientesUpdate";
            Text = "FrmPacientesUpdate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmPacientesUpdateAceptar;
        private Button btnPacientesUpdateCancelar;
    }
}