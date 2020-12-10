using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// needed for MsSql to work
using System.Data.SqlClient;

namespace Design_Document_Mock_Up
{
    public partial class frmDonorPage : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;
        // to specify sunday
        Boolean sunday = false;
        string filedir = "C:/Users/admin/Documents/Visual Studio 2019/Projects/BDMS - In Progress/bin/";

        public frmDonorPage()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getTimeOfDay()
        {
            string time = "";
            if (radb_Morning.Checked == true)
                time = "Morning";
            if (radb_Afternoon.Checked == true)
                time = "Afternoon";
            if (radb_Evening.Checked == true)
                time = "Evening";
            return time;
        }

        private bool chkSunday()
        {
            //gets column index
            int selectedIndex = dgv_Calendar.CurrentCell.ColumnIndex;
            //gets current cell value
            //string cellDay = dgv_Calendar.CurrentCell.Value.ToString();
            //identifies column name
            string columnName = dgv_Calendar.Columns[selectedIndex].Name.ToString();

            if (columnName == "Sunday" && radb_Evening.Checked == true)
                sunday = true;
            else
                sunday = false;
            return sunday;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (sunday == true)
                {
                    string message = "Closed Sunday on Evenings!";
                    string caption = "Select Another time!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    string time = getTimeOfDay();
                    int selectedIndex = dgv_Calendar.CurrentCell.ColumnIndex;
                    string cellDay = dgv_Calendar.CurrentCell.Value.ToString();
                    string columnName = dgv_Calendar.Columns[selectedIndex].Name.ToString();
                    string num = frmMain.donorNum[0].donorNumber;
                    //string apptString = columnName + " " + time + " the " + cellDay;
                    sql = "UPDATE test_table SET AppmntDayWeek = '" + columnName.ToString() + "'," +
                        "AppmntDateNum = '" + cellDay.ToString() + "', " +
                        "AppmntTimeDay = '" + time.ToString() + "' WHERE Number = '" + num.ToString() + "'";

                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    ExecuteSQLStmt(sql);

                    // Username should be searched upon to prevent duplicates!
                    // Email Address field needs proofing!
                    string message = "We Hope to See you there!";
                    string caption = "Appointment Created!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void findImage()
        {
            string num = frmMain.donorNum[0].donorNumber;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SetImage FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            string image = cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            if (image == "")
                pct_Image.Image = Image.FromFile(filedir + "defaultpic.png");
            else
                pct_Image.Image = Image.FromFile(filedir + image);
        }

        private void fontNScheme()
        {
            string num = frmMain.donorNum[0].donorNumber;
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT FONT FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);

            SqlDataAdapter counter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            counter.Fill(ds);

            string sFont = cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            //second part
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            cmd = new SqlCommand("SELECT Scheme FROM test_table " +
                "WHERE Number = '" + num + "'", cnn);
            counter = new SqlDataAdapter(cmd);
            counter.Fill(ds);

            string sScheme = cmd.ExecuteScalar().ToString();
            counter.Dispose();
            cmd.Dispose();

            int setFont = Int32.Parse(sFont);
            if (setFont == 1)
            {
                grp_calendar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                grp_hourSelect.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                grp_timeofDay.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                lbl_listings.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Afternoon.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Evening.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Morning.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Confirm.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Cancel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
            if (setFont == 2)
            {
                grp_calendar.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                grp_hourSelect.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                grp_timeofDay.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                lbl_listings.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Afternoon.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Evening.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Morning.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Confirm.Font = new Font("Calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Cancel.Font = new Font("calibri", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
            if (setFont == 3)
            {
                grp_calendar.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                grp_hourSelect.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                grp_timeofDay.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                lbl_listings.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Afternoon.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Evening.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                radb_Morning.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Confirm.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
                btn_Cancel.Font = new Font("Comic Sans MS", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
            int setScheme = Int32.Parse(sScheme);
            if (setScheme == 1)
            {
                this.BackColor = Color.DarkGray;
                btn_Confirm.BackColor = Color.DarkGray;
                btn_Cancel.BackColor = Color.DarkGray;
            }
            if (setScheme == 2)
            {
                this.BackColor = Color.PowderBlue;
                btn_Confirm.BackColor = Color.Aqua;
                btn_Cancel.BackColor = Color.Aqua;
            }
            if (setScheme == 3)
            {
                this.BackColor = Color.Black;
                btn_Confirm.BackColor = Color.DimGray;
                btn_Cancel.BackColor = Color.DimGray;
                grp_timeofDay.ForeColor = System.Drawing.Color.White;
                grp_hourSelect.ForeColor = System.Drawing.Color.White;
                lbl_listings.ForeColor = System.Drawing.Color.White;
                radb_Morning.ForeColor = System.Drawing.Color.White;
                radb_Evening.ForeColor = System.Drawing.Color.White;
                radb_Afternoon.ForeColor = System.Drawing.Color.White;
            }
        }

        private void frmDonorPage_Load(object sender, EventArgs e)
        {
            radb_Morning.Checked = true;
            calendarLoad();
            findImage();
            fontNScheme();
        }

        private void calendarLoad()
        {
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            SqlDataAdapter da = new SqlDataAdapter("SELECT Monday, " +
                "Tuesday, " +
                "Wednesday, " +
                "Thursday, " +
                "Friday," +
                "Saturday," +
                "Sunday " +
                "FROM test_Calendar", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_Calendar");
            da.Fill(ds, "test_Calendar");
            dgv_Calendar.DataSource = ds.Tables["test_Calendar"].DefaultView;
            dgv_Calendar.AllowUserToAddRows = false;
            dgv_Calendar.AllowUserToDeleteRows = false;
            dgv_Calendar.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Calendar.MultiSelect = false;
            dgv_Calendar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            radb_Morning.Checked = true;
            relistings();
        }

        private void relistings()
        {
            if (radb_Morning.Checked == true)
                lbl_listings.Text = "8 AM TO 12 PM";
            if (radb_Afternoon.Checked == true)
                lbl_listings.Text = "12 PM TO 4 PM";
            if (radb_Afternoon.Checked == true && sunday == false)
                lbl_listings.Text = "4 PM TO 8 PM";
            if (radb_Evening.Checked == true && sunday == true)
                lbl_listings.Text = "CLOSED SUNDAY ON EVENINGS";
        }

        private void radb_Morning_CheckedChanged(object sender, EventArgs e)
        {
            relistings();
        }

        private void radb_Afternoon_CheckedChanged(object sender, EventArgs e)
        {
            relistings();
        }

        private void radb_Evening_CheckedChanged(object sender, EventArgs e)
        {
            relistings();
        }
    }
}
