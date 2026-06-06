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
            SuspendLayout();
            // 
            // textBoxAX
            // 
            textBoxAX.Location = new Point(97, 66);
            textBoxAX.Name = "textBoxAX";
            textBoxAX.Size = new Size(150, 31);
            textBoxAX.TabIndex = 0;
            textBoxAX.KeyPress += textBoxAX_KeyPress;
            // 
            // textBoxAY
            // 
            textBoxAY.Location = new Point(343, 66);
            textBoxAY.Name = "textBoxAY";
            textBoxAY.Size = new Size(150, 31);
            textBoxAY.TabIndex = 1;
            // 
            // MA
            // 
            MA.Location = new Point(580, 66);
            MA.Name = "MA";
            MA.Size = new Size(150, 31);
            MA.TabIndex = 2;
            // 
            // textBoxBX
            // 
            textBoxBX.Location = new Point(97, 141);
            textBoxBX.Name = "textBoxBX";
            textBoxBX.Size = new Size(150, 31);
            textBoxBX.TabIndex = 3;
            // 
            // textBoxBY
            // 
            textBoxBY.Location = new Point(343, 141);
            textBoxBY.Name = "textBoxBY";
            textBoxBY.Size = new Size(150, 31);
            textBoxBY.TabIndex = 4;
            // 
            // MB
            // 
            MB.Location = new Point(580, 141);
            MB.Name = "MB";
            MB.Size = new Size(150, 31);
            MB.TabIndex = 5;
            // 
            // textBoxCX
            // 
            textBoxCX.Location = new Point(97, 215);
            textBoxCX.Name = "textBoxCX";
            textBoxCX.Size = new Size(150, 31);
            textBoxCX.TabIndex = 6;
            // 
            // textBoxCY
            // 
            textBoxCY.Location = new Point(343, 215);
            textBoxCY.Name = "textBoxCY";
            textBoxCY.Size = new Size(150, 31);
            textBoxCY.TabIndex = 7;
            // 
            // MC
            // 
            MC.Location = new Point(580, 215);
            MC.Name = "MC";
            MC.Size = new Size(150, 31);
            MC.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 9;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 10;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 69);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 11;
            label3.Text = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 141);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 12;
            label4.Text = "B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 215);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 13;
            label5.Text = "C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 9);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 14;
            label6.Text = "Медіани";
            // 
            // buttonres
            // 
            buttonres.Location = new Point(361, 290);
            buttonres.Name = "buttonres";
            buttonres.Size = new Size(112, 34);
            buttonres.TabIndex = 15;
            buttonres.Text = "Result";
            buttonres.UseVisualStyleBackColor = true;
            buttonres.Click += buttonres_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 376);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}