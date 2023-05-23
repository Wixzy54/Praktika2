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
    public partial class Zadan5 : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=ZP");
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        public Zadan5()
        {
            InitializeComponent();
            command = new MySqlCommand("SELECT `Фамилия`,`Отдел`,`Должность`,`Стаж работы, лет` FROM osnova WHERE `Стаж работы, лет` BETWEEN 5 AND 10;", connection);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Zadan5_Load(object sender, EventArgs e)
        {

        }
    }
}
