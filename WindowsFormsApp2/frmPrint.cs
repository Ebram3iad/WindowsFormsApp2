using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp2
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintInvoice(Orders orders, List<OrderDetail> Data)
        {
            InvoiceReport2 report = new InvoiceReport2();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
                report.InitData(orders.OrderID.ToString(), orders.OrderDate, orders.ContactName, orders.Address, orders.PostalCode, orders.City, orders.Phone, Data);
                documentViewer1.DocumentSource = report;
                report.CreateDocument();
            }
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}