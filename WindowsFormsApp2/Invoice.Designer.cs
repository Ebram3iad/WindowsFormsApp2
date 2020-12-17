namespace WindowsFormsApp2
{
    partial class Invoice
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnShow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Show = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnFrieght = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xtraTabProducts = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControlProducts = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPagGetProducts = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditRemain = new DevExpress.XtraEditors.TextEdit();
            this.textEditPaid = new DevExpress.XtraEditors.TextEdit();
            this.textEditTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlGetProducts = new DevExpress.XtraGrid.GridControl();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataviewprod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.xtraTabPagAddProduct = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.button1 = new System.Windows.Forms.Button();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabPagEditProduct = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPagRemoveProduct = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabStore = new DevExpress.XtraTab.XtraTabPage();
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.xtraTabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlProducts)).BeginInit();
            this.xtraTabControlProducts.SuspendLayout();
            this.xtraTabPagGetProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGetProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.xtraTabPagAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(WindowsFormsApp2.Orders);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Appearance.Options.UseBorderColor = true;
            this.xtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.White;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabInvoice;
            this.xtraTabControl1.Size = new System.Drawing.Size(1065, 541);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabInvoice,
            this.xtraTabProducts,
            this.xtraTabStore});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            this.xtraTabControl1.SelectedPageChangeAnimationCompleted += new DevExpress.XtraTab.TabPageChangeEventHandler(this.xtraTabControl1_SelectedPageChangeAnimationCompleted);
            this.xtraTabControl1.TabIndexChanged += new System.EventHandler(this.xtraTabControl1_TabIndexChanged);
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabInvoice
            // 
            this.xtraTabInvoice.Controls.Add(this.layoutControl1);
            this.xtraTabInvoice.Name = "xtraTabInvoice";
            this.xtraTabInvoice.Size = new System.Drawing.Size(1058, 507);
            this.xtraTabInvoice.Text = "Invoice";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1058, 507);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.ordersBindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, 38);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Show});
            this.gridControl.Size = new System.Drawing.Size(1034, 426);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId,
            this.colContactName,
            this.colAddress,
            this.colPostalCode,
            this.colCity,
            this.colPhone,
            this.colOrderDate,
            this.gridColumnShow,
            this.gridColumnFrieght,
            this.gridColumnShipCity});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colOrderId
            // 
            this.colOrderId.Caption = "Order Id";
            this.colOrderId.FieldName = "OrderID";
            this.colOrderId.MinWidth = 25;
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.Visible = true;
            this.colOrderId.VisibleIndex = 0;
            this.colOrderId.Width = 94;
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.MinWidth = 25;
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 1;
            this.colContactName.Width = 94;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 94;
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.MinWidth = 25;
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 3;
            this.colPostalCode.Width = 94;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.MinWidth = 25;
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            this.colCity.Width = 94;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 25;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 5;
            this.colPhone.Width = 94;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 25;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 6;
            this.colOrderDate.Width = 94;
            // 
            // gridColumnShow
            // 
            this.gridColumnShow.Caption = "Show Details";
            this.gridColumnShow.ColumnEdit = this.Show;
            this.gridColumnShow.MinWidth = 25;
            this.gridColumnShow.Name = "gridColumnShow";
            this.gridColumnShow.Visible = true;
            this.gridColumnShow.VisibleIndex = 9;
            this.gridColumnShow.Width = 94;
            // 
            // Show
            // 
            this.Show.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.Show.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Show.Name = "Show";
            this.Show.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // gridColumnFrieght
            // 
            this.gridColumnFrieght.Caption = "Feight";
            this.gridColumnFrieght.FieldName = "Freight";
            this.gridColumnFrieght.MinWidth = 25;
            this.gridColumnFrieght.Name = "gridColumnFrieght";
            this.gridColumnFrieght.Visible = true;
            this.gridColumnFrieght.VisibleIndex = 7;
            this.gridColumnFrieght.Width = 94;
            // 
            // gridColumnShipCity
            // 
            this.gridColumnShipCity.Caption = "Ship City";
            this.gridColumnShipCity.FieldName = "ShipCity";
            this.gridColumnShipCity.MinWidth = 25;
            this.gridColumnShipCity.Name = "gridColumnShipCity";
            this.gridColumnShipCity.Visible = true;
            this.gridColumnShipCity.VisibleIndex = 8;
            this.gridColumnShipCity.Width = 94;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(389, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.EditFormat.FormatString = "YYYY-MM-DD hh:mm:ss";
            this.dateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit2.Size = new System.Drawing.Size(241, 22);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 7;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2020, 12, 15, 13, 37, 10, 0);
            this.dateEdit1.Location = new System.Drawing.Point(76, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.EditFormat.FormatString = "YYYY-MM-DD hh:mm:ss";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Size = new System.Drawing.Size(245, 22);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(929, 468);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 27);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(786, 468);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 27);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.dtFromDate,
            this.dtToDate,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1058, 507);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLoad;
            this.layoutControlItem2.Location = new System.Drawing.Point(917, 456);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(121, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(121, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(121, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Control = this.dateEdit1;
            this.dtFromDate.Location = new System.Drawing.Point(0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(313, 26);
            this.dtFromDate.Text = "From Date";
            this.dtFromDate.TextSize = new System.Drawing.Size(60, 16);
            // 
            // dtToDate
            // 
            this.dtToDate.Control = this.dateEdit2;
            this.dtToDate.Location = new System.Drawing.Point(313, 0);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(309, 26);
            this.dtToDate.Text = "To Date";
            this.dtToDate.TextSize = new System.Drawing.Size(60, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1038, 430);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(774, 456);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(143, 31);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(143, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(143, 31);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 456);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(774, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(622, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(416, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xtraTabProducts
            // 
            this.xtraTabProducts.Controls.Add(this.xtraTabControlProducts);
            this.xtraTabProducts.Name = "xtraTabProducts";
            this.xtraTabProducts.Size = new System.Drawing.Size(1058, 507);
            this.xtraTabProducts.Text = "Products";
            this.xtraTabProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // xtraTabControlProducts
            // 
            this.xtraTabControlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlProducts.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlProducts.Name = "xtraTabControlProducts";
            this.xtraTabControlProducts.SelectedTabPage = this.xtraTabPagGetProducts;
            this.xtraTabControlProducts.Size = new System.Drawing.Size(1058, 507);
            this.xtraTabControlProducts.TabIndex = 0;
            this.xtraTabControlProducts.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPagGetProducts,
            this.xtraTabPagAddProduct,
            this.xtraTabPagEditProduct,
            this.xtraTabPagRemoveProduct});
            this.xtraTabControlProducts.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControlProducts_SelectedPageChanged);
            this.xtraTabControlProducts.TabIndexChanged += new System.EventHandler(this.xtraTabControlProducts_TabIndexChanged);
            this.xtraTabControlProducts.Click += new System.EventHandler(this.xtraTabControlProducts_Click);
            // 
            // xtraTabPagGetProducts
            // 
            this.xtraTabPagGetProducts.Controls.Add(this.panelControl1);
            this.xtraTabPagGetProducts.Controls.Add(this.lookUpEditProduct);
            this.xtraTabPagGetProducts.Controls.Add(this.lookUpEditCategory);
            this.xtraTabPagGetProducts.Controls.Add(this.label2);
            this.xtraTabPagGetProducts.Controls.Add(this.label1);
            this.xtraTabPagGetProducts.Controls.Add(this.gridControlGetProducts);
            this.xtraTabPagGetProducts.Name = "xtraTabPagGetProducts";
            this.xtraTabPagGetProducts.Size = new System.Drawing.Size(1051, 473);
            this.xtraTabPagGetProducts.Text = "All Product";
            this.xtraTabPagGetProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPagGetProducts_Paint);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.textEditRemain);
            this.panelControl1.Controls.Add(this.textEditPaid);
            this.panelControl1.Controls.Add(this.textEditTotal);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 358);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1051, 115);
            this.panelControl1.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearancePressed.BackColor = System.Drawing.Color.Red;
            this.btnDelete.AppearancePressed.Options.UseBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(120, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // textEditRemain
            // 
            this.textEditRemain.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEditRemain.Enabled = false;
            this.textEditRemain.Location = new System.Drawing.Point(867, 20);
            this.textEditRemain.Name = "textEditRemain";
            this.textEditRemain.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditRemain.Properties.Appearance.Options.UseFont = true;
            this.textEditRemain.Size = new System.Drawing.Size(169, 40);
            this.textEditRemain.TabIndex = 8;
            // 
            // textEditPaid
            // 
            this.textEditPaid.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEditPaid.Location = new System.Drawing.Point(546, 20);
            this.textEditPaid.Name = "textEditPaid";
            this.textEditPaid.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEditPaid.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPaid.Properties.Appearance.Options.UseFont = true;
            this.textEditPaid.Size = new System.Drawing.Size(169, 40);
            this.textEditPaid.TabIndex = 7;
            this.textEditPaid.EditValueChanged += new System.EventHandler(this.textEditPaid_EditValueChanged);
            this.textEditPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditPaid_KeyDown);
            this.textEditPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditPaid_KeyPress);
            // 
            // textEditTotal
            // 
            this.textEditTotal.Enabled = false;
            this.textEditTotal.Location = new System.Drawing.Point(264, 20);
            this.textEditTotal.Name = "textEditTotal";
            this.textEditTotal.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTotal.Properties.Appearance.Options.UseFont = true;
            this.textEditTotal.Size = new System.Drawing.Size(169, 40);
            this.textEditTotal.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearancePressed.BackColor = System.Drawing.Color.Red;
            this.btnSave.AppearancePressed.Options.UseBackColor = true;
            this.btnSave.Location = new System.Drawing.Point(5, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lookUpEditProduct
            // 
            this.lookUpEditProduct.Location = new System.Drawing.Point(529, 1);
            this.lookUpEditProduct.Name = "lookUpEditProduct";
            this.lookUpEditProduct.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpEditProduct.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditProduct.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditProduct.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpEditProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lookUpEditProduct.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name", 20, DevExpress.Utils.FormatType.None, "Product Name", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditProduct.Properties.DataSource = this.productsBindingSource;
            this.lookUpEditProduct.Properties.DisplayMember = "ProductName";
            this.lookUpEditProduct.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.lookUpEditProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditProduct.Properties.ValueMember = "ProductID";
            this.lookUpEditProduct.Properties.Click += new System.EventHandler(this.lookUpEditProduct_Properties_Click);
            this.lookUpEditProduct.Size = new System.Drawing.Size(234, 38);
            this.lookUpEditProduct.TabIndex = 14;
            this.lookUpEditProduct.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.lookUpEditProduct_ProcessNewValue);
            this.lookUpEditProduct.EditValueChanged += new System.EventHandler(this.lookUpEditProduct_EditValueChanged);
            this.lookUpEditProduct.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookUpEditProduct_EditValueChanging);
            this.lookUpEditProduct.Click += new System.EventHandler(this.lookUpEditProduct_Click);
            this.lookUpEditProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lookUpEditProduct_MouseClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(WindowsFormsApp2.Products);
            // 
            // lookUpEditCategory
            // 
            this.lookUpEditCategory.Location = new System.Drawing.Point(85, 2);
            this.lookUpEditCategory.Name = "lookUpEditCategory";
            this.lookUpEditCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpEditCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditCategory.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name")});
            this.lookUpEditCategory.Properties.DataSource = this.categoriesBindingSource;
            this.lookUpEditCategory.Properties.DisplayMember = "CategoryName";
            this.lookUpEditCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditCategory.Properties.ValueMember = "CategoryID";
            this.lookUpEditCategory.Size = new System.Drawing.Size(234, 38);
            this.lookUpEditCategory.TabIndex = 13;
            this.lookUpEditCategory.EditValueChanged += new System.EventHandler(this.lookUpEditCategory_EditValueChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(WindowsFormsApp2.Categories);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Store";
            // 
            // gridControlGetProducts
            // 
            this.gridControlGetProducts.DataSource = this.orderDetailBindingSource;
            this.gridControlGetProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGetProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlGetProducts.Location = new System.Drawing.Point(0, 0);
            this.gridControlGetProducts.MainView = this.dataviewprod;
            this.gridControlGetProducts.Name = "gridControlGetProducts";
            this.gridControlGetProducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.gridControlGetProducts.Size = new System.Drawing.Size(1051, 473);
            this.gridControlGetProducts.TabIndex = 0;
            this.gridControlGetProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataviewprod});
            this.gridControlGetProducts.TabIndexChanged += new System.EventHandler(this.gridControlGetProducts_TabIndexChanged);
            this.gridControlGetProducts.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControlGetProducts.Validating += new System.ComponentModel.CancelEventHandler(this.gridControlGetProducts_Validating);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(WindowsFormsApp2.OrderDetail);
            // 
            // dataviewprod
            // 
            this.dataviewprod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.Discount,
            this.Total});
            this.dataviewprod.CustomizationFormBounds = new System.Drawing.Rectangle(1018, 335, 322, 276);
            this.dataviewprod.GridControl = this.gridControlGetProducts;
            this.dataviewprod.Name = "dataviewprod";
            this.dataviewprod.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dataviewprod_InitNewRow);
            this.dataviewprod.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.dataviewprod_InvalidRowException);
            this.dataviewprod.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.dataviewprod_ValidateRow);
            this.dataviewprod.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.dataviewprod_ValidatingEditor);
            this.dataviewprod.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.dataviewprod_InvalidValueException);
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.FieldName = "ProductID";
            this.Id.MinWidth = 25;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 94;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 25;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            this.Quantity.Width = 94;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Caption = "Unit Price";
            this.UnitPrice.FieldName = "UnitPrice";
            this.UnitPrice.MinWidth = 25;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = true;
            this.UnitPrice.VisibleIndex = 3;
            this.UnitPrice.Width = 94;
            // 
            // Discount
            // 
            this.Discount.Caption = "Discount";
            this.Discount.FieldName = "Discount";
            this.Discount.MinWidth = 25;
            this.Discount.Name = "Discount";
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 4;
            this.Discount.Width = 94;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.MinWidth = 25;
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 5;
            this.Total.Width = 94;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // xtraTabPagAddProduct
            // 
            this.xtraTabPagAddProduct.Controls.Add(this.layoutControl2);
            this.xtraTabPagAddProduct.Name = "xtraTabPagAddProduct";
            this.xtraTabPagAddProduct.Size = new System.Drawing.Size(1051, 473);
            this.xtraTabPagAddProduct.Text = "Add Product";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.button1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1051, 473);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1027, 449);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1051, 473);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.button1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1031, 453);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // xtraTabPagEditProduct
            // 
            this.xtraTabPagEditProduct.Name = "xtraTabPagEditProduct";
            this.xtraTabPagEditProduct.Size = new System.Drawing.Size(1051, 473);
            this.xtraTabPagEditProduct.Text = "Edit Product";
            this.xtraTabPagEditProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // xtraTabPagRemoveProduct
            // 
            this.xtraTabPagRemoveProduct.Name = "xtraTabPagRemoveProduct";
            this.xtraTabPagRemoveProduct.Size = new System.Drawing.Size(1051, 473);
            this.xtraTabPagRemoveProduct.Text = "Remove Product";
            // 
            // xtraTabStore
            // 
            this.xtraTabStore.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabStore.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabStore.Name = "xtraTabStore";
            this.xtraTabStore.Size = new System.Drawing.Size(1058, 507);
            this.xtraTabStore.Text = "Store";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 541);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.xtraTabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlProducts)).EndInit();
            this.xtraTabControlProducts.ResumeLayout(false);
            this.xtraTabPagGetProducts.ResumeLayout(false);
            this.xtraTabPagGetProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGetProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.xtraTabPagAddProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabInvoice;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem dtFromDate;
        private DevExpress.XtraLayout.LayoutControlItem dtToDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraTab.XtraTabPage xtraTabProducts;
        private DevExpress.XtraTab.XtraTabPage xtraTabStore;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlProducts;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagGetProducts;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagAddProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagEditProduct;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagRemoveProduct;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProduct;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlGetProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView dataviewprod;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Discount;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditRemain;
        private DevExpress.XtraEditors.TextEdit textEditPaid;
        private DevExpress.XtraEditors.TextEdit textEditTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnShow;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Show;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFrieght;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnShipCity;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}