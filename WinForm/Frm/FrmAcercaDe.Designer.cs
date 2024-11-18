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
            lklAuthorIcons = new LinkLabel();
            lblAuthorIcons = new Label();
            groupBox1 = new GroupBox();
            lblAuthorApp = new Label();
            lblRepository = new Label();
            lklRepository = new LinkLabel();
            lblAutoríaIconos = new Label();
            groupBox1.SuspendLayout();
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
            lblIconsUrl.Location = new Point(51, 19);
            lblIconsUrl.Name = "lblIconsUrl";
            lblIconsUrl.Size = new Size(118, 15);
            lblIconsUrl.TabIndex = 3;
            lblIconsUrl.Text = "Fuente de los iconos:";
            // 
            // llbUrlIcons
            // 
            llbUrlIcons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            llbUrlIcons.AutoSize = true;
            llbUrlIcons.Location = new Point(200, 19);
            llbUrlIcons.Name = "llbUrlIcons";
            llbUrlIcons.Size = new Size(144, 15);
            llbUrlIcons.TabIndex = 4;
            llbUrlIcons.TabStop = true;
            llbUrlIcons.Text = "https://www.flaticon.com";
            // 
            // lklAuthorIcons
            // 
            lklAuthorIcons.AutoSize = true;
            lklAuthorIcons.Location = new Point(165, 46);
            lklAuthorIcons.Name = "lklAuthorIcons";
            lklAuthorIcons.Size = new Size(261, 15);
            lklAuthorIcons.TabIndex = 8;
            lklAuthorIcons.TabStop = true;
            lklAuthorIcons.Text = "https://www.flaticon.com/authors/pixel-perfect";
            // 
            // lblAuthorIcons
            // 
            lblAuthorIcons.AutoSize = true;
            lblAuthorIcons.Location = new Point(51, 46);
            lblAuthorIcons.Name = "lblAuthorIcons";
            lblAuthorIcons.Size = new Size(108, 15);
            lblAuthorIcons.TabIndex = 7;
            lblAuthorIcons.Text = "Derechos de Autor:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAutoríaIconos);
            groupBox1.Controls.Add(lblIconsUrl);
            groupBox1.Controls.Add(lklAuthorIcons);
            groupBox1.Controls.Add(llbUrlIcons);
            groupBox1.Controls.Add(lblAuthorIcons);
            groupBox1.Location = new Point(114, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 94);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autoría de los Iconos";
            // 
            // lblAuthorApp
            // 
            lblAuthorApp.AutoSize = true;
            lblAuthorApp.Location = new Point(165, 279);
            lblAuthorApp.Name = "lblAuthorApp";
            lblAuthorApp.Size = new Size(386, 15);
            lblAuthorApp.TabIndex = 10;
            lblAuthorApp.Text = "Derechos de Autor de la Aplicación: Francisco Javier Fernández Collados";
            // 
            // lblRepository
            // 
            lblRepository.AutoSize = true;
            lblRepository.Location = new Point(165, 316);
            lblRepository.Name = "lblRepository";
            lblRepository.Size = new Size(70, 15);
            lblRepository.TabIndex = 11;
            lblRepository.Text = "Repositorio:";
            // 
            // lklRepository
            // 
            lklRepository.AutoSize = true;
            lklRepository.Location = new Point(241, 316);
            lklRepository.Name = "lklRepository";
            lklRepository.Size = new Size(310, 15);
            lklRepository.TabIndex = 12;
            lklRepository.TabStop = true;
            lklRepository.Text = "https://github.com/FcoJavierFdezColados/GestionClinica";
            // 
            // lblAutoríaIconos
            // 
            lblAutoríaIconos.AutoSize = true;
            lblAutoríaIconos.Location = new Point(51, 76);
            lblAutoríaIconos.Name = "lblAutoríaIconos";
            lblAutoríaIconos.Size = new Size(378, 15);
            lblAutoríaIconos.TabIndex = 9;
            lblAutoríaIconos.Text = "El uso de estos iconos es gratuíto siempre que se reconozca a su autor.";
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lklRepository);
            Controls.Add(lblRepository);
            Controls.Add(lblAuthorApp);
            Controls.Add(groupBox1);
            Controls.Add(lblDevelopedBy);
            Controls.Add(btnFrmAcercaDeAceptar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de Gestión Clínica";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFrmAcercaDeAceptar;
        private Label lblDevelopedBy;
        private Label lblIconsUrl;
        private LinkLabel llbUrlIcons;
        private LinkLabel lklAuthorIcons;
        private Label lblAuthorIcons;
        private GroupBox groupBox1;
        private Label lblAuthorApp;
        private Label lblRepository;
        private LinkLabel lklRepository;
        private Label lblAutoríaIconos;
    }
}