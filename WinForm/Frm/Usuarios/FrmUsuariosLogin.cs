using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm.Usuarios
{
    public partial class FrmUsuariosLogin : Form
    {
        public FrmUsuariosLogin()
        {
            InitializeComponent();
        }

        private void btnCancelarFrmUsuariosLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptarFrmUsuariosLogin_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string userTb = tbUserNameFrmUsuariosLogin.Text;

                Modelo.Usuario usuario = Data.DataUsuario.GetInstance().ListarUsuarios().FirstOrDefault
                    (
                        x => x.NombreUsuario == userTb
                    );

                var dataBasePass = usuario.Password;
                var frmPass = tbPasswordFrmUsuariosLogin.Text;

                if(Auxiliar.Password.GetInstance().VerificarHash(frmPass, dataBasePass))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no coinciden");
                    DialogResult = DialogResult.Cancel;
                }

               
            }
            DialogResult = DialogResult.None;
        }

        private bool ValidarCampos()
        {
            if(tbUserNameFrmUsuariosLogin.Text == "")
            {
                MessageBox.Show("El campo nombre de usuario no debe contener espacios.");
                tbUserNameFrmUsuariosLogin.Focus();
                return false;
            }
            else if(tbPasswordFrmUsuariosLogin.Text == "")
            {
                MessageBox.Show("El campo contraseña debe estar relleno.");
                tbPasswordFrmUsuariosLogin.Focus();
                return false;
            }

            return true;
        }
    }
}
