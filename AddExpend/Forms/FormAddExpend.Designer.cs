namespace tubesAKHIR_Kelompok5.Forms
{
    partial class FormAddExpend
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
            lblNamaBarang = new Label();
            tbNamaBarang = new TextBox();
            tbHargaSatuan = new TextBox();
            label1 = new Label();
            tbJumlah = new TextBox();
            label2 = new Label();
            lblUsername = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            tgl = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            nmBrg = new DataGridViewTextBoxColumn();
            hrgSat = new DataGridViewTextBoxColumn();
            jml = new DataGridViewTextBoxColumn();
            totalExp = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            lblTotalName = new Label();
            lblTotalTrx = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNamaBarang
            // 
            lblNamaBarang.AutoSize = true;
            lblNamaBarang.Location = new Point(214, 69);
            lblNamaBarang.Name = "lblNamaBarang";
            lblNamaBarang.Size = new Size(83, 20);
            lblNamaBarang.TabIndex = 0;
            lblNamaBarang.Text = "Nama Item";
            // 
            // tbNamaBarang
            // 
            tbNamaBarang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNamaBarang.CharacterCasing = CharacterCasing.Upper;
            tbNamaBarang.Location = new Point(214, 92);
            tbNamaBarang.Name = "tbNamaBarang";
            tbNamaBarang.Size = new Size(797, 27);
            tbNamaBarang.TabIndex = 1;
            // 
            // tbHargaSatuan
            // 
            tbHargaSatuan.Location = new Point(214, 153);
            tbHargaSatuan.Name = "tbHargaSatuan";
            tbHargaSatuan.Size = new Size(286, 27);
            tbHargaSatuan.TabIndex = 3;
            tbHargaSatuan.TextChanged += textBox1_TextChanged;
            tbHargaSatuan.KeyPress += tbHargaSatuan_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 131);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Harga Satuan";
            label1.Click += label1_Click;
            // 
            // tbJumlah
            // 
            tbJumlah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbJumlah.Location = new Point(506, 153);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.Size = new Size(505, 27);
            tbJumlah.TabIndex = 5;
            tbJumlah.KeyPress += tbJumlah_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 131);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Jumlah Item";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(9, 131);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(176, 37);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "No Name";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 16);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 8;
            label4.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(565, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(915, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.TabStop = false;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(9, 507);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "&Save";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tgl, user, nmBrg, hrgSat, jml, totalExp });
            dataGridView1.Location = new Point(11, 251);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(999, 249);
            dataGridView1.TabIndex = 13;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // tgl
            // 
            tgl.HeaderText = "Tanggal";
            tgl.MinimumWidth = 6;
            tgl.Name = "tgl";
            tgl.Width = 125;
            // 
            // user
            // 
            user.HeaderText = "Username";
            user.MinimumWidth = 6;
            user.Name = "user";
            user.Width = 125;
            // 
            // nmBrg
            // 
            nmBrg.HeaderText = "Nama Item";
            nmBrg.MinimumWidth = 6;
            nmBrg.Name = "nmBrg";
            nmBrg.Width = 300;
            // 
            // hrgSat
            // 
            hrgSat.HeaderText = "Harga Satuan";
            hrgSat.MinimumWidth = 6;
            hrgSat.Name = "hrgSat";
            hrgSat.Width = 125;
            // 
            // jml
            // 
            jml.HeaderText = "Jumlah Item";
            jml.MinimumWidth = 6;
            jml.Name = "jml";
            jml.Width = 125;
            // 
            // totalExp
            // 
            totalExp.HeaderText = "Total Expend";
            totalExp.MinimumWidth = 6;
            totalExp.Name = "totalExp";
            totalExp.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(795, 197);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kpl;
            pictureBox1.Location = new Point(55, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblTotalName
            // 
            lblTotalName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalName.Location = new Point(668, 503);
            lblTotalName.Name = "lblTotalName";
            lblTotalName.Size = new Size(94, 37);
            lblTotalName.TabIndex = 16;
            lblTotalName.Text = "Total (Rp.) :";
            lblTotalName.TextAlign = ContentAlignment.MiddleLeft;
            lblTotalName.Click += label3_Click_1;
            // 
            // lblTotalTrx
            // 
            lblTotalTrx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalTrx.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotalTrx.Location = new Point(774, 503);
            lblTotalTrx.Name = "lblTotalTrx";
            lblTotalTrx.Size = new Size(222, 37);
            lblTotalTrx.TabIndex = 17;
            lblTotalTrx.Tag = "0";
            lblTotalTrx.Text = "0";
            lblTotalTrx.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormAddExpend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 582);
            Controls.Add(lblTotalTrx);
            Controls.Add(lblTotalName);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(lblUsername);
            Controls.Add(tbJumlah);
            Controls.Add(label2);
            Controls.Add(tbHargaSatuan);
            Controls.Add(label1);
            Controls.Add(tbNamaBarang);
            Controls.Add(lblNamaBarang);
            Name = "FormAddExpend";
            Text = "Add Expend";
            Load += FormAddExpend_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaBarang;
        private TextBox tbNamaBarang;
        private TextBox tbHargaSatuan;
        private Label label1;
        private TextBox tbJumlah;
        private Label label2;
        private Label lblUsername;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn tgl;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn nmBrg;
        private DataGridViewTextBoxColumn hrgSat;
        private DataGridViewTextBoxColumn jml;
        private DataGridViewTextBoxColumn totalExp;
        internal protected Button btnCancel;
        private Label lblTotalName;
        private Label lblTotalTrx;
    }
}