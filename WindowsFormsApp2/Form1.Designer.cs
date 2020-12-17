namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.priceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceTypeCombox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTypeCombox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTypeBindingSource
            // 
            this.priceTypeBindingSource.DataSource = typeof(WindowsFormsApp2.priceType);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApp2.product);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.priceTypeCombox});
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colprice,
            this.colFirstPrice,
            this.colSecondPrice,
            this.PriceType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 25;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            this.colprice.Width = 94;
            // 
            // colFirstPrice
            // 
            this.colFirstPrice.FieldName = "FirstPrice";
            this.colFirstPrice.MinWidth = 25;
            this.colFirstPrice.Name = "colFirstPrice";
            this.colFirstPrice.Visible = true;
            this.colFirstPrice.VisibleIndex = 3;
            this.colFirstPrice.Width = 94;
            // 
            // colSecondPrice
            // 
            this.colSecondPrice.FieldName = "SecondPrice";
            this.colSecondPrice.MinWidth = 25;
            this.colSecondPrice.Name = "colSecondPrice";
            this.colSecondPrice.Visible = true;
            this.colSecondPrice.VisibleIndex = 4;
            this.colSecondPrice.Width = 94;
            // 
            // PriceType
            // 
            this.PriceType.Caption = "priceType";
            this.PriceType.ColumnEdit = this.priceTypeCombox;
            this.PriceType.MinWidth = 25;
            this.PriceType.Name = "PriceType";
            this.PriceType.Visible = true;
            this.PriceType.VisibleIndex = 5;
            this.PriceType.Width = 94;
            // 
            // priceTypeCombox
            // 
            this.priceTypeCombox.AutoHeight = false;
            this.priceTypeCombox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceTypeCombox.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceTypeCombox.Name = "priceTypeCombox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTypeCombox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource priceTypeBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PriceType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox priceTypeCombox;
    }
}

