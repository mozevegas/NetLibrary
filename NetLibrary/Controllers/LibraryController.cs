using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NetLibrary.Models;

namespace NetLibrary.Controllers
{
    public class LibraryController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAllBooks()
        {
            // this is where the code (sqlCommand)

            //return Ok("Oh yeah, I think it works");

            // DatabaseLocation
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=MyLibraryDB;Trusted_Connection=True;";


            var bookList = new List<BookClass>();
            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Connected!");
                var sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = @"SELECT * FROM LibraryTable";
                connection.Open();


                var reader = sqlCommand.ExecuteReader();


                while (reader.Read())
                {
                    var bookz = new BookClass(reader);
                    bookList.Add(bookz);
                }



                connection.Close();
            }

            return Ok(bookList);

        }
        [HttpPut]
        public IHttpActionResult AddBook ()
        {
            return Ok();
        }

    }
}
