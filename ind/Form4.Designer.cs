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
            textBoxX1.Location = new Point(129, 44);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(100, 23);
            textBoxX1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = " Inp first x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = " Inp first x";
            label2.Click += label2_Click;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(129, 104);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(100, 23);
            textBoxX2.TabIndex = 3;
            // 
            // Result
            // 
            Result.Location = new Point(154, 214);
            Result.Name = "Result";
            Result.Size = new Size(75, 23);
            Result.TabIndex = 4;
            Result.Text = "Res";
            Result.UseVisualStyleBackColor = true;
            Result.Click += Result_Click;
            // 
            // textBoxMove
            // 
            textBoxMove.Location = new Point(129, 159);
            textBoxMove.Name = "textBoxMove";
            textBoxMove.Size = new Size(100, 23);
            textBoxMove.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 167);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = " Int move";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(536, 44);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(100, 23);
            textBoxSum.TabIndex = 7;
            textBoxSum.TextChanged += textBoxSum_TextChanged;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(536, 96);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(100, 23);
            textBoxCount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 47);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 47);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Sum ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 9);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "0.2 < y < 0.5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 104);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 12;
            label7.Text = "Count";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(407, 259);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(243, 154);
            listBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(60, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form4";
            Text = "Form4";
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