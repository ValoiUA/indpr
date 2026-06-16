namespace ind
{
    partial class Form5
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
            label1 = new Label();
            textBoxArray = new TextBox();
            Add = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxSum = new TextBox();
            textBoxMore = new TextBox();
            textBoxCount = new TextBox();
            Remove = new Button();
            Home = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Input number for list";
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(60, 95);
            textBoxArray.Margin = new Padding(4, 5, 4, 5);
            textBoxArray.Name = "textBoxArray";
            textBoxArray.Size = new Size(310, 31);
            textBoxArray.TabIndex = 1;
            textBoxArray.TextChanged += textBoxArray_TextChanged_1;
            // 
            // Add
            // 
            Add.Location = new Point(93, 190);
            Add.Margin = new Padding(4, 5, 4, 5);
            Add.Name = "Add";
            Add.Size = new Size(107, 38);
            Add.TabIndex = 2;
            Add.Text = "Add num";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(491, 38);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 304);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 413);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 4;
            label2.Text = "SumEven";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 477);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 5;
            label3.Text = "Power more than 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 558);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 6;
            label4.Text = "CountOdd";
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(670, 408);
            textBoxSum.Margin = new Padding(4, 5, 4, 5);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(141, 31);
            textBoxSum.TabIndex = 7;
            // 
            // textBoxMore
            // 
            textBoxMore.Location = new Point(670, 472);
            textBoxMore.Margin = new Padding(4, 5, 4, 5);
            textBoxMore.Name = "textBoxMore";
            textBoxMore.Size = new Size(141, 31);
            textBoxMore.TabIndex = 8;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(670, 553);
            textBoxCount.Margin = new Padding(4, 5, 4, 5);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(141, 31);
            textBoxCount.TabIndex = 9;
            // 
            // Remove
            // 
            Remove.Location = new Point(60, 257);
            Remove.Margin = new Padding(4, 5, 4, 5);
            Remove.Name = "Remove";
            Remove.Size = new Size(177, 38);
            Remove.TabIndex = 10;
            Remove.Text = "Remove num";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Home
            // 
            Home.Location = new Point(71, 528);
            Home.Margin = new Padding(4, 5, 4, 5);
            Home.Name = "Home";
            Home.Size = new Size(129, 40);
            Home.TabIndex = 11;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(Home);
            Controls.Add(Remove);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxMore);
            Controls.Add(textBoxSum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(Add);
            Controls.Add(textBoxArray);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxArray;
        private Button Add;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxSum;
        private TextBox textBoxMore;
        private TextBox textBoxCount;
        private Button Remove;
        private Button Home;
    }
}