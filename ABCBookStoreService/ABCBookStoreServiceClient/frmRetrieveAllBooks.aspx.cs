using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ABCBookStoreServiceClient.ABCBookStoreServiceReference;


namespace ABCBookStoreServiceClient
{

    public partial class frmRetrieveAllBooks : System.Web.UI.Page
    {
        ABCBookStoreRetrieveAllServiceClient client = new ABCBookStoreRetrieveAllServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvAllBooks.DataSource = client.RetrieveAll().BookSet;
            gvAllBooks.DataBind();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLandingPage.aspx");
        }
    }
}