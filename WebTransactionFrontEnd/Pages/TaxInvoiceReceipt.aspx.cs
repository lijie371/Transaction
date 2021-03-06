﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransactionFrontEnd.ViewPayment;

public partial class Pages_TaxInvoiceReceipt : System.Web.UI.Page
{
    public ViewPayment Model
    {
        get { return Session["ViewPayment"] as ViewPayment; }
        set { Session["ViewPayment"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Model == null)
            {
                throw new ApplicationException("MISSING_MODEL");
            }

            byte[] pdf = Model.CreateTaxInvoiceReceipt();


        }
    }
}