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
            lblDevelopedBy = new Label();
            lblIconsUrl = new Label();
            llbUrlIcons = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // lblDevelopedBy
            // 
            lblDevelopedBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDevelopedBy.AutoSize = true;
            lblDevelopedBy.Font = new Font("Segoe UI", 20F);
            lblDevelopedBy.Location = new Point(114, 114);
            lblDevelopedBy.Name = "lblDevelopedBy";
            lblDevelopedBy.Size = new Size(489, 37);
            lblDevelopedBy.TabIndex = 2;
            lblDevelopedBy.Text = "Developed by Fco. Javier Fdez. Collados";
            // 
            // lblIconsUrl
            // 
            lblIconsUrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIconsUrl.AutoSize = true;
            lblIconsUrl.Location = new Point(204, 211);
            lblIconsUrl.Name = "lblIconsUrl";
            lblIconsUrl.Size = new Size(118, 15);
            lblIconsUrl.TabIndex = 3;
            lblIconsUrl.Text = "Fuente de los iconos:";
            // 
            // llbUrlIcons
            // 
            llbUrlIcons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            llbUrlIcons.AutoSize = true;
            llbUrlIcons.Location = new Point(353, 211);
            llbUrlIcons.Name = "llbUrlIcons";
            llbUrlIcons.Size = new Size(144, 15);
            llbUrlIcons.TabIndex = 4;
            llbUrlIcons.TabStop = true;
            llbUrlIcons.Text = "https://www.flaticon.com";
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(llbUrlIcons);
            Controls.Add(lblIconsUrl);
            Controls.Add(lblDevelopedBy);
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
        private Label lblDevelopedBy;
        private Label lblIconsUrl;
        private LinkLabel llbUrlIcons;
    }
}