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
            toolStrip1 = new ToolStrip();
            tsbFrmDoctoresCrear = new ToolStripButton();
            tsbFrmDoctoresEditar = new ToolStripButton();
            tsbFrmDoctoresEliminar = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbFrmDoctoresCrear, tsbFrmDoctoresEditar, tsbFrmDoctoresEliminar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
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
            Controls.Add(toolStrip1);
            Name = "FrmDoctoresRead";
            Text = "FrmDoctoresRead";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbFrmDoctoresCrear;
        private ToolStripButton tsbFrmDoctoresEditar;
        private ToolStripButton tsbFrmDoctoresEliminar;
        private DataGridView dataGridView1;
    }
}