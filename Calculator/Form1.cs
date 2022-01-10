using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public double value = 0;
        public char operatorchar = ' ';
        public double number1, number2;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(lb_panel.Text == "0")
                lb_panel.Text = "";
                Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!lb_panel.Text.Contains(","))
                {
                    lb_panel.Text += button.Text;
                    lbl_prev.Text += button.Text;
                }
            }
            else 
            {
                lb_panel.Text += button.Text;
                lbl_prev.Text += button.Text;
            }
         
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lb_panel.Text = "0";
        }

        private void btn_operator_Click(object sender, EventArgs e)
        {
            Button opButton = (Button)sender;
            if(lb_panel.Text != "0")
            {
                
                operatorchar = Convert.ToChar(opButton.Text);
                lbl_previously.Text = lb_panel.Text + operatorchar;
                lbl_prev.Text = lb_panel.Text + operatorchar;
                number1 = double.Parse(lb_panel.Text);
                lb_panel.Text += opButton.Text;
                lb_panel.Text = "";
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (lb_panel.Text != "0")
            {
                number2 = double.Parse(lb_panel.Text);
                lb_panel.Text = "";
                lbl_previously.Text = lb_panel.Text;
                lbl_prev.Text += "=";
                
            }
            switch (operatorchar)
            {
                case '+': value = number1 + number2;
                    break;
                case '-': value = number1 - number2;
                    break;
                case '*': value = number1 * number2;
                    break;
                case '/': value = number1 / number2;
                    break;

            }
            lb_panel.Text = value.ToString();
            lbl_prev.Text = value.ToString();
        }
    }
}
