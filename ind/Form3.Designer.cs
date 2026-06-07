namespace ind
{
    partial class Form3
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
            textBoxAX = new TextBox();
            textBoxAY = new TextBox();
            MA = new TextBox();
            textBoxBX = new TextBox();
            textBoxBY = new TextBox();
            MB = new TextBox();
            textBoxCX = new TextBox();
            textBoxCY = new TextBox();
            MC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonres = new Button();
            textBox1 = new TextBox();
            Home = new Button();
            SuspendLayout();
            // 
            // textBoxAX
            // 
            textBoxAX.Location = new Point(68, 40);
            textBoxAX.Margin = new Padding(2, 2, 2, 2);
            textBoxAX.Name = "textBoxAX";
            textBoxAX.Size = new Size(106, 23);
            textBoxAX.TabIndex = 0;
            textBoxAX.KeyPress += textBoxAX_KeyPress;
            // 
            // textBoxAY
            // 
            textBoxAY.Location = new Point(240, 40);
            textBoxAY.Margin = new Padding(2, 2, 2, 2);
            textBoxAY.Name = "textBoxAY";
            textBoxAY.Size = new Size(106, 23);
            textBoxAY.TabIndex = 1;
            // 
            // MA
            // 
            MA.Location = new Point(406, 40);
            MA.Margin = new Padding(2, 2, 2, 2);
            MA.Name = "MA";
            MA.Size = new Size(106, 23);
            MA.TabIndex = 2;
            // 
            // textBoxBX
            // 
            textBoxBX.Location = new Point(68, 85);
            textBoxBX.Margin = new Padding(2, 2, 2, 2);
            textBoxBX.Name = "textBoxBX";
            textBoxBX.Size = new Size(106, 23);
            textBoxBX.TabIndex = 3;
            // 
            // textBoxBY
            // 
            textBoxBY.Location = new Point(240, 85);
            textBoxBY.Margin = new Padding(2, 2, 2, 2);
            textBoxBY.Name = "textBoxBY";
            textBoxBY.Size = new Size(106, 23);
            textBoxBY.TabIndex = 4;
            // 
            // MB
            // 
            MB.Location = new Point(406, 85);
            MB.Margin = new Padding(2, 2, 2, 2);
            MB.Name = "MB";
            MB.Size = new Size(106, 23);
            MB.TabIndex = 5;
            // 
            // textBoxCX
            // 
            textBoxCX.Location = new Point(68, 129);
            textBoxCX.Margin = new Padding(2, 2, 2, 2);
            textBoxCX.Name = "textBoxCX";
            textBoxCX.Size = new Size(106, 23);
            textBoxCX.TabIndex = 6;
            // 
            // textBoxCY
            // 
            textBoxCY.Location = new Point(240, 129);
            textBoxCY.Margin = new Padding(2, 2, 2, 2);
            textBoxCY.Name = "textBoxCY";
            textBoxCY.Size = new Size(106, 23);
            textBoxCY.TabIndex = 7;
            // 
            // MC
            // 
            MC.Location = new Point(406, 129);
            MC.Margin = new Padding(2, 2, 2, 2);
            MC.Name = "MC";
            MC.Size = new Size(106, 23);
            MC.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 9;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 10;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 11;
            label3.Text = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 85);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 12;
            label4.Text = "B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 129);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 13;
            label5.Text = "C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 14;
            label6.Text = "Медіани";
            // 
            // buttonres
            // 
            buttonres.Location = new Point(253, 174);
            buttonres.Margin = new Padding(2, 2, 2, 2);
            buttonres.Name = "buttonres";
            buttonres.Size = new Size(78, 20);
            buttonres.TabIndex = 15;
            buttonres.Text = "Result";
            buttonres.UseVisualStyleBackColor = true;
            buttonres.Click += buttonres_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 226);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 16;
            // 
            // Home
            // 
            Home.Location = new Point(428, 225);
            Home.Name = "Home";
            Home.Size = new Size(75, 23);
            Home.TabIndex = 17;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(Home);
            Controls.Add(textBox1);
            Controls.Add(buttonres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MC);
            Controls.Add(textBoxCY);
            Controls.Add(textBoxCX);
            Controls.Add(MB);
            Controls.Add(textBoxBY);
            Controls.Add(textBoxBX);
            Controls.Add(MA);
            Controls.Add(textBoxAY);
            Controls.Add(textBoxAX);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAX;
        private TextBox textBoxAY;
        private TextBox MA;
        private TextBox textBoxBX;
        private TextBox textBoxBY;
        private TextBox MB;
        private TextBox textBoxCX;
        private TextBox textBoxCY;
        private TextBox MC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonres;
        private TextBox textBox1;
        private Button Home;
    }
}