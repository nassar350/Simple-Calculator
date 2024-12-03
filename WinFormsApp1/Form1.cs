using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal? result = null;

        char? op = null;

        bool emptyAfterCalculation = false;

        private void calculation(decimal num)
        {
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
                    break;
                case '%':
                    result %= num;
                    break;
                default:
                    result = num;
                    break;
            }
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
            txt.Text += '0';
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txt.Text += '.';
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            txt.Text += '1';
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt.Text += '2';
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt.Text += '3';
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt.Text += '4';
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt.Text += '5';
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            txt.Text += '6';
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt.Text += '7';
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt.Text += '8';
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
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
                    calculation(input);
                    txt.Text = result.ToString();

                    op = '+';
                }                
            }

            emptyAfterCalculation = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    calculation(input);
                    op = null;
                }                
            }

            txt.Text = result.ToString();

            emptyAfterCalculation = true;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    calculation(input);
                    txt.Text = result.ToString();

                    op = '-';
                }
            }

            emptyAfterCalculation = true;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (emptyAfterCalculation)
            {
                char lastChar = txt.Text[txt.Text.Length - 1];
                txt.Text = lastChar.ToString();
                emptyAfterCalculation = false;
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    calculation(input);
                    txt.Text = result.ToString();

                    op = '*';
                }
            }
            
            emptyAfterCalculation = true;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    calculation(input);
                    txt.Text = result.ToString();

                    op = '%';
                }              
            }          

            emptyAfterCalculation = true;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    calculation(input);
                    txt.Text = result.ToString();

                    op = '/';
                }                
            }

            emptyAfterCalculation = true;
        }
    }
}
