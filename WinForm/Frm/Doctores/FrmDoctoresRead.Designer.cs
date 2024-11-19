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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctoresRead));
            toolStripFrmDocRead = new ToolStrip();
            tsbFrmDoctoresCrear = new ToolStripButton();
            tsbFrmDoctoresEditar = new ToolStripButton();
            tsbFrmDoctoresEliminar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tslBuscarFrmDocRead = new ToolStripLabel();
            tstbBuscarFrmDocRead = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            DgvwDoctoresRead = new DataGridView();
            doctorBindingSource = new BindingSource(components);
            DoctorId = new DataGridViewTextBoxColumn();
            NumColegiado = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            toolStripFrmDocRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvwDoctoresRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStripFrmDocRead
            // 
            toolStripFrmDocRead.Items.AddRange(new ToolStripItem[] { tsbFrmDoctoresCrear, tsbFrmDoctoresEditar, tsbFrmDoctoresEliminar, toolStripSeparator1, tslBuscarFrmDocRead, tstbBuscarFrmDocRead, toolStripLabel1 });
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
            tstbBuscarFrmDocRead.TextChanged += tstbBuscarFrmDocRead_TextChanged;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(59, 22);
            toolStripLabel1.Text = "Apellidos:";
            // 
            // DgvwDoctoresRead
            // 
            DgvwDoctoresRead.AutoGenerateColumns = false;
            DgvwDoctoresRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvwDoctoresRead.Columns.AddRange(new DataGridViewColumn[] { DoctorId, NumColegiado, Apellidos, Nombre });
            DgvwDoctoresRead.DataSource = doctorBindingSource;
            DgvwDoctoresRead.Dock = DockStyle.Fill;
            DgvwDoctoresRead.Location = new Point(0, 25);
            DgvwDoctoresRead.MultiSelect = false;
            DgvwDoctoresRead.Name = "DgvwDoctoresRead";
            DgvwDoctoresRead.Size = new Size(800, 425);
            DgvwDoctoresRead.TabIndex = 1;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Modelo.Doctor);
            // 
            // DoctorId
            // 
            DoctorId.DataPropertyName = "DoctorId";
            DoctorId.HeaderText = "DoctorId";
            DoctorId.Name = "DoctorId";
            DoctorId.ToolTipText = "DoctorId";
            DoctorId.Visible = false;
            // 
            // NumColegiado
            // 
            NumColegiado.DataPropertyName = "NumColegiado";
            NumColegiado.HeaderText = "Número de Colegiado";
            NumColegiado.Name = "NumColegiado";
            NumColegiado.ToolTipText = "NumColegiado";
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.ToolTipText = "Apellidos";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ToolTipText = "Nombre";
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
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
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
        private ToolStripLabel toolStripLabel1;
        private DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numColegiadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DoctorId;
        private DataGridViewTextBoxColumn NumColegiado;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Nombre;
        private BindingSource doctorBindingSource;
    }
}