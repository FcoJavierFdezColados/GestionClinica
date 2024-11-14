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
            btnFrmCitaUpdateAceptar = new Button();
            btnFrmCitaUpdateCancelar = new Button();
            gbFrmCitaUpdateActualizar = new GroupBox();
            gbFrmCitaUpdateCancelar = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            gbFrmCitaUpdateActualizar.SuspendLayout();
            gbFrmCitaUpdateCancelar.SuspendLayout();
            SuspendLayout();
            // 
            // btnFrmCitaUpdateAceptar
            // 
            btnFrmCitaUpdateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFrmCitaUpdateAceptar.DialogResult = DialogResult.OK;
            btnFrmCitaUpdateAceptar.Location = new Point(240, 415);
            btnFrmCitaUpdateAceptar.Name = "btnFrmCitaUpdateAceptar";
            btnFrmCitaUpdateAceptar.Size = new Size(75, 23);
            btnFrmCitaUpdateAceptar.TabIndex = 0;
            btnFrmCitaUpdateAceptar.Text = "Aceptar";
            btnFrmCitaUpdateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnFrmCitaUpdateCancelar
            // 
            btnFrmCitaUpdateCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFrmCitaUpdateCancelar.DialogResult = DialogResult.Cancel;
            btnFrmCitaUpdateCancelar.Location = new Point(461, 415);
            btnFrmCitaUpdateCancelar.Name = "btnFrmCitaUpdateCancelar";
            btnFrmCitaUpdateCancelar.Size = new Size(75, 23);
            btnFrmCitaUpdateCancelar.TabIndex = 1;
            btnFrmCitaUpdateCancelar.Text = "Cancelar";
            btnFrmCitaUpdateCancelar.UseVisualStyleBackColor = true;
            // 
            // gbFrmCitaUpdateActualizar
            // 
            gbFrmCitaUpdateActualizar.Controls.Add(textBox1);
            gbFrmCitaUpdateActualizar.Controls.Add(label4);
            gbFrmCitaUpdateActualizar.Controls.Add(comboBox2);
            gbFrmCitaUpdateActualizar.Controls.Add(comboBox1);
            gbFrmCitaUpdateActualizar.Controls.Add(dateTimePicker1);
            gbFrmCitaUpdateActualizar.Controls.Add(label3);
            gbFrmCitaUpdateActualizar.Controls.Add(label2);
            gbFrmCitaUpdateActualizar.Controls.Add(label1);
            gbFrmCitaUpdateActualizar.Location = new Point(12, 12);
            gbFrmCitaUpdateActualizar.Name = "gbFrmCitaUpdateActualizar";
            gbFrmCitaUpdateActualizar.Size = new Size(776, 214);
            gbFrmCitaUpdateActualizar.TabIndex = 2;
            gbFrmCitaUpdateActualizar.TabStop = false;
            gbFrmCitaUpdateActualizar.Text = "Datos de la cita";
            // 
            // gbFrmCitaUpdateCancelar
            // 
            gbFrmCitaUpdateCancelar.Controls.Add(label7);
            gbFrmCitaUpdateCancelar.Controls.Add(textBox2);
            gbFrmCitaUpdateCancelar.Controls.Add(label6);
            gbFrmCitaUpdateCancelar.Controls.Add(checkBox1);
            gbFrmCitaUpdateCancelar.Controls.Add(dateTimePicker2);
            gbFrmCitaUpdateCancelar.Controls.Add(label5);
            gbFrmCitaUpdateCancelar.Location = new Point(12, 232);
            gbFrmCitaUpdateCancelar.Name = "gbFrmCitaUpdateCancelar";
            gbFrmCitaUpdateCancelar.Size = new Size(776, 163);
            gbFrmCitaUpdateCancelar.TabIndex = 3;
            gbFrmCitaUpdateCancelar.TabStop = false;
            gbFrmCitaUpdateCancelar.Text = "Cancelar Cita";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 106);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(103, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(103, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(247, 23);
            comboBox2.TabIndex = 5;
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(449, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 160);
            textBox1.TabIndex = 7;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(132, 36);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(218, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(157, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Está cancelada";
            checkBox1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(449, 37);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 120);
            textBox2.TabIndex = 5;
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
            // FrmCitaUpdate
            // 
            AcceptButton = btnFrmCitaUpdateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFrmCitaUpdateCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(gbFrmCitaUpdateCancelar);
            Controls.Add(gbFrmCitaUpdateActualizar);
            Controls.Add(btnFrmCitaUpdateCancelar);
            Controls.Add(btnFrmCitaUpdateAceptar);
            Name = "FrmCitaUpdate";
            Text = "FrmCitaUpdate";
            gbFrmCitaUpdateActualizar.ResumeLayout(false);
            gbFrmCitaUpdateActualizar.PerformLayout();
            gbFrmCitaUpdateCancelar.ResumeLayout(false);
            gbFrmCitaUpdateCancelar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmCitaUpdateAceptar;
        private Button btnFrmCitaUpdateCancelar;
        private GroupBox gbFrmCitaUpdateActualizar;
        private GroupBox gbFrmCitaUpdateCancelar;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label6;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label7;
    }
}