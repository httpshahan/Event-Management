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

namespace EventManagement
{
    public partial class Venues : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public Venues()
        {
            InitializeComponent();
            showVenues();
        }

        private void showVenues()
        {
            connector.OpenConnection();
            string query = "SELECT * from venuetbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connector.connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VenueDGV.DataSource = ds.Tables[0];
            connector.CloseConnection();
        }
        private void clear()
        {
            VnName.Text = "";
            VnCapacity.Text = "";
            VnAddress.Text = "";
            VnManager.Text = "";
            VnMphone.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            EventMange eventMange = new EventMange();
            eventMange.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (VnName.Text == "" || VnAddress.Text == "" || VnCapacity.Text == "" || VnManager.Text == "" || VnMphone.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                connector.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT into venuetbl(VName,VCapacity,VAddress,VManager,VPhone) VALUES(@vn,@vc,@va,@vm,@vp)", connector.connection);
                cmd.Parameters.AddWithValue("@vn", VnName.Text);
                cmd.Parameters.AddWithValue("@vc", VnCapacity.Text);
                cmd.Parameters.AddWithValue("@va", VnAddress.Text);
                cmd.Parameters.AddWithValue("@vm", VnManager.Text);
                cmd.Parameters.AddWithValue("@vp", VnMphone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venue Added");
                connector.CloseConnection();
                showVenues();
                clear();
            }
        }
        int key = 0;
        private void VenueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VenueDGV.CurrentRow.Selected = true;
            VnName.Text = VenueDGV.CurrentRow.Cells[1].Value.ToString();
            VnCapacity.Text = VenueDGV.CurrentRow.Cells[2].Value.ToString();
            VnAddress.Text = VenueDGV.CurrentRow.Cells[3].Value.ToString();
            VnManager.Text = VenueDGV.CurrentRow.Cells[4].Value.ToString();
            VnMphone.Text = VenueDGV.CurrentRow.Cells[5].Value.ToString();

            if (VnName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(VenueDGV.CurrentRow.Cells[0].Value.ToString());
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
                MySqlCommand cmd = new MySqlCommand("UPDATE venuetbl SET VName = @vn ,VCapacity = @vc,VAddress = @VA,VManager = @vm,VPhone = @vp WHERE VenueId = @vid", connector.connection);
                cmd.Parameters.AddWithValue("@vn", VnName.Text);
                cmd.Parameters.AddWithValue("@vc", VnCapacity.Text);
                cmd.Parameters.AddWithValue("@va", VnAddress.Text);
                cmd.Parameters.AddWithValue("@vm", VnManager.Text);
                cmd.Parameters.AddWithValue("@vp", VnMphone.Text);
                cmd.Parameters.AddWithValue("@vid", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venue Updated");
                connector.CloseConnection();
                showVenues();
                clear();
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
                MySqlCommand cmd = new MySqlCommand("DELETE from venuetbl where VenueId = @vid", connector.connection);
                cmd.Parameters.AddWithValue("@vid", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venue Deleted");
                connector.CloseConnection();
                showVenues();
                clear();
            }

        }
    }
}
