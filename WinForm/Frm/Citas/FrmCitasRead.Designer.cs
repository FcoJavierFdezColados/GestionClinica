namespace WinForm.Frm.Citas
{
    partial class FrmCitasRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitasRead));
            splitContainer1 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            dgwCitasRead = new DataGridView();
            toolStripFrmCitas = new ToolStrip();
            tsbFrmCitasAgregar = new ToolStripButton();
            tsbFrmCitasEditar = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            tsbFrmCitasEliminar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            statusStripFrmCitasRead = new StatusStrip();
            tsslFrmCitasRead = new ToolStripStatusLabel();
            citaBindingSource = new BindingSource(components);
            doctorBindingSource = new BindingSource(components);
            citaViewModelBindingSource = new BindingSource(components);
            Paciente = new DataGridViewTextBoxColumn();
            PacienteId = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            DoctorId = new DataGridViewTextBoxColumn();
            citaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaCitaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motivoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaCanceladaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fechaCancelacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motivoCancelacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCompletoPacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCompletoDoctorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCitasRead).BeginInit();
            toolStripFrmCitas.SuspendLayout();
            statusStripFrmCitasRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)citaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citaViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgwCitasRead);
            splitContainer1.Panel2.Controls.Add(toolStripFrmCitas);
            splitContainer1.Panel2.Controls.Add(statusStripFrmCitasRead);
            splitContainer1.Size = new Size(1041, 450);
            splitContainer1.SplitterDistance = 29;
            splitContainer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(818, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dgwCitasRead
            // 
            dgwCitasRead.AutoGenerateColumns = false;
            dgwCitasRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCitasRead.Columns.AddRange(new DataGridViewColumn[] { Paciente, PacienteId, Doctor, DoctorId, citaIdDataGridViewTextBoxColumn, fechaCitaDataGridViewTextBoxColumn, motivoDataGridViewTextBoxColumn, estaCanceladaDataGridViewCheckBoxColumn, fechaCancelacionDataGridViewTextBoxColumn, motivoCancelacionDataGridViewTextBoxColumn, nombreCompletoPacienteDataGridViewTextBoxColumn, nombreCompletoDoctorDataGridViewTextBoxColumn });
            dgwCitasRead.DataSource = citaViewModelBindingSource;
            dgwCitasRead.Dock = DockStyle.Fill;
            dgwCitasRead.Location = new Point(0, 25);
            dgwCitasRead.Name = "dgwCitasRead";
            dgwCitasRead.Size = new Size(1041, 370);
            dgwCitasRead.TabIndex = 3;
            // 
            // toolStripFrmCitas
            // 
            toolStripFrmCitas.Items.AddRange(new ToolStripItem[] { tsbFrmCitasAgregar, tsbFrmCitasEditar, toolStripLabel1, toolStripTextBox1, tsbFrmCitasEliminar, toolStripSeparator1 });
            toolStripFrmCitas.Location = new Point(0, 0);
            toolStripFrmCitas.Name = "toolStripFrmCitas";
            toolStripFrmCitas.Size = new Size(1041, 25);
            toolStripFrmCitas.TabIndex = 2;
            toolStripFrmCitas.Text = "toolStrip1";
            // 
            // tsbFrmCitasAgregar
            // 
            tsbFrmCitasAgregar.AccessibleRole = AccessibleRole.Dialog;
            tsbFrmCitasAgregar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmCitasAgregar.Image = (Image)resources.GetObject("tsbFrmCitasAgregar.Image");
            tsbFrmCitasAgregar.ImageTransparentColor = Color.Magenta;
            tsbFrmCitasAgregar.Name = "tsbFrmCitasAgregar";
            tsbFrmCitasAgregar.Size = new Size(23, 22);
            tsbFrmCitasAgregar.Tag = "Reservar cita";
            tsbFrmCitasAgregar.Text = "Crear cita";
            tsbFrmCitasAgregar.ToolTipText = "Añadir";
            tsbFrmCitasAgregar.Click += tsbFrmCitasAgregar_Click;
            tsbFrmCitasAgregar.MouseLeave += tsbFrmCitasAgregar_MouseLeave;
            tsbFrmCitasAgregar.MouseHover += tsbFrmCitasAgregar_MouseHover;
            // 
            // tsbFrmCitasEditar
            // 
            tsbFrmCitasEditar.AccessibleRole = AccessibleRole.Dialog;
            tsbFrmCitasEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmCitasEditar.Image = (Image)resources.GetObject("tsbFrmCitasEditar.Image");
            tsbFrmCitasEditar.ImageTransparentColor = Color.Magenta;
            tsbFrmCitasEditar.Name = "tsbFrmCitasEditar";
            tsbFrmCitasEditar.Size = new Size(23, 22);
            tsbFrmCitasEditar.Tag = "Editar cita";
            tsbFrmCitasEditar.Text = "Editar";
            tsbFrmCitasEditar.Click += tsbFrmCitasEditar_Click;
            tsbFrmCitasEditar.MouseLeave += tsbFrmCitasEditar_MouseLeave;
            tsbFrmCitasEditar.MouseHover += tsbFrmCitasEditar_MouseHover;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(16, 22);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.BackColor = SystemColors.Window;
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // tsbFrmCitasEliminar
            // 
            tsbFrmCitasEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmCitasEliminar.Image = (Image)resources.GetObject("tsbFrmCitasEliminar.Image");
            tsbFrmCitasEliminar.ImageTransparentColor = Color.Magenta;
            tsbFrmCitasEliminar.Name = "tsbFrmCitasEliminar";
            tsbFrmCitasEliminar.Size = new Size(23, 22);
            tsbFrmCitasEliminar.Tag = "Eliminar cita";
            tsbFrmCitasEliminar.Text = "Eliminar";
            tsbFrmCitasEliminar.MouseLeave += tsbFrmCitasEliminar_MouseLeave;
            tsbFrmCitasEliminar.MouseHover += tsbFrmCitasEliminar_MouseHover;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // statusStripFrmCitasRead
            // 
            statusStripFrmCitasRead.Items.AddRange(new ToolStripItem[] { tsslFrmCitasRead });
            statusStripFrmCitasRead.Location = new Point(0, 395);
            statusStripFrmCitasRead.Name = "statusStripFrmCitasRead";
            statusStripFrmCitasRead.Size = new Size(1041, 22);
            statusStripFrmCitasRead.TabIndex = 1;
            statusStripFrmCitasRead.Text = "statusStrip1";
            // 
            // tsslFrmCitasRead
            // 
            tsslFrmCitasRead.Name = "tsslFrmCitasRead";
            tsslFrmCitasRead.Size = new Size(0, 17);
            tsslFrmCitasRead.Tag = "Editar cita";
            // 
            // citaBindingSource
            // 
            citaBindingSource.DataSource = typeof(Modelo.Cita);
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Modelo.Doctor);
            // 
            // citaViewModelBindingSource
            // 
            citaViewModelBindingSource.DataSource = typeof(ViewModel.CitaViewModel);
            // 
            // Paciente
            // 
            Paciente.DataPropertyName = "Paciente";
            Paciente.HeaderText = "Paciente";
            Paciente.Name = "Paciente";
            Paciente.Visible = false;
            // 
            // PacienteId
            // 
            PacienteId.DataPropertyName = "PacienteId";
            PacienteId.HeaderText = "PacienteId";
            PacienteId.Name = "PacienteId";
            PacienteId.Visible = false;
            // 
            // Doctor
            // 
            Doctor.DataPropertyName = "Doctor";
            Doctor.HeaderText = "Doctor";
            Doctor.Name = "Doctor";
            Doctor.Visible = false;
            // 
            // DoctorId
            // 
            DoctorId.DataPropertyName = "DoctorId";
            DoctorId.HeaderText = "DoctorId";
            DoctorId.Name = "DoctorId";
            DoctorId.Visible = false;
            // 
            // citaIdDataGridViewTextBoxColumn
            // 
            citaIdDataGridViewTextBoxColumn.DataPropertyName = "CitaId";
            citaIdDataGridViewTextBoxColumn.HeaderText = "CitaId";
            citaIdDataGridViewTextBoxColumn.Name = "citaIdDataGridViewTextBoxColumn";
            citaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "FechaCita";
            fechaCitaDataGridViewTextBoxColumn.HeaderText = "FechaCita";
            fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            // 
            // estaCanceladaDataGridViewCheckBoxColumn
            // 
            estaCanceladaDataGridViewCheckBoxColumn.DataPropertyName = "EstaCancelada";
            estaCanceladaDataGridViewCheckBoxColumn.HeaderText = "EstaCancelada";
            estaCanceladaDataGridViewCheckBoxColumn.Name = "estaCanceladaDataGridViewCheckBoxColumn";
            // 
            // fechaCancelacionDataGridViewTextBoxColumn
            // 
            fechaCancelacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCancelacion";
            fechaCancelacionDataGridViewTextBoxColumn.HeaderText = "FechaCancelacion";
            fechaCancelacionDataGridViewTextBoxColumn.Name = "fechaCancelacionDataGridViewTextBoxColumn";
            // 
            // motivoCancelacionDataGridViewTextBoxColumn
            // 
            motivoCancelacionDataGridViewTextBoxColumn.DataPropertyName = "MotivoCancelacion";
            motivoCancelacionDataGridViewTextBoxColumn.HeaderText = "MotivoCancelacion";
            motivoCancelacionDataGridViewTextBoxColumn.Name = "motivoCancelacionDataGridViewTextBoxColumn";
            // 
            // nombreCompletoPacienteDataGridViewTextBoxColumn
            // 
            nombreCompletoPacienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCompletoPaciente";
            nombreCompletoPacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            nombreCompletoPacienteDataGridViewTextBoxColumn.Name = "nombreCompletoPacienteDataGridViewTextBoxColumn";
            // 
            // nombreCompletoDoctorDataGridViewTextBoxColumn
            // 
            nombreCompletoDoctorDataGridViewTextBoxColumn.DataPropertyName = "NombreCompletoDoctor";
            nombreCompletoDoctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            nombreCompletoDoctorDataGridViewTextBoxColumn.Name = "nombreCompletoDoctorDataGridViewTextBoxColumn";
            // 
            // FrmCitasRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 450);
            Controls.Add(splitContainer1);
            Name = "FrmCitasRead";
            Text = "FrmCitasRead";
            Load += FrmCitasRead_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwCitasRead).EndInit();
            toolStripFrmCitas.ResumeLayout(false);
            toolStripFrmCitas.PerformLayout();
            statusStripFrmCitasRead.ResumeLayout(false);
            statusStripFrmCitasRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)citaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)citaViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DateTimePicker dateTimePicker1;
        private ToolStrip toolStripFrmCitas;
        private ToolStripButton tsbFrmCitasAgregar;
        private StatusStrip statusStripFrmCitasRead;
        private ToolStripButton tsbFrmCitasEditar;
        private ToolStripTextBox toolStripTextBox1;
        private DataGridView dgwCitasRead;
        private ToolStripStatusLabel tsslFrmCitasRead;
        private ToolStripButton tsbFrmCitasEliminar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CitaId;
        private DataGridViewTextBoxColumn FechaCita;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewCheckBoxColumn EstaCancelada;
        private DataGridViewTextBoxColumn FechaCancelacion;
        private DataGridViewTextBoxColumn MotivoCancelacion;
        private BindingSource doctorBindingSource;
        private BindingSource citaBindingSource;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn PacienteId;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn DoctorId;
        private DataGridViewTextBoxColumn citaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estaCanceladaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaCancelacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoCancelacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCompletoPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCompletoDoctorDataGridViewTextBoxColumn;
        private BindingSource citaViewModelBindingSource;
    }
}