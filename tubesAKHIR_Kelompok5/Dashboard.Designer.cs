namespace tubesAKHIR_Kelompok5
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AddIncomeButton = new Button();
            pictureBox3 = new PictureBox();
            AddExpendButton = new Button();
            pictureBox4 = new PictureBox();
            ViewReportButton = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(657, -119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 737);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // AddIncomeButton
            // 
            AddIncomeButton.BackColor = SystemColors.ActiveCaptionText;
            AddIncomeButton.ForeColor = SystemColors.ButtonHighlight;
            AddIncomeButton.Location = new Point(190, 152);
            AddIncomeButton.Name = "AddIncomeButton";
            AddIncomeButton.Size = new Size(271, 62);
            AddIncomeButton.TabIndex = 4;
            AddIncomeButton.Text = "Add Income";
            AddIncomeButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // AddExpendButton
            // 
            AddExpendButton.BackColor = SystemColors.ActiveCaptionText;
            AddExpendButton.ForeColor = SystemColors.ButtonHighlight;
            AddExpendButton.Location = new Point(193, 311);
            AddExpendButton.Name = "AddExpendButton";
            AddExpendButton.Size = new Size(268, 60);
            AddExpendButton.TabIndex = 6;
            AddExpendButton.Text = "AddExpend";
            AddExpendButton.UseVisualStyleBackColor = false;
            AddExpendButton.Click += AddExpendButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 408);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // ViewReportButton
            // 
            ViewReportButton.BackColor = SystemColors.ActiveCaptionText;
            ViewReportButton.ForeColor = SystemColors.ButtonHighlight;
            ViewReportButton.Location = new Point(190, 463);
            ViewReportButton.Name = "ViewReportButton";
            ViewReportButton.Size = new Size(263, 65);
            ViewReportButton.TabIndex = 8;
            ViewReportButton.Text = "View Report";
            ViewReportButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(515, 562);
            button1.Name = "button1";
            button1.Size = new Size(136, 40);
            button1.TabIndex = 10;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 11;
            label1.Text = "HALLO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(114, 4);
            label2.Name = "label2";
            label2.Size = new Size(73, 36);
            label2.TabIndex = 12;
            label2.Text = "User";
            label2.Click += label2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(986, 614);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ViewReportButton);
            Controls.Add(pictureBox4);
            Controls.Add(AddExpendButton);
            Controls.Add(pictureBox3);
            Controls.Add(AddIncomeButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button AddIncomeButton;
        private PictureBox pictureBox3;
        private Button AddExpendButton;
        private PictureBox pictureBox4;
        private Button ViewReportButton;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}