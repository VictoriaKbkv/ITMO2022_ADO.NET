using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;



namespace ITMO_CSharp_DesktopApps_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ApressFinancialEntities ctx = new ApressFinancialEntities();
        BindingSource bindingSourceShares = new BindingSource();
        int DelCount = 0;
        int AddCount;


        private void tsbtnShow_Click(object sender, EventArgs e)
        {
            ctx.Shares.Load();
            bindingSourceShares.DataSource = ctx.Shares.Local.ToBindingList();
            SharesGrid.DataSource = bindingSourceShares;
            SharesGrid.Columns["ShareID"].Visible = false;
            SharesGrid.Columns["Transactions"].Visible = false;
            DelRowsStatus.Text = DelCount.ToString();
            AddCount = 0;
            AddRowsStatus.Text = AddCount.ToString();

        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            long DelID;
            Shares DelShares;

            foreach (DataGridViewRow item in SharesGrid.SelectedRows)
            {
                DelID = (long)item.Cells[0].Value;
                DelShares = ctx.Shares.First(b => b.ShareID == DelID);
                ctx.Shares.Remove(DelShares);
                DelCount++;             
            }

            DelRowsStatus.Text = DelCount.ToString();

        }

       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchForm SForm = new SearchForm();
            if (SForm.ShowDialog() != DialogResult.OK) return;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            authorizationForm login = new authorizationForm();
            login.ShowDialog();
        }

        private void SharesGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AddCount = AddCount + 1;
            AddRowsStatus.Text = AddCount.ToString();
        }


        private void SharesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SharesGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LemonChiffon;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                DelCount = 0;
                DelRowsStatus.Text = DelCount.ToString();
                AddCount = 0;
                AddRowsStatus.Text = AddCount.ToString();
                foreach (DataGridViewRow item in SharesGrid.Rows)
                {
                    SharesGrid.Rows[item.Index].DefaultCellStyle.BackColor = Color.White;
                }
                MessageBox.Show("Changes successfully saved");
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Check Data: ShareDesc not null, SharePrice numeric", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DiscardButton_Click(object sender, EventArgs e)
        {
            var changedEntries = ctx.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
            DelCount = 0;
            DelRowsStatus.Text = DelCount.ToString();
            AddCount = 0;
            AddRowsStatus.Text = AddCount.ToString();
            foreach (DataGridViewRow item in SharesGrid.Rows)
            {
                SharesGrid.Rows[item.Index].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx.Dispose(); 
        }
    }
}
