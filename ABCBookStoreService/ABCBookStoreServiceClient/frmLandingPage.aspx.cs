using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABCBookStoreServiceClient
{
    public partial class frmLandingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLandingPage.aspx");
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInsertBook.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmDeleteBook.aspx");
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmRetrieveAllBooks.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmUpdateBook.aspx");
        }

        protected void btnViewByDate_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmShowBooksByDate.aspx");
        }

        protected void btnViewByPrice_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmShowBooksByPrice.aspx");
        }

        protected void btnViewByPublisher_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmShowBooksByPublisher.aspx");
        }

        protected void btnViewByAuthor_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmShowBooksByAuthor.aspx");
        }
    }
}