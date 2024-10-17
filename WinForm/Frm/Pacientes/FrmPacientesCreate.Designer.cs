namespace WinForm.Frm.Pacientes
{
    partial class FrmPacientesCreate
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
            btnFrmPacientesCreateAceptar = new Button();
            btnPacientesCreateCancelar = new Button();
            SuspendLayout();
            // 
            // btnFrmPacientesCreateAceptar
            // 
            btnFrmPacientesCreateAceptar.DialogResult = DialogResult.OK;
            btnFrmPacientesCreateAceptar.Location = new Point(255, 358);
            btnFrmPacientesCreateAceptar.Name = "btnFrmPacientesCreateAceptar";
            btnFrmPacientesCreateAceptar.Size = new Size(75, 23);
            btnFrmPacientesCreateAceptar.TabIndex = 0;
            btnFrmPacientesCreateAceptar.Text = "Aceptar";
            btnFrmPacientesCreateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnPacientesCreateCancelar
            // 
            btnPacientesCreateCancelar.DialogResult = DialogResult.Cancel;
            btnPacientesCreateCancelar.Location = new Point(470, 358);
            btnPacientesCreateCancelar.Name = "btnPacientesCreateCancelar";
            btnPacientesCreateCancelar.Size = new Size(75, 23);
            btnPacientesCreateCancelar.TabIndex = 1;
            btnPacientesCreateCancelar.Text = "Cancelar";
            btnPacientesCreateCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPacientesCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPacientesCreateCancelar);
            Controls.Add(btnFrmPacientesCreateAceptar);
            Name = "FrmPacientesCreate";
            Text = "FrmPacientesCreate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmPacientesCreateAceptar;
        private Button btnPacientesCreateCancelar;
    }
}