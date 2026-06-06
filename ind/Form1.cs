namespace ind
{
    public partial class Form1 : Form
    {
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
    }
}
