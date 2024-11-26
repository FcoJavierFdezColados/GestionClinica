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
            dtpFechaCitaFrmCitasRead = new DateTimePicker();
            dgwCitasRead = new DataGridView();
            CitaId = new DataGridViewTextBoxColumn();
            FechaCita = new DataGridViewTextBoxColumn();
            NombreCompletoPaciente = new DataGridViewTextBoxColumn();
            NombreCompletoDoctor = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            EstaCancelada = new DataGridViewCheckBoxColumn();
            MotivoCancelacion = new DataGridViewTextBoxColumn();
            Paciente = new DataGridViewTextBoxColumn();
            PacienteId = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            DoctorId = new DataGridViewTextBoxColumn();
            FechaCancelacion = new DataGridViewTextBoxColumn();
            toolStripFrmCitas = new ToolStrip();
            tsbFrmCitasAgregar = new ToolStripButton();
            tsbFrmCitasCancelar = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            tbBuscarCitaFrmCitasRead = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            statusStripFrmCitasRead = new StatusStrip();
            tsslFrmCitasRead = new ToolStripStatusLabel();
            citaBindingSource = new BindingSource(components);
            tslBuscarCitas = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCitasRead).BeginInit();
            toolStripFrmCitas.SuspendLayout();
            statusStripFrmCitasRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)citaBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dtpFechaCitaFrmCitasRead);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgwCitasRead);
            splitContainer1.Panel2.Controls.Add(toolStripFrmCitas);
            splitContainer1.Panel2.Controls.Add(statusStripFrmCitasRead);
            splitContainer1.Size = new Size(445, 450);
            splitContainer1.SplitterDistance = 29;
            splitContainer1.TabIndex = 0;
            // 
            // dtpFechaCitaFrmCitasRead
            // 
            dtpFechaCitaFrmCitasRead.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpFechaCitaFrmCitasRead.Location = new Point(222, 3);
            dtpFechaCitaFrmCitasRead.Name = "dtpFechaCitaFrmCitasRead";
            dtpFechaCitaFrmCitasRead.Size = new Size(220, 23);
            dtpFechaCitaFrmCitasRead.TabIndex = 0;
            dtpFechaCitaFrmCitasRead.ValueChanged += dtpFechaCitaFrmCitasRead_ValueChanged;
            // 
            // dgwCitasRead
            // 
            dgwCitasRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCitasRead.Columns.AddRange(new DataGridViewColumn[] { CitaId, FechaCita, NombreCompletoPaciente, NombreCompletoDoctor, Motivo, EstaCancelada, MotivoCancelacion, Paciente, PacienteId, Doctor, DoctorId, FechaCancelacion });
            dgwCitasRead.Dock = DockStyle.Fill;
            dgwCitasRead.Location = new Point(0, 25);
            dgwCitasRead.Name = "dgwCitasRead";
            dgwCitasRead.Size = new Size(445, 370);
            dgwCitasRead.TabIndex = 3;
            // 
            // CitaId
            // 
            CitaId.DataPropertyName = "CitaId";
            CitaId.HeaderText = "CitaId";
            CitaId.Name = "CitaId";
            CitaId.Visible = false;
            // 
            // FechaCita
            // 
            FechaCita.DataPropertyName = "FechaCita";
            FechaCita.HeaderText = "Fecha de la cita";
            FechaCita.Name = "FechaCita";
            // 
            // NombreCompletoPaciente
            // 
            NombreCompletoPaciente.DataPropertyName = "NombreCompletoPaciente";
            NombreCompletoPaciente.HeaderText = "Paciente";
            NombreCompletoPaciente.Name = "NombreCompletoPaciente";
            // 
            // NombreCompletoDoctor
            // 
            NombreCompletoDoctor.DataPropertyName = "NombreCompletoDoctor";
            NombreCompletoDoctor.HeaderText = "Doctor";
            NombreCompletoDoctor.Name = "NombreCompletoDoctor";
            // 
            // Motivo
            // 
            Motivo.DataPropertyName = "Motivo";
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            Motivo.Visible = false;
            // 
            // EstaCancelada
            // 
            EstaCancelada.DataPropertyName = "EstaCancelada";
            EstaCancelada.HeaderText = "Esta Cancelada";
            EstaCancelada.Name = "EstaCancelada";
            EstaCancelada.Resizable = DataGridViewTriState.True;
            EstaCancelada.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MotivoCancelacion
            // 
            MotivoCancelacion.DataPropertyName = "MotivoCancelacion";
            MotivoCancelacion.HeaderText = "Motivo de la cancelacion";
            MotivoCancelacion.Name = "MotivoCancelacion";
            MotivoCancelacion.Visible = false;
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
            // FechaCancelacion
            // 
            FechaCancelacion.DataPropertyName = "FechaCancelacion";
            FechaCancelacion.HeaderText = "Fecha de Cancelacion";
            FechaCancelacion.Name = "FechaCancelacion";
            FechaCancelacion.Visible = false;
            // 
            // toolStripFrmCitas
            // 
            toolStripFrmCitas.Items.AddRange(new ToolStripItem[] { tsbFrmCitasAgregar, tsbFrmCitasCancelar, toolStripLabel1, tbBuscarCitaFrmCitasRead, toolStripSeparator1, tslBuscarCitas });
            toolStripFrmCitas.Location = new Point(0, 0);
            toolStripFrmCitas.Name = "toolStripFrmCitas";
            toolStripFrmCitas.Size = new Size(445, 25);
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
            // tsbFrmCitasCancelar
            // 
            tsbFrmCitasCancelar.AccessibleRole = AccessibleRole.Dialog;
            tsbFrmCitasCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFrmCitasCancelar.Image = (Image)resources.GetObject("tsbFrmCitasCancelar.Image");
            tsbFrmCitasCancelar.ImageTransparentColor = Color.Magenta;
            tsbFrmCitasCancelar.Name = "tsbFrmCitasCancelar";
            tsbFrmCitasCancelar.Size = new Size(23, 22);
            tsbFrmCitasCancelar.Tag = "Camcelar cita";
            tsbFrmCitasCancelar.Text = "Cancelar cita";
            tsbFrmCitasCancelar.Click += tsbFrmCitasCancelar_Click;
            tsbFrmCitasCancelar.MouseLeave += tsbFrmCitasCancelar_MouseLeave;
            tsbFrmCitasCancelar.MouseHover += tsbFrmCitasCancelar_MouseHover;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(16, 22);
            // 
            // tbBuscarCitaFrmCitasRead
            // 
            tbBuscarCitaFrmCitasRead.Alignment = ToolStripItemAlignment.Right;
            tbBuscarCitaFrmCitasRead.BackColor = SystemColors.Window;
            tbBuscarCitaFrmCitasRead.BorderStyle = BorderStyle.FixedSingle;
            tbBuscarCitaFrmCitasRead.Name = "tbBuscarCitaFrmCitasRead";
            tbBuscarCitaFrmCitasRead.Size = new Size(100, 25);
            tbBuscarCitaFrmCitasRead.TextChanged += tbBuscarCitaFrmCitasRead_TextChanged;
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
            statusStripFrmCitasRead.Size = new Size(445, 22);
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
            // tslBuscarCitas
            // 
            tslBuscarCitas.Alignment = ToolStripItemAlignment.Right;
            tslBuscarCitas.Name = "tslBuscarCitas";
            tslBuscarCitas.Size = new Size(141, 22);
            tslBuscarCitas.Text = "Buscar citas por paciente:";
            // 
            // FrmCitasRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
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
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DateTimePicker dtpFechaCitaFrmCitasRead;
        private ToolStrip toolStripFrmCitas;
        private ToolStripButton tsbFrmCitasAgregar;
        private StatusStrip statusStripFrmCitasRead;
        private ToolStripButton tsbFrmCitasCancelar;
        private ToolStripTextBox tbBuscarCitaFrmCitasRead;
        private ToolStripStatusLabel tsslFrmCitasRead;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private BindingSource citaBindingSource;
        private DataGridView dgwCitasRead;
        private DataGridViewTextBoxColumn CitaId;
        private DataGridViewTextBoxColumn FechaCita;
        private DataGridViewTextBoxColumn NombreCompletoPaciente;
        private DataGridViewTextBoxColumn NombreCompletoDoctor;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewCheckBoxColumn EstaCancelada;
        private DataGridViewTextBoxColumn MotivoCancelacion;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn PacienteId;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn DoctorId;
        private DataGridViewTextBoxColumn FechaCancelacion;
        private ToolStripLabel tslBuscarCitas;
    }
}