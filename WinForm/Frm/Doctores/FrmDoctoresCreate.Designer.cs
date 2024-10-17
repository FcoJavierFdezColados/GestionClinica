namespace WinForm.Frm.Doctores
{
    partial class FrmDoctoresCreate
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
            btnDoctoresCreateAceptar = new Button();
            btnDoctoresCreateCancel = new Button();
            SuspendLayout();
            // 
            // btnDoctoresCreateAceptar
            // 
            btnDoctoresCreateAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDoctoresCreateAceptar.DialogResult = DialogResult.OK;
            btnDoctoresCreateAceptar.Location = new Point(207, 353);
            btnDoctoresCreateAceptar.Name = "btnDoctoresCreateAceptar";
            btnDoctoresCreateAceptar.Size = new Size(75, 23);
            btnDoctoresCreateAceptar.TabIndex = 0;
            btnDoctoresCreateAceptar.Text = "Aceptar";
            btnDoctoresCreateAceptar.UseVisualStyleBackColor = true;
            // 
            // btnDoctoresCreateCancel
            // 
            btnDoctoresCreateCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDoctoresCreateCancel.DialogResult = DialogResult.Cancel;
            btnDoctoresCreateCancel.Location = new Point(435, 353);
            btnDoctoresCreateCancel.Name = "btnDoctoresCreateCancel";
            btnDoctoresCreateCancel.Size = new Size(75, 23);
            btnDoctoresCreateCancel.TabIndex = 1;
            btnDoctoresCreateCancel.Text = "Cancelar";
            btnDoctoresCreateCancel.UseVisualStyleBackColor = true;
            // 
            // FrmDoctoresCreate
            // 
            AcceptButton = btnDoctoresCreateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnDoctoresCreateCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoctoresCreateCancel);
            Controls.Add(btnDoctoresCreateAceptar);
            Name = "FrmDoctoresCreate";
            Text = "FrmDoctoresCreate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoctoresCreateAceptar;
        private Button btnDoctoresCreateCancel;
    }
}