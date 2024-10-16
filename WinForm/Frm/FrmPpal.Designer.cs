namespace WinForm.Frm
{
    partial class FrmPpal
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
            menuFrmPpal = new MenuStrip();
            archivosToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            doctoresToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem1 = new ToolStripMenuItem();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            cascadaToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            statussFrmPpal = new StatusStrip();
            tsslStatusFrmPpal = new ToolStripStatusLabel();
            menuFrmPpal.SuspendLayout();
            statussFrmPpal.SuspendLayout();
            SuspendLayout();
            // 
            // menuFrmPpal
            // 
            menuFrmPpal.Items.AddRange(new ToolStripItem[] { archivosToolStripMenuItem, citasToolStripMenuItem, ventanaToolStripMenuItem, ayudaToolStripMenuItem });
            menuFrmPpal.Location = new Point(0, 0);
            menuFrmPpal.Name = "menuFrmPpal";
            menuFrmPpal.Size = new Size(800, 24);
            menuFrmPpal.TabIndex = 1;
            menuFrmPpal.Text = "Archivos";
            // 
            // archivosToolStripMenuItem
            // 
            archivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, doctoresToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            archivosToolStripMenuItem.Size = new Size(65, 20);
            archivosToolStripMenuItem.Text = "&Archivos";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.P;
            pacientesToolStripMenuItem.Size = new Size(231, 22);
            pacientesToolStripMenuItem.Text = "&Pacientes";
            // 
            // doctoresToolStripMenuItem
            // 
            doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            doctoresToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.D;
            doctoresToolStripMenuItem.Size = new Size(231, 22);
            doctoresToolStripMenuItem.Text = "&Doctores";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(228, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            salirToolStripMenuItem.Size = new Size(231, 22);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { citasToolStripMenuItem1 });
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(45, 20);
            citasToolStripMenuItem.Text = "&Citas";
            // 
            // citasToolStripMenuItem1
            // 
            citasToolStripMenuItem1.Name = "citasToolStripMenuItem1";
            citasToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.C;
            citasToolStripMenuItem1.Size = new Size(208, 22);
            citasToolStripMenuItem1.Text = "Ci&tas";
            // 
            // ventanaToolStripMenuItem
            // 
            ventanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadaToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem });
            ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            ventanaToolStripMenuItem.Size = new Size(61, 20);
            ventanaToolStripMenuItem.Text = "&Ventana";
            // 
            // cascadaToolStripMenuItem
            // 
            cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            cascadaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            cascadaToolStripMenuItem.Size = new Size(242, 22);
            cascadaToolStripMenuItem.Text = "&Cascada";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.H;
            horizontalToolStripMenuItem.Size = new Size(242, 22);
            horizontalToolStripMenuItem.Text = "&Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
            verticalToolStripMenuItem.Size = new Size(242, 22);
            verticalToolStripMenuItem.Text = "&Vertical";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca &de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // statussFrmPpal
            // 
            statussFrmPpal.Items.AddRange(new ToolStripItem[] { tsslStatusFrmPpal });
            statussFrmPpal.Location = new Point(0, 428);
            statussFrmPpal.Name = "statussFrmPpal";
            statussFrmPpal.Size = new Size(800, 22);
            statussFrmPpal.TabIndex = 3;
            statussFrmPpal.Text = "statusStrip1";
            // 
            // tsslStatusFrmPpal
            // 
            tsslStatusFrmPpal.Name = "tsslStatusFrmPpal";
            tsslStatusFrmPpal.Size = new Size(118, 17);
            tsslStatusFrmPpal.Text = "toolStripStatusLabel1";
            // 
            // FrmPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statussFrmPpal);
            Controls.Add(menuFrmPpal);
            IsMdiContainer = true;
            MainMenuStrip = menuFrmPpal;
            Name = "FrmPpal";
            Text = "FrmPpal";
            WindowState = FormWindowState.Maximized;
            menuFrmPpal.ResumeLayout(false);
            menuFrmPpal.PerformLayout();
            statussFrmPpal.ResumeLayout(false);
            statussFrmPpal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuFrmPpal;
        private ToolStripMenuItem archivosToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem doctoresToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem1;
        private ToolStripMenuItem ventanaToolStripMenuItem;
        private ToolStripMenuItem cascadaToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private StatusStrip statussFrmPpal;
        private ToolStripStatusLabel tsslStatusFrmPpal;
    }
}