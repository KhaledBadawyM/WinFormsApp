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
            // TODO: This line of code loads data into the 'database1DataSet2.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.database1DataSet2.Groups);
            // TODO: This line of code loads data into the 'database1DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet1.users);
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

        private void insertUser_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand insertComm = new SqlCommand("INSERT INTO users (userName,password,privilege,groupid) VALUES (@user , @pass , @priv, @gid)", connection))
            {
                connection.Open();
                insertComm.Parameters.Add(new SqlParameter("user", _username.Text));
                insertComm.Parameters.Add(new SqlParameter("pass", _password.Text));
                insertComm.Parameters.Add(new SqlParameter("priv", Convert.ToInt32(_privilege.Text)));
                insertComm.Parameters.Add(new SqlParameter("gid", Convert.ToInt32(_groupid.Text)));

                insertComm.ExecuteScalar();
            }

            //showtable();
            this.usersTableAdapter.Fill(this.database1DataSet1.users);

        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Comm = new SqlCommand("UPDATE users SET userName=@user ,password=@pass,privilege=@priv,groupid=@gid WHERE userId=@id", connection))
            {
                connection.Open();
                Comm.Parameters.Add(new SqlParameter("id", usersDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value));
                Comm.Parameters.Add(new SqlParameter("user", _username.Text));
                Comm.Parameters.Add(new SqlParameter("pass", _password.Text));
                Comm.Parameters.Add(new SqlParameter("priv", Convert.ToInt32(_privilege.Text)));
                Comm.Parameters.Add(new SqlParameter("gid", Convert.ToInt32(_groupid.Text)));

                Comm.ExecuteScalar();
            }

            //showtable();
            this.usersTableAdapter.Fill(this.database1DataSet1.users);
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Comm = new SqlCommand("DELETE FROM users WHERE userId=@id ", connection))
            {
                connection.Open();
                Comm.Parameters.Add(new SqlParameter("id", usersDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value));
                Comm.ExecuteScalar();
            }

            this.usersTableAdapter.Fill(this.database1DataSet1.users);
        }

        private void insertGroup_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand insertComm = new SqlCommand("INSERT INTO Groups (groupname,allowedlogin,login,Name,Description) VALUES (@gname , @allowed , @log, @name ,@desc)", connection))
            {
                connection.Open();
                insertComm.Parameters.Add(new SqlParameter("gname", _groupName.Text));
                insertComm.Parameters.Add(new SqlParameter("allowed", Convert.ToInt32(_allowed.Text)));
                insertComm.Parameters.Add(new SqlParameter("log", Convert.ToInt32(_login.Text)));
                insertComm.Parameters.Add(new SqlParameter("name", _name.Text));
                insertComm.Parameters.Add(new SqlParameter("desc", _desc.Text));

                insertComm.ExecuteScalar();
            }

            this.groupsTableAdapter.Fill(this.database1DataSet2.Groups);
        }

        private void updateGroup_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Comm = new SqlCommand("UPDATE Groups SET groupname=@gname,allowedlogin=@allowed,login=@log,Name=@name,Description=@desc WHERE id =@_id", connection))
            {
                connection.Open();
                Comm.Parameters.Add(new SqlParameter("_id", groupsDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value));
                Comm.Parameters.Add(new SqlParameter("gname", _groupName.Text));
                Comm.Parameters.Add(new SqlParameter("allowed", Convert.ToInt32(_allowed.Text)));
                Comm.Parameters.Add(new SqlParameter("log", Convert.ToInt32(_login.Text)));
                Comm.Parameters.Add(new SqlParameter("name", _name.Text));
                Comm.Parameters.Add(new SqlParameter("desc", _desc.Text));

                Comm.ExecuteScalar();
            }

            this.groupsTableAdapter.Fill(this.database1DataSet2.Groups);
        }

        private void deleteGroup_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Comm = new SqlCommand("DELETE FROM Groups WHERE id =@_id", connection))
            {
                connection.Open();
                Comm.Parameters.Add(new SqlParameter("_id", groupsDataGridView.SelectedRows[selectedRowIndex].Cells[0].Value));
                
                Comm.ExecuteScalar();
            }

            this.groupsTableAdapter.Fill(this.database1DataSet2.Groups);
        }
    }
}
