using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Document_Mock_Up
{
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {

        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            radb_fSmall.Checked = true;
        }
    }
}
