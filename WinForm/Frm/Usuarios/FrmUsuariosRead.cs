using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Frm.Pacientes;

namespace WinForm.Frm.Usuarios
{
    public partial class FrmUsuariosRead : Form
    {
        public FrmUsuariosRead()
        {
            InitializeComponent();
        }

        private void tsbAddFrmUsuariosRead_Click(object sender, EventArgs e)
        {
            FrmUsuariosCreate frmUsuariosCreate = new FrmUsuariosCreate();

            if (frmUsuariosCreate.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            try
            {
                dgvFrmUsuariosRead.DataSource = Data.DataUsuario.GetInstance().ListarUsuarios();
            }
            catch (SqlException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void tsbBloquearFrmUsuariosRead_Click(object sender, EventArgs e)
        {
            if (dgvFrmUsuariosRead.Rows.Count > 0)
            {
                var result = MessageBox.Show
                    (
                        "¿Esta seguro de querer eliminar el registro de la tabla?",
                        "Aviso", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );
                if (result == DialogResult.OK)
                {
                    try
                    {
                        int usuarioId = (int)dgvFrmUsuariosRead.SelectedRows[0].Cells["UsuarioId"].Value;
                        Modelo.Usuario usuario = Data.DataUsuario.GetInstance().ListarUsuarios().FirstOrDefault
                            (
                                x => x.UsuarioId == usuarioId
                            );
                        
                        if (usuario.EstaBloqueado != null)
                        {
                            if ((bool)usuario.EstaBloqueado)
                                usuario.EstaBloqueado = false;

                            else
                                usuario.EstaBloqueado = true;
                        }
                        
                        Data.DataUsuario.GetInstance().ActualizarUsuario(usuarioId, usuario);

                        CargarDatos();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("No se encontró la columna seleccionada.");
                        Console.Error.WriteLine(ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        Console.Error.WriteLine(ex.StackTrace);
                    }
                }
            }
        }

        private void FrmUsuariosRead_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
