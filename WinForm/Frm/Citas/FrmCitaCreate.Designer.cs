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
            btnFrmCitaCreateAceptar = new Button();
            btnFrmCitaCreateCancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnFrmCitaCreateAceptar
            // 
            btnFrmCitaCreateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFrmCitaCreateAceptar.DialogResult = DialogResult.OK;
            btnFrmCitaCreateAceptar.Location = new Point(243, 352);
            btnFrmCitaCreateAceptar.Name = "btnFrmCitaCreateAceptar";
            btnFrmCitaCreateAceptar.Size = new Size(75, 23);
            btnFrmCitaCreateAceptar.TabIndex = 0;
            btnFrmCitaCreateAceptar.Text = "Aceptar";
            btnFrmCitaCreateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnFrmCitaCreateCancelar
            // 
            btnFrmCitaCreateCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFrmCitaCreateCancelar.DialogResult = DialogResult.Cancel;
            btnFrmCitaCreateCancelar.Location = new Point(476, 352);
            btnFrmCitaCreateCancelar.Name = "btnFrmCitaCreateCancelar";
            btnFrmCitaCreateCancelar.Size = new Size(75, 23);
            btnFrmCitaCreateCancelar.TabIndex = 1;
            btnFrmCitaCreateCancelar.Text = "Cancelar";
            btnFrmCitaCreateCancelar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(682, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha de la cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 69);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 122);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Doctor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 6;
            label4.Text = "Motivo de la cita:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(682, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(106, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(682, 23);
            comboBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 142);
            textBox1.TabIndex = 9;
            // 
            // FrmCitaCreate
            // 
            AcceptButton = btnFrmCitaCreateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnFrmCitaCreateCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnFrmCitaCreateCancelar);
            Controls.Add(btnFrmCitaCreateAceptar);
            Name = "FrmCitaCreate";
            Text = "FrmCitaCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFrmCitaCreateAceptar;
        private Button btnFrmCitaCreateCancelar;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}