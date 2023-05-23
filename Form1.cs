using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Form1 : Form
    {
        public static MySql.Data.MySqlClient.MySqlConnection Connection;

        public Form1()
        {
            InitializeComponent();
            try
            {
                Connection = new MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=ZP");
                Connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private bool ValidateUser(string username, string password)
        {
            string connectionString = "server=localhost;user=root;password=;database=ZP";
            using (Connection = new MySqlConnection(connectionString))
            {
                Connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND role = 'user'";
                if (username == "w")
                {
                    query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND role = 'admin'";
                }

                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (ValidateUser(username, password))
            {
                MessageBox.Show("Вход выполнен успешно!");
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }   
        }
    }
}
