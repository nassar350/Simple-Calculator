using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal? result = null, num = 0;

        char op;

        bool empty = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt.Clear();
            result = 0;
        }

        private void btn_clear_MouseHover(object sender, EventArgs e)
        {

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
            if (txt.Text.Length > 0)
            {
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            op = '+';

            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    if (result == null)
                    {
                        result = input;
                    }
                    else
                    {
                        result *= input;
                    }
                    txt.Clear();
                }
            }

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    num = input;
                }
            }

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
                default:
                    break;
            }

            txt.Text = result.ToString();
            empty = true;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            op = '-';

            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    if (result == null)
                    {
                        result = input;
                    }
                    else
                    {
                        result *= input;
                    }
                    txt.Clear();
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (empty == true)
            {
                txt.Clear();
                empty = false;
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            op = '*';

            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (decimal.TryParse(txt.Text, out decimal input))
                {
                    if (result == null)
                    {
                        result = input;
                    }
                    else
                    {
                        result *= input;
                    }
                    txt.Clear();
                }
            }
        }
    }
}
