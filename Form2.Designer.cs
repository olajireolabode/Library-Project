namespace ProApp
{
    partial class BookEdit
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
            titleTextBox = new TextBox();
            titleLabel = new Label();
            bookIdLabel = new Label();
            bookIdTextBox = new TextBox();
            genreLabel = new Label();
            genreTextBox = new TextBox();
            authorLabel = new Label();
            authorTextBox = new TextBox();
            publisherLabel = new Label();
            publisherTextBox = new TextBox();
            editButton = new Button();
            reservedCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(124, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(125, 27);
            titleTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(80, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(38, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new Point(58, 48);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(60, 20);
            bookIdLabel.TabIndex = 3;
            bookIdLabel.Text = "Book Id";
            // 
            // bookIdTextBox
            // 
            bookIdTextBox.Location = new Point(124, 45);
            bookIdTextBox.Name = "bookIdTextBox";
            bookIdTextBox.Size = new Size(125, 27);
            bookIdTextBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(70, 81);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(48, 20);
            genreLabel.TabIndex = 5;
            genreLabel.Text = "Genre";
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(124, 78);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(125, 27);
            genreTextBox.TabIndex = 4;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(64, 114);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(54, 20);
            authorLabel.TabIndex = 7;
            authorLabel.Text = "Author";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(124, 111);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(125, 27);
            authorTextBox.TabIndex = 6;
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new Point(49, 147);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(69, 20);
            publisherLabel.TabIndex = 9;
            publisherLabel.Text = "Publisher";
            // 
            // publisherTextBox
            // 
            publisherTextBox.Location = new Point(124, 144);
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new Size(125, 27);
            publisherTextBox.TabIndex = 8;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.MenuHighlight;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.ForeColor = SystemColors.Window;
            editButton.Location = new Point(89, 259);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(113, 55);
            editButton.TabIndex = 10;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // reservedCheckBox
            // 
            reservedCheckBox.AutoSize = true;
            reservedCheckBox.Location = new Point(99, 199);
            reservedCheckBox.Name = "reservedCheckBox";
            reservedCheckBox.Size = new Size(91, 24);
            reservedCheckBox.TabIndex = 11;
            reservedCheckBox.Text = "Reserved";
            reservedCheckBox.UseVisualStyleBackColor = true;
            reservedCheckBox.CheckedChanged += reservedCheckBox_CheckedChanged;
            // 
            // BookEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 345);
            Controls.Add(reservedCheckBox);
            Controls.Add(editButton);
            Controls.Add(publisherLabel);
            Controls.Add(publisherTextBox);
            Controls.Add(authorLabel);
            Controls.Add(authorTextBox);
            Controls.Add(genreLabel);
            Controls.Add(genreTextBox);
            Controls.Add(bookIdLabel);
            Controls.Add(bookIdTextBox);
            Controls.Add(titleLabel);
            Controls.Add(titleTextBox);
            Name = "BookEdit";
            Text = "Book Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private Label titleLabel;
        private Label bookIdLabel;
        private TextBox bookIdTextBox;
        private Label genreLabel;
        private TextBox genreTextBox;
        private Label authorLabel;
        private TextBox authorTextBox;
        private Label publisherLabel;
        private TextBox publisherTextBox;
        private Button editButton;
        private CheckBox reservedCheckBox;
    }
}