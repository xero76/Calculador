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
    public partial class frmVolumenes : Form
    {
        public frmVolumenes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Close();
            obj.Show();
        }

        private void rbtCono_CheckedChanged(object sender, EventArgs e)
        {
            lblValor1.Text = "Base";
            lblValor2.Text = "Altura";
            lblValor2.Visible = true;
            txtValor2.Visible = true;
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";
        }

        private void rbtCubo_CheckedChanged(object sender, EventArgs e)
        {
            lblValor1.Text = "Lado";
            lblValor2.Visible = false;
            txtValor2.Visible = false;
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";
        }

        private void rbtCilindro_CheckedChanged(object sender, EventArgs e)
        {
            lblValor1.Text = "Radio";
            lblValor2.Text = "Altura";
            lblValor2.Visible = true;
            txtValor2.Visible = true;
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";
        }

        private void rbtEsfera_CheckedChanged(object sender, EventArgs e)
        {
            lblValor1.Text = "Radio";
            lblValor2.Visible = false;
            txtValor2.Visible = false;
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";
        }

        public bool ComprobarVariable1()
        {
            bool variablesOk = false;

            if (double.TryParse(txtValor1.Text, out double num1))
            {
                variablesOk = true;

            }
            else
            {
                if (lblValor1.Text == "Base")
                {
                    if (txtValor1.Text == "")
                    {
                        MessageBox.Show("La Base esta Vacia");
                    }
                    else
                    {
                        MessageBox.Show("La Base no es un numero");
                    }
                }
                else if (lblValor1.Text == "radio")
                {

                    if (txtValor1.Text == "")
                    {
                        MessageBox.Show("El Radio esta Vacio");
                    }
                    else
                    {
                        MessageBox.Show("El Radio no es un numero");
                    }
                }
                else
                {
                    if (txtValor1.Text == "")
                    {
                        MessageBox.Show("El Lado esta Vacio");
                    }
                    else
                    {
                        MessageBox.Show("El lado no es un numero");
                    }
                }


            }
            return variablesOk;
        }
        public bool ComprobarVariable2()
        {
            bool variablesOk = false;

            if (double.TryParse(txtValor2.Text, out double num1))
            {
                variablesOk = true;
            }
            else
            {
                if (txtValor2.Text == "")
                {
                    MessageBox.Show("La Altura esta Vacia");
                }
                else
                {
                    MessageBox.Show("La Altura no es un numero");
                }
            }
            return variablesOk;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cVolumenes obj = new cVolumenes();
            double valor1, valor2;
            if (rbtCubo.Checked == true)
            {
                if (ComprobarVariable1() == true)
                {
                    valor1 = double.Parse(txtValor1.Text);

                    txtResultado.Text = obj.Cubo(valor1).ToString();
                }
            }
            else if (rbtCilindro.Checked == true)
            {
                if (ComprobarVariable1() == true && ComprobarVariable2() == true)
                {
                    valor1 = double.Parse(txtValor1.Text);
                    valor2 = double.Parse(txtValor2.Text);
                    txtResultado.Text = obj.Cilindro(valor1, valor2).ToString();
                }
            }
            else if (rbtEsfera.Checked == true)
            {
                if (ComprobarVariable1() == true)
                {
                    valor1 = double.Parse(txtValor1.Text);
                    txtResultado.Text = obj.Esfera(valor1).ToString();
                }
            }
            else if (rbtCono.Checked == true)
            {
                if (ComprobarVariable1() == true && ComprobarVariable2() == true)
                {
                    valor1 = double.Parse(txtValor1.Text);
                    valor2 = double.Parse(txtValor2.Text);
                    txtResultado.Text = obj.Cono(valor1, valor2).ToString();
                }
            }
        }
    }
}
