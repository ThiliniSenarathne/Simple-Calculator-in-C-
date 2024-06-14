using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnumber1.Text);
            int num2 = Convert.ToInt32(txtnumber2.Text);
            int add = num1 + num2;
            //MessageBox.Show(num1 + "+" + num2 + "=" + add);
            txtResult.Text = add.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnumber1.Text);
            double num2 = Convert.ToDouble(txtnumber2.Text);
            double div = num1 / num2;
            //MessageBox.Show(num1 + "/" + num2 + "=" + div);
            txtResult.Text = div.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnumber1.Text);
            int num2 = Convert.ToInt32(txtnumber2.Text);
            int mul = num1 * num2;
            //MessageBox.Show(num1 + "*" + num2 + "=" + mul);
            txtResult.Text = mul.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(txtnumber1.Text);
            int num2 = Convert.ToInt32(txtnumber2.Text);
            int sub = num1 - num2;
            //MessageBox.Show(num1 + "-" + num2 + "=" + mul);
            txtResult.Text = sub.ToString();
        }

        private void txtnumber1_TextChanged(object sender, EventArgs e)
        {
            //double result = 0;
            //double.TryParse(txtnumber1.Text, out result);
            //MessageBox.Show(result.ToString());
          if(txtnumber1.Text.Trim()=="")
            {
                if (IsNumeric(txtnumber1.Text))
                {
                    //MessageBox.Show("Valid Number");
                    ShowButtons();
                }
                else
                {
                    //MessageBox.Show("Invalid Number");
                    HideButtons();
                }
            }
       }
       /* private IsNumeric(string InputString)
        {
            double result = 0;
            double.TryParse(InputString,out result);
            if(result>0)
            {
                MessageBox.Show("Valid Number");
            }
            else
            {
                MessageBox.Show("Invalid Number");
            }
        }*/
        private bool IsNumeric(string inputString)
        {
            double result = 0;
            double.TryParse(inputString,out result);
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ShowButtons()
        {
            btnAdd.Show();
            btnSub.Show();
            btnMul.Show();
            btnDiv.Show();

        }
        private void HideButtons()
        {
            btnAdd.Hide();
            btnSub.Hide();
            btnMul.Hide();
            btnDiv.Hide();

        }
    }
}
