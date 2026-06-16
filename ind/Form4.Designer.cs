namespace ind
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxX1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxX2 = new TextBox();
            Result = new Button();
            textBoxMove = new TextBox();
            label3 = new Label();
            textBoxSum = new TextBox();
            textBoxCount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(184, 73);
            textBoxX1.Margin = new Padding(4, 5, 4, 5);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(141, 31);
            textBoxX1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = " Inp first x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = " Inp first x";
            label2.Click += label2_Click;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(184, 173);
            textBoxX2.Margin = new Padding(4, 5, 4, 5);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(141, 31);
            textBoxX2.TabIndex = 3;
            // 
            // Result
            // 
            Result.Location = new Point(220, 357);
            Result.Margin = new Padding(4, 5, 4, 5);
            Result.Name = "Result";
            Result.Size = new Size(107, 38);
            Result.TabIndex = 4;
            Result.Text = "Res";
            Result.UseVisualStyleBackColor = true;
            Result.Click += Result_Click;
            // 
            // textBoxMove
            // 
            textBoxMove.Location = new Point(184, 265);
            textBoxMove.Margin = new Padding(4, 5, 4, 5);
            textBoxMove.Name = "textBoxMove";
            textBoxMove.Size = new Size(141, 31);
            textBoxMove.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 6;
            label3.Text = " Int move";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(766, 73);
            textBoxSum.Margin = new Padding(4, 5, 4, 5);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(141, 31);
            textBoxSum.TabIndex = 7;
            textBoxSum.TextChanged += textBoxSum_TextChanged;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(766, 160);
            textBoxCount.Margin = new Padding(4, 5, 4, 5);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(141, 31);
            textBoxCount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 78);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(709, 78);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 10;
            label5.Text = "Sum ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(789, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 11;
            label6.Text = "0.01 < y < 0.2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 173);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 12;
            label7.Text = "Count";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(581, 432);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(345, 254);
            listBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(86, 620);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 14;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxSum);
            Controls.Add(label3);
            Controls.Add(textBoxMove);
            Controls.Add(Result);
            Controls.Add(textBoxX2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxX1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX1;
        private Label label1;
        private Label label2;
        private TextBox textBoxX2;
        private Button Result;
        private TextBox textBoxMove;
        private Label label3;
        private TextBox textBoxSum;
        private TextBox textBoxCount;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private Button button1;
    }
}