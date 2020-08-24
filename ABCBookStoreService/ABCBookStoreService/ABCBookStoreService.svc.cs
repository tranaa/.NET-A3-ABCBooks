using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABCBookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ABCBookStoreService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ABCBookStoreService.svc or ABCBookStoreService.svc.cs at the Solution Explorer and start debugging.
    public class ABCBookStoreService : IABCBookStoreInsertService, IABCBookStoreRetrieveByDateService, IABCBookStoreRetrieveByPriceService, IABCBookStoreRetrieveByPublisherService, IABCBookStoreRetrieveByAuthorService, IABCBookStoreDeleteService, IABCBookStoreUpdateService, IABCBookStoreRetrieveAllService
    {
        SqlConnection conn;

        public void GetDBConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ABCBookstoreDB"].ConnectionString);
        }
        public string Delete(float isbn)
        {
            string msg = string.Empty;
            GetDBConnection();
            conn.Open();
            string cmdTxt = "DELETE FROM BookInfo WHERE ISBNNumber = @isbn";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                msg = "Book deleted successfully";
            else
                msg = "Book deletion failed";
            conn.Close();
            return msg;
        }

        public string Insert(Book book)
        {
            string msg = string.Empty;
            GetDBConnection();
            conn.Open();
            string cmdTxt = "Insert into BookInfo values(@isbn, @title, @author, @publishDate, @publisher, @pageCount, @price)";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@title", book.BookTitle);
            cmd.Parameters.AddWithValue("@author", book.AuthorList);
            cmd.Parameters.AddWithValue("@isbn", book.ISBNNumber);
            cmd.Parameters.AddWithValue("@publishDate", DateTime.Parse(book.PublishingDate).ToString("yyyy-dd-MM"));
            cmd.Parameters.AddWithValue("@publisher", book.Publisher);
            cmd.Parameters.AddWithValue("@pageCount", book.PageCount);
            cmd.Parameters.AddWithValue("@price", book.Price);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                msg = "Book inserted successfully";
            else
                msg = "Book insertion failed";
            conn.Close();
            return msg;
        }

        public RetrieveBooks RetrieveAll()
        {
            RetrieveBooks books = new RetrieveBooks();
            GetDBConnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from BookInfo", conn);
            da.Fill(ds);
            books.BookSet = ds;
            conn.Close();
            return books;
        }

        public RetrieveBooks RetrieveByAuthor(string author)
        {
            RetrieveBooks books = new RetrieveBooks();
            GetDBConnection();
            conn.Open();
            string cmdTxt = "SELECT * FROM BookInfo WHERE AuthorList LIKE @author";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@author", "%" + author + "%");
            DataSet bookDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bookDataSet);
            books.BookSet = bookDataSet;
            conn.Close();
            return books;
        }

        public RetrieveBooks RetrieveByDate(string date)
        {
            RetrieveBooks books = new RetrieveBooks();
            GetDBConnection();
            conn.Open();
            string formattedDate = DateTime.Parse(date).ToString("yyyy-dd-MM");
            string cmdTxt = "SELECT * FROM BookInfo WHERE PublishingDate > @date";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@date", formattedDate);
            DataSet bookDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bookDataSet);
            books.BookSet = bookDataSet;
            conn.Close();
            return books;
        }

        public RetrieveBooks RetrieveByPrice(float price)
        {
            RetrieveBooks books = new RetrieveBooks();
            GetDBConnection();
            conn.Open();
            string cmdTxt = "SELECT * FROM BookInfo WHERE Price >  @price";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@price", price);
            DataSet bookDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bookDataSet);
            books.BookSet = bookDataSet;
            conn.Close();
            return books;
        }

        public RetrieveBooks RetrieveByPublisher(string publisher)
        {
            RetrieveBooks books = new RetrieveBooks();
            GetDBConnection();
            conn.Open();
            string cmdTxt = "SELECT * FROM BookInfo WHERE Publisher LIKE @publisher";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@publisher", "%" + publisher + "%");
            DataSet bookDataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bookDataSet);
            books.BookSet = bookDataSet;
            conn.Close();
            return books;
        }

        public string Update(Book book)
        {
            string msg = string.Empty;
            GetDBConnection();
            conn.Open();
            string cmdTxt = "UPDATE BookInfo SET AuthorList=@author, PublishingDate=@publishDate, Publisher=@publisher, PageCount=@pageCount, Price=@price WHERE BookTitle LIKE @title";
            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Parameters.AddWithValue("@title", "%" + book.BookTitle + "%");
            cmd.Parameters.AddWithValue("@author", book.AuthorList);
            cmd.Parameters.AddWithValue("@publishDate", book.PublishingDate);
            cmd.Parameters.AddWithValue("@publisher", book.Publisher);
            cmd.Parameters.AddWithValue("@pageCount", book.PageCount);
            cmd.Parameters.AddWithValue("@price", book.Price);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                msg = "Book updated successfully";
            else
                msg = "Book update failed";
            conn.Close();
            return msg;
        }
    }
}
