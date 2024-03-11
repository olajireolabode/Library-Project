namespace ProApp
{
    partial class MainUser
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
            label2 = new Label();
            bookNameTextBox = new TextBox();
            searchButton = new Button();
            label4 = new Label();
            label5 = new Label();
            resultsListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.icons8_user_64;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(114, 101);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 156);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Book Name:";
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.Location = new Point(206, 156);
            bookNameTextBox.Margin = new Padding(3, 4, 3, 4);
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.Size = new Size(301, 27);
            bookNameTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.MenuHighlight;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = SystemColors.Window;
            searchButton.Location = new Point(230, 368);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(113, 55);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 468);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 5;
            label4.Text = "Log Out";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(378, 468);
            label5.Name = "label5";
            label5.Size = new Size(197, 28);
            label5.TabIndex = 6;
            label5.Text = "Create Membership";
            label5.Click += label5_Click;
            // 
            // resultsListBox
            // 
            resultsListBox.FormattingEnabled = true;
            resultsListBox.ItemHeight = 20;
            resultsListBox.Location = new Point(73, 191);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(434, 164);
            resultsListBox.TabIndex = 7;
            resultsListBox.MouseClick += resultsListBox_MouseClick;
            // 
            // MainUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 534);
            Controls.Add(resultsListBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(searchButton);
            Controls.Add(bookNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox bookNameTextBox;
        private Button searchButton;
        private Label label4;
        private Label label5;
        private ListBox resultsListBox;
    }
}