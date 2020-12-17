using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public partial class InvoiceReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport2()
        {
            InitializeComponent();
        }

        public void InitData(string orderid, DateTime orderdate, string customer, string address, string postalcode,string city, string phone, List<OrderDetail> data )
        {
            pCustomerName.Value = customer;
            pOrderID.Value = orderid;
            pDate.Value = orderdate.Date;
            pCity.Value = city;
            pPhone.Value = phone;
            pPostalCode.Value = postalcode;
            pAddress.Value = address;
            objectDataSource1.DataSource = data;
        }

    }
}
