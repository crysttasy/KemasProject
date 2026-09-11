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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            conn.crud($"SELECT * FROM tb_users WHERE username = '{txtUser.Text}' AND password = '{txtPass.Text}';");
            int cekbaris = conn.ds.Tables[0].Rows.Count;

            if (cekbaris == 1)
            {
                DataRow baris = conn.ds.Tables[0].Rows[0];
                dashboard FDashboard = new dashboard();
                FDashboard.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password Salah!");
            }
        }
    }
}
