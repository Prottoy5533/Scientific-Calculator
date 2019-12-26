using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scientific_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        double number = 0;
        double results = 0;
        string operation = "";
        bool enter_value = false;
        //private string lblShowOp;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") || (enter_value))

                txtInput.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtInput.Text.Contains("."))
                {
                    txtInput.Text = txtInput.Text + num.Text;
                }
            }
            else
            {
                txtInput.Text = txtInput.Text + num.Text;
            }

        }

        

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
        protected void Arithmetic_Operate(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            operate.Value = myButton.Text;
            txtTempData.Value = txtInput.Text;
            txtInput.Text = String.Empty;
            //txtInput.Text = "";
            // txtInput.Text = System.Convert.ToString(txtTempData.Value) + " " + operation;

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            //txtInput.Text = "";
            double dresult = 0;
            
            switch (operate.Value)
            {
                case "+":
                    dresult = Convert.ToDouble(txtTempData.Value) + Convert.ToDouble(txtInput.Text);
                    txtInput.Text = dresult.ToString();

                    break;

                case "-":
                    dresult = Convert.ToDouble(txtTempData.Value) - Convert.ToDouble(txtInput.Text);
                    txtInput.Text = dresult.ToString();
                    break;

                case "/":
                    if (txtInput.Text =="0")
                    {
                        txtInput.Text = ("Error");
                    }
                    else
                    {
                        dresult = Convert.ToDouble(txtTempData.Value) / Convert.ToDouble(txtInput.Text);
                    }
                   
                    break;

                case "*":
                    dresult = Convert.ToDouble(txtTempData.Value) * Convert.ToDouble(txtInput.Text);
                    txtInput.Text = dresult.ToString();
                    break;

                case "+-":
                    dresult = (Convert.ToDouble(txtTempData.Value)*-1) - Convert.ToDouble(txtInput.Text);
                    txtInput.Text = dresult.ToString();
                    break;

                case "Mod":
                    dresult = Convert.ToDouble(txtTempData.Value) % Convert.ToDouble(txtInput.Text);
                    txtInput.Text = dresult.ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtTempData.Value);
                    double q = Convert.ToDouble(txtInput.Text); ;
                   // q = (dresult);
                    dresult = Math.Exp(i*Math.Log(q*4));
                    txtInput.Text = dresult.ToString();
                    break;

            }
            


        }

        protected void btnSub_Click(object sender, EventArgs e)
        {

        }

        

        protected void btnCE_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            //txtInput.Text = "";

        }

        protected void btnX_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1, 1);
            }
            if (txtInput.Text == "")
            {
                txtInput.Text = "0";
            }
        }

        protected void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnPi_Click(object sender, EventArgs e)
        {
            txtInput.Text = "3.1415926535";
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtInput.Text);
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            ilog = Math.Log10(ilog);
            txtInput.Text = ilog.ToString();
        }

        protected void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txtInput.Text);
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            txtInput.Text = sqrt.ToString();

        }

        protected void btnSinh_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(txtInput.Text);
            double b = (sinh * (Math.PI)) / 180;
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            sinh = Math.Sinh(b);
            txtInput.Text = sinh.ToString();

        }

        protected void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtInput.Text);
            double b = (sin*(Math.PI))/180;
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            sin = Math.Sin(b);
            txtInput.Text = sin.ToString();

        }

        protected void btnCosh_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(txtInput.Text);
            double b = (cosh * (Math.PI)) / 180;
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            cosh = Math.Cosh(b);
            txtInput.Text = cosh.ToString();
        }

        protected void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtInput.Text);
            double b = (cos * (Math.PI)) / 180;
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            cos = Math.Cos(b);
            txtInput.Text = cos.ToString();
        }

        protected void btnTanh_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(txtInput.Text);
            double b = (tanh * (Math.PI)) / 180;
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            tanh = Math.Tanh(b);
            txtInput.Text = tanh.ToString();

        }

        protected void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(txtInput.Text);
            double b = (tan * (Math.PI)) / 180;
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            tan = Math.Tan(b);
            txtInput.Text = tan.ToString();
        }

        protected void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtInput.Text);
            txtInput.Text = System.Convert.ToString(a, 2);
        }

        protected void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtInput.Text);
            txtInput.Text = System.Convert.ToString(a, 16);
        }

        protected void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtInput.Text);
            txtInput.Text = System.Convert.ToString(a, 8);
        }

        protected void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtInput.Text);
            int decimalValue = Convert.ToInt32(a.ToString(), 2);
            txtInput.Text = decimalValue.ToString();
        }

        protected void btnSquare_Click(object sender, EventArgs e)
        {
           
            var a = Convert.ToDouble(txtInput.Text)*Convert.ToDouble(txtInput.Text);
            txtInput.Text = System.Convert.ToString(a);
        }

        protected void btnQuebe_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(txtInput.Text) * Convert.ToDouble(txtInput.Text) * Convert.ToDouble(txtInput.Text);
            txtInput.Text = System.Convert.ToString(a);
        }

        protected void btnOnebyX_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(1.0/ Convert.ToDouble(txtInput.Text)) ;
            txtInput.Text = System.Convert.ToString(a);

        }

        protected void btnInx_Click(object sender, EventArgs e)
        {
            double ln = Double.Parse(txtInput.Text);
            //txtInput.Text = System.Convert.ToString("log" + "(" + (txtInput.Text) + ")");
            ln = Math.Log(ln);
            txtInput.Text = ln.ToString();
        }

        protected void btnPercentage_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(txtInput.Text)/Convert.ToDouble(100);
            txtInput.Text = a.ToString();
           
        }

        protected void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        protected void btnCube_Click(object sender, EventArgs e)
        {
            double qube = Double.Parse(txtInput.Text);
            double root = Math.Pow(qube, (1.0 / 3.0));
            
            txtInput.Text = root.ToString();
        }
    }

    } 
 