using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    decimal? result = null;
    char? op = null;
    bool emptyAfterCalculation = false;
    Exception? error = null;

    char[] allowedInput = { '+', '-', '*', '/', '%' };

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
                    result /= num;
                else
                    error = new DivideByZeroException("Error");
                break;
            case '%':
                if (num != 0)
                    result %= num;
                else
                    error = new DivideByZeroException("Error");
                break;
            default:
                result = num;
                break;
        }
    }

    private bool ExecuteError()
    {
        if (error is not null)
        {
            txt.Text = error.Message;
            result = null;
            op = null;
            error = null;
            return true;
        }
        return false;
    }

    private void ValidateInput(object? sender, KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b')
        {
            return;
        }
        if (e.KeyChar == (char)Keys.Enter)
        {
            btn_equal.PerformClick();
            e.Handled = true;
            return;
        }
        switch (e.KeyChar)
        {
            case '+':
                btn_add.PerformClick();
                break;
            case '-':
                btn_sub.PerformClick();
                break;
            case '*':
                btn_mul.PerformClick();
                break;
            case '/':
                btn_div.PerformClick();
                break;
            case '%':
                btn_mod.PerformClick();
                break;
            default:
                break;
        }
        e.Handled = true;
    }

    public Form1()
    {
        InitializeComponent();

        txt.KeyPress += ValidateInput;
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
        if (emptyAfterCalculation && txt.Text.Length > 1)
        {
            char lastChar = txt.Text[txt.Text.Length - 1];
            txt.Text = lastChar.ToString();
            emptyAfterCalculation = false;
        }

        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {
        if (txt.Text.Length > 0 && emptyAfterCalculation == false)
        {
            txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
        }
        txt.Focus();
    }
    private void btn_clear_Click(object sender, EventArgs e)
    {
        txt.Clear();
        result = null;
        op = null;
        emptyAfterCalculation = false;

        txt.Focus();
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

    private void btn_add_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt.Text))
        {
            if (decimal.TryParse(txt.Text, out decimal input))
            {
                calculation(input);
                if (!ExecuteError())
                {
                    txt.Text = result.ToString();
                    op = '+';
                }
            }                
        }

        emptyAfterCalculation = true;
        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }

    private void btn_sub_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt.Text))
        {
            if (decimal.TryParse(txt.Text, out decimal input))
            {
                calculation(input);
                if (!ExecuteError())
                {
                    txt.Text = result.ToString();
                    op = '-';
                }
            }
        }

        emptyAfterCalculation = true;
        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }


    private void btn_mul_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt.Text))
        {
            if (decimal.TryParse(txt.Text, out decimal input))
            {
                calculation(input);
                if (!ExecuteError())
                {
                    txt.Text = result.ToString();
                    op = '*';
                }
            }
        }
        
        emptyAfterCalculation = true;
        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }

    private void btn_mod_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt.Text))
        {
            if (decimal.TryParse(txt.Text, out decimal input))
            {
                calculation(input);
                if (!ExecuteError())
                {
                    txt.Text = result.ToString();
                    op = '%';
                }
            }
        }

        emptyAfterCalculation = true;
        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }

    private void btn_div_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt.Text))
        {
            if (decimal.TryParse(txt.Text, out decimal input))
            {
                calculation(input);
                if (!ExecuteError())
                {
                    txt.Text = result.ToString();
                    op = '/';
                }
            }                
        }

        emptyAfterCalculation = true;
        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }

    private void btn_equal_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt.Text))
        {
            if (decimal.TryParse(txt.Text, out decimal input))
            {
                calculation(input);
                if (!ExecuteError())
                {
                    op = null;
                    txt.Text = result.ToString();
                }
            }
        }

        emptyAfterCalculation = true;
        txt.Focus();
        txt.SelectionStart = txt.Text.Length;
    }
}
