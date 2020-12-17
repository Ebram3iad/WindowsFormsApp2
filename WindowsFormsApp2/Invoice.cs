using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;

namespace WindowsFormsApp2
{
    public partial class Invoice : Form
    {
        public List<OrderDetail> currentorder = new List<OrderDetail>();

        public Orders ordersObj;
        public List<Orders> orderList = new List<Orders>();
        public Invoice()
        {
            InitializeComponent();
        }

        public void CalulateTotalPrice()
        {
            decimal totalPrice = 0;
            if (currentorder == null)
                return;
            foreach (var item in currentorder)
            {
                totalPrice += item.Total;
            }
            textEditTotal.Text = totalPrice.ToString();
        }
        public void LoadCategoryComBox()
        {
            
                    // "select  ProductID,ProductName,c.CategoryID,QuantityPerUnit,UnitPrice,Discontinued FROM Products p inner join Categories c on p.CategoryID=c.CategoryID";
                    productsBindingSource.DataSource = Products.GetProducts();
                    // "select CategoryID, CategoryName from Categories";
                    categoriesBindingSource.DataSource = Categories.GetCategories();             
        }


        private void btnPrint_Click(object sender, EventArgs e) { }
        private void btnLoad_Click(object sender, EventArgs e) { }
        private void Invoice_Load(object sender, EventArgs e) { }
        private void xtraTabPage2_Paint(object sender, PaintEventArgs e) { }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPageIndex)
            {

                default:
                    break;
            }
        }

        private void gridControl_Click(object sender, EventArgs e) { }
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
                {
                    dateEdit2.EditValue = DateTime.Now;
                    dateEdit1.EditValue = "1/2/1999";
                    ordersBindingSource.DataSource = Orders.GetOrdersBetweenToDates(dateEdit1.EditValue.ToString(), dateEdit2.EditValue.ToString());

                }
                else
                {
                    ordersBindingSource.DataSource = Orders.GetOrdersBetweenToDates(dateEdit1.EditValue.ToString(), dateEdit2.EditValue.ToString());
                }

            }
            catch (Exception err)
            {

                string message = err.Message;          
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (frmPrint frm = new frmPrint())
                {
                    frm.PrintInvoice(obj, OrderDetail.GetOrderDetailsById(obj.OrderID));
                    frm.ShowDialog();
                }
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e) { }
        private void gridControl1_Click(object sender, EventArgs e) { }
        private void xtraTabControlProducts_Click(object sender, EventArgs e) { }
        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabPagGetProducts_Paint(object sender, PaintEventArgs e) { }
        private void lookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    int selectedCompoCategoryValue = int.Parse(lookUpEditCategory.EditValue.ToString());
                    string productBYCatId = $"select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Categories.CategoryID = {selectedCompoCategoryValue}";
                    productsBindingSource.DataSource = db.Query<Products>(productBYCatId, commandType: CommandType.Text);
                }
            }
        }



        private void lookUpEditProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditProduct.EditValue != null)
            {
                int quantity = 1;
                OrderDetail order = null;
                int selectedCompoProductValue = int.Parse(lookUpEditProduct.EditValue.ToString());
                Products prod = Products.getproduct(selectedCompoProductValue);
                if (prod != null)
                {
                    if (dataviewprod.RowCount == 0)
                    {
                        currentorder = new List<OrderDetail>();
                        currentorder.Add(new OrderDetail() { ProductID = prod.ProductID, ProductName = prod.ProductName, UnitPrice = prod.UnitPrice, Discount = 0, Quantity = quantity });
                        gridControlGetProducts.DataSource = currentorder;
                        gridControlGetProducts.RefreshDataSource();
                    }
                    else
                    {
                        currentorder = gridControlGetProducts.DataSource as List<OrderDetail>;
                        OrderDetail item = currentorder.Find(p => p.ProductID == prod.ProductID);
                        if (item != null)
                        {
                            item.Quantity = item.Quantity + 1;
                        }
                        else
                        {
                            order = new OrderDetail() { ProductID = prod.ProductID, ProductName = prod.ProductName, UnitPrice = prod.UnitPrice, Discount = 0, Quantity = quantity };
                            currentorder.Add(order);
                        }
                        gridControlGetProducts.DataSource = null;
                        gridControlGetProducts.DataSource = currentorder;
                        gridControlGetProducts.RefreshDataSource();
                    }
                }
            }
            CalulateTotalPrice();
        }


        private void lookUpEditProduct_Click(object sender, EventArgs e)
        {
        }

        private void lookUpEditProduct_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void lookUpEditProduct_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lookUpEditProduct_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {

        }

        private void lookUpEditProduct_Properties_Click(object sender, EventArgs e)
        {

        }

        private void gridControlGetProducts_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dataviewprod_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            CalulateTotalPrice();
            if (dataviewprod.FocusedColumn.FieldName == "Quantity")
            {
                double quantity = 0;

                if (!Double.TryParse(e.Value as string, out quantity))
                {
                    e.Valid = false;
                    e.ErrorText = "Only numeric values are accepted.";
                }
                else if (quantity <= 0)
                {
                    e.Valid = false;
                    e.ErrorText = "The quantity must be more than Zero 0";
                }
            }
            else if (dataviewprod.FocusedColumn.FieldName == "UnitPrice")
            {
                double unitPrice = 0;

                if (!Double.TryParse(e.Value as string, out unitPrice))
                {
                    e.Valid = false;
                    e.ErrorText = "Only numeric values are accepted.";
                }
                else if (unitPrice <= 0)
                {
                    e.Valid = false;
                    e.ErrorText = "The unitPrice must be more than Zero 0";
                }
            }
            else if (dataviewprod.FocusedColumn.FieldName == "Discount")
            {
                double discount = 0;
                if (!Double.TryParse(e.Value as string, out discount))
                {
                    e.Valid = false;
                    e.ErrorText = "Only numeric values are accepted.";
                }
                else if (discount <= 0)
                {
                    e.Valid = false;
                    e.ErrorText = "The unitPrice must be more than Zero 0";
                }
            }
        }

        private void dataviewprod_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show(this, e.ErrorText, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void dataviewprod_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn colQuantity = dataviewprod.Columns["Quantity"];
            GridColumn colDiscount = dataviewprod.Columns["Discount"];
            GridColumn colUnitPrice = dataviewprod.Columns["UnitPrice"];

            double quantity = Convert.ToDouble(dataviewprod.GetRowCellValue(dataviewprod.FocusedRowHandle, colQuantity));
            double discount = Convert.ToDouble(dataviewprod.GetRowCellValue(dataviewprod.FocusedRowHandle, colDiscount));
            double unitPrice = Convert.ToDouble(dataviewprod.GetRowCellValue(dataviewprod.FocusedRowHandle, colUnitPrice));
            double netDiscountValue = unitPrice * (discount / 100);
            if (netDiscountValue >= unitPrice)
            {
                dataviewprod.SetColumnError(colDiscount, $"The Discount value should be less than this value");
                dataviewprod.SetColumnError(null, "Invalid data");
                e.Valid = false;
                e.ErrorText = "The Discount value should be less than this value";
            }

            CalulateTotalPrice();
        }

        private void dataviewprod_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) { }
        private void dataviewprod_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            MessageBox.Show(this, e.ErrorText, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);

            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void xtraTabControlProducts_TabIndexChanged(object sender, EventArgs e) { }
        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e) { }
        private void gridControlGetProducts_TabIndexChanged(object sender, EventArgs e) { }
        private void xtraTabControlProducts_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) { }
        public enum opType
        {
            add = 0,
            update = 1,
            delete = 2
        }
        public void refreshOrderGrid(Orders order, opType type)
        {
            if (type == opType.add)
            {
                orderList.Add(order);
                ordersBindingSource.DataSource = orderList;
                gridControl.RefreshDataSource();
            }
        }
        private void textEditPaid_EditValueChanged(object sender, EventArgs e)
        {
            if (textEditPaid.EditValue.ToString() == "" || textEditPaid.EditValue == null)
            {
                textEditRemain.EditValue = textEditPaid.EditValue = "0";
                return;
            }
            if (Convert.ToDecimal(textEditPaid.EditValue.ToString()) == 0)
            {
                textEditRemain.EditValue = textEditTotal.EditValue;
                return;
            }
            if (Convert.ToDecimal(textEditPaid.EditValue.ToString()) >= Convert.ToDecimal(textEditTotal.EditValue.ToString()))
            {
                textEditRemain.EditValue = "0";
                textEditPaid.EditValue = textEditTotal.EditValue;
                return;
            }
            decimal paid = Convert.ToDecimal(textEditPaid.EditValue.ToString());
            decimal total = Convert.ToDecimal(textEditTotal.EditValue.ToString());
            decimal remain = 0;
            remain = total - paid;
            textEditRemain.EditValue = remain.ToString();
        }

        private void textEditPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^0-9]\.\d");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}

            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void textEditPaid_KeyDown(object sender, KeyEventArgs e)
        {

            //if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode == Keys.Space))
            //{
            //   preventdefault
            //}
        }

        private void xtraTabControl1_TabIndexChanged(object sender, EventArgs e) { }
        private void xtraTabControl1_SelectedPageChangeAnimationCompleted(object sender, DevExpress.XtraTab.TabPageChangeEventArgs e) { }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 1:
                    LoadCategoryComBox();
                    break;
                case 0:
                    //ordersBindingSource.DataSource = orderList;
                    break;
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ordersObj == null)
            {
                ordersObj = new Orders();
                ordersObj.OrderDate = DateTime.Now.Date;
                ordersObj.Total = Convert.ToDecimal(textEditTotal.EditValue.ToString());
                ordersObj.Paid = Convert.ToDecimal(textEditPaid.EditValue.ToString());
                ordersObj.Remain = Convert.ToDecimal(textEditRemain.EditValue.ToString());
                ordersObj.Insert();
                refreshOrderGrid(ordersObj, opType.add);
                foreach (var item in currentorder)
                {
                    item.Insert();
                }
                //orderList.Add(ordersObj.GetOrderById(Orders.GetOrderId()));
                MessageBox.Show("Saved Successfully !");
            }
            else
            {
                ordersObj.OrderDate = DateTime.Now.Date;
                ordersObj.Total = Convert.ToDecimal(textEditTotal.EditValue.ToString());
                ordersObj.Paid = Convert.ToDecimal(textEditPaid.EditValue.ToString());
                ordersObj.Remain = Convert.ToDecimal(textEditRemain.EditValue.ToString());
                ordersObj.Update();
                refreshOrderGrid(ordersObj, opType.update);
                foreach (var item in currentorder)
                {
                    item.Update(ordersObj.OrderID);
                }
                MessageBox.Show("Updated Successfully !");
            }
        }

        private void reprositoryShow_Click(object sender, EventArgs e) { }
        private void Show_Click(object sender, EventArgs e)
        {
            ordersObj = ordersBindingSource.Current as Orders;
            if (ordersObj != null)
            {
                currentorder = OrderDetail.GetOrderDetailsById(ordersObj.OrderID);
                gridControlGetProducts.DataSource = currentorder;
                textEditTotal.EditValue = ordersObj.Freight;
                textEditPaid.EditValue = ordersObj.ShipCountry;
                decimal remain = Convert.ToDecimal(ordersObj.Freight) - Convert.ToDecimal(ordersObj.ShipCountry);
                textEditRemain.EditValue = remain;
                xtraTabControl1.SelectedTabPageIndex = 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ordersObj.Delete();
            gridControlGetProducts.DataSource = null;
            textEditTotal.EditValue = 0;
            textEditPaid.EditValue = 0;
            textEditRemain.EditValue = 0;
            ordersObj = null;
            //refreshOrderGrid(ordersObj, opType.delete);
            MessageBox.Show("Deleted Successfully");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControlGetProducts.DataSource = null;
            textEditTotal.EditValue = 0;
            textEditPaid.EditValue = 0;
            textEditRemain.EditValue = 0;
            ordersObj = null;
        }
    }
}

