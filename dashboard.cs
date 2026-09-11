using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemasProject
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            data_master.role dm_role = new data_master.role { TopLevel = false, TopMost = true };
            pageconn.UntukKemas(dm_role, panelCenter);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            data_master.user dm_user = new data_master.user { TopLevel = false, TopMost = true };
            pageconn.UntukKemas(dm_user, panelCenter);
        }
    }
}
