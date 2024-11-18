namespace WinForm.Frm.Pacientes
{
    partial class FrmPacientesRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientesRead));
            toolStripFrmPacientes = new ToolStrip();
            tsbFrmPacientesCrear = new ToolStripButton();
            tsbFrmPacientesEditar = new ToolStripButton();
            tsbFrmPacientesEliminar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tslBuscarFrmPacientesRead = new ToolStripLabel();
            tstbBuscarFrmPacientesRead = new ToolStripTextBox();
            DgvwPacientesRead = new DataGridView();
            toolStripLabel1 = new ToolStripLabel();
            toolStripFrmPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvwPacientesRead).BeginInit();
            SuspendLayout();
            // 
            // toolStripFrmPacientes
            // 
            toolStripFrmPacientes.Items.AddRange(new ToolStripItem[] { tsbFrmPacientesCrear, tsbFrmPacientesEditar, tsbFrmPacientesEliminar, toolStripSeparator1, tslBuscarFrmPacientesRead, tstbBuscarFrmPacientesRead, toolStripLabel1 });
            toolStripFrmPacientes.Location = new Point(0, 0);
            toolStripFrmPacientes.Name = "toolStripFrmPacientes";
            toolStripFrmPacientes.Size = new Size(800, 25);
            toolStripFrmPacientes.TabIndex = 0;
            toolStripFrmPacientes.Text = "Menú Pacientes";
            // 
            // tsbFrmPacientesCrear
            // 
            tsbFrmPacientesCrear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmPacientesCrear.Image = (Image)resources.GetObject("tsbFrmPacientesCrear.Image");
            tsbFrmPacientesCrear.ImageTransparentColor = Color.Magenta;
            tsbFrmPacientesCrear.Name = "tsbFrmPacientesCrear";
            tsbFrmPacientesCrear.Size = new Size(23, 22);
            tsbFrmPacientesCrear.Text = "Añadir";
            tsbFrmPacientesCrear.Click += tsbFrmPacientesCrear_Click;
            // 
            // tsbFrmPacientesEditar
            // 
            tsbFrmPacientesEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmPacientesEditar.Image = (Image)resources.GetObject("tsbFrmPacientesEditar.Image");
            tsbFrmPacientesEditar.ImageTransparentColor = Color.Magenta;
            tsbFrmPacientesEditar.Name = "tsbFrmPacientesEditar";
            tsbFrmPacientesEditar.Size = new Size(23, 22);
            tsbFrmPacientesEditar.Text = "Editar";
            tsbFrmPacientesEditar.Click += tsbFrmPacientesEditar_Click;
            // 
            // tsbFrmPacientesEliminar
            // 
            tsbFrmPacientesEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmPacientesEliminar.Image = (Image)resources.GetObject("tsbFrmPacientesEliminar.Image");
            tsbFrmPacientesEliminar.ImageTransparentColor = Color.Magenta;
            tsbFrmPacientesEliminar.Name = "tsbFrmPacientesEliminar";
            tsbFrmPacientesEliminar.Size = new Size(23, 22);
            tsbFrmPacientesEliminar.Text = "Eliminar";
            tsbFrmPacientesEliminar.Click += tsbFrmPacientesEliminar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tslBuscarFrmPacientesRead
            // 
            tslBuscarFrmPacientesRead.Alignment = ToolStripItemAlignment.Right;
            tslBuscarFrmPacientesRead.Image = (Image)resources.GetObject("tslBuscarFrmPacientesRead.Image");
            tslBuscarFrmPacientesRead.Name = "tslBuscarFrmPacientesRead";
            tslBuscarFrmPacientesRead.Size = new Size(16, 22);
            // 
            // tstbBuscarFrmPacientesRead
            // 
            tstbBuscarFrmPacientesRead.Alignment = ToolStripItemAlignment.Right;
            tstbBuscarFrmPacientesRead.BorderStyle = BorderStyle.FixedSingle;
            tstbBuscarFrmPacientesRead.Name = "tstbBuscarFrmPacientesRead";
            tstbBuscarFrmPacientesRead.Size = new Size(100, 25);
            tstbBuscarFrmPacientesRead.TextChanged += tstbBuscarFrmPacientesRead_TextChanged;
            // 
            // DgvwPacientesRead
            // 
            DgvwPacientesRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvwPacientesRead.Dock = DockStyle.Fill;
            DgvwPacientesRead.Location = new Point(0, 25);
            DgvwPacientesRead.MultiSelect = false;
            DgvwPacientesRead.Name = "DgvwPacientesRead";
            DgvwPacientesRead.Size = new Size(800, 425);
            DgvwPacientesRead.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(59, 22);
            toolStripLabel1.Text = "Apellidos:";
            // 
            // FrmPacientesRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvwPacientesRead);
            Controls.Add(toolStripFrmPacientes);
            Name = "FrmPacientesRead";
            Text = "Lista de Pacientes";
            Load += FrmPacientesRead_Load;
            toolStripFrmPacientes.ResumeLayout(false);
            toolStripFrmPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvwPacientesRead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripFrmPacientes;
        private ToolStripButton tsbFrmPacientesCrear;
        private ToolStripButton tsbFrmPacientesEditar;
        private ToolStripButton tsbFrmPacientesEliminar;
        private DataGridView DgvwPacientesRead;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tslBuscarFrmPacientesRead;
        private ToolStripTextBox tstbBuscarFrmPacientesRead;
        private ToolStripLabel toolStripLabel1;
    }
}