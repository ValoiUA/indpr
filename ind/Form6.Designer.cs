namespace ind
{
    partial class Form6
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
            dataGridView1 = new DataGridView();
            numericUpDownRows = new NumericUpDown();
            numericUpDownCols = new NumericUpDown();
            buttonCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonHome = new Button();
            buttonCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCols).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 247);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1060, 462);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // numericUpDownRows
            // 
            numericUpDownRows.Location = new Point(123, 20);
            numericUpDownRows.Margin = new Padding(4, 5, 4, 5);
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new Size(171, 31);
            numericUpDownRows.TabIndex = 1;
            // 
            // numericUpDownCols
            // 
            numericUpDownCols.Location = new Point(123, 92);
            numericUpDownCols.Margin = new Padding(4, 5, 4, 5);
            numericUpDownCols.Name = "numericUpDownCols";
            numericUpDownCols.Size = new Size(171, 31);
            numericUpDownCols.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(150, 198);
            buttonCreate.Margin = new Padding(4, 5, 4, 5);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(107, 38);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 4;
            label1.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 5;
            label2.Text = "Cols";
            // 
            // buttonHome
            // 
            buttonHome.Location = new Point(734, 88);
            buttonHome.Margin = new Padding(4, 5, 4, 5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(107, 38);
            buttonHome.TabIndex = 6;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(387, 198);
            buttonCalc.Margin = new Padding(4, 5, 4, 5);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(107, 38);
            buttonCalc.TabIndex = 7;
            buttonCalc.Text = "Calc";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonCalc);
            Controls.Add(buttonHome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCreate);
            Controls.Add(numericUpDownCols);
            Controls.Add(numericUpDownRows);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCols).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private NumericUpDown numericUpDownRows;
        private NumericUpDown numericUpDownCols;
        private Button buttonCreate;
        private Label label1;
        private Label label2;
        private Button buttonHome;
        private Button buttonCalc;
    }
}