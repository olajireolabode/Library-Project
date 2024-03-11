namespace ProApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            userBox = new TextBox();
            pssBox = new TextBox();
            ClearFiledLabel = new Label();
            hideButton = new Button();
            viewButton = new Button();
            LogoLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(122, 356);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(165, 407);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 1;
            label1.Text = "Exit";
            label1.Click += label1_Click_1;
            // 
            // userBox
            // 
            userBox.BorderStyle = BorderStyle.FixedSingle;
            userBox.Cursor = Cursors.IBeam;
            userBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userBox.Location = new Point(54, 207);
            userBox.Name = "userBox";
            userBox.Size = new Size(238, 29);
            userBox.TabIndex = 2;
            // 
            // pssBox
            // 
            pssBox.BorderStyle = BorderStyle.FixedSingle;
            pssBox.Cursor = Cursors.IBeam;
            pssBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pssBox.Location = new Point(54, 252);
            pssBox.Name = "pssBox";
            pssBox.PasswordChar = '*';
            pssBox.Size = new Size(238, 29);
            pssBox.TabIndex = 3;
            // 
            // ClearFiledLabel
            // 
            ClearFiledLabel.AutoSize = true;
            ClearFiledLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClearFiledLabel.ForeColor = Color.Black;
            ClearFiledLabel.Location = new Point(199, 288);
            ClearFiledLabel.Name = "ClearFiledLabel";
            ClearFiledLabel.Size = new Size(93, 21);
            ClearFiledLabel.TabIndex = 4;
            ClearFiledLabel.Text = "Clear Fields";
            ClearFiledLabel.Click += ClearFiledLabel_Click_1;
            // 
            // hideButton
            // 
            hideButton.BackColor = SystemColors.AppWorkspace;
            hideButton.BackgroundImage = (Image)resources.GetObject("hideButton.BackgroundImage");
            hideButton.BackgroundImageLayout = ImageLayout.Zoom;
            hideButton.FlatStyle = FlatStyle.Flat;
            hideButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hideButton.ForeColor = SystemColors.ButtonHighlight;
            hideButton.Location = new Point(298, 252);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(26, 22);
            hideButton.TabIndex = 5;
            hideButton.UseVisualStyleBackColor = false;
            hideButton.Click += hideButton_Click;
            // 
            // viewButton
            // 
            viewButton.BackColor = SystemColors.AppWorkspace;
            viewButton.BackgroundImage = Properties.Resources.eyeIcon;
            viewButton.BackgroundImageLayout = ImageLayout.Zoom;
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewButton.ForeColor = SystemColors.ButtonHighlight;
            viewButton.Location = new Point(298, 252);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(26, 22);
            viewButton.TabIndex = 6;
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += viewButton_Click_2;
            // 
            // LogoLabel
            // 
            LogoLabel.Image = (Image)resources.GetObject("LogoLabel.Image");
            LogoLabel.Location = new Point(134, 23);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(100, 100);
            LogoLabel.TabIndex = 7;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(18, 207);
            label3.Name = "label3";
            label3.Size = new Size(30, 22);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(18, 252);
            label4.Name = "label4";
            label4.Size = new Size(30, 22);
            label4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LogoLabel);
            Controls.Add(viewButton);
            Controls.Add(hideButton);
            Controls.Add(ClearFiledLabel);
            Controls.Add(pssBox);
            Controls.Add(userBox);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox userBox;
        private TextBox pssBox;
        private Label ClearFiledLabel;
        private Button hideButton;
        private Button viewButton;
        private Label LogoLabel;
        private Label label3;
        private Label label4;
    }
}