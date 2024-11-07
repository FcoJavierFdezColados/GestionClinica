namespace WinForm.Frm.Doctores
{
    partial class FrmDoctoresUpdate
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
            btnDoctoresUpdateAceptar = new Button();
            btnDoctoresUpdateCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnDoctoresUpdateAceptar
            // 
            btnDoctoresUpdateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDoctoresUpdateAceptar.DialogResult = DialogResult.OK;
            btnDoctoresUpdateAceptar.Location = new Point(229, 348);
            btnDoctoresUpdateAceptar.Name = "btnDoctoresUpdateAceptar";
            btnDoctoresUpdateAceptar.Size = new Size(75, 23);
            btnDoctoresUpdateAceptar.TabIndex = 0;
            btnDoctoresUpdateAceptar.Text = "Aceptar";
            btnDoctoresUpdateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnDoctoresUpdateCancel
            // 
            btnDoctoresUpdateCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDoctoresUpdateCancel.DialogResult = DialogResult.Cancel;
            btnDoctoresUpdateCancel.Location = new Point(484, 348);
            btnDoctoresUpdateCancel.Name = "btnDoctoresUpdateCancel";
            btnDoctoresUpdateCancel.Size = new Size(75, 23);
            btnDoctoresUpdateCancel.TabIndex = 1;
            btnDoctoresUpdateCancel.Text = "Cancelar";
            btnDoctoresUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Número de Colegiado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(646, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // FrmDoctoresUpdate
            // 
            AcceptButton = btnDoctoresUpdateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnDoctoresUpdateCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDoctoresUpdateCancel);
            Controls.Add(btnDoctoresUpdateAceptar);
            Name = "FrmDoctoresUpdate";
            Text = "FrmDoctoresUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoctoresUpdateAceptar;
        private Button btnDoctoresUpdateCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}