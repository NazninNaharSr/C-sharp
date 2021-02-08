using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class Available_Room : Form
    {
        //string ConnectionString = "data source = DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = True";
        public Available_Room()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Admin_Home ah = new Admin_Home();
            ah.Show();
            this.Hide();
        }

        private void Available_Room_Load(object sender, EventArgs e)
        {
           // PopulateComboBox();
        }
       /* void PopulateComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AvailableRoom", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Room_Type.ValueMember = "Room_No";
                Room_Type.DisplayMember = "Room_Type";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "Select";
                dtbl.Rows.InsertAt(topItem, 0);
                Room_Type.DataSource = dtbl;
            }
        }*/

        private void showButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            SqlCommand command = new SqlCommand("SELECT * FROM AvailableRoom", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            dataGridView1.DataSource = source;
            con.Close();
        }
    }
}
