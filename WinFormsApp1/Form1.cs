using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal? result = null;

        char? op = null;

        bool emptyAfterCalculation = false;

        // hide the textbox pointer
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

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

            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                btn_clear_Click(sender, e);
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btn_equal_Click(sender, e);
            }

        }

        private void Form1_KeyPress(object? sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case '+':
                    btn_add_Click(sender, e);
                    break;
                case '-':
                    btn_sub_Click(sender, e);
                    break;
                case '*':
                    btn_mul_Click(sender, e);
                    break;
                case '/':
                    btn_div_Click(sender, e);
                    break;
                case '%':
                    btn_mod_Click(sender, e);
                    break;
                case '\r':
                    break;
                default:
                    txt_TextChanged(sender, e);
                    break;
            }
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
            txt_TextChanged(sender, e); 
            txt.Text += '0';
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '.';
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '1';
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '2';
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '3';
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '4';
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '5';
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '6';
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '7';
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
            txt.Text += '8';
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            txt_TextChanged(sender, e);
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
            txt_TextChanged(sender, e);

            if (txt.Text.Length == 0)
            {
                txt.Text += '-';
                return;
            }
            else if (txt.Text.Length >= 1 && !decimal.TryParse(txt.Text, out decimal input))
            {
                return;
            }

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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            txt.SelectionStart = txt.Text.Length;
            txt.SelectionLength = 0;
            txt.Focus();

            HideCaret(txt.Handle);

            if (emptyAfterCalculation)
            {
                txt.Clear();
            }

            emptyAfterCalculation = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt.SelectionStart = txt.Text.Length;
            txt.SelectionLength = 0;
            txt.Focus();

            HideCaret(txt.Handle);
        }

    }
}
