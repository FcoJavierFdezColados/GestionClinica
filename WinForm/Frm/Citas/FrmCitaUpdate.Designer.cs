namespace WinForm.Frm.Citas
{
    partial class FrmCitaUpdate
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
            btnFrmCitaUpdateAceptar = new Button();
            btnFrmCitaUpdateCancelar = new Button();
            SuspendLayout();
            // 
            // btnFrmCitaUpdateAceptar
            // 
            btnFrmCitaUpdateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFrmCitaUpdateAceptar.DialogResult = DialogResult.OK;
            btnFrmCitaUpdateAceptar.Location = new Point(242, 366);
            btnFrmCitaUpdateAceptar.Name = "btnFrmCitaUpdateAceptar";
            btnFrmCitaUpdateAceptar.Size = new Size(75, 23);
            btnFrmCitaUpdateAceptar.TabIndex = 0;
            btnFrmCitaUpdateAceptar.Text = "Aceptar";
            btnFrmCitaUpdateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnFrmCitaUpdateCancelar
            // 
            btnFrmCitaUpdateCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFrmCitaUpdateCancelar.DialogResult = DialogResult.Cancel;
            btnFrmCitaUpdateCancelar.Location = new Point(463, 366);
            btnFrmCitaUpdateCancelar.Name = "btnFrmCitaUpdateCancelar";
            btnFrmCitaUpdateCancelar.Size = new Size(75, 23);
            btnFrmCitaUpdateCancelar.TabIndex = 1;
            btnFrmCitaUpdateCancelar.Text = "Cancelar";
            btnFrmCitaUpdateCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmCitaUpdate
            // 
            AcceptButton = btnFrmCitaUpdateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFrmCitaUpdateCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrmCitaUpdateCancelar);
            Controls.Add(btnFrmCitaUpdateAceptar);
            Name = "FrmCitaUpdate";
            Text = "FrmCitaUpdate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmCitaUpdateAceptar;
        private Button btnFrmCitaUpdateCancelar;
    }
}