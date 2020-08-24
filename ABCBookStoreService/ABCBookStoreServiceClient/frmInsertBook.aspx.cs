using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ABCBookStoreServiceClient.ABCBookStoreServiceReference;

namespace ABCBookStoreServiceClient
{
    public partial class frmInsertBook : System.Web.UI.Page
    {
        ABCBookStoreInsertServiceClient client = new ABCBookStoreInsertServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.BookTitle = txtBookTitle.Text;
                book.AuthorList = txtAuthorList.Text;
                book.ISBNNumber = float.Parse(txtISBNNumber.Text);
                book.PublishingDate = DateTime.Parse(txtPublishingDate.Text).ToString("yyyy-dd-MM");
                book.Publisher = txtPublisher.Text;
                book.PageCount = Int32.Parse(txtPageCount.Text);
                book.Price = float.Parse(txtPrice.Text);
                lblMsg.Text = client.Insert(book);
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