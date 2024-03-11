namespace ProApp
{
    partial class MainStaff
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
            label7 = new Label();
            label6 = new Label();
            addBookButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            titleTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            booksListBox = new ListBox();
            publisherTextBox = new TextBox();
            authorTextBox = new TextBox();
            genreTextBox = new TextBox();
            bookIdTextBox = new TextBox();
            titleLabel = new Label();
            bookIdLabel = new Label();
            genreLabel = new Label();
            authorLabel = new Label();
            publisherLabel = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(638, 354);
            label7.Name = "label7";
            label7.Size = new Size(74, 55);
            label7.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(215, 231);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 31;
            label6.Text = "Log out";
            label6.Click += label6_Click;
            // 
            // addBookButton
            // 
            addBookButton.BackColor = SystemColors.MenuHighlight;
            addBookButton.FlatStyle = FlatStyle.Flat;
            addBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBookButton.ForeColor = SystemColors.Window;
            addBookButton.Location = new Point(19, 167);
            addBookButton.Margin = new Padding(3, 2, 3, 2);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(221, 34);
            addBookButton.TabIndex = 30;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = false;
            addBookButton.Click += addBookButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.MenuHighlight;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = SystemColors.Window;
            searchButton.Location = new Point(280, 167);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(221, 34);
            searchButton.TabIndex = 27;
            searchButton.Text = "Search Book";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(280, 44);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(222, 23);
            searchTextBox.TabIndex = 25;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(19, 44);
            titleTextBox.Margin = new Padding(3, 2, 3, 2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(222, 23);
            titleTextBox.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 15);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 21;
            label2.Text = "Search for Book:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 20;
            label1.Text = "Add Book:";
            // 
            // booksListBox
            // 
            booksListBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            booksListBox.FormattingEnabled = true;
            booksListBox.ItemHeight = 21;
            booksListBox.Location = new Point(280, 68);
            booksListBox.Margin = new Padding(3, 2, 3, 2);
            booksListBox.Name = "booksListBox";
            booksListBox.SelectionMode = SelectionMode.MultiSimple;
            booksListBox.Size = new Size(222, 88);
            booksListBox.TabIndex = 34;
            booksListBox.MouseClick += booksListBox_MouseClick;
            // 
            // publisherTextBox
            // 
            publisherTextBox.Location = new Point(19, 142);
            publisherTextBox.Margin = new Padding(3, 2, 3, 2);
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new Size(222, 23);
            publisherTextBox.TabIndex = 38;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(19, 118);
            authorTextBox.Margin = new Padding(3, 2, 3, 2);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(222, 23);
            authorTextBox.TabIndex = 37;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(19, 93);
            genreTextBox.Margin = new Padding(3, 2, 3, 2);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(222, 23);
            genreTextBox.TabIndex = 36;
            // 
            // bookIdTextBox
            // 
            bookIdTextBox.Location = new Point(19, 68);
            bookIdTextBox.Margin = new Padding(3, 2, 3, 2);
            bookIdTextBox.Name = "bookIdTextBox";
            bookIdTextBox.Size = new Size(222, 23);
            bookIdTextBox.TabIndex = 35;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(177, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(29, 15);
            titleLabel.TabIndex = 39;
            titleLabel.Text = "Title";
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new Point(178, 72);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(47, 15);
            bookIdLabel.TabIndex = 40;
            bookIdLabel.Text = "Book Id";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(178, 96);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(38, 15);
            genreLabel.TabIndex = 41;
            genreLabel.Text = "Genre";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(179, 121);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(44, 15);
            authorLabel.TabIndex = 42;
            authorLabel.Text = "Author";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new Point(179, 146);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(56, 15);
            publisherLabel.TabIndex = 43;
            publisherLabel.Text = "Publisher";
            // 
            // MainStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 278);
            Controls.Add(publisherLabel);
            Controls.Add(authorLabel);
            Controls.Add(genreLabel);
            Controls.Add(bookIdLabel);
            Controls.Add(titleLabel);
            Controls.Add(publisherTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(genreTextBox);
            Controls.Add(bookIdTextBox);
            Controls.Add(booksListBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(addBookButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainStaff";
            Text = "Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Button addBookButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private TextBox titleTextBox;
        private Label label2;
        private Label label1;
        private ListBox booksListBox;
        private TextBox publisherTextBox;
        private TextBox authorTextBox;
        private TextBox genreTextBox;
        private TextBox bookIdTextBox;
        private Label titleLabel;
        private Label bookIdLabel;
        private Label genreLabel;
        private Label authorLabel;
        private Label publisherLabel;
    }
}