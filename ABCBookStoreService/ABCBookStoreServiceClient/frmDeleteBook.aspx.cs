using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ABCBookStoreServiceClient.ABCBookStoreServiceReference;


namespace ABCBookStoreServiceClient
{
    public partial class frmDeleteBook : System.Web.UI.Page
    {
        ABCBookStoreDeleteServiceClient client = new ABCBookStoreDeleteServiceClient();
        ABCBookStoreRetrieveAllServiceClient clientGetBooks = new ABCBookStoreRetrieveAllServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            gvAllBooks.DataSource = clientGetBooks.RetrieveAll().BookSet;
            gvAllBooks.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                float isbn = float.Parse(txtISBNNumber.Text);
                lblMsg.Text = client.Delete(isbn);
                gvAllBooks.DataSource = clientGetBooks.RetrieveAll().BookSet;
                gvAllBooks.DataBind();
            } 
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                lblMsg.Text = "Invalid input try again";
            }
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLandingPage.aspx");
        }
    }
}