namespace WinForm.Frm.Citas
{
    partial class FrmCitaCreate
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
            btnAceptarFrmCitaCreate = new Button();
            btnCancelarFrmCitaCreate = new Button();
            dtpFechaCitaFrmCitaCreate = new DateTimePicker();
            lblFechaCitaFrmCitaCreate = new Label();
            lblPacienteFrmCitaCreate = new Label();
            lblDoctorFrmCitaCreate = new Label();
            lblMotivoCitaFrmCitaCreate = new Label();
            cbPacienteFrmCitaCreate = new ComboBox();
            pacienteBindingSource = new BindingSource(components);
            cbDoctorFrmCitaCreate = new ComboBox();
            tbMotivoCitaFrmCitaCreate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAceptarFrmCitaCreate
            // 
            btnAceptarFrmCitaCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptarFrmCitaCreate.DialogResult = DialogResult.OK;
            btnAceptarFrmCitaCreate.Location = new Point(243, 352);
            btnAceptarFrmCitaCreate.Name = "btnAceptarFrmCitaCreate";
            btnAceptarFrmCitaCreate.Size = new Size(75, 23);
            btnAceptarFrmCitaCreate.TabIndex = 4;
            btnAceptarFrmCitaCreate.Text = "Aceptar";
            btnAceptarFrmCitaCreate.UseVisualStyleBackColor = true;
            btnAceptarFrmCitaCreate.Click += btnAceptarFrmCitaCreate_Click;
            // 
            // btnCancelarFrmCitaCreate
            // 
            btnCancelarFrmCitaCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarFrmCitaCreate.DialogResult = DialogResult.Cancel;
            btnCancelarFrmCitaCreate.Location = new Point(476, 352);
            btnCancelarFrmCitaCreate.Name = "btnCancelarFrmCitaCreate";
            btnCancelarFrmCitaCreate.Size = new Size(75, 23);
            btnCancelarFrmCitaCreate.TabIndex = 5;
            btnCancelarFrmCitaCreate.Text = "Cancelar";
            btnCancelarFrmCitaCreate.UseVisualStyleBackColor = true;
            btnCancelarFrmCitaCreate.Click += btnCancelarFrmCitaCreate_Click;
            // 
            // dtpFechaCitaFrmCitaCreate
            // 
            dtpFechaCitaFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaCitaFrmCitaCreate.Location = new Point(106, 12);
            dtpFechaCitaFrmCitaCreate.Name = "dtpFechaCitaFrmCitaCreate";
            dtpFechaCitaFrmCitaCreate.Size = new Size(682, 23);
            dtpFechaCitaFrmCitaCreate.TabIndex = 0;
            // 
            // lblFechaCitaFrmCitaCreate
            // 
            lblFechaCitaFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFechaCitaFrmCitaCreate.AutoSize = true;
            lblFechaCitaFrmCitaCreate.Location = new Point(12, 18);
            lblFechaCitaFrmCitaCreate.Name = "lblFechaCitaFrmCitaCreate";
            lblFechaCitaFrmCitaCreate.Size = new Size(88, 15);
            lblFechaCitaFrmCitaCreate.TabIndex = 3;
            lblFechaCitaFrmCitaCreate.Text = "Fecha de la cita";
            // 
            // lblPacienteFrmCitaCreate
            // 
            lblPacienteFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPacienteFrmCitaCreate.AutoSize = true;
            lblPacienteFrmCitaCreate.Location = new Point(48, 69);
            lblPacienteFrmCitaCreate.Name = "lblPacienteFrmCitaCreate";
            lblPacienteFrmCitaCreate.Size = new Size(52, 15);
            lblPacienteFrmCitaCreate.TabIndex = 4;
            lblPacienteFrmCitaCreate.Text = "Paciente";
            // 
            // lblDoctorFrmCitaCreate
            // 
            lblDoctorFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDoctorFrmCitaCreate.AutoSize = true;
            lblDoctorFrmCitaCreate.Location = new Point(57, 122);
            lblDoctorFrmCitaCreate.Name = "lblDoctorFrmCitaCreate";
            lblDoctorFrmCitaCreate.Size = new Size(43, 15);
            lblDoctorFrmCitaCreate.TabIndex = 5;
            lblDoctorFrmCitaCreate.Text = "Doctor";
            // 
            // lblMotivoCitaFrmCitaCreate
            // 
            lblMotivoCitaFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMotivoCitaFrmCitaCreate.AutoSize = true;
            lblMotivoCitaFrmCitaCreate.Location = new Point(12, 173);
            lblMotivoCitaFrmCitaCreate.Name = "lblMotivoCitaFrmCitaCreate";
            lblMotivoCitaFrmCitaCreate.Size = new Size(98, 15);
            lblMotivoCitaFrmCitaCreate.TabIndex = 6;
            lblMotivoCitaFrmCitaCreate.Text = "Motivo de la cita:";
            // 
            // cbPacienteFrmCitaCreate
            // 
            cbPacienteFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbPacienteFrmCitaCreate.DataSource = pacienteBindingSource;
            cbPacienteFrmCitaCreate.DisplayMember = "Apellidos";
            cbPacienteFrmCitaCreate.FormattingEnabled = true;
            cbPacienteFrmCitaCreate.Location = new Point(106, 66);
            cbPacienteFrmCitaCreate.Name = "cbPacienteFrmCitaCreate";
            cbPacienteFrmCitaCreate.Size = new Size(682, 23);
            cbPacienteFrmCitaCreate.TabIndex = 1;
            // 
            // pacienteBindingSource
            // 
            pacienteBindingSource.DataSource = typeof(Modelo.Paciente);
            // 
            // cbDoctorFrmCitaCreate
            // 
            cbDoctorFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbDoctorFrmCitaCreate.FormattingEnabled = true;
            cbDoctorFrmCitaCreate.Location = new Point(106, 119);
            cbDoctorFrmCitaCreate.Name = "cbDoctorFrmCitaCreate";
            cbDoctorFrmCitaCreate.Size = new Size(682, 23);
            cbDoctorFrmCitaCreate.TabIndex = 2;
            // 
            // tbMotivoCitaFrmCitaCreate
            // 
            tbMotivoCitaFrmCitaCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMotivoCitaFrmCitaCreate.Location = new Point(12, 191);
            tbMotivoCitaFrmCitaCreate.Multiline = true;
            tbMotivoCitaFrmCitaCreate.Name = "tbMotivoCitaFrmCitaCreate";
            tbMotivoCitaFrmCitaCreate.Size = new Size(776, 142);
            tbMotivoCitaFrmCitaCreate.TabIndex = 3;
            // 
            // FrmCitaCreate
            // 
            AcceptButton = btnAceptarFrmCitaCreate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelarFrmCitaCreate;
            ClientSize = new Size(800, 450);
            Controls.Add(tbMotivoCitaFrmCitaCreate);
            Controls.Add(cbDoctorFrmCitaCreate);
            Controls.Add(cbPacienteFrmCitaCreate);
            Controls.Add(lblMotivoCitaFrmCitaCreate);
            Controls.Add(lblDoctorFrmCitaCreate);
            Controls.Add(lblPacienteFrmCitaCreate);
            Controls.Add(lblFechaCitaFrmCitaCreate);
            Controls.Add(dtpFechaCitaFrmCitaCreate);
            Controls.Add(btnCancelarFrmCitaCreate);
            Controls.Add(btnAceptarFrmCitaCreate);
            Name = "FrmCitaCreate";
            Text = "FrmCitaCreate";
            Load += FrmCitaCreate_Load;
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptarFrmCitaCreate;
        private Button btnCancelarFrmCitaCreate;
        private DateTimePicker dtpFechaCitaFrmCitaCreate;
        private Label lblFechaCitaFrmCitaCreate;
        private Label lblPacienteFrmCitaCreate;
        private Label lblDoctorFrmCitaCreate;
        private Label lblMotivoCitaFrmCitaCreate;
        private ComboBox cbPacienteFrmCitaCreate;
        private ComboBox cbDoctorFrmCitaCreate;
        private TextBox tbMotivoCitaFrmCitaCreate;
        private BindingSource pacienteBindingSource;
    }
}