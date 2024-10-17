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
            // FrmDoctoresUpdate
            // 
            AcceptButton = btnDoctoresUpdateAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnDoctoresUpdateCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoctoresUpdateCancel);
            Controls.Add(btnDoctoresUpdateAceptar);
            Name = "FrmDoctoresUpdate";
            Text = "FrmDoctoresUpdate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoctoresUpdateAceptar;
        private Button btnDoctoresUpdateCancel;
    }
}