namespace LogIn_App
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            button1 = new Button();
            button2 = new Button();
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            checkbxshowpass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(134, 125, 121);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(174, 427);
            button1.Name = "button1";
            button1.Size = new Size(201, 41);
            button1.TabIndex = 0;
            button1.Text = "LogIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(134, 125, 121);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(174, 486);
            button2.Name = "button2";
            button2.Size = new Size(201, 41);
            button2.TabIndex = 1;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = false;
            button2.BackColorChanged += button2_BackColorChanged;
            button2.Click += button2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(134, 125, 121);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.Hand;
            txtUsername.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.InfoText;
            txtUsername.Location = new Point(115, 178);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 26);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.BackColor = Color.FromArgb(134, 125, 121);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.Hand;
            txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.Black;
            txtpassword.ImeMode = ImeMode.NoControl;
            txtpassword.Location = new Point(115, 320);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(328, 26);
            txtpassword.TabIndex = 3;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(174, 247);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(134, 125, 121);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(222, 544);
            button3.Name = "button3";
            button3.Size = new Size(91, 26);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // checkbxshowpass
            // 
            checkbxshowpass.AutoSize = true;
            checkbxshowpass.Cursor = Cursors.Hand;
            checkbxshowpass.FlatStyle = FlatStyle.Flat;
            checkbxshowpass.ForeColor = Color.FromArgb(201, 146, 61);
            checkbxshowpass.Location = new Point(315, 352);
            checkbxshowpass.Name = "checkbxshowpass";
            checkbxshowpass.Size = new Size(128, 24);
            checkbxshowpass.TabIndex = 7;
            checkbxshowpass.Text = "Show Password";
            checkbxshowpass.UseVisualStyleBackColor = true;
            checkbxshowpass.CheckedChanged += checkbxshowpass_CheckedChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 32, 76);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(551, 683);
            Controls.Add(checkbxshowpass);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(0, 0, 192);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn ";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtUsername;
        private TextBox txtpassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
        private CheckBox checkbxshowpass;
    }
}
