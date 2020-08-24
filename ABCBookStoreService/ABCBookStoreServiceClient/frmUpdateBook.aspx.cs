using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ABCBookStoreServiceClient.ABCBookStoreServiceReference;

namespace ABCBookStoreServiceClient
{
    public partial class frmUpdateBook : System.Web.UI.Page
    {
        ABCBookStoreUpdateServiceClient client = new ABCBookStoreUpdateServiceClient();
        ABCBookStoreRetrieveAllServiceClient clientGetBooks = new ABCBookStoreRetrieveAllServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvAllBooks.DataSource = clientGetBooks.RetrieveAll().BookSet;
            gvAllBooks.DataBind();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.BookTitle = txtBookTitle.Text;
                book.AuthorList = txtAuthorList.Text;
                book.ISBNNumber = 0;
                book.PublishingDate = DateTime.Parse(txtPublishingDate.Text).ToString("yyyy-MM-dd");
                book.Publisher = txtPublisher.Text;
                book.PageCount = Int32.Parse(txtPageCount.Text);
                book.Price = float.Parse(txtPrice.Text);
                lblMsg.Text = client.Update(book);
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