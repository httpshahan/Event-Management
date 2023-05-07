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
using System.Xml.Linq;

namespace EventManagement
{
    public partial class Customers : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public Customers()
        {
            InitializeComponent();
            showCustomers();
        }
        private void showCustomers()
        {
            connector.OpenConnection();
            string query = "SELECT * from customer";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connector.connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            custDGV.DataSource = ds.Tables[0];
            connector.CloseConnection();
        }
        private void clear()
        {
            CustName.Text = "";
            CustPhone.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            Venues venues = new Venues();
            venues.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            EventMange eventMange = new EventMange();
            eventMange.Show();
            this.Hide();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CustName.Text == "" || CustPhone.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                connector.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT into customer(CustName,CustPhone) VALUES(@cn,@cp)", connector.connection);
                cmd.Parameters.AddWithValue("@cn", CustName.Text);
                cmd.Parameters.AddWithValue("@cp", CustPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added");
                connector.CloseConnection();
                showCustomers();
                clear();
            }
        }
        int key = 0;
        private void custDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            custDGV.CurrentRow.Selected = true;
            CustName.Text = custDGV.CurrentRow.Cells[1].Value.ToString();
            CustPhone.Text = custDGV.CurrentRow.Cells[2].Value.ToString();


            if (CustName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(custDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Row");
            }
            else
            {
                connector.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE from customer where CustId = @Cid", connector.connection);
                cmd.Parameters.AddWithValue("@Cid", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted");
                connector.CloseConnection();
                showCustomers();
                clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Row");
            }
            else
            {
                connector.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE customer SET CustName = @cn,CustPhone = @cp WHERE CustId = @cid", connector.connection);
                cmd.Parameters.AddWithValue("@cn", CustName.Text);
                cmd.Parameters.AddWithValue("@cp", CustPhone.Text);
                cmd.Parameters.AddWithValue("@cid", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Updated");
                connector.CloseConnection();
                showCustomers();
                clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
