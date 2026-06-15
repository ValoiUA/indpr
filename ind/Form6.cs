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
    public partial class Form6 : Form
    {
        Form1 f1 = new Form1();
        public Form6()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.Text = "Робота з матрицею";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            int rows = (int)numericUpDownRows.Value;
            int cols = (int)numericUpDownCols.Value;

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress -= f1.checkDigit;
                tb.KeyPress += f1.checkDigit;
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[dataGridView1.RowCount,
                     dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("Заповніть усі клітинки");
                        return;
                    }

                    arr[i, j] = Convert.ToInt32(
                        dataGridView1.Rows[i].Cells[j].Value);
                }
            }
            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        sum += arr[i, j];
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Елементів нижче головної діагоналі немає");
                return;
            }

            double avg = sum / count;

            MessageBox.Show($"Середнє арифметичне = {avg:F2}");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.ColumnCount == 0)
            {
                MessageBox.Show("Спочатку створіть матрицю за допомогою кнопки створення!");
                return;
            }
            Random rnd = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int randomValue = rnd.Next(-50, 51);
                    dataGridView1.Rows[i].Cells[j].Value = randomValue;
                }
            }
        }
    }
}
