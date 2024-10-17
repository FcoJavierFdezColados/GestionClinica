namespace WinForm.Frm.Citas
{
    partial class FrmCitaCreate
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
            btnFrmCitaCreateAceptar = new Button();
            btnFrmCitaCreateCancelar = new Button();
            SuspendLayout();
            // 
            // btnFrmCitaCreateAceptar
            // 
            btnFrmCitaCreateAceptar.DialogResult = DialogResult.OK;
            btnFrmCitaCreateAceptar.Location = new Point(243, 352);
            btnFrmCitaCreateAceptar.Name = "btnFrmCitaCreateAceptar";
            btnFrmCitaCreateAceptar.Size = new Size(75, 23);
            btnFrmCitaCreateAceptar.TabIndex = 0;
            btnFrmCitaCreateAceptar.Text = "Acetar";
            btnFrmCitaCreateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnFrmCitaCreateCancelar
            // 
            btnFrmCitaCreateCancelar.DialogResult = DialogResult.Cancel;
            btnFrmCitaCreateCancelar.Location = new Point(476, 352);
            btnFrmCitaCreateCancelar.Name = "btnFrmCitaCreateCancelar";
            btnFrmCitaCreateCancelar.Size = new Size(75, 23);
            btnFrmCitaCreateCancelar.TabIndex = 1;
            btnFrmCitaCreateCancelar.Text = "Cancelar";
            btnFrmCitaCreateCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmCitaCreate
            // 
            AcceptButton = btnFrmCitaCreateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFrmCitaCreateCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrmCitaCreateCancelar);
            Controls.Add(btnFrmCitaCreateAceptar);
            Name = "FrmCitaCreate";
            Text = "FrmCitaCreate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmCitaCreateAceptar;
        private Button btnFrmCitaCreateCancelar;
    }
}