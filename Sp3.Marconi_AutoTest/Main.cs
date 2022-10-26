using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sp3.Marconi_AutoTest
{
    public partial class Main : Form
    {
        //DECLARACION DE VARIABLES PUTOOOO GLOBALES
        int numeroTurno;
        string nombreDominio;
        int anioFabricacion;
        string nombreTitular;
        //DECLARAR ARRAYS
        //VECTOR - ARRAYS 1 DIMENSION
        string[] vecAutoTest = new string[5];
        //MATRIZ - ARRAY 2 DIMENSIONES
        string[,] natAutoTest = new string[5, 10];
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            numeroTurno = int.Parse(txtNumerodeturno.Text);
            nombreDominio = txtDominio.Text;
            anioFabricacion = Convert.ToInt32(numFabricacion.Value);
            nombreTitular = txtTitular.Text;

            MessageBox.Show("REGISTRO REALIZADO","REGISTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarInterfaz();
        }
        private void LimpiarInterfaz()
        {
            txtNumerodeturno.Clear();
            txtDominio.Clear();
            numFabricacion.Value = 2022;
            txtTitular.Clear();

            txtNumerodeturno.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numeroTurno + nombreTitular + nombreDominio + numFabricacion);
        }

        private void txtNumerodeturno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
        }
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text !="")
            {
                numFabricacion.Enabled = true;
            }
            else
            {
                numFabricacion.Enabled = false;
                txtTitular.Enabled = false;
            }
        }

        private void txtNumerodeturno_TextChanged(object sender, EventArgs e)
        {
            if (txtNumerodeturno.Text != "")
            {
                txtDominio.Enabled = true;
            }
            else
            {
                txtDominio.Enabled = false;
            }
        }

        private void numFabricacion_ValueChanged(object sender, EventArgs e)
        {
            //if (numFabricacion.Value >= 1950 && <= 2022)
            {
                numFabricacion.Enabled = true;
            }
            //else
            {
                numFabricacion.Enabled = false;
            }
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text != "")
            {
                txtTitular.Enabled = true;
            }
            else
            {
                txtTitular.Enabled = false;
            }
        }
    }
}
