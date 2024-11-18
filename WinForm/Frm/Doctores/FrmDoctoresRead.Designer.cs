namespace WinForm.Frm.Doctores
{
    partial class FrmDoctoresRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctoresRead));
            toolStripFrmDocRead = new ToolStrip();
            tsbFrmDoctoresCrear = new ToolStripButton();
            tsbFrmDoctoresEditar = new ToolStripButton();
            tsbFrmDoctoresEliminar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tstbBuscarFrmDocRead = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            toolStripFrmDocRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStripFrmDocRead
            // 
            toolStripFrmDocRead.Items.AddRange(new ToolStripItem[] { tsbFrmDoctoresCrear, tsbFrmDoctoresEditar, tsbFrmDoctoresEliminar, toolStripSeparator1, toolStripLabel1, tstbBuscarFrmDocRead });
            toolStripFrmDocRead.Location = new Point(0, 0);
            toolStripFrmDocRead.Name = "toolStripFrmDocRead";
            toolStripFrmDocRead.Size = new Size(800, 25);
            toolStripFrmDocRead.TabIndex = 0;
            toolStripFrmDocRead.Text = "toolStrip1";
            // 
            // tsbFrmDoctoresCrear
            // 
            tsbFrmDoctoresCrear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmDoctoresCrear.Image = (Image)resources.GetObject("tsbFrmDoctoresCrear.Image");
            tsbFrmDoctoresCrear.ImageTransparentColor = Color.Magenta;
            tsbFrmDoctoresCrear.Name = "tsbFrmDoctoresCrear";
            tsbFrmDoctoresCrear.Size = new Size(23, 22);
            tsbFrmDoctoresCrear.Text = "Añadir";
            tsbFrmDoctoresCrear.Click += tsbFrmDoctoresCrear_Click;
            // 
            // tsbFrmDoctoresEditar
            // 
            tsbFrmDoctoresEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmDoctoresEditar.Image = (Image)resources.GetObject("tsbFrmDoctoresEditar.Image");
            tsbFrmDoctoresEditar.ImageTransparentColor = Color.Magenta;
            tsbFrmDoctoresEditar.Name = "tsbFrmDoctoresEditar";
            tsbFrmDoctoresEditar.Size = new Size(23, 22);
            tsbFrmDoctoresEditar.Text = "Editar";
            tsbFrmDoctoresEditar.Click += tsbFrmDoctoresEditar_Click;
            // 
            // tsbFrmDoctoresEliminar
            // 
            tsbFrmDoctoresEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmDoctoresEliminar.Image = (Image)resources.GetObject("tsbFrmDoctoresEliminar.Image");
            tsbFrmDoctoresEliminar.ImageTransparentColor = Color.Magenta;
            tsbFrmDoctoresEliminar.Name = "tsbFrmDoctoresEliminar";
            tsbFrmDoctoresEliminar.Size = new Size(23, 22);
            tsbFrmDoctoresEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(16, 22);
            // 
            // tstbBuscarFrmDocRead
            // 
            tstbBuscarFrmDocRead.Alignment = ToolStripItemAlignment.Right;
            tstbBuscarFrmDocRead.BorderStyle = BorderStyle.FixedSingle;
            tstbBuscarFrmDocRead.Name = "tstbBuscarFrmDocRead";
            tstbBuscarFrmDocRead.Size = new Size(100, 25);
            tstbBuscarFrmDocRead.ToolTipText = "Buscar Doctor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 425);
            dataGridView1.TabIndex = 1;
            // 
            // FrmDoctoresRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStripFrmDocRead);
            Name = "FrmDoctoresRead";
            Text = "Lista de Doctores";
            toolStripFrmDocRead.ResumeLayout(false);
            toolStripFrmDocRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripFrmDocRead;
        private ToolStripButton tsbFrmDoctoresCrear;
        private ToolStripButton tsbFrmDoctoresEditar;
        private ToolStripButton tsbFrmDoctoresEliminar;
        private DataGridView dataGridView1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstbBuscarFrmDocRead;
    }
}