namespace ITMO2022_ADO.NET_Lab4Ex6
{
    partial class Form1
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.customersTableAdapter1 = new ITMO2022_ADO.NET_Lab4Ex6.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new ITMO2022_ADO.NET_Lab4Ex6.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.northwindDataSet1 = new ITMO2022_ADO.NET_Lab4Ex6.NorthwindDataSet();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.GetOrdersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(12, 12);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.RowTemplate.Height = 28;
            this.CustomersGrid.Size = new System.Drawing.Size(397, 419);
            this.CustomersGrid.TabIndex = 0;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(491, 14);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(207, 26);
            this.SortTextBox.TabIndex = 1;
            this.SortTextBox.Text = "CustomerID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(491, 58);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(207, 26);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.Text = "City = \'London\'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter";
            // 
            // SetDataViewPropertiesButton
            // 
            this.SetDataViewPropertiesButton.Location = new System.Drawing.Point(439, 293);
            this.SetDataViewPropertiesButton.Name = "SetDataViewPropertiesButton";
            this.SetDataViewPropertiesButton.Size = new System.Drawing.Size(221, 35);
            this.SetDataViewPropertiesButton.TabIndex = 5;
            this.SetDataViewPropertiesButton.Text = "Set Data View Properties";
            this.SetDataViewPropertiesButton.UseVisualStyleBackColor = true;
            this.SetDataViewPropertiesButton.Click += new System.EventHandler(this.SetDataViewPropertiesButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(439, 343);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(221, 35);
            this.AddRowButton.TabIndex = 6;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Location = new System.Drawing.Point(726, 14);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.RowTemplate.Height = 28;
            this.OrdersGrid.Size = new System.Drawing.Size(397, 419);
            this.OrdersGrid.TabIndex = 7;
            // 
            // GetOrdersButton
            // 
            this.GetOrdersButton.Location = new System.Drawing.Point(439, 396);
            this.GetOrdersButton.Name = "GetOrdersButton";
            this.GetOrdersButton.Size = new System.Drawing.Size(221, 35);
            this.GetOrdersButton.TabIndex = 8;
            this.GetOrdersButton.Text = "Get Orders";
            this.GetOrdersButton.UseVisualStyleBackColor = true;
            this.GetOrdersButton.Click += new System.EventHandler(this.GetOrdersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 450);
            this.Controls.Add(this.GetOrdersButton);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.SetDataViewPropertiesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetDataViewPropertiesButton;
        private System.Windows.Forms.Button AddRowButton;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Button GetOrdersButton;
    }
}

