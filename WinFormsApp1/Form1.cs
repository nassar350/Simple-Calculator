using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal? result = null;

        char? op = null;

        bool emptyAfterCalculation = false;

        private void Calculation(decimal num, out bool error)
        {
            error = false;
            switch (op)
            {
                case '+':
                    result += num;
                    break;
                case '-':
                    result -= num;
                    break;
                case '*':
                    result *= num;
                    break;
                case '/':
                    if (num != 0)
                    {
                        result /= num;
                    }
                    else
                    {
                        error = true;
                    }
                    break;
                case '%':
                    result %= num;
                    break;
                default:
                    result = num;
                    break;
            }
        }

        private void EmptyTextboxOrNot()
        {
            if (emptyAfterCalculation)
            {
                txt.Clear();
                emptyAfterCalculation = false;
            }
        }

        private void ValideNumberError()
        {
            result = null;
            op = null;
            emptyAfterCalculation = true;

            txt.Text = "Enter a valid number";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt.Clear();
            result = null;
            op = null;
            emptyAfterCalculation = false;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '0';
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '.';
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '1';
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '2';
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '3';
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '4';
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '5';
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '6';
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '7';
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '8';
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            EmptyTextboxOrNot();
            txt.Text += '9';
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0 && emptyAfterCalculation == false)
            {
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    Calculation(input, out bool error);

                    if (error)
                    {
                        txt.Text = "Cannot divide by zero";
                        result = null;
                        op = null;
                    }
                    else
                    {
                        txt.Text = result.ToString();
                        op = '+';
                    }
                }
                else
                {
                    ValideNumberError();
                }
            }
            else
            {
                ValideNumberError();
            }

            emptyAfterCalculation = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    Calculation(input, out bool error);

                    if (error)
                    {
                        txt.Text = "Cannot divide by zero";
                        result = null;
                    }
                    else
                    {
                        txt.Text = result.ToString();
                    }

                    op = null;
                }
                else
                {
                    ValideNumberError();
                    return;
                }
            }
            else
            {
                ValideNumberError();
                return;
            }

            emptyAfterCalculation = true;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    Calculation(input, out bool error);

                    if (error)
                    {
                        txt.Text = "Cannot divide by zero";
                        result = null;
                        op = null;
                    }
                    else
                    {
                        txt.Text = result.ToString();
                        op = '-';
                    }
                }
                else
                {
                    ValideNumberError();
                }
            }
            else
            {
                ValideNumberError();
            }

            emptyAfterCalculation = true;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    Calculation(input, out bool error);

                    if (error)
                    {
                        txt.Text = "Cannot divide by zero";
                        result = null;
                        op = null;  
                    }
                    else
                    {
                        txt.Text = result.ToString();
                        op = '*';
                    }
                }
                else
                {
                    ValideNumberError();
                }
            }
            else
            {
                ValideNumberError();
            }

            emptyAfterCalculation = true;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    Calculation(input, out bool error);

                    if (error)
                    {
                        txt.Text = "Cannot divide by zero";
                        result = null;
                        op = null;
                    }
                    else
                    {
                        txt.Text = result.ToString();
                        op = '%';
                    }
                }
                else
                {
                    ValideNumberError();
                }
            }
            else
            {
                ValideNumberError();
            }

            emptyAfterCalculation = true;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    Calculation(input, out bool error);

                    if (error)
                    {
                        txt.Text = "Cannot divide by zero";
                        result = null;
                        op = null;
                    }
                    else
                    {
                        txt.Text = result.ToString();
                        op = '/';
                    }
                }
                else
                {
                    ValideNumberError();
                }
            }
            else
            {
                ValideNumberError();
            }

            emptyAfterCalculation = true;
        }
    }
}
