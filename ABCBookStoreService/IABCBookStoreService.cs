using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ABCBookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IABCBookStoreService" in both code and config file together.
    [ServiceContract]
    public interface IABCBookStoreInsertService
    {
        [OperationContract]
        string Insert(Book book);
    }

    [ServiceContract]
    public interface IABCBookStoreRetrieveAllService
    {
        [OperationContract]
        RetrieveBooks RetrieveAll();
    }

    [ServiceContract]
    public interface IABCBookStoreUpdateService
    {
        [OperationContract]
        string Update(Book book);
    }

    [ServiceContract]
    public interface IABCBookStoreDeleteService
    {
        [OperationContract]
        string Delete(float isbn);
    }

    [ServiceContract]
    public interface IABCBookStoreRetrieveByAuthorService
    {
        [OperationContract]
        RetrieveBooks RetrieveByAuthor(string author);
    }


    [ServiceContract]
    public interface IABCBookStoreRetrieveByPublisherService
    {
        [OperationContract]
        RetrieveBooks RetrieveByPublisher(string publisher);
    }


    [ServiceContract]
    public interface IABCBookStoreRetrieveByPriceService
    {
        [OperationContract]
        RetrieveBooks RetrieveByPrice(float price);
    }


    [ServiceContract]
    public interface IABCBookStoreRetrieveByDateService
    {
        [OperationContract]
        RetrieveBooks RetrieveByDate(string date);
    }

    [DataContract]
    public class RetrieveBooks
    {
        [DataMember]
        public DataSet BookSet { get; set; }
    }

    [DataContract]
    public class Book
    {
        [DataMember]
        public float ISBNNumber { get; set; }
        [DataMember]
        public string AuthorList { get; set; }
        [DataMember]
        public string BookTitle { get; set; }
        [DataMember]
        public string PublishingDate { get; set; }
        [DataMember]
        public string Publisher { get; set; }
        [DataMember]
        public int PageCount { get; set; }
        [DataMember]
        public float Price { get; set; }
    }

}
