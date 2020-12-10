using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// needed for MySql to work
using System.Data.SqlClient;

using System.Data.Common;

// needed for email to work
using System.Net.Mail;

// for printing I guess
using System.Drawing.Printing;

namespace Design_Document_Mock_Up
{
    public partial class frmAdminForm : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;
        Boolean selectDonor = false;
        Boolean selectWorker = false;
        public frmAdminForm()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            //adjusts the datagridview to the proper usage
            dgv_donorTable.AllowUserToAddRows = false;
            dgv_donorTable.AllowUserToDeleteRows = false;
            dgv_donorTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_donorTable.MultiSelect = false;
            dgv_donorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_workerTable.AllowUserToAddRows = false;
            dgv_workerTable.AllowUserToDeleteRows = false;
            dgv_workerTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_workerTable.MultiSelect = false;
            dgv_workerTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //remove all customer data when returning to form main

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            // WORKERS
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsWorker = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_table");
            da.Fill(ds, "test_table");
            dgv_workerTable.DataSource = ds.Tables["test_table"].DefaultView;

            // DONORS
            SqlDataAdapter dd = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsDonor = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet dsd = new DataSet("test_table");
            dd.Fill(dsd, "test_table");
            dgv_donorTable.DataSource = dsd.Tables["test_table"].DefaultView;

            
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            //Opening CreateAdmin Form 
            frmCreateAdmin frmCreateAdmin = new frmCreateAdmin();
            //Hides this form
            this.Hide();
            //Opens CreateAdmin Form
            frmCreateAdmin.ShowDialog();
            //Opens THIS form when CreateAdmin closes
            this.Show();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }

        private void btn_sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgv_donorTable.CurrentCell.RowIndex;
                string isDonor = dgv_donorTable.Rows[selectedIndex].Cells["IsDonor"].Value.ToString();
                if (selectedIndex > -1 && isDonor == "Y")
                {
                    string rowNum = dgv_donorTable.Rows[selectedIndex].Cells["Number"].Value.ToString();
                    string AppmntDay = dgv_donorTable.Rows[selectedIndex].Cells["AppmntDayWeek"].Value.ToString();
                    string AppmntDateNum = dgv_donorTable.Rows[selectedIndex].Cells["AppmntDateNum"].Value.ToString();
                    string AppmntTime = dgv_donorTable.Rows[selectedIndex].Cells["AppmntTimeDay"].Value.ToString();
                    string emailAdd = dgv_donorTable.Rows[selectedIndex].Cells["EmailAddress"].Value.ToString();
                    dgv_donorTable.Rows.RemoveAt(selectedIndex);
                    dgv_donorTable.Refresh();

                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    string mailmessage = AppmntDay + " the " + AppmntDateNum + " in the " + AppmntTime;

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("testinganappffs@gmail.com");
                    mail.To.Add(emailAdd);
                    mail.Subject = "Appointment Reminder";
                    mail.Body = "You have an appointment on " + mailmessage;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("testinganappffs", "changeafterfinal");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Appointment Reminder Sent!");
                }
                else
                {
                    MessageBox.Show("This is not a donor!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reportPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string mailmessage = "There are " + getDonors() + " appointments scheduled.";

                if (mailmessage == "nope")
                {
                    MessageBox.Show("No Donor Appointments!");
                }
                else
                {
                    PrintDocument p = new PrintDocument();
                    p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                    {
                        e1.Graphics.DrawString(mailmessage, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                    };
                    p.Print();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }

        private string getDonors()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE isDonor = 'Y'" +
                "AND AppmntDateNum IS NOT NULL", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            // If unique return value, valid login
            int donorCount = ds.Tables[0].Rows.Count;
            string appstring = "";

            if (donorCount == 0)
                appstring = "nope";
            else
            {
                //DataTableMapping custMap = counter.TableMappings.Add("test_table");
                //foreach (DataTable dt in ds.Tables)
                //{
                // ran out of time
                //}
                appstring = donorCount.ToString();
            }
            return appstring;
        }


        private void ExecuteSQLStmt(string sql)
        {
            cnn = new SqlConnection(connectionString);
            // Open the connection  
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            //cnn = new SqlConnection(connectionString);
            //if (cnn.State == ConnectionState.Open)
            //    cnn.Close();
            //cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
        }

        private void dgv_donorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_DeleteDonor.Enabled = true;
        }

        private void dgv_workerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_DeleteWorker.Enabled = true;
        }

        private void btn_DeleteDonor_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Delete Donor?";
                string caption = " ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int selectedIndex = dgv_donorTable.CurrentCell.RowIndex;
                    //DataRow row = (dgv_donorTable.SelectedRows[selectedIndex].DataBoundItem as DataRowView).Row;

                    if (selectedIndex > -1)
                    {
                        string rowNum = dgv_donorTable.Rows[selectedIndex].Cells["Number"].Value.ToString();

                        dgv_donorTable.Rows.RemoveAt(selectedIndex);
                        dgv_donorTable.Refresh();

                        // ADD SQL STUFF 
                        cnn = new SqlConnection(connectionString);
                        /// Open the connection  
                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                        connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                        cnn.ConnectionString = connectionString;
                        cnn.Open();

                        sql = "DELETE FROM test_table WHERE Number = " + rowNum + "";

                        ExecuteSQLStmt(sql);
                        btn_DeleteDonor.Enabled = false;
                    }
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DeleteWorker_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Delete Worker?";
                string caption = " ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int selectedIndex = dgv_workerTable.CurrentCell.RowIndex;
                    //DataRow row = (dgv_donorTable.SelectedRows[selectedIndex].DataBoundItem as DataRowView).Row;

                    if (selectedIndex > -1)
                    {
                        string rowNum = dgv_workerTable.Rows[selectedIndex].Cells["Number"].Value.ToString();

                        dgv_workerTable.Rows.RemoveAt(selectedIndex);
                        dgv_workerTable.Refresh();

                        // ADD SQL STUFF 
                        cnn = new SqlConnection(connectionString);
                        /// Open the connection  
                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                        connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                        cnn.ConnectionString = connectionString;
                        cnn.Open();

                        sql = "DELETE FROM test_table WHERE Number = " + rowNum + "";

                        ExecuteSQLStmt(sql);
                        btn_DeleteWorker.Enabled = false;
                    }
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createTable()
        {
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            sql = "CREATE TABLE test_table (Number varchar(1), " +
                "PersonID varchar(7), " +
                "LastName varchar(255), " +
                "FirstName varchar(255), " +
                "Password varchar(255), " +
                "PhoneNumber varchar(255), " +
                "EmailAddress varchar(255)," +
                "Gender varchar(7)," +
                "BloodGroup varchar(3)," +
                "UserName varchar(20)," +
                "Address varchar(30)," +
                "Age varchar(2)," +
                "Schedule varchar(10)," +
                "AppmntDayWeek varchar(10)," +
                "AppmntDateNum varchar(2)," +
                "AppmntTimeDay varchar(10)," +
                "IsDonor varchar(1)," +
                "IsAdmin varchar(1)," +
                "IsWorker varchar(1), " +
                "SetImage varchar(15)," +
                "Font varchar(1)," +
                "Scheme varchar(1))";
            ExecuteSQLStmt(sql);
            // create default admin account
            // ADD SQL STUFF 
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();


            sql = "INSERT INTO test_table(Number, PersonID, LastName, " +
       "FirstName, Password, PhoneNumber, EmailAddress, " +
       "UserName, IsDonor, IsAdmin, IsWorker) " +
       //values 
       "Values ('1', 'ADM111', 'Hammer', 'badmin', 'lives2ban', " +
       "'1800133766', 'email@badmins.com', 'powertrip', 'N', 'Y', 'N')";
            // Codes for identifying donors, workers, and admins on the database
            ExecuteSQLStmt(sql);
            
            string message = "Table Created!";
            string caption = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_deleteTable_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "This will erase recreate the table. " +
                    "Are you sure you wish to proceed?";
                string caption = "Delete Table?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    string sql = "DROP TABLE test_table ";
                    ExecuteSQLStmt(sql);
                    // recreates the table
                    createTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createDB()
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                /// Open the connection  
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "CREATE DATABASE testDB";
                ExecuteSQLStmt(sql);

                string message = "Database Created!";
                string caption = " ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deleteDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Delete Database? It will be recreated.";
                string caption = "ARE YOU SURE?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    string sql = "DROP DATABASE testDB";
                    ExecuteSQLStmt(sql);
                    // recreates the DB()
                    createDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_createWorker_Click(object sender, EventArgs e)
        {
            //Opening CreateWorker Form 
            frmCreateWorker frmCreateWorker = new frmCreateWorker();
            //Hides this form
            this.Hide();
            //Opens CreateWorker Form
            frmCreateWorker.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_donorTable.DataSource = null;
            dgv_workerTable.DataSource = null;

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            // WORKERS
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsWorker = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_table");
            da.Fill(ds, "test_table");
            dgv_workerTable.DataSource = ds.Tables["test_table"].DefaultView;

            // DONORS
            SqlDataAdapter dd = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsDonor = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet dsd = new DataSet("test_table");
            dd.Fill(dsd, "test_table");
            dgv_donorTable.DataSource = dsd.Tables["test_table"].DefaultView;
        }
    }
}
