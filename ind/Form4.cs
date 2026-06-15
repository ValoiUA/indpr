using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ind
{
    public partial class Form4 : Form
    {
        Form1 f1 = new Form1();
        public Form4()
        {
            InitializeComponent();
            textBoxSum.ReadOnly = true;
            textBoxCount.ReadOnly = true;
            textBoxX2.KeyPress += f1.checkDigit;
            textBoxX1.KeyPress += f1.checkDigit;
            textBoxMove.KeyPress += f1.checkDigit;
            this.Text = "Обчислення функції";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double y = 0;
            double sum = 0;
            double count = 0;
            double.TryParse(textBoxX1.Text, out double x1);
            double.TryParse(textBoxX2.Text, out double x2);
            double.TryParse(textBoxMove.Text, out double move);

            if (x1 > x2 && move > 0)
            {
                MessageBox.Show("X1 must be less than X2 for positive move");
                return;
            }
            if (x1 < x2 && move < 0)
            {
                MessageBox.Show("X1 must be greater than X2 for negative move");
                return;
            }

            if (x1 < x2)
            {
                for (double i = x1; i <= x2; i += move)
                {
                    y = Math.Log2(i) / Math.Pow(i, 3);
                    if (y < 0.2 && y > 0.01)
                    {
                        sum += y;
                        count++;
                    }

                    listBox1.Items.Add($"X: {i:F2}, Y: {y:F4}");
                }

            }
            else if (x1 > x2)
            {
                {
                    for (double i = x1; i >= x2; i += move)
                    {
                        y = Math.Log2(i) / Math.Pow(i, 3);
                        if (y < 0.2 && y > 0.01)
                        {
                            sum += y;
                            count++;
                        }
                        listBox1.Items.Add($"X: {i:F2}, Y: {y:F4}");
                    }
                }
            }
            else
            {
                y = Math.Log2(x1) / Math.Pow(x1, 3);
                if (y < 0.2 && y > 0.01)
                {
                    sum += y;
                    count++;
                }
                listBox1.Items.Add($"X: {x1:F2}, Y: {y:F4}");
            }
            textBoxSum.Text = sum.ToString("F4");
            textBoxCount.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
