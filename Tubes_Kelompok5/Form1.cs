using System.Transactions;

namespace Tubes_Kelompok5
{
    public partial class FormAddIncome : Form
    {
        public FormAddIncome()
        {
            InitializeComponent();
        }
        private void tbHargaSatuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //   MessageBox.Show(e.);
            //  e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void clearBarang()
        {
            textBox1.Text = string.Empty;
            textBox3.Text = "0";
            textBox2.Text = "0";
        }
        private void insertItem()
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = dateTimePicker1.Value.ToString();
            row.Cells[1].Value = userName;
            row.Cells[2].Value = textBox1.Text;
            row.Cells[3].Value = textBox2.Text;
            row.Cells[4].Value = textBox3.Text;
            row.Cells[5].Value = double.Parse(textBox3.Text) * double.Parse(textBox2.Text);
            dataGridView1.Rows.Add(row);
            // hitung total trasaction
            totalTransaksi = (totalTransaksi) + double.Parse(row.Cells[5].Value.ToString());
            label6.Text = totalTransaksi.ToString("#,###");
        }
        private double totalTransaksi
        {
            get; set;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.insertItem();
            this.clearBarang();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                double itemTotal = double.Parse(selectedRow.Cells[5].Value.ToString());

                dataGridView1.Rows.RemoveAt(selectedRow.Index);

                // Kurangi total transaksi
                totalTransaksi -= itemTotal;
                label6.Text = totalTransaksi.ToString("#,###");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Libs.Transaction trxObj = createTransactionObject();
            string jsonString = trxObj.createJson();
            saveJsonToFile(jsonString);
            clearDataGridView();
            clearBarang();
            MessageBox.Show("Data berhasil di simpan");
        }
        private void clearDataGridView()
        {
            dataGridView1.Rows.Clear();
            label6.Text = "0";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = this.userName;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private int rowIndex
        {
            get; set;
        }

        public string userName
        {
            get; set;
        }

        public void saveJsonToFile(string jsonString)
        {
            string path = @"C:\Users\asus\Documents\TUGAS ADEK\SEMESTER 4\KPL\Tubes_Kelompok5\income-data.json";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(jsonString);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("," + jsonString);
                }
            }
        }
        private Libs.Transaction createTransactionObject()
        {
            //Transaction trx = new Transaction();
            Tubes_Kelompok5.Libs.Transaction trx = new Libs.Transaction();
            trx.trxId = userName + DateTime.Now.ToString("_ddMMyyyyHHmmss");
            trx.trxType = "Income";
            trx.data = new List<Libs.Item>();
            trx.trxTotal = totalTransaksi.ToString();

            DataGridViewRowCollection rows = dataGridView1.Rows;
            for (int j = 0; j < rows.Count - 1; j++)
            {
                // MessageBox.Show(rows[j].Cells[2].Value.ToString());
                DataGridViewRow r = rows[j];
                Libs.Item item = new Libs.Item();
                item.tanggal = r.Cells[0].Value.ToString();
                item.username = r.Cells[1].Value.ToString();
                item.nama = r.Cells[2].Value.ToString();
                item.harga = r.Cells[3].Value.ToString();
                item.jumlah = r.Cells[4].Value.ToString();
                item.total = r.Cells[5].Value.ToString();
                trx.data.Add(item);
            }
            return trx;
        }

        private void pictureBox1_SizeModeChanged(object sender, EventArgs e)
        {

        }

        private void FormAddIncome_Load(object sender, EventArgs e)
        {
            label7.Text = this.userName;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //MessageBox.Show("Delete");
            this.totalTransaksi = calculateTotalTransaction();
            label6.Text = this.totalTransaksi.ToString("#,###");

        }
        private double calculateTotalTransaction()
        {
            double total = 0;
            DataGridViewRowCollection rows = dataGridView1.Rows;
            for (int j = 0; j < rows.Count - 1; j++)
            {
                DataGridViewRow r = rows[j];
                total += double.Parse(r.Cells[5].Value.ToString());
            }
            return total;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.rowIndex = e.RowIndex;
        }
    }
}