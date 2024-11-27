using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm.Doctores
{
    public partial class FrmDoctoresCreate : Form
    {
        public FrmDoctoresCreate()
        {
            InitializeComponent();
            tbNombreFrmDocCreate.Focus();
        }

        private void btnAceptarFrmDoctoresCreate_Click(object sender, EventArgs e)
        {
            Modelo.Doctor doctor = new Modelo.Doctor();

            if (ValidarDatos())
            {
                doctor.Nombre = tbNombreFrmDocCreate.Text;
                doctor.Apellidos = tbApellidosFrmDocCreate.Text;
                doctor.NumColegiado = tbNumColegiadoFrmDocCreate.Text;

                Data.DataDoctor.GetInstance().InsertarDoctor(doctor);

                MessageBox.Show("Doctor añadido correctamente");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private bool ValidarDatos()
        {
            if (tbNombreFrmDocCreate.Text == "")
            {
                MessageBox.Show("El campo nombre debe estar relleno.");
                tbNombreFrmDocCreate.Focus();
                return false;
            }
            else if (tbApellidosFrmDocCreate.Text == "")
            {
                MessageBox.Show("El campo apellidos debe estar relleno.");
                tbApellidosFrmDocCreate.Focus();
                return false;
            }
            else if (tbNumColegiadoFrmDocCreate.Text == "")
            {
                MessageBox.Show("El campo número de colegiado debe estar relleno.");
                tbNumColegiadoFrmDocCreate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelFrmDoctoresCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
