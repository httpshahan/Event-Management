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
    public partial class EventMange : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public EventMange()
        {
            InitializeComponent();
            showEvents();
            GetVenue();
            GetCustomer();
        }

        private void showEvents()
        {
            connector.OpenConnection();
            string query = "SELECT * from eventtbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connector.connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            eventDGV.DataSource = ds.Tables[0];
            connector.CloseConnection();
        }
        private void clear()
        {
            Ename.Text = "";
            ECname.Text = "";
            EVname.Text = "";
            Eduration.Text = "";
            Estatus.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVenue_Click(object sender, EventArgs e)
        {
            Venues venues = new Venues();
            venues.Show();
            this.Hide();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void GetCustomer()
        {
            connector.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT CustId  FROM customer", connector.connection);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(Rdr);
            ECid.ValueMember = "CustID";
            ECid.DataSource = dt;
            connector.CloseConnection();

        }

        private void getCustomerName()
        {
            connector.OpenConnection();
            string Query = "SELECT * from customer WHERE CustId = " + ECid.SelectedValue.ToString() + "";
            MySqlCommand cmd = new MySqlCommand(Query, connector.connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ECname.Text = dr["CustName"].ToString();
            }
            connector.CloseConnection();
        }
        private void GetVenue()
        {
            connector.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT VenueId  FROM venuetbl", connector.connection);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("VenueId", typeof(int));
            dt.Load(Rdr);
            EVid.ValueMember = "VenueId";
            EVid.DataSource = dt;
            connector.CloseConnection();
        }

        private void getVenueName()
        {
            connector.OpenConnection();
            string Query = "SELECT * from venuetbl WHERE VenueId = " + EVid.SelectedValue.ToString() + "";
            MySqlCommand cmd = new MySqlCommand(Query, connector.connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EVname.Text = dr["VName"].ToString();
            }
            connector.CloseConnection();
        }

        private void EVid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getVenueName();
        }

        private void ECid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getCustomerName();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ename.Text == ""
                || EVname.Text == ""
                || ECname.Text == ""
                || Eduration.Text == ""
                || Estatus.SelectedIndex == -1)
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                connector.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT into eventtbl(EvName,EvDate,VenueId,EvVenue,EvDurartion,EvCustId,EvCustName,EvStatus) " +
                                                     "VALUES(@en,@evd,@evId,@ev,@ed,@ecId,@ec,@es)", connector.connection);
                cmd.Parameters.AddWithValue("@en", Ename.Text);
                cmd.Parameters.AddWithValue("@evd", EDatenTime.Value.Date);
                cmd.Parameters.AddWithValue("@evId", EVid.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ev", EVname.Text);
                cmd.Parameters.AddWithValue("@ed", Eduration.Text);
                cmd.Parameters.AddWithValue("@ecId", ECid.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ec", ECname.Text);
                cmd.Parameters.AddWithValue("@es", Estatus.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event Added");
                connector.CloseConnection();
                showEvents();
                clear();
            }
        }
        int key = 0;

        private void eventDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eventDGV.CurrentRow.Selected = true;
            Ename.Text = eventDGV.CurrentRow.Cells[1].Value.ToString();
            EDatenTime.Text = eventDGV.CurrentRow.Cells[2].Value.ToString();
            EVid.SelectedValue = eventDGV.CurrentRow.Cells[3].Value.ToString();
            EVname.Text = eventDGV.CurrentRow.Cells[4].Value.ToString();
            Eduration.Text = eventDGV.CurrentRow.Cells[5].Value.ToString();
            ECid.SelectedValue = eventDGV.CurrentRow.Cells[6].Value.ToString();
            ECname.Text = eventDGV.CurrentRow.Cells[7].Value.ToString();
            Estatus.SelectedItem = eventDGV.CurrentRow.Cells[8].Value.ToString();

            if (Ename.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(eventDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select an Event");
            }
            else
            {
                connector.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE eventtbl SET EvName =@en,EvDate=@evd,VenueId=@evId,EvVenue=@ev,EvDurartion=@ed,EvCustId=@ecId,EvCustName=@ec,EvStatus=@es WHERE EvId = @key", connector.connection);
                cmd.Parameters.AddWithValue("@en", Ename.Text);
                cmd.Parameters.AddWithValue("@evd", EDatenTime.Value.Date);
                cmd.Parameters.AddWithValue("@evId", EVid.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ev", EVname.Text);
                cmd.Parameters.AddWithValue("@ed", Eduration.Text);
                cmd.Parameters.AddWithValue("@ecId", ECid.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ec", ECname.Text);
                cmd.Parameters.AddWithValue("@es", Estatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@key", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event Updated");
                connector.CloseConnection();
                showEvents();
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
                MySqlCommand cmd = new MySqlCommand("DELETE from eventtbl where EvId = @Eid", connector.connection);
                cmd.Parameters.AddWithValue("@Eid", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event Deleted");
                connector.CloseConnection();
                showEvents();
                clear();
            }
        }


    }
}
