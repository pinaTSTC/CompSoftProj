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

// needed for email to work
using System.Net.Mail;

// for printing I guess
using System.Drawing.Printing;

namespace Design_Document_Mock_Up
{
    public partial class frmWorkercs : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmWorkercs()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
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

        private void frmWorkercs_Load(object sender, EventArgs e)
        {
            reloadDGV();
            dgv_donorTable.AllowUserToAddRows = false;
            dgv_donorTable.AllowUserToDeleteRows = false;
            dgv_donorTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_donorTable.MultiSelect = false;
            dgv_donorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void reloadDGV()
        {
            //MUST BE EDITED TO ONLY PULL DONOR RECORDS

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM test_table WHERE IsDonor = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_table");
            da.Fill(ds, "test_table");
            dgv_donorTable.DataSource = ds.Tables["test_table"].DefaultView;
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

        private void btn_Delete_Click(object sender, EventArgs e)
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
                        btn_Delete.Enabled = false;
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

        private void btn_sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgv_donorTable.CurrentCell.RowIndex;
                
                if (selectedIndex > -1)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btn_printReport_Click(object sender, EventArgs e)
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_donorTable.DataSource = null;

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();
            // DONORS
            SqlDataAdapter dd = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsDonor = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet dsd = new DataSet("test_table");
            dd.Fill(dsd, "test_table");
            dgv_donorTable.DataSource = dsd.Tables["test_table"].DefaultView;
        }

        private void dgv_donorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Delete.Enabled = true;
        }
    }
}
