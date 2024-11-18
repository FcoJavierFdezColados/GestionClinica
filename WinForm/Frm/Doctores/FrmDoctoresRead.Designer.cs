﻿namespace WinForm.Frm.Doctores
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
            tslBuscarFrmDocRead = new ToolStripLabel();
            tstbBuscarFrmDocRead = new ToolStripTextBox();
            DgvwDoctoresRead = new DataGridView();
            toolStripFrmDocRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvwDoctoresRead).BeginInit();
            SuspendLayout();
            // 
            // toolStripFrmDocRead
            // 
            toolStripFrmDocRead.Items.AddRange(new ToolStripItem[] { tsbFrmDoctoresCrear, tsbFrmDoctoresEditar, tsbFrmDoctoresEliminar, toolStripSeparator1, tslBuscarFrmDocRead, tstbBuscarFrmDocRead });
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
            tsbFrmDoctoresCrear.Text = "Añadir Doctor";
            tsbFrmDoctoresCrear.Click += tsbFrmDoctoresCrear_Click;
            // 
            // tsbFrmDoctoresEditar
            // 
            tsbFrmDoctoresEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmDoctoresEditar.Image = (Image)resources.GetObject("tsbFrmDoctoresEditar.Image");
            tsbFrmDoctoresEditar.ImageTransparentColor = Color.Magenta;
            tsbFrmDoctoresEditar.Name = "tsbFrmDoctoresEditar";
            tsbFrmDoctoresEditar.Size = new Size(23, 22);
            tsbFrmDoctoresEditar.Text = "Editar Doctor";
            tsbFrmDoctoresEditar.Click += tsbFrmDoctoresEditar_Click;
            // 
            // tsbFrmDoctoresEliminar
            // 
            tsbFrmDoctoresEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmDoctoresEliminar.Image = (Image)resources.GetObject("tsbFrmDoctoresEliminar.Image");
            tsbFrmDoctoresEliminar.ImageTransparentColor = Color.Magenta;
            tsbFrmDoctoresEliminar.Name = "tsbFrmDoctoresEliminar";
            tsbFrmDoctoresEliminar.Size = new Size(23, 22);
            tsbFrmDoctoresEliminar.Text = "Borrar Doctor";
            tsbFrmDoctoresEliminar.Click += tsbFrmDoctoresEliminar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tslBuscarFrmDocRead
            // 
            tslBuscarFrmDocRead.Alignment = ToolStripItemAlignment.Right;
            tslBuscarFrmDocRead.Image = (Image)resources.GetObject("tslBuscarFrmDocRead.Image");
            tslBuscarFrmDocRead.Margin = new Padding(0, 1, 1, 2);
            tslBuscarFrmDocRead.Name = "tslBuscarFrmDocRead";
            tslBuscarFrmDocRead.Size = new Size(16, 22);
            // 
            // tstbBuscarFrmDocRead
            // 
            tstbBuscarFrmDocRead.Alignment = ToolStripItemAlignment.Right;
            tstbBuscarFrmDocRead.BorderStyle = BorderStyle.FixedSingle;
            tstbBuscarFrmDocRead.Name = "tstbBuscarFrmDocRead";
            tstbBuscarFrmDocRead.Size = new Size(100, 25);
            tstbBuscarFrmDocRead.ToolTipText = "Buscar Doctor";
            // 
            // DgvwDoctoresRead
            // 
            DgvwDoctoresRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvwDoctoresRead.Dock = DockStyle.Fill;
            DgvwDoctoresRead.Location = new Point(0, 25);
            DgvwDoctoresRead.MultiSelect = false;
            DgvwDoctoresRead.Name = "DgvwDoctoresRead";
            DgvwDoctoresRead.Size = new Size(800, 425);
            DgvwDoctoresRead.TabIndex = 1;
            // 
            // FrmDoctoresRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvwDoctoresRead);
            Controls.Add(toolStripFrmDocRead);
            Name = "FrmDoctoresRead";
            Text = "Lista de Doctores";
            Load += FrmDoctoresRead_Load;
            toolStripFrmDocRead.ResumeLayout(false);
            toolStripFrmDocRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvwDoctoresRead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripFrmDocRead;
        private ToolStripButton tsbFrmDoctoresCrear;
        private ToolStripButton tsbFrmDoctoresEditar;
        private ToolStripButton tsbFrmDoctoresEliminar;
        private DataGridView DgvwDoctoresRead;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tslBuscarFrmDocRead;
        private ToolStripTextBox tstbBuscarFrmDocRead;
    }
}