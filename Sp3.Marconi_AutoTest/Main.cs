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
        int vContadorTurnos = 0;
        int vModeloMasAntiguo = 0;
        int vCantidadDom6 = 0;
        //DECLARAR ARRAYS
        //VECTOR - ARRAYS 1 DIMENSION
        string[] vector = new string[0];
        //MATRIZ - ARRAY 2 DIMENSIONES
        string[,] natAutoTest = new string[0,0];
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDominio.Text.Length >= 6 && txtTitular.Text.Length >= 2)
            {
                MessageBox.Show("Datos ingresados correctamente");
                vContadorTurnos++;
                if (numFabricacion.Value < vModeloMasAntiguo || vModeloMasAntiguo == 0)
                {
                    vModeloMasAntiguo = Convert.ToInt32(numFabricacion.Value);
                }
                if (txtDominio.Text.Length == 6)
                {
                    vCantidadDom6++;
                }
                LimpiarInterfaz();
            }
            else
            {
                MessageBox.Show("Faltan o hay datos ingresados incorrectamente");
            }
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
            txtCantidaddeturnos.Text = vContadorTurnos.ToString();
            txtAntiguo.Text = vModeloMasAntiguo.ToString();
            txtCaracteres.Text = vCantidadDom6.ToString();
        }

        private void txtNumerodeturno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números", "Error");
            }

        }
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text != "")
            {
                lblFabricacion.Enabled = true;
                numFabricacion.Enabled = true;
                lblTitular.Enabled = true;
                txtTitular.Enabled = true;
            }
            else
            {
                lblFabricacion.Enabled = false;
                numFabricacion.Enabled = false;
                lblTitular.Enabled = false;
                txtTitular.Enabled = false;
            }
        }

        private void txtNumerodeturno_TextChanged(object sender, EventArgs e)
        {
            if (txtNumerodeturno.Text != "")
            {
                lblDominio.Enabled = true;
                txtDominio.Enabled = true;
            }
            else
            {
                lblDominio.Enabled = false;
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
            if (txtTitular.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
