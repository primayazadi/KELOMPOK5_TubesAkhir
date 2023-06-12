using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace tubesAKHIR_Kelompok5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Wellcome_Label_Click(object sender, EventArgs e)
        {

        }

        public void Clear_Button_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        public void Login_Button_Click(object sender, EventArgs e)
        {
            string file = "User.json";
            string json = File.ReadAllText(file);
            List<Users> users = JsonConvert.DeserializeObject<List<Users>>(json);
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            bool isAuthenticated = false;

            foreach (Users user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    isAuthenticated = true;
                    break;
                }
            }


            String userS = UsernameTextBox.Text;
            String userBawa = UsernameTextBox.Text;
            if (isAuthenticated)
            {
                
                MessageBox.Show("Login berhasil!");
                Dashboard i = new Dashboard();
                i.Show();
                i.userrr(userBawa);
                i.userrr(userS);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }

           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Username_Label_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regis P = new Regis();
            P.Show();
            this.Hide();
        }
    }

}