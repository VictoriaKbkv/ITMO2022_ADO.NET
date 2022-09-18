namespace ITMO_CSharp_DesktopApps_FinalProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabDirectory = new System.Windows.Forms.TabControl();
            this.tabShares = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ShareStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DelRowsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AddRowsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SharesGrid = new System.Windows.Forms.DataGridView();
            this.toolStripShares = new System.Windows.Forms.ToolStrip();
            this.tsbtnShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DiscardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabDirectory.SuspendLayout();
            this.tabShares.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SharesGrid)).BeginInit();
            this.toolStripShares.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDirectory
            // 
            this.tabDirectory.Controls.Add(this.tabShares);
            this.tabDirectory.Controls.Add(this.tabCustomers);
            this.tabDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDirectory.Location = new System.Drawing.Point(0, 0);
            this.tabDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.tabDirectory.Name = "tabDirectory";
            this.tabDirectory.SelectedIndex = 0;
            this.tabDirectory.Size = new System.Drawing.Size(654, 527);
            this.tabDirectory.TabIndex = 0;
            // 
            // tabShares
            // 
            this.tabShares.Controls.Add(this.statusStrip1);
            this.tabShares.Controls.Add(this.SharesGrid);
            this.tabShares.Controls.Add(this.toolStripShares);
            this.tabShares.Location = new System.Drawing.Point(4, 22);
            this.tabShares.Margin = new System.Windows.Forms.Padding(2);
            this.tabShares.Name = "tabShares";
            this.tabShares.Padding = new System.Windows.Forms.Padding(2);
            this.tabShares.Size = new System.Drawing.Size(646, 501);
            this.tabShares.TabIndex = 0;
            this.tabShares.Text = "Shares";
            this.tabShares.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShareStatusLabel,
            this.toolStripStatusLabel1,
            this.DelRowsStatus,
            this.toolStripStatusLabel2,
            this.AddRowsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(2, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ShareStatusLabel
            // 
            this.ShareStatusLabel.Name = "ShareStatusLabel";
            this.ShareStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Deleted Rows:";
            // 
            // DelRowsStatus
            // 
            this.DelRowsStatus.Name = "DelRowsStatus";
            this.DelRowsStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel2.Text = "       Added Rows:";
            // 
            // AddRowsStatus
            // 
            this.AddRowsStatus.Name = "AddRowsStatus";
            this.AddRowsStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // SharesGrid
            // 
            this.SharesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SharesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SharesGrid.Location = new System.Drawing.Point(2, 41);
            this.SharesGrid.Margin = new System.Windows.Forms.Padding(2);
            this.SharesGrid.Name = "SharesGrid";
            this.SharesGrid.RowTemplate.Height = 28;
            this.SharesGrid.Size = new System.Drawing.Size(642, 458);
            this.SharesGrid.TabIndex = 2;
            this.SharesGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SharesGrid_CellValueChanged);
            this.SharesGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SharesGrid_RowsAdded);
            // 
            // toolStripShares
            // 
            this.toolStripShares.AutoSize = false;
            this.toolStripShares.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnShow,
            this.toolStripSeparator1,
            this.tsbtnFind,
            this.toolStripSeparator2,
            this.tsbtnDelete,
            this.toolStripSeparator4,
            this.SaveButton,
            this.toolStripSeparator3,
            this.DiscardButton,
            this.toolStripSeparator5});
            this.toolStripShares.Location = new System.Drawing.Point(2, 2);
            this.toolStripShares.Name = "toolStripShares";
            this.toolStripShares.Size = new System.Drawing.Size(642, 39);
            this.toolStripShares.TabIndex = 0;
            this.toolStripShares.Text = "toolStrip1";
            // 
            // tsbtnShow
            // 
            this.tsbtnShow.AutoSize = false;
            this.tsbtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShow.Image")));
            this.tsbtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShow.Name = "tsbtnShow";
            this.tsbtnShow.Size = new System.Drawing.Size(57, 57);
            this.tsbtnShow.Text = "Show all";
            this.tsbtnShow.Click += new System.EventHandler(this.tsbtnShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnFind
            // 
            this.tsbtnFind.AutoSize = false;
            this.tsbtnFind.Enabled = false;
            this.tsbtnFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFind.Image")));
            this.tsbtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFind.Name = "tsbtnFind";
            this.tsbtnFind.Size = new System.Drawing.Size(57, 57);
            this.tsbtnFind.Text = "Find";
            this.tsbtnFind.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.AutoSize = false;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(70, 57);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = false;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(57, 57);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // DiscardButton
            // 
            this.DiscardButton.AutoSize = false;
            this.DiscardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DiscardButton.Image = ((System.Drawing.Image)(resources.GetObject("DiscardButton.Image")));
            this.DiscardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(100, 57);
            this.DiscardButton.Text = "Discard changes";
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Size = new System.Drawing.Size(646, 501);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 527);
            this.Controls.Add(this.tabDirectory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Directory Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabDirectory.ResumeLayout(false);
            this.tabShares.ResumeLayout(false);
            this.tabShares.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SharesGrid)).EndInit();
            this.toolStripShares.ResumeLayout(false);
            this.toolStripShares.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDirectory;
        private System.Windows.Forms.TabPage tabShares;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.ToolStrip toolStripShares;
        private System.Windows.Forms.ToolStripButton tsbtnShow;
        private System.Windows.Forms.ToolStripButton tsbtnFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView SharesGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ShareStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel DelRowsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel AddRowsStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton DiscardButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}