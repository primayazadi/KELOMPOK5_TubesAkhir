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
using tubesAKHIR_Kelompok5;

namespace tubesAKHIR_Kelompok5
{
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usernamee_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regis_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PassworddTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void Passwordd_label_Click(object sender, EventArgs e)
        {

        }

        private void RegisterTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Wellcome_Label_Click(object sender, EventArgs e)
        {

        }
        public enum RegistrationRuleType
        {
            UsernameNotEmpty,
            PasswordNotEmpty,
            
        }

        List<RegistrationRule> registrationRules = new List<RegistrationRule>()
        {
            new RegistrationRule()
            {
            RuleType = RegistrationRuleType.UsernameNotEmpty,
            Validation = user => !string.IsNullOrEmpty(user.Username),
            Process = user => MessageBox.Show("Username harus diisi.")
            },
            new RegistrationRule()
            {
            RuleType = RegistrationRuleType.PasswordNotEmpty,
            Validation = user => !string.IsNullOrEmpty(user.Password),
            Process = user => MessageBox.Show("Password harus diisi.")
            }

        };

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string file = "user.json";
            List<Users> users = new List<Users>();

            // Baca file JSON jika sudah ada
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                users = JsonConvert.DeserializeObject<List<Users>>(json);
            }

            // Buat objek User baru dari input pengguna
            Users newUser = new Users
            {
                Username = UsernameeTextBox.Text,
                Password = PassworddTextBox.Text
            };

            // Iterasi melalui tabel data aturan validasi
            foreach (var rule in registrationRules)
            {
                if (!rule.Validation(newUser))
                {
                    rule.Process(newUser);
                    return;
                }
            }

            // Tambahkan objek User baru ke daftar pengguna
            users.Add(newUser);

            // Serialisasi daftar pengguna ke JSON
            string updatedJson = JsonConvert.SerializeObject(users);

            // Tulis data JSON ke file
            File.WriteAllText(file, updatedJson);

            MessageBox.Show("Registrasi berhasil");

            Login W = new Login();
            W.Show();
            this.Hide();
        }


    }

        

        

        
        
        
}

