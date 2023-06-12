namespace tubesAKHIR_Kelompok5
{
    partial class Regis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regis));
            pictureBox1 = new PictureBox();
            PassworddTextBox = new TextBox();
            UsernameeTextBox = new TextBox();
            Passwordd_label = new Label();
            Usernamee_Label = new Label();
            RegisterButton = new Button();
            button1 = new Button();
            label1 = new Label();
            Wellcome_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(557, 527);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PassworddTextBox
            // 
            PassworddTextBox.Location = new Point(645, 227);
            PassworddTextBox.Name = "PassworddTextBox";
            PassworddTextBox.Size = new Size(274, 31);
            PassworddTextBox.TabIndex = 12;
            PassworddTextBox.UseSystemPasswordChar = true;
            PassworddTextBox.TextChanged += PassworddTextBox_TextChanged;
            // 
            // UsernameeTextBox
            // 
            UsernameeTextBox.Location = new Point(645, 147);
            UsernameeTextBox.Name = "UsernameeTextBox";
            UsernameeTextBox.Size = new Size(274, 31);
            UsernameeTextBox.TabIndex = 11;
            UsernameeTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // Passwordd_label
            // 
            Passwordd_label.AutoSize = true;
            Passwordd_label.BackColor = SystemColors.ActiveCaptionText;
            Passwordd_label.ForeColor = SystemColors.Control;
            Passwordd_label.Location = new Point(645, 197);
            Passwordd_label.Name = "Passwordd_label";
            Passwordd_label.Size = new Size(172, 25);
            Passwordd_label.TabIndex = 10;
            Passwordd_label.Text = "Enter Your Password";
            Passwordd_label.Click += Passwordd_label_Click;
            // 
            // Usernamee_Label
            // 
            Usernamee_Label.AutoSize = true;
            Usernamee_Label.BackColor = SystemColors.ActiveCaptionText;
            Usernamee_Label.ForeColor = SystemColors.Control;
            Usernamee_Label.Location = new Point(645, 117);
            Usernamee_Label.Name = "Usernamee_Label";
            Usernamee_Label.Size = new Size(176, 25);
            Usernamee_Label.TabIndex = 9;
            Usernamee_Label.Text = "Enter Your Username";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(711, 294);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(155, 42);
            RegisterButton.TabIndex = 13;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(784, 470);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Login Here";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(579, 475);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 15;
            label1.Text = "Already Have Account?";
            // 
            // Wellcome_Label
            // 
            Wellcome_Label.AutoSize = true;
            Wellcome_Label.FlatStyle = FlatStyle.System;
            Wellcome_Label.Font = new Font("MV Boli", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Wellcome_Label.ForeColor = SystemColors.ButtonFace;
            Wellcome_Label.Location = new Point(632, 51);
            Wellcome_Label.Name = "Wellcome_Label";
            Wellcome_Label.Size = new Size(313, 37);
            Wellcome_Label.TabIndex = 16;
            Wellcome_Label.Text = "Wellcome To Wspend";
            Wellcome_Label.Click += Wellcome_Label_Click;
            // 
            // Regis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(991, 601);
            Controls.Add(Wellcome_Label);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(RegisterButton);
            Controls.Add(PassworddTextBox);
            Controls.Add(UsernameeTextBox);
            Controls.Add(Passwordd_label);
            Controls.Add(Usernamee_Label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Regis";
            Text = "Regis";
            Load += Regis_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox PassworddTextBox;
        private TextBox UsernameeTextBox;
        private Label Passwordd_label;
        private Label Usernamee_Label;
        private Button RegisterButton;
        private Button button1;
        private Label label1;
        private Label Wellcome_Label;
    }
}