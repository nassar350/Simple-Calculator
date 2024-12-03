namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt = new TextBox();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_mod = new Button();
            btn_div = new Button();
            btn_seven = new Button();
            btn_eight = new Button();
            btn_nine = new Button();
            btn_mul = new Button();
            btn_four = new Button();
            btn_five = new Button();
            btn_six = new Button();
            btn_sub = new Button();
            btn_one = new Button();
            btn_two = new Button();
            btn_three = new Button();
            btn_add = new Button();
            btn_zero = new Button();
            btn_dot = new Button();
            btn_equal = new Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt.BackColor = Color.WhiteSmoke;
            txt.Font = new Font("Segoe UI", 21F);
            txt.Location = new Point(12, 42);
            txt.Name = "txt";
            txt.Size = new Size(398, 54);
            txt.TabIndex = 0;
            // 
            // btn_clear
            // 
            btn_clear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_clear.AutoSize = true;
            btn_clear.BackColor = Color.FromArgb(49, 54, 63);
            btn_clear.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_clear.ForeColor = Color.FromArgb(238, 238, 238);
            btn_clear.Location = new Point(12, 168);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(96, 45);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_delete.AutoSize = true;
            btn_delete.BackColor = Color.FromArgb(49, 54, 63);
            btn_delete.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.FromArgb(238, 238, 238);
            btn_delete.Location = new Point(114, 168);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 45);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_mod
            // 
            btn_mod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_mod.AutoSize = true;
            btn_mod.BackColor = Color.FromArgb(49, 54, 63);
            btn_mod.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_mod.FlatAppearance.BorderSize = 0;
            btn_mod.FlatStyle = FlatStyle.Flat;
            btn_mod.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_mod.ForeColor = Color.FromArgb(238, 238, 238);
            btn_mod.Location = new Point(214, 168);
            btn_mod.Name = "btn_mod";
            btn_mod.Size = new Size(94, 45);
            btn_mod.TabIndex = 21;
            btn_mod.Text = "%";
            btn_mod.UseVisualStyleBackColor = false;
            btn_mod.Click += btn_mod_Click;
            // 
            // btn_div
            // 
            btn_div.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_div.AutoSize = true;
            btn_div.BackColor = Color.FromArgb(49, 54, 63);
            btn_div.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_div.FlatAppearance.BorderSize = 0;
            btn_div.FlatStyle = FlatStyle.Flat;
            btn_div.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_div.ForeColor = Color.FromArgb(238, 238, 238);
            btn_div.Location = new Point(314, 168);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(96, 45);
            btn_div.TabIndex = 22;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.Click += btn_div_Click;
            // 
            // btn_seven
            // 
            btn_seven.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_seven.AutoSize = true;
            btn_seven.BackColor = Color.FromArgb(49, 54, 63);
            btn_seven.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_seven.FlatAppearance.BorderSize = 0;
            btn_seven.FlatStyle = FlatStyle.Flat;
            btn_seven.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_seven.ForeColor = Color.FromArgb(238, 238, 238);
            btn_seven.Location = new Point(12, 221);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(96, 45);
            btn_seven.TabIndex = 23;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = false;
            btn_seven.Click += btn_seven_Click;
            // 
            // btn_eight
            // 
            btn_eight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_eight.AutoSize = true;
            btn_eight.BackColor = Color.FromArgb(49, 54, 63);
            btn_eight.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_eight.FlatAppearance.BorderSize = 0;
            btn_eight.FlatStyle = FlatStyle.Flat;
            btn_eight.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_eight.ForeColor = Color.FromArgb(238, 238, 238);
            btn_eight.Location = new Point(114, 221);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(94, 45);
            btn_eight.TabIndex = 24;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = false;
            btn_eight.Click += btn_eight_Click;
            // 
            // btn_nine
            // 
            btn_nine.AutoSize = true;
            btn_nine.BackColor = Color.FromArgb(49, 54, 63);
            btn_nine.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_nine.FlatAppearance.BorderSize = 0;
            btn_nine.FlatStyle = FlatStyle.Flat;
            btn_nine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_nine.ForeColor = Color.FromArgb(238, 238, 238);
            btn_nine.Location = new Point(214, 221);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(94, 45);
            btn_nine.TabIndex = 25;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = false;
            btn_nine.Click += btn_nine_Click;
            // 
            // btn_mul
            // 
            btn_mul.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_mul.AutoSize = true;
            btn_mul.BackColor = Color.FromArgb(49, 54, 63);
            btn_mul.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_mul.FlatAppearance.BorderSize = 0;
            btn_mul.FlatStyle = FlatStyle.Flat;
            btn_mul.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_mul.ForeColor = Color.FromArgb(238, 238, 238);
            btn_mul.Location = new Point(314, 221);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(96, 45);
            btn_mul.TabIndex = 26;
            btn_mul.Text = "×";
            btn_mul.UseVisualStyleBackColor = false;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_four
            // 
            btn_four.BackColor = Color.FromArgb(49, 54, 63);
            btn_four.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_four.FlatAppearance.BorderSize = 0;
            btn_four.FlatStyle = FlatStyle.Flat;
            btn_four.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_four.ForeColor = Color.FromArgb(238, 238, 238);
            btn_four.Location = new Point(12, 272);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(96, 45);
            btn_four.TabIndex = 27;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = false;
            btn_four.Click += btn_four_Click;
            // 
            // btn_five
            // 
            btn_five.BackColor = Color.FromArgb(49, 54, 63);
            btn_five.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_five.FlatAppearance.BorderSize = 0;
            btn_five.FlatStyle = FlatStyle.Flat;
            btn_five.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_five.ForeColor = Color.FromArgb(238, 238, 238);
            btn_five.Location = new Point(114, 272);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(94, 45);
            btn_five.TabIndex = 28;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = false;
            btn_five.Click += btn_five_Click;
            // 
            // btn_six
            // 
            btn_six.BackColor = Color.FromArgb(49, 54, 63);
            btn_six.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_six.FlatAppearance.BorderSize = 0;
            btn_six.FlatStyle = FlatStyle.Flat;
            btn_six.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_six.ForeColor = Color.FromArgb(238, 238, 238);
            btn_six.Location = new Point(214, 272);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(94, 45);
            btn_six.TabIndex = 29;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = false;
            btn_six.Click += btn_six_Click;
            // 
            // btn_sub
            // 
            btn_sub.BackColor = Color.FromArgb(49, 54, 63);
            btn_sub.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_sub.FlatAppearance.BorderSize = 0;
            btn_sub.FlatStyle = FlatStyle.Flat;
            btn_sub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_sub.ForeColor = Color.FromArgb(238, 238, 238);
            btn_sub.Location = new Point(314, 272);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(96, 45);
            btn_sub.TabIndex = 30;
            btn_sub.Text = "–";
            btn_sub.UseVisualStyleBackColor = false;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_one
            // 
            btn_one.BackColor = Color.FromArgb(49, 54, 63);
            btn_one.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_one.FlatAppearance.BorderSize = 0;
            btn_one.FlatStyle = FlatStyle.Flat;
            btn_one.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_one.ForeColor = Color.FromArgb(238, 238, 238);
            btn_one.Location = new Point(12, 323);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(96, 45);
            btn_one.TabIndex = 31;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = false;
            btn_one.Click += btn_one_Click;
            // 
            // btn_two
            // 
            btn_two.BackColor = Color.FromArgb(49, 54, 63);
            btn_two.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_two.FlatAppearance.BorderSize = 0;
            btn_two.FlatStyle = FlatStyle.Flat;
            btn_two.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_two.ForeColor = Color.FromArgb(238, 238, 238);
            btn_two.Location = new Point(114, 323);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(94, 45);
            btn_two.TabIndex = 32;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = false;
            btn_two.Click += btn_two_Click;
            // 
            // btn_three
            // 
            btn_three.BackColor = Color.FromArgb(49, 54, 63);
            btn_three.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_three.FlatAppearance.BorderSize = 0;
            btn_three.FlatStyle = FlatStyle.Flat;
            btn_three.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_three.ForeColor = Color.FromArgb(238, 238, 238);
            btn_three.Location = new Point(214, 323);
            btn_three.Name = "btn_three";
            btn_three.Size = new Size(94, 45);
            btn_three.TabIndex = 33;
            btn_three.Text = "3";
            btn_three.UseVisualStyleBackColor = false;
            btn_three.Click += btn_three_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(49, 54, 63);
            btn_add.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.FromArgb(238, 238, 238);
            btn_add.Location = new Point(314, 323);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(96, 45);
            btn_add.TabIndex = 34;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_zero
            // 
            btn_zero.BackColor = Color.FromArgb(49, 54, 63);
            btn_zero.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_zero.FlatAppearance.BorderSize = 0;
            btn_zero.FlatStyle = FlatStyle.Flat;
            btn_zero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_zero.ForeColor = Color.FromArgb(238, 238, 238);
            btn_zero.Location = new Point(12, 374);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(96, 45);
            btn_zero.TabIndex = 35;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = false;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = Color.FromArgb(49, 54, 63);
            btn_dot.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_dot.FlatAppearance.BorderSize = 0;
            btn_dot.FlatStyle = FlatStyle.Flat;
            btn_dot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_dot.ForeColor = Color.FromArgb(238, 238, 238);
            btn_dot.Location = new Point(114, 374);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(94, 45);
            btn_dot.TabIndex = 36;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_equal
            // 
            btn_equal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_equal.AutoSize = true;
            btn_equal.BackColor = Color.DarkTurquoise;
            btn_equal.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_equal.FlatAppearance.BorderSize = 0;
            btn_equal.FlatStyle = FlatStyle.Flat;
            btn_equal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_equal.ForeColor = Color.FromArgb(238, 238, 238);
            btn_equal.Location = new Point(214, 374);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(196, 45);
            btn_equal.TabIndex = 37;
            btn_equal.Text = "=";
            btn_equal.UseMnemonic = false;
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(420, 450);
            Controls.Add(btn_equal);
            Controls.Add(btn_dot);
            Controls.Add(btn_zero);
            Controls.Add(btn_add);
            Controls.Add(btn_three);
            Controls.Add(btn_two);
            Controls.Add(btn_one);
            Controls.Add(btn_sub);
            Controls.Add(btn_six);
            Controls.Add(btn_five);
            Controls.Add(btn_four);
            Controls.Add(btn_mul);
            Controls.Add(btn_nine);
            Controls.Add(btn_eight);
            Controls.Add(btn_seven);
            Controls.Add(btn_div);
            Controls.Add(btn_mod);
            Controls.Add(btn_delete);
            Controls.Add(btn_clear);
            Controls.Add(txt);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_mod;
        private Button btn_div;
        private Button btn_seven;
        private Button btn_eight;
        private Button btn_nine;
        private Button btn_mul;
        private Button btn_four;
        private Button btn_five;
        private Button btn_six;
        private Button btn_sub;
        private Button btn_one;
        private Button btn_two;
        private Button btn_three;
        private Button btn_add;
        private Button btn_zero;
        private Button btn_dot;
        private Button btn_equal;
    }
}
