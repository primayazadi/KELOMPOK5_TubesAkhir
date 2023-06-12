namespace tubesAKHIR_Kelompok5
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Username_Label = new Label();
            Password_label = new Label();
            UsernameTextBox = new TextBox();
            Login_Button = new Button();
            Clear_Button = new Button();
            Wellcome_Label = new Label();
            checkBox1 = new CheckBox();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.BackColor = SystemColors.ActiveCaptionText;
            Username_Label.ForeColor = SystemColors.Control;
            Username_Label.Location = new Point(496, 256);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(91, 25);
            Username_Label.TabIndex = 0;
            Username_Label.Text = "Username";
            Username_Label.Click += Username_Label_Click;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.BackColor = SystemColors.ActiveCaptionText;
            Password_label.ForeColor = SystemColors.Control;
            Password_label.Location = new Point(496, 316);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(87, 25);
            Password_label.TabIndex = 1;
            Password_label.Text = "Password";
            Password_label.Click += Password_label_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(644, 256);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(274, 31);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(784, 385);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(80, 36);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Clear_Button
            // 
            Clear_Button.Location = new Point(653, 385);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(80, 36);
            Clear_Button.TabIndex = 5;
            Clear_Button.Text = "Clear";
            Clear_Button.UseVisualStyleBackColor = true;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // Wellcome_Label
            // 
            Wellcome_Label.AutoSize = true;
            Wellcome_Label.FlatStyle = FlatStyle.System;
            Wellcome_Label.Font = new Font("MV Boli", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Wellcome_Label.ForeColor = SystemColors.ButtonFace;
            Wellcome_Label.Location = new Point(605, 158);
            Wellcome_Label.Name = "Wellcome_Label";
            Wellcome_Label.Size = new Size(313, 37);
            Wellcome_Label.TabIndex = 6;
            Wellcome_Label.Text = "Wellcome To Wspend";
            Wellcome_Label.Click += Wellcome_Label_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(644, 353);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(644, 310);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(274, 31);
            PasswordTextBox.TabIndex = 8;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(841, 441);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(981, 640);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(checkBox1);
            Controls.Add(Wellcome_Label);
            Controls.Add(Clear_Button);
            Controls.Add(Login_Button);
            Controls.Add(UsernameTextBox);
            Controls.Add(Password_label);
            Controls.Add(Username_Label);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            Text = "login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username_Label;
        private Label Password_label;
        private TextBox UsernameTextBox;
        private Button Login_Button;
        private Button Clear_Button;
        private Label Wellcome_Label;
        private CheckBox checkBox1;
        private TextBox PasswordTextBox;
        private Button button1;
    }
}