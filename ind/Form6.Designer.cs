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
            buttonAuto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCols).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 277);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // numericUpDownRows
            // 
            numericUpDownRows.Location = new Point(86, 12);
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new Size(120, 23);
            numericUpDownRows.TabIndex = 1;
            // 
            // numericUpDownCols
            // 
            numericUpDownCols.Location = new Point(86, 55);
            numericUpDownCols.Name = "numericUpDownCols";
            numericUpDownCols.Size = new Size(120, 23);
            numericUpDownCols.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(96, 119);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(101, 23);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create array";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Cols";
            // 
            // buttonHome
            // 
            buttonHome.Location = new Point(271, 20);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(75, 23);
            buttonHome.TabIndex = 6;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(271, 119);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(75, 23);
            buttonCalc.TabIndex = 7;
            buttonCalc.Text = "Calc";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // buttonAuto
            // 
            buttonAuto.Location = new Point(441, 119);
            buttonAuto.Name = "buttonAuto";
            buttonAuto.Size = new Size(75, 23);
            buttonAuto.TabIndex = 8;
            buttonAuto.Text = "Autoadd";
            buttonAuto.UseVisualStyleBackColor = true;
            buttonAuto.Click += buttonAuto_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAuto);
            Controls.Add(buttonCalc);
            Controls.Add(buttonHome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCreate);
            Controls.Add(numericUpDownCols);
            Controls.Add(numericUpDownRows);
            Controls.Add(dataGridView1);
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
        private Button buttonAuto;
    }
}