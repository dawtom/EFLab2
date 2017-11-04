namespace ConsoleApp3
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSet = new ConsoleApp3.DataSet.OrdersDataSet();
            this.ordersTableAdapter = new ConsoleApp3.DataSet.OrdersDataSetTableAdapters.OrdersTableAdapter();
            this.placeAnOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersDataSet;
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "OrdersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // placeAnOrderButton
            // 
            this.placeAnOrderButton.Location = new System.Drawing.Point(45, 13);
            this.placeAnOrderButton.Name = "placeAnOrderButton";
            this.placeAnOrderButton.Size = new System.Drawing.Size(106, 23);
            this.placeAnOrderButton.TabIndex = 1;
            this.placeAnOrderButton.Text = "Złóż zamówienie";
            this.placeAnOrderButton.UseVisualStyleBackColor = true;
            this.placeAnOrderButton.Click += new System.EventHandler(this.placeAnOrderButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(479, 217);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(151, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Wróć do menu głównego";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // shipAddressDataGridViewTextBoxColumn
            // 
            this.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
            this.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
            this.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
            // 
            // shipCityDataGridViewTextBoxColumn
            // 
            this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
            // 
            // shipCountryDataGridViewTextBoxColumn
            // 
            this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 262);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.placeAnOrderButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet.OrdersDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet.OrdersDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button placeAnOrderButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
    }
}