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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace EventManagement
{
    public partial class feedback : Form
    {

        MySqlConnector connector = new MySqlConnector();
        public feedback()
        {
            InitializeComponent();
            showFeedBacks();
            getEvent();
        }

        private void showFeedBacks()
        {
            connector.OpenConnection();
            string query = "SELECT * from feedback";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connector.connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            fbDGV.DataSource = ds.Tables[0];
            connector.CloseConnection();
        }
        private void clear()
        {
            Ename.Text = "";
            fbHost.SelectedIndex = -1;
            fbVenue.SelectedIndex = -1;
            fbPunc.SelectedIndex = -1;
        }

        private void getEvent()
        {
            connector.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT EvId  FROM eventtbl", connector.connection);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EvId", typeof(int));
            dt.Load(Rdr);
            EVid.ValueMember = "EvId";
            EVid.DataSource = dt;
            connector.CloseConnection();

        }

        private void getEventName()
        {
            connector.OpenConnection();
            string Query = "SELECT * from eventtbl WHERE EvId = " + EVid.SelectedValue.ToString() + "";
            MySqlCommand cmd = new MySqlCommand(Query, connector.connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Ename.Text = dr["EvName"].ToString();
            }
            connector.CloseConnection();
        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }

        private void EVid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getEventName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ename.Text == ""
                || fbHost.SelectedIndex == -1
                || fbPunc.SelectedIndex == -1
                || fbVenue.SelectedIndex == -1)
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                connector.OpenConnection();
                int Avrall = (fbHost.SelectedIndex + fbPunc.SelectedIndex + fbVenue.SelectedIndex + 3) / 3;
                MySqlCommand cmd = new MySqlCommand("INSERT into feedback(EventId,EventName,Venue,Hospatality,Pucntuality,Overall) " +
                                                     "VALUES(@eid,@en,@v,@h,@p,@o)", connector.connection);
                cmd.Parameters.AddWithValue("@eid", EVid.Text);
                cmd.Parameters.AddWithValue("@en", Ename.Text);
                cmd.Parameters.AddWithValue("@v", fbVenue.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@h", fbHost.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@p", fbPunc.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@o", Avrall);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event Added");
                connector.CloseConnection();
                showFeedBacks();
                clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Venues venues = new Venues();
            venues.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
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
