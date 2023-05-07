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
using MySql.Data.MySqlClient;
using System.Collections;


namespace EventManagement
{
    public partial class dashboard : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public dashboard()
        {
            InitializeComponent();
            getVenueCount();
            getEventCount();
            getVCustomerCount();
        }

        private void getVenueCount()
        {
            connector.OpenConnection();
            string query = "SELECT COUNT(*) FROM venuetbl";
            MySqlCommand command = new MySqlCommand(query, connector.connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            veneueCount.Text = count.ToString();
            connector.CloseConnection();

        }
        private void getEventCount()
        {
            connector.OpenConnection();
            string query = "SELECT COUNT(*) FROM customer";
            MySqlCommand command = new MySqlCommand(query, connector.connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            eventCount.Text = count.ToString();
            connector.CloseConnection();

        }
        private void getVCustomerCount()
        {
            connector.OpenConnection();
            string query = "SELECT COUNT(*) FROM eventtbl";
            MySqlCommand command = new MySqlCommand(query, connector.connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            custCount.Text = count.ToString();
            connector.CloseConnection();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Venues venues = new Venues();
            venues.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            feedback feedback = new feedback();
            feedback.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EventMange eventMange = new EventMange();
            eventMange.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }
    }
}
