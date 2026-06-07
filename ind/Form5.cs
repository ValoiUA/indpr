using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ind
{
    public partial class Form5 : Form
    {
        Form1 f1 = new Form1();
        List<double> numbers = new List<double>();
        double sumOdd = 0;
        double mtt = 0;
        double evenCount = 0;
        public Form5()
        {
            InitializeComponent();
            textBoxArray.KeyPress += f1.checkDigit;
            textBoxCount.ReadOnly = true;
            textBoxSum.ReadOnly = true;
            textBoxMore.ReadOnly = true;
        }
        private void UpdateInfo()
        {
            sumOdd = 0;
            evenCount = 0;
            mtt = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if ((i + 1) % 2 == 0)
                    sumOdd += numbers[i];
                if (((int)numbers[i]) % 2 != 0)
                    evenCount++;
                if (numbers[i] > 3)
                    mtt += numbers[i] * numbers[i];
            }

            textBoxCount.Text = evenCount.ToString();
            textBoxSum.Text = sumOdd.ToString("F4");
            textBoxMore.Text = mtt.ToString("F4");
        }

        private void textBoxArray_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxArray.Text, out double number))
            {
                MessageBox.Show("Введіть коректне число");
                return;
            }

            numbers.Add(number);
            listBox1.Items.Add(number);

            File.AppendAllText("numbers.txt", number + Environment.NewLine);

            UpdateInfo();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxArray.Text, out double number))
            {
                MessageBox.Show("Введіть коректне число");
                return;
            }

            int index = numbers.IndexOf(number);

            if (index == -1)
            {
                MessageBox.Show("Такого числа немає");
                return;
            }

            numbers.RemoveAt(index);
            listBox1.Items.RemoveAt(index);

            File.WriteAllLines("numbers.txt",
                numbers.Select(x => x.ToString()));

            UpdateInfo();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
