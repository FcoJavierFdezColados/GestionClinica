namespace WinForm.Frm
{
    partial class FrmAcercaDe
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
            btnFrmAcercaDeAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(780, 89);
            label1.TabIndex = 0;
            label1.Text = "Acerca de Gestión Clínica";
            // 
            // btnFrmAcercaDeAceptar
            // 
            btnFrmAcercaDeAceptar.DialogResult = DialogResult.OK;
            btnFrmAcercaDeAceptar.Dock = DockStyle.Bottom;
            btnFrmAcercaDeAceptar.Location = new Point(0, 385);
            btnFrmAcercaDeAceptar.Name = "btnFrmAcercaDeAceptar";
            btnFrmAcercaDeAceptar.Size = new Size(800, 65);
            btnFrmAcercaDeAceptar.TabIndex = 1;
            btnFrmAcercaDeAceptar.Text = "Aceptar";
            btnFrmAcercaDeAceptar.UseVisualStyleBackColor = true;
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrmAcercaDeAceptar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de Gestión Clínica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFrmAcercaDeAceptar;
    }
}