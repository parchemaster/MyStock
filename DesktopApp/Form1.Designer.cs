namespace DesktopApp
{
    partial class myStock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.deleteStockButton = new System.Windows.Forms.Button();
            this.displayFavoritesButton = new System.Windows.Forms.Button();
            this.addToFavoritButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.infoLable = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.favoriteList = new System.Windows.Forms.ListBox();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Controls.Add(this.deleteStockButton);
            this.panel1.Controls.Add(this.displayFavoritesButton);
            this.panel1.Controls.Add(this.addToFavoritButton);
            this.panel1.Controls.Add(this.displayButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.closePriceDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.stockBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(0, 279);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(200, 147);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.Visible = false;
            // 
            // deleteStockButton
            // 
            this.deleteStockButton.Location = new System.Drawing.Point(3, 129);
            this.deleteStockButton.Name = "deleteStockButton";
            this.deleteStockButton.Size = new System.Drawing.Size(194, 36);
            this.deleteStockButton.TabIndex = 4;
            this.deleteStockButton.Text = "Delete stock from favorites";
            this.deleteStockButton.UseVisualStyleBackColor = true;
            this.deleteStockButton.Click += new System.EventHandler(this.deleteStockButton_Click_1);
            // 
            // displayFavoritesButton
            // 
            this.displayFavoritesButton.Location = new System.Drawing.Point(3, 87);
            this.displayFavoritesButton.Name = "displayFavoritesButton";
            this.displayFavoritesButton.Size = new System.Drawing.Size(194, 36);
            this.displayFavoritesButton.TabIndex = 3;
            this.displayFavoritesButton.Text = "Display favorites";
            this.displayFavoritesButton.UseVisualStyleBackColor = true;
            this.displayFavoritesButton.Click += new System.EventHandler(this.displayFavoritesButton_Click_1);
            // 
            // addToFavoritButton
            // 
            this.addToFavoritButton.Location = new System.Drawing.Point(3, 45);
            this.addToFavoritButton.Name = "addToFavoritButton";
            this.addToFavoritButton.Size = new System.Drawing.Size(194, 36);
            this.addToFavoritButton.TabIndex = 2;
            this.addToFavoritButton.Text = "Add stock to favorit";
            this.addToFavoritButton.UseVisualStyleBackColor = true;
            this.addToFavoritButton.Click += new System.EventHandler(this.addToFavoritButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(3, 3);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(194, 36);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display stock";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // infoLable
            // 
            this.infoLable.AutoSize = true;
            this.infoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.infoLable.Location = new System.Drawing.Point(275, 15);
            this.infoLable.Name = "infoLable";
            this.infoLable.Size = new System.Drawing.Size(466, 37);
            this.infoLable.TabIndex = 1;
            this.infoLable.Text = "Welcom to you\'r stock market";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(454, 99);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 2;
            this.input.Visible = false;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // favoriteList
            // 
            this.favoriteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteList.FormattingEnabled = true;
            this.favoriteList.Location = new System.Drawing.Point(243, 187);
            this.favoriteList.Name = "favoriteList";
            this.favoriteList.Size = new System.Drawing.Size(812, 251);
            this.favoriteList.TabIndex = 3;
            this.favoriteList.Visible = false;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(243, 153);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(812, 297);
            this.chart.TabIndex = 5;
            this.chart.Text = "cartesianChart2";
            this.chart.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // closePriceDataGridViewTextBoxColumn
            // 
            this.closePriceDataGridViewTextBoxColumn.DataPropertyName = "ClosePrice";
            this.closePriceDataGridViewTextBoxColumn.HeaderText = "ClosePrice";
            this.closePriceDataGridViewTextBoxColumn.Name = "closePriceDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(Stock);
            // 
            // myStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 475);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.favoriteList);
            this.Controls.Add(this.input);
            this.Controls.Add(this.infoLable);
            this.Controls.Add(this.panel1);
            this.Name = "myStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStock";
            this.Load += new System.EventHandler(this.myStock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteStockButton;
        private System.Windows.Forms.Button displayFavoritesButton;
        private System.Windows.Forms.Button addToFavoritButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label infoLable;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ListBox favoriteList;
        private System.Windows.Forms.DataGridView dataGrid;
        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource;
    }
}

