using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_edad
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        double n1;
        double n2;
        double resultado;
        string operacion;
        bool limpiarCero = true;


        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "1";
                limpiarCero = false;
            }
            else
            { 
            txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtPantalla.Text=="0")
            {
                return;
            }
            else
            {
                txtPantalla.Text=txtPantalla.Text+"0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            
                txtPantalla.Text= txtPantalla.Text + ".";
                
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txtPantalla.Text);
          

            switch (operacion)
            {
                case "+":
                    resultado = n1 + n2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = n1 - n2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = n1 / n2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "x":
                    resultado = n1 * n2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "%":
                    MessageBox.Show("dsds");
                    resultado = n1 % n2;
                    txtPantalla.Text = resultado.ToString();
                    break;




                default:
                    break;
            }



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "2";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "3";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "4";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "5";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "6";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "7";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "8";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (limpiarCero)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "9";
                limpiarCero = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            operacion = "+";
            txtPantalla.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            operacion = "-";
            txtPantalla.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            operacion = "x";
            txtPantalla.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            btnPunto.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            btnPunto.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.TextLength>1)
            {
               txtPantalla.Text=txtPantalla.Text.Remove(txtPantalla.Text.Length -1,1);
            }
            btnPunto.Enabled = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            operacion = "/";
            txtPantalla.Clear();

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operacion = "raiz";
            n1 = double.Parse(txtPantalla.Text);
            resultado = n1;
            txtPantalla.Text = Math.Sqrt(n1).ToString();
        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            operacion="%";
            n2 = double.Parse(txtPantalla.Text);
            resultado = n1 + n2;
            txtPantalla.Text = Convert.ToString((n1 * n2) / 100);

        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtPantalla.Text);
            resultado = n1;
            txtPantalla.Text = Math.Pow(n1, 2).ToString();
        }
    }
}
