using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace DB1
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DB1.Properties.Settings.Database1ConnectionString"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.groupDevices' table. You can move, or remove it, as needed.
            this.groupDevicesTableAdapter.Fill(this.database1DataSet.groupDevices);
            //showtable();
        }

        //private void showtable()
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    using ( SqlDataAdapter  adapter = new SqlDataAdapter("SELECT * FROM groupDevices", connection))
        //    {
        //        DataTable devTable = new DataTable();
        //        adapter.Fill(devTable);
        //        devsList.DisplayMember = "deviceName"; 
        //        devsList.DataSource = devTable ;
        //    }
        //}

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand insertComm = new SqlCommand("INSERT INTO groupDevices (deviceName ,groupid,platenumber,citycode,modemid,IP ) VALUES (@name , @gid , @pid, @ccode, @mid, @ip)", connection))
            {
                connection.Open();
                insertComm.Parameters.Add(new SqlParameter("name", devName.Text));
                insertComm.Parameters.Add(new SqlParameter("gid", grpId.Text));
                insertComm.Parameters.Add(new SqlParameter("pid", pltNumber.Text));
                insertComm.Parameters.Add(new SqlParameter("ccode", ctyCode.Text));
                insertComm.Parameters.Add(new SqlParameter("mid", modId.Text));
                insertComm.Parameters.Add(new SqlParameter("ip", devIp.Text));
                insertComm.ExecuteScalar();
            }

            //showtable();
            this.groupDevicesTableAdapter.Fill(this.database1DataSet.groupDevices);
        }

        private void devsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupDevicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupDevicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void updateDev_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Comm = new SqlCommand("UPDATE  groupDevices SET deviceName=@name ,groupid=@gid ,platenumber=@pid,citycode=@ccode,modemid=@mid,IP=@ip WHERE deviceId=@id", connection))
            {
                connection.Open();

               // int i = Convert.ToInt32(groupDevicesDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value) ;
                Comm.Parameters.Add(new SqlParameter("@id", groupDevicesDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value));
                Comm.Parameters.Add(new SqlParameter("@name", devName.Text));
                Comm.Parameters.Add(new SqlParameter("@gid", grpId.Text));
                Comm.Parameters.Add(new SqlParameter("@pid", pltNumber.Text));
                Comm.Parameters.Add(new SqlParameter("@ccode", ctyCode.Text));
                Comm.Parameters.Add(new SqlParameter("@mid", modId.Text));
                Comm.Parameters.Add(new SqlParameter("@ip", devIp.Text));
                Comm.ExecuteScalar();
            }

            //showtable();
            this.groupDevicesTableAdapter.Fill(this.database1DataSet.groupDevices);

        }
        int selectedRowIndex;
        private void groupDevicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            //LoadPatientRecords();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
   
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Comm = new SqlCommand("DELETE FROM groupDevices WHERE deviceId=@id ", connection))
            {
                connection.Open();
                Comm.Parameters.Add(new SqlParameter("@id", groupDevicesDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value));
                Comm.ExecuteScalar();
            }

            //showtable();
            this.groupDevicesTableAdapter.Fill(this.database1DataSet.groupDevices); 
       }
    }
}
