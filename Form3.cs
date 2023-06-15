using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tubesAKHIR_prima.Libs;

namespace tubesAKHIR_prima
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //income
            string jsonFilePath = "Income-data.json";
            //expand
            string jsonFilePath2 = "Expend-data.json";


            string jsonContent = File.ReadAllText(jsonFilePath);
            string jsonContent2 = File.ReadAllText(jsonFilePath2);
            var trx = JsonConvert.DeserializeObject<Transaction>(jsonContent);
            var trx2 = JsonConvert.DeserializeObject<Transaction>(jsonContent2);
            int income = Convert.ToInt32(trx.trxTotal);
            int expanse = Convert.ToInt32(trx2.trxTotal);
            int total = income - expanse;
            textBox1.Text = "rp." + income.ToString("N");
            textBox2.Text = "rp." + expanse.ToString("N");
            textBox3.Text = "rp." + total.ToString("N");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard k = new Dashboard();
            k.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
