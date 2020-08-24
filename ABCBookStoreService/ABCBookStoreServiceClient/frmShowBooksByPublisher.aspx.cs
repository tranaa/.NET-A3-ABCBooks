using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ABCBookStoreServiceClient.ABCBookStoreServiceReference;

namespace ABCBookStoreServiceClient
{
    public partial class frmShowBooksByPublisher : System.Web.UI.Page
    {
        ABCBookStoreRetrieveByPublisherServiceClient client = new ABCBookStoreRetrieveByPublisherServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLandingPage.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet books = client.RetrieveByPublisher(txtPublisher.Text).BookSet;
                gvAllBooks.DataSource = books;
                gvAllBooks.DataBind();
                lblWarning.Text = books.Tables[0].Rows.Count > 0 ? "Search successful" : "Nothing Found";
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                lblWarning.Text = "Invalid input try again";
            }
        }
    }
}