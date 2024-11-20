namespace WinForm.Frm.Usuarios
{
    partial class FrmUsuariosRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosRead));
            toolStrip1 = new ToolStrip();
            tsbAddFrmUsuariosRead = new ToolStripButton();
            tsbBloquearFrmUsuariosRead = new ToolStripButton();
            dgvFrmUsuariosRead = new DataGridView();
            UsuarioId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            EstaBloqueado = new DataGridViewCheckBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFrmUsuariosRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAddFrmUsuariosRead, tsbBloquearFrmUsuariosRead });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(443, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddFrmUsuariosRead
            // 
            tsbAddFrmUsuariosRead.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAddFrmUsuariosRead.Image = (Image)resources.GetObject("tsbAddFrmUsuariosRead.Image");
            tsbAddFrmUsuariosRead.ImageTransparentColor = Color.Magenta;
            tsbAddFrmUsuariosRead.Name = "tsbAddFrmUsuariosRead";
            tsbAddFrmUsuariosRead.Size = new Size(23, 22);
            tsbAddFrmUsuariosRead.Text = "Crear Usuario";
            tsbAddFrmUsuariosRead.Click += tsbAddFrmUsuariosRead_Click;
            // 
            // tsbBloquearFrmUsuariosRead
            // 
            tsbBloquearFrmUsuariosRead.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBloquearFrmUsuariosRead.Image = (Image)resources.GetObject("tsbBloquearFrmUsuariosRead.Image");
            tsbBloquearFrmUsuariosRead.ImageTransparentColor = Color.Magenta;
            tsbBloquearFrmUsuariosRead.Name = "tsbBloquearFrmUsuariosRead";
            tsbBloquearFrmUsuariosRead.Size = new Size(23, 22);
            tsbBloquearFrmUsuariosRead.Text = "Editar Usuario";
            tsbBloquearFrmUsuariosRead.Click += tsbBloquearFrmUsuariosRead_Click;
            // 
            // dgvFrmUsuariosRead
            // 
            dgvFrmUsuariosRead.AutoGenerateColumns = false;
            dgvFrmUsuariosRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFrmUsuariosRead.Columns.AddRange(new DataGridViewColumn[] { UsuarioId, Nombre, Apellidos, NombreUsuario, Password, EstaBloqueado });
            dgvFrmUsuariosRead.DataSource = usuarioBindingSource;
            dgvFrmUsuariosRead.Dock = DockStyle.Fill;
            dgvFrmUsuariosRead.Location = new Point(0, 25);
            dgvFrmUsuariosRead.MultiSelect = false;
            dgvFrmUsuariosRead.Name = "dgvFrmUsuariosRead";
            dgvFrmUsuariosRead.Size = new Size(443, 425);
            dgvFrmUsuariosRead.TabIndex = 1;
            // 
            // UsuarioId
            // 
            UsuarioId.DataPropertyName = "UsuarioId";
            UsuarioId.HeaderText = "UsuarioId";
            UsuarioId.Name = "UsuarioId";
            UsuarioId.Visible = false;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "Nombre de Usuario";
            NombreUsuario.Name = "NombreUsuario";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.Visible = false;
            // 
            // EstaBloqueado
            // 
            EstaBloqueado.DataPropertyName = "EstaBloqueado";
            EstaBloqueado.HeaderText = "EstaBloqueado";
            EstaBloqueado.Name = "EstaBloqueado";
            EstaBloqueado.Resizable = DataGridViewTriState.True;
            EstaBloqueado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Modelo.Usuario);
            // 
            // FrmUsuariosRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(dgvFrmUsuariosRead);
            Controls.Add(toolStrip1);
            Name = "FrmUsuariosRead";
            Text = "FrmUsuariosRead";
            Load += FrmUsuariosRead_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFrmUsuariosRead).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbAddFrmUsuariosRead;
        private ToolStripButton tsbBloquearFrmUsuariosRead;
        private DataGridView dgvFrmUsuariosRead;
        private BindingSource usuarioBindingSource;
        private DataGridViewTextBoxColumn UsuarioId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewCheckBoxColumn EstaBloqueado;
    }
}