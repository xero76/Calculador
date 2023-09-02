using Calculador.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculador
{
    public partial class frmLongitudes : Form
    {
        public frmLongitudes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Close();
            obj.Show();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            cLongitudes obj = new cLongitudes();
            double valor_ingresado;
            valor_ingresado = double.Parse(txtValor.Text);
            if(cmbOrigen.Text == "Metros" && cmbDestino.Text == "Centimetros")
            {
                txtResultado.Text = Convert.ToString(obj.mts_cms(valor_ingresado));
            }
            else if (cmbOrigen.Text == "Metros" && cmbDestino.Text == "Milimetros")
            {
                txtResultado.Text = Convert.ToString(obj.mts_mili(valor_ingresado));
            }
            else if (cmbOrigen.Text == "Metros" && cmbDestino.Text == "Metros")
            {
                MessageBox.Show("No es necesario intentar convertir a una misma unidad");
            }
            else if (cmbOrigen.Text == "Centimetros" && cmbDestino.Text == "Metros")
            {
                txtResultado.Text = Convert.ToString(obj.cms_mts(valor_ingresado));
            }
            else if (cmbOrigen.Text == "Centimetros" && cmbDestino.Text == "Milimetros")
            {
                txtResultado.Text = Convert.ToString(obj.cms_mili(valor_ingresado));
            }
            else if (cmbOrigen.Text == "Centimetros" && cmbDestino.Text == "Centimetros")
            {
                MessageBox.Show("No es necesario intentar convertir a una misma unidad");
            }
            else if (cmbOrigen.Text == "Milimetros" && cmbDestino.Text == "Metros")
            {
                txtResultado.Text = Convert.ToString(obj.mili_mts(valor_ingresado));
            }
            else if (cmbOrigen.Text == "Milimetros" && cmbDestino.Text == "Centimetros")
            {
                txtResultado.Text = Convert.ToString(obj.mili_cms(valor_ingresado));
            }
            else if (cmbOrigen.Text == "Milimetros" && cmbDestino.Text == "Milimetros")
            {
                MessageBox.Show("No es necesario intentar convertir a una misma unidad");
            }

        }
        public bool ComprobarVariable()
        {
            bool VariableOK = false;

            if (double.TryParse(txtValor.Text, out double num1))
            {
                VariableOK = true;

            }
            else
            {
                MessageBox.Show("Error en valor");
            }
            


            return VariableOK;
        }

    }
}
