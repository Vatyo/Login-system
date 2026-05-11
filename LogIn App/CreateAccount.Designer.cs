namespace LogIn_App
{
    partial class CreateAccount
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
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtpassword1 = new TextBox();
            txtconfpass2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.FromArgb(134, 125, 121);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.Hand;
            txtUsername.Location = new Point(112, 110);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(239, 34);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(201, 146, 61);
            label1.Location = new Point(151, 71);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter your User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(201, 146, 61);
            label2.Location = new Point(163, 188);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter your Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(201, 146, 61);
            label3.Location = new Point(144, 304);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 3;
            label3.Text = "Confirm your Password";
            // 
            // txtpassword1
            // 
            txtpassword1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtpassword1.BackColor = Color.FromArgb(134, 125, 121);
            txtpassword1.BorderStyle = BorderStyle.None;
            txtpassword1.Cursor = Cursors.Hand;
            txtpassword1.Location = new Point(112, 226);
            txtpassword1.Multiline = true;
            txtpassword1.Name = "txtpassword1";
            txtpassword1.Size = new Size(239, 34);
            txtpassword1.TabIndex = 4;
            txtpassword1.TextChanged += txtpassword1_TextChanged;
            // 
            // txtconfpass2
            // 
            txtconfpass2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtconfpass2.BackColor = Color.FromArgb(134, 125, 121);
            txtconfpass2.BorderStyle = BorderStyle.None;
            txtconfpass2.Cursor = Cursors.Hand;
            txtconfpass2.Location = new Point(112, 345);
            txtconfpass2.Multiline = true;
            txtconfpass2.Name = "txtconfpass2";
            txtconfpass2.Size = new Size(239, 34);
            txtconfpass2.TabIndex = 5;
            txtconfpass2.TextChanged += txtconfpass2_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(134, 125, 121);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(112, 431);
            button1.Name = "button1";
            button1.Size = new Size(239, 29);
            button1.TabIndex = 6;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(134, 125, 121);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(181, 492);
            button2.Name = "button2";
            button2.Size = new Size(104, 31);
            button2.TabIndex = 7;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 32, 76);
            ClientSize = new Size(498, 568);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtconfpass2);
            Controls.Add(txtpassword1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtpassword1;
        private TextBox txtconfpass2;
        private Button button1;
        private Button button2;
    }
}