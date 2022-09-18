using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO_CSharp_DesktopApps_FinalProject
{
    public partial class authorizationForm : Form
    {
        public authorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "User1";
            string password = "Qwerty123";

            if ((textBoxUsername.Text == username) && (textBoxPassword.Text == password))
            {
                this.Close();
            }
            else
            {
                failedAuthorizationForm tryAgain = new failedAuthorizationForm();
                tryAgain.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
