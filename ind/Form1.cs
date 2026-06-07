namespace ind
{
    public partial class Form1 : Form
    {
        public void checkDigit(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if ("-,.".Contains(e.KeyChar) && (sender as TextBox).Text.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                if (tb.SelectionStart != 0 || tb.Text.Contains("-"))
                    e.Handled = true;

                return;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (tb.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }
                if (tb.Text == "-")
                {
                    e.Handled = true;
                    return;
                }
                if (tb.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }
                if (tb.Text.Contains(",") || tb.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }


            }
        }


        public void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 35;
            btn.Width = 120;
        }
        public Form1()
        {
            InitializeComponent();
            StyleButton(button1, Color.Bisque);
            StyleButton(button2, Color.Bisque);
            StyleButton(button3, Color.Bisque);
            StyleButton(button4, Color.Bisque);
            StyleButton(button5, Color.Bisque);
            StyleButton(button6, Color.Bisque);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }
    }
}
