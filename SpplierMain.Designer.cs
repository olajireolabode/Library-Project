namespace ProApp
{
    partial class SpplierMain
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
            spBooksListBox = new ListBox();
            searchTextBox = new TextBox();
            label2 = new Label();
            logOutLabel = new Label();
            SuspendLayout();
            // 
            // spBooksListBox
            // 
            spBooksListBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            spBooksListBox.FormattingEnabled = true;
            spBooksListBox.ItemHeight = 21;
            spBooksListBox.Location = new Point(24, 81);
            spBooksListBox.Margin = new Padding(3, 2, 3, 2);
            spBooksListBox.Name = "spBooksListBox";
            spBooksListBox.SelectionMode = SelectionMode.MultiSimple;
            spBooksListBox.Size = new Size(222, 88);
            spBooksListBox.TabIndex = 37;
            spBooksListBox.MouseClick += spBooksListBox_MouseClick;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(24, 50);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(222, 23);
            searchTextBox.TabIndex = 36;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 21);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 35;
            label2.Text = "Search for Book:";
            // 
            // logOutLabel
            // 
            logOutLabel.AutoSize = true;
            logOutLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOutLabel.ForeColor = Color.Black;
            logOutLabel.Location = new Point(99, 203);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(69, 21);
            logOutLabel.TabIndex = 38;
            logOutLabel.Text = "Log Out";
            logOutLabel.Click += logOutLabel_Click;
            // 
            // SpplierMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 247);
            Controls.Add(logOutLabel);
            Controls.Add(spBooksListBox);
            Controls.Add(searchTextBox);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SpplierMain";
            Text = "SpplierMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox spBooksListBox;
        private TextBox searchTextBox;
        private Label label2;
        private Label logOutLabel;
    }
}