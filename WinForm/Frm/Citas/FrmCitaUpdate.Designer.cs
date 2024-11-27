namespace WinForm.Frm.Citas
{
    partial class FrmCitaUpdate
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
            btnAceptarFrmCitaUpdate = new Button();
            btnCancelarFrmCitaUpdate = new Button();
            gbFrmCitaUpdateActualizar = new GroupBox();
            tbDoctorFrmCitaUpdate = new TextBox();
            tbPacienteFrmCitaUpdate = new TextBox();
            tbMotivoCitaFrmCitaUpdate = new TextBox();
            label4 = new Label();
            dtpFechaCitaFrmCitaUpdate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbFrmCitaUpdateCancelar = new GroupBox();
            label7 = new Label();
            tbMotivoCancelFrmCitaUpdate = new TextBox();
            label6 = new Label();
            ckbEstaCanceladaFrmCitaUpdate = new CheckBox();
            dtpFechaCancelFrmCitaUpdate = new DateTimePicker();
            label5 = new Label();
            gbFrmCitaUpdateActualizar.SuspendLayout();
            gbFrmCitaUpdateCancelar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptarFrmCitaUpdate
            // 
            btnAceptarFrmCitaUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptarFrmCitaUpdate.DialogResult = DialogResult.OK;
            btnAceptarFrmCitaUpdate.Location = new Point(240, 452);
            btnAceptarFrmCitaUpdate.Name = "btnAceptarFrmCitaUpdate";
            btnAceptarFrmCitaUpdate.Size = new Size(75, 23);
            btnAceptarFrmCitaUpdate.TabIndex = 1;
            btnAceptarFrmCitaUpdate.Text = "Aceptar";
            btnAceptarFrmCitaUpdate.UseVisualStyleBackColor = true;
            btnAceptarFrmCitaUpdate.Click += btnAceptarFrmCitaUpdate_Click;
            // 
            // btnCancelarFrmCitaUpdate
            // 
            btnCancelarFrmCitaUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarFrmCitaUpdate.DialogResult = DialogResult.Cancel;
            btnCancelarFrmCitaUpdate.Location = new Point(455, 452);
            btnCancelarFrmCitaUpdate.Name = "btnCancelarFrmCitaUpdate";
            btnCancelarFrmCitaUpdate.Size = new Size(75, 23);
            btnCancelarFrmCitaUpdate.TabIndex = 2;
            btnCancelarFrmCitaUpdate.Text = "Cancelar";
            btnCancelarFrmCitaUpdate.UseVisualStyleBackColor = true;
            // 
            // gbFrmCitaUpdateActualizar
            // 
            gbFrmCitaUpdateActualizar.Controls.Add(tbDoctorFrmCitaUpdate);
            gbFrmCitaUpdateActualizar.Controls.Add(tbPacienteFrmCitaUpdate);
            gbFrmCitaUpdateActualizar.Controls.Add(tbMotivoCitaFrmCitaUpdate);
            gbFrmCitaUpdateActualizar.Controls.Add(label4);
            gbFrmCitaUpdateActualizar.Controls.Add(dtpFechaCitaFrmCitaUpdate);
            gbFrmCitaUpdateActualizar.Controls.Add(label3);
            gbFrmCitaUpdateActualizar.Controls.Add(label2);
            gbFrmCitaUpdateActualizar.Controls.Add(label1);
            gbFrmCitaUpdateActualizar.Location = new Point(0, 0);
            gbFrmCitaUpdateActualizar.Name = "gbFrmCitaUpdateActualizar";
            gbFrmCitaUpdateActualizar.Size = new Size(794, 214);
            gbFrmCitaUpdateActualizar.TabIndex = 2;
            gbFrmCitaUpdateActualizar.TabStop = false;
            gbFrmCitaUpdateActualizar.Text = "Datos de la cita";
            // 
            // tbDoctorFrmCitaUpdate
            // 
            tbDoctorFrmCitaUpdate.Enabled = false;
            tbDoctorFrmCitaUpdate.Location = new Point(103, 153);
            tbDoctorFrmCitaUpdate.Name = "tbDoctorFrmCitaUpdate";
            tbDoctorFrmCitaUpdate.Size = new Size(247, 23);
            tbDoctorFrmCitaUpdate.TabIndex = 9;
            // 
            // tbPacienteFrmCitaUpdate
            // 
            tbPacienteFrmCitaUpdate.Enabled = false;
            tbPacienteFrmCitaUpdate.Location = new Point(103, 103);
            tbPacienteFrmCitaUpdate.Name = "tbPacienteFrmCitaUpdate";
            tbPacienteFrmCitaUpdate.Size = new Size(247, 23);
            tbPacienteFrmCitaUpdate.TabIndex = 8;
            // 
            // tbMotivoCitaFrmCitaUpdate
            // 
            tbMotivoCitaFrmCitaUpdate.Enabled = false;
            tbMotivoCitaFrmCitaUpdate.Location = new Point(449, 48);
            tbMotivoCitaFrmCitaUpdate.Multiline = true;
            tbMotivoCitaFrmCitaUpdate.Name = "tbMotivoCitaFrmCitaUpdate";
            tbMotivoCitaFrmCitaUpdate.Size = new Size(321, 160);
            tbMotivoCitaFrmCitaUpdate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 19);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 6;
            label4.Text = "Motivo de la cita:";
            // 
            // dtpFechaCitaFrmCitaUpdate
            // 
            dtpFechaCitaFrmCitaUpdate.Enabled = false;
            dtpFechaCitaFrmCitaUpdate.Location = new Point(103, 48);
            dtpFechaCitaFrmCitaUpdate.Name = "dtpFechaCitaFrmCitaUpdate";
            dtpFechaCitaFrmCitaUpdate.Size = new Size(247, 23);
            dtpFechaCitaFrmCitaUpdate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 156);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 106);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 54);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha de la cita";
            // 
            // gbFrmCitaUpdateCancelar
            // 
            gbFrmCitaUpdateCancelar.Controls.Add(label7);
            gbFrmCitaUpdateCancelar.Controls.Add(tbMotivoCancelFrmCitaUpdate);
            gbFrmCitaUpdateCancelar.Controls.Add(label6);
            gbFrmCitaUpdateCancelar.Controls.Add(ckbEstaCanceladaFrmCitaUpdate);
            gbFrmCitaUpdateCancelar.Controls.Add(dtpFechaCancelFrmCitaUpdate);
            gbFrmCitaUpdateCancelar.Controls.Add(label5);
            gbFrmCitaUpdateCancelar.Location = new Point(0, 220);
            gbFrmCitaUpdateCancelar.Name = "gbFrmCitaUpdateCancelar";
            gbFrmCitaUpdateCancelar.Size = new Size(794, 208);
            gbFrmCitaUpdateCancelar.TabIndex = 3;
            gbFrmCitaUpdateCancelar.TabStop = false;
            gbFrmCitaUpdateCancelar.Text = "Cancelar Cita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 94);
            label7.Name = "label7";
            label7.Size = new Size(142, 15);
            label7.TabIndex = 6;
            label7.Text = "Marcar para cancelar cita:";
            // 
            // tbMotivoCancelFrmCitaUpdate
            // 
            tbMotivoCancelFrmCitaUpdate.Location = new Point(449, 37);
            tbMotivoCancelFrmCitaUpdate.Multiline = true;
            tbMotivoCancelFrmCitaUpdate.Name = "tbMotivoCancelFrmCitaUpdate";
            tbMotivoCancelFrmCitaUpdate.Size = new Size(321, 120);
            tbMotivoCancelFrmCitaUpdate.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 19);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 4;
            label6.Text = "Motivo de la cancelación:";
            // 
            // ckbEstaCanceladaFrmCitaUpdate
            // 
            ckbEstaCanceladaFrmCitaUpdate.AutoSize = true;
            ckbEstaCanceladaFrmCitaUpdate.Checked = true;
            ckbEstaCanceladaFrmCitaUpdate.CheckState = CheckState.Checked;
            ckbEstaCanceladaFrmCitaUpdate.Enabled = false;
            ckbEstaCanceladaFrmCitaUpdate.Location = new Point(157, 93);
            ckbEstaCanceladaFrmCitaUpdate.Name = "ckbEstaCanceladaFrmCitaUpdate";
            ckbEstaCanceladaFrmCitaUpdate.Size = new Size(103, 19);
            ckbEstaCanceladaFrmCitaUpdate.TabIndex = 3;
            ckbEstaCanceladaFrmCitaUpdate.Text = "Está cancelada";
            ckbEstaCanceladaFrmCitaUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCancelFrmCitaUpdate
            // 
            dtpFechaCancelFrmCitaUpdate.Enabled = false;
            dtpFechaCancelFrmCitaUpdate.Location = new Point(132, 36);
            dtpFechaCancelFrmCitaUpdate.Name = "dtpFechaCancelFrmCitaUpdate";
            dtpFechaCancelFrmCitaUpdate.Size = new Size(218, 23);
            dtpFechaCancelFrmCitaUpdate.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 42);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 0;
            label5.Text = "Fecha de cancelación";
            // 
            // FrmCitaUpdate
            // 
            AcceptButton = btnAceptarFrmCitaUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelarFrmCitaUpdate;
            ClientSize = new Size(794, 487);
            Controls.Add(gbFrmCitaUpdateCancelar);
            Controls.Add(gbFrmCitaUpdateActualizar);
            Controls.Add(btnCancelarFrmCitaUpdate);
            Controls.Add(btnAceptarFrmCitaUpdate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCitaUpdate";
            Text = "Cancelar Cita";
            Load += FrmCitaUpdate_Load;
            gbFrmCitaUpdateActualizar.ResumeLayout(false);
            gbFrmCitaUpdateActualizar.PerformLayout();
            gbFrmCitaUpdateCancelar.ResumeLayout(false);
            gbFrmCitaUpdateCancelar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptarFrmCitaUpdate;
        private Button btnCancelarFrmCitaUpdate;
        private GroupBox gbFrmCitaUpdateActualizar;
        private GroupBox gbFrmCitaUpdateCancelar;
        private DateTimePicker dtpFechaCitaFrmCitaUpdate;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbMotivoCitaFrmCitaUpdate;
        private Label label4;
        private TextBox tbMotivoCancelFrmCitaUpdate;
        private Label label6;
        private CheckBox ckbEstaCanceladaFrmCitaUpdate;
        private DateTimePicker dtpFechaCancelFrmCitaUpdate;
        private Label label5;
        private Label label7;
        private TextBox tbDoctorFrmCitaUpdate;
        private TextBox tbPacienteFrmCitaUpdate;
    }
}