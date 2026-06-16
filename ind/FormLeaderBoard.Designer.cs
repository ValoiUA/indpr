namespace Doodlejump
{
    partial class FormLeaderBoard
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
            buttonLeave = new Button();
            listBoxLeaderBoard = new ListBox();
            SuspendLayout();
            // 
            // buttonLeave
            // 
            buttonLeave.Location = new Point(157, 563);
            buttonLeave.Margin = new Padding(4, 5, 4, 5);
            buttonLeave.Name = "buttonLeave";
            buttonLeave.Size = new Size(136, 38);
            buttonLeave.TabIndex = 0;
            buttonLeave.Text = "Leave";
            buttonLeave.UseVisualStyleBackColor = true;
            buttonLeave.Click += buttonLeave_Click;
            // 
            // listBoxLeaderBoard
            // 
            listBoxLeaderBoard.FormattingEnabled = true;
            listBoxLeaderBoard.ItemHeight = 25;
            listBoxLeaderBoard.Location = new Point(47, 20);
            listBoxLeaderBoard.Margin = new Padding(4, 5, 4, 5);
            listBoxLeaderBoard.Name = "listBoxLeaderBoard";
            listBoxLeaderBoard.Size = new Size(438, 529);
            listBoxLeaderBoard.TabIndex = 1;
            listBoxLeaderBoard.SelectedIndexChanged += listBoxLeaderBoard_SelectedIndexChanged;
            // 
            // FormLeaderBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 685);
            Controls.Add(listBoxLeaderBoard);
            Controls.Add(buttonLeave);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLeaderBoard";
            Text = "FormLeaderBoard";
            Load += FormLeaderBoard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLeave;
        private ListBox listBoxLeaderBoard;
    }
}