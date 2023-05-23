using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktika
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=ZP");
        private MySqlCommand command;
        private MySqlDataAdapter adapter;

        public Form2()
        {
            InitializeComponent();
            command = new MySqlCommand("SELECT * FROM `osnova`", connection);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dobavlenie dobavlenie = new Dobavlenie();
            dobavlenie.Show();
        }

        private void Vihod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выход выполнен успешно!");
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void Zadan1_Click(object sender, EventArgs e)
        {
            Zadan1 zadan1 = new Zadan1();
            zadan1.Show();
            
        }

        private void Zadan2_Click(object sender, EventArgs e)
        {

            Zadan2 zadan2 = new Zadan2();
            zadan2.Show();
        }

        private void Zadan3_Click(object sender, EventArgs e)
        {
            Zadan3 zadan3 = new Zadan3();
            zadan3.Show();

        } 
        private void Zadan4_Click(object sender, EventArgs e)
        {
            Zadan4 zadan4 = new Zadan4();
            zadan4.Show();
        }
        private void Zadan5_Click(object sender, EventArgs e)
        {
            Zadan5 zadan5 = new Zadan5();
            zadan5.Show();
        }
        private void Zadan6_Click(object sender, EventArgs e)
        {
            Zadan6 zadan6 = new Zadan6();
            zadan6.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Udal_Click(object sender, EventArgs e)
        {
            Udal Udal = new Udal();
            Udal.Show();
        }
    
    }
}
