using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NetLibrary.Models
{
    public class BookClass
    {
       

        public BookClass(SqlDataReader reader)
        {
            this.Title = reader["Title"].ToString();
            this.Author = reader["Author"].ToString();
            this.YearPublished = (int)reader["YearPublished"];
            this.Genre = reader["Genre"].ToString();
            this.IsCheckedOut = (bool)reader["IsCheckedOut"];
            this.LastCheckedOut = reader["LastCheckedOut"].ToString();
            this.DueBackDate = reader["DueBackDate"].ToString();

        }

        public string id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public string Genre { get; set; }
        public bool IsCheckedOut { get; set; }
        public string LastCheckedOut { get; set; }
        public string DueBackDate { get; set; }

    }
}