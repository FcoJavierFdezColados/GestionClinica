using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Auxiliar;

namespace WinForm.Frm.Usuarios
{
    public partial class FrmUsuariosCreate : Form
    {
        public FrmUsuariosCreate()
        {
            InitializeComponent();
        }

        private void btnAceptarFrmUsuariosCreate_Click(object sender, EventArgs e)
        {
            Modelo.Usuario usuario = new Modelo.Usuario();

            if (ValidarCampos())
            {
                usuario.Nombre = tbNombreFrmUsuariosCreate.Text;
                usuario.Apellidos = tbApellidosFrmUsuariosCreate.Text;
                usuario.NombreUsuario = tbUserNameFrmUsuariosCreate.Text;
                usuario.EstaBloqueado = false;
                usuario.Password = Password.GetInstance().GenerarHash(tbPasswordFrmUsuariosCreate.Text);

                Data.DataUsuario.GetInstance().InsertarUsuario(usuario);

                MessageBox.Show("Usuario añadido correctamente.");
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidarCampos()
        {
            if(tbNombreFrmUsuariosCreate.Text == "")
            {
                MessageBox.Show("El campo nombre debe estar relleno.");
                tbNombreFrmUsuariosCreate.Focus();
                return false;
            }
            else if(tbApellidosFrmUsuariosCreate.Text == "")
            {
                MessageBox.Show("El campo apellidos debe estar relleno.");
                tbApellidosFrmUsuariosCreate.Focus();
                return false;
            }
            else if(tbUserNameFrmUsuariosCreate.Text == "")
            {
                MessageBox.Show("El campo nombre de usuario debe estar relleno.");
                tbApellidosFrmUsuariosCreate.Focus();
                return false;
            }
            else if(tbUserNameFrmUsuariosCreate.Text.Contains(" "))
            {
                MessageBox.Show("El campo nombre de usuario no debe contener espacios.");
                tbApellidosFrmUsuariosCreate.Focus();
                return false;
            }
            else if(tbPasswordFrmUsuariosCreate.Text == "")
            {
                MessageBox.Show("El campo contraseña debe estar relleno.");
                tbApellidosFrmUsuariosCreate.Focus();
                return false;
            }
            else if(tbConfirmPassFrmUsuariosCreate.Text == "")
            {
                MessageBox.Show("El campo confirmar contraseña debe estar relleno.");
                tbApellidosFrmUsuariosCreate.Focus();
                return false;
            }
            else if(!tbPasswordFrmUsuariosCreate.Text.Equals(tbConfirmPassFrmUsuariosCreate.Text))
            {
                MessageBox.Show("Los campos contraseña y confirmar contraseña deben coincidir.");
                tbApellidosFrmUsuariosCreate.Focus();
                return false;
            }

            return true;
        }
    }
}
