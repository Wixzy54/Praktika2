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
    public partial class Dobavlenie : Form
    {
        MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter;
        public Dobavlenie()
        {
            InitializeComponent();
        }

        private void Dobavlenie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(string.Format("INSERT INTO ZP VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6},{7},{8},{9});",
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                double.Parse(textBox5.Text) * double.Parse(textBox6.Text),
                int.Parse(textBox5.Text) * int.Parse(textBox6.Text) * 0.13,
                int.Parse(textBox5.Text) * int.Parse(textBox6.Text) * 0.01,
                int.Parse(textBox5.Text) * int.Parse(textBox6.Text) + int.Parse(textBox5.Text) * int.Parse(textBox6.Text) * 0.13), Form1.Connection);

            try
            {
                mySqlDataAdapter.Fill(dataTable);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.Show();
            this.Close();
        }
    }
}
