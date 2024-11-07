using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm.Pacientes
{
    public partial class FrmPacientesUpdate : Form
    {
        private int _pacienteId; 
        public FrmPacientesUpdate(int pacienteId)
        {
            InitializeComponent();

            _pacienteId = pacienteId;
        }

        private void btnFrmPacientesUpdateAceptar_Click(object sender, EventArgs e)
        {
            Modelo.Paciente paciente = new Modelo.Paciente();

           

            
        }
    }
}
