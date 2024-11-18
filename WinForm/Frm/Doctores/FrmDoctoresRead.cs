﻿using Microsoft.Data.SqlClient;
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
    public partial class FrmDoctoresRead : Form
    {
        public FrmDoctoresRead()
        {
            InitializeComponent();
        }

        private void tsbFrmDoctoresCrear_Click(object sender, EventArgs e)
        {
            FrmDoctoresCreate frmDoctoresCreate = new FrmDoctoresCreate();

            if (frmDoctoresCreate.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void tsbFrmDoctoresEditar_Click(object sender, EventArgs e)
        {
            FrmDoctoresUpdate frmDoctoresUpdate = new FrmDoctoresUpdate();

            if (frmDoctoresUpdate.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void FrmDoctoresRead_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbFrmDoctoresEliminar_Click(object sender, EventArgs e)
        {
            if(DgvwDoctoresRead.Rows.Count > 0)
            {
                int doctorId = (int)DgvwDoctoresRead.Rows[0].Cells["PacienteId"].Value;
                Data.DataDoctor.GetInstance().BorrarDoctor(doctorId);
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
            }
        }

        private void CargarDatos()
        {
            try
            {
                DgvwDoctoresRead.DataSource = Data.DataDoctor.GetInstance().ListarDoctores();
            }
            catch(SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }
    }
}
