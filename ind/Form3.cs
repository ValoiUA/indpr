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
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
            textBoxAX.KeyPress += f1.checkDigit;
            textBoxAY.KeyPress += f1.checkDigit;
            textBoxBX.KeyPress += f1.checkDigit;
            textBoxBY.KeyPress += f1.checkDigit;
            textBoxCX.KeyPress += f1.checkDigit;
            textBoxCY.KeyPress += f1.checkDigit;
            MA.ReadOnly = true;
            MB.ReadOnly = true;
            MC.ReadOnly = true;
            textBox1.ReadOnly = true;
            this.Text = "Площа трикутника по медіанам";
        }


        private void buttonres_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxAX.Text, out double AX);
            double.TryParse(textBoxAY.Text, out double AY);
            double.TryParse(textBoxBX.Text, out double BX);
            double.TryParse(textBoxBY.Text, out double BY);
            double.TryParse(textBoxCX.Text, out double CX);
            double.TryParse(textBoxCY.Text, out double CY);
            double a = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow(BY - AY, 2));
            double b = Math.Sqrt(Math.Pow(CX - BX, 2) + Math.Pow(CY - BY, 2));
            double c = Math.Sqrt(Math.Pow(CX - AX, 2) + Math.Pow(CY - AY, 2));
            if (a >= b + c || b >= c + a || c >= a + b)
            {
                MessageBox.Show("Такого трикутника не існує");
                return;
            }
            double Dx = (BX + CX) / 2;
            double Dy = (BY + CY) / 2;

            double Ex = (AX + CX) / 2;
            double Ey = (AY + CY) / 2;

            double Fx = (AX + BX) / 2;
            double Fy = (AY + BY) / 2;
            double m1 = Math.Sqrt(Math.Pow(AX - Dx, 2) + Math.Pow(AY - Dy, 2));
            double m2 = Math.Sqrt(Math.Pow(BX - Ex, 2) + Math.Pow(BY - Ey, 2));
            double m3 = Math.Sqrt(Math.Pow(CX - Fx, 2) + Math.Pow(CY - Fy, 2));
            MA.Text = m1.ToString();
            MB.Text = m2.ToString();
            MC.Text = m3.ToString();
            double s =
    Math.Abs(
        AX * (BY - CY) +
        BX * (CY - AY) +
        CX * (AY - BY)
    ) / 2;
            textBox1.Text = s.ToString();
        }

        private void textBoxAX_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
