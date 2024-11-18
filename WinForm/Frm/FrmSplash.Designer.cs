namespace WinForm.Frm
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            timerFrmSplash = new System.Windows.Forms.Timer(components);
            lblGestionClinica = new Label();
            label1 = new Label();
            pbFrmSplash = new ProgressBar();
            lblIconsSource = new Label();
            lklSourceIcons = new LinkLabel();
            lblAuthorIcons = new Label();
            lklAuthorIcons = new LinkLabel();
            SuspendLayout();
            // 
            // timerFrmSplash
            // 
            timerFrmSplash.Enabled = true;
            timerFrmSplash.Interval = 1000;
            timerFrmSplash.Tick += timerFrmSplash_Tick;
            // 
            // lblGestionClinica
            // 
            lblGestionClinica.AutoSize = true;
            lblGestionClinica.Font = new Font("Segoe UI", 75F);
            lblGestionClinica.ForeColor = SystemColors.ActiveCaptionText;
            lblGestionClinica.Location = new Point(41, 52);
            lblGestionClinica.Name = "lblGestionClinica";
            lblGestionClinica.Size = new Size(709, 133);
            lblGestionClinica.TabIndex = 0;
            lblGestionClinica.Text = "Gestión Clínica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(164, 209);
            label1.Name = "label1";
            label1.Size = new Size(456, 46);
            label1.TabIndex = 1;
            label1.Text = "por Fco. Javier Fdez. Collados";
            // 
            // pbFrmSplash
            // 
            pbFrmSplash.Dock = DockStyle.Bottom;
            pbFrmSplash.Location = new Point(0, 387);
            pbFrmSplash.Maximum = 3000;
            pbFrmSplash.Name = "pbFrmSplash";
            pbFrmSplash.Size = new Size(800, 63);
            pbFrmSplash.Step = 1000;
            pbFrmSplash.TabIndex = 2;
            // 
            // lblIconsSource
            // 
            lblIconsSource.AutoSize = true;
            lblIconsSource.Location = new Point(22, 303);
            lblIconsSource.Name = "lblIconsSource";
            lblIconsSource.Size = new Size(117, 15);
            lblIconsSource.TabIndex = 3;
            lblIconsSource.Text = "Iconos obtenidos de:";
            // 
            // lklSourceIcons
            // 
            lklSourceIcons.AutoSize = true;
            lklSourceIcons.Location = new Point(145, 303);
            lklSourceIcons.Name = "lklSourceIcons";
            lklSourceIcons.Size = new Size(144, 15);
            lklSourceIcons.TabIndex = 4;
            lklSourceIcons.TabStop = true;
            lklSourceIcons.Text = "https://www.flaticon.com";
            // 
            // lblAuthorIcons
            // 
            lblAuthorIcons.AutoSize = true;
            lblAuthorIcons.Location = new Point(338, 305);
            lblAuthorIcons.Name = "lblAuthorIcons";
            lblAuthorIcons.Size = new Size(108, 15);
            lblAuthorIcons.TabIndex = 5;
            lblAuthorIcons.Text = "Derechos de Autor:";
            // 
            // lklAuthorIcons
            // 
            lklAuthorIcons.AutoSize = true;
            lklAuthorIcons.Location = new Point(452, 305);
            lklAuthorIcons.Name = "lklAuthorIcons";
            lklAuthorIcons.Size = new Size(261, 15);
            lklAuthorIcons.TabIndex = 6;
            lklAuthorIcons.TabStop = true;
            lklAuthorIcons.Text = "https://www.flaticon.com/authors/pixel-perfect";
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lklAuthorIcons);
            Controls.Add(lblAuthorIcons);
            Controls.Add(lklSourceIcons);
            Controls.Add(lblIconsSource);
            Controls.Add(pbFrmSplash);
            Controls.Add(label1);
            Controls.Add(lblGestionClinica);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSplash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerFrmSplash;
        private Label lblGestionClinica;
        private Label label1;
        private ProgressBar pbFrmSplash;
        private Label lblIconsSource;
        private LinkLabel lklSourceIcons;
        private Label lblAuthorIcons;
        private LinkLabel lklAuthorIcons;
    }
}