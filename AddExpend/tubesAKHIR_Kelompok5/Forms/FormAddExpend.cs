using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using tubesAKHIR_Kelompok5.Libs;

namespace tubesAKHIR_Kelompok5.Forms
{
    public partial class FormAddExpend : Form
    {
        public FormAddExpend()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            tbNamaBarang.Text = string.Empty;
            tbJumlah.Text = "0";
            tbHargaSatuan.Text = "0";
        }

        private void insertItem()
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = dateTimePicker1.Value.ToString();
            row.Cells[1].Value = userName;
            row.Cells[2].Value = tbNamaBarang.Text;
            row.Cells[3].Value = tbHargaSatuan.Text;
            row.Cells[4].Value = tbJumlah.Text;
            row.Cells[5].Value = double.Parse(tbJumlah.Text) * double.Parse(tbHargaSatuan.Text);
            dataGridView1.Rows.Add(row);
            // hitung total trasaction
            // lblTotalTrx.Tag = double.Parse(lblTotalTrx.Tag.ToString()) + double.Parse(row.Cells[5].Value.ToString());
            this.totalTransaction = this.totalTransaction + double.Parse(row.Cells[5].Value.ToString());
            lblTotalTrx.Text = this.totalTransaction.ToString("#,###");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.insertItem();
            this.clearBarang();
            tbNamaBarang.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Transaction trxObj = createTransactionObject();
            string jsonString = trxObj.createJson();
            saveJsonToFile(jsonString);
            clearDataGridView();
            clearBarang();
            MessageBox.Show("Data berhasil di simpan");
        }

        private void clearDataGridView()
        {
            dataGridView1.Rows.Clear();
            lblTotalTrx.Text = "0";
        }

        public void saveJsonToFile(string jsonString)
        {
            string path = @"C:\Users\Lenovo\Downloads\tubesAKHIR_Kelompok5\expend-data.json";
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
        private Transaction createTransactionObject()
        {
            Transaction trx = new Transaction();
            trx.trxId = userName + DateTime.Now.ToString("_ddMMyyyyHHmmss");
            trx.trxType = "expend";
            trx.data = new List<Item>();
            trx.trxTotal = this.totalTransaction.ToString();

            DataGridViewRowCollection rows = dataGridView1.Rows;
            for (int j = 0; j < rows.Count - 1; j++)
            {
                // MessageBox.Show(rows[j].Cells[2].Value.ToString());
                DataGridViewRow r = rows[j];
                Item item = new Item();
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.rowIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void FormAddExpend_Load(object sender, EventArgs e)
        {
            lblUsername.Text = this.userName;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //MessageBox.Show("Delete");
            this.totalTransaction = calculateTotalTransaction();
            lblTotalTrx.Text = this.totalTransaction.ToString("#,###");

        }

        private int rowIndex
        {
            get; set;
        }

        public string userName
        {
            get; set;
        }

        private double totalTransaction
        {
            get; set;
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
    }
}
