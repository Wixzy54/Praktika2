using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktika
{
    public partial class Zadan1 : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=ZP");
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        public Zadan1()
        {
            InitializeComponent();
            command = new MySqlCommand("SELECT `Начисленная зарплата, руб` FROM `ZP`.`osnova`", connection);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Zadan1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
