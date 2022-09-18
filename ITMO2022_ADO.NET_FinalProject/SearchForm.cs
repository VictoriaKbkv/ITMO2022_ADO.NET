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
    public partial class SearchForm : Form
    {
        public string SearchShareDesc
        {
            get { return SearchShareDescTxtBx.Text; }
            set { SearchShareDescTxtBx.Text = value; }
        }
        public string SearchShareTicker
        {
            get { return SearchShareTickerTxtBx.Text; }
            set { SearchShareTickerTxtBx.Text = value; }
        }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((SearchShareDesc == "") && (SearchShareTicker == ""))
            {
                MessageBox.Show("No search creteria added, all items shown");
            }
            
        }
    }
}
