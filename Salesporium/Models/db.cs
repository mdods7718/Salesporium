using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Salesporium.Models
{
    public class db
    {
        //creating a new sql connection with the db from appsettings
        SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=SalesporiumContext-24e06f0c-d846-4eed-8a07-bebaefa2a741;Trusted_Connection=True;MultipleActiveResultSets=true");

        public DataTable Getrecord()
        {
            //using sql statement to grab all records from sales table
            SqlCommand com = new SqlCommand("select * from dbo.Sales", con);

            //data adapter works as a bridge between DataSet and Database. It opens the database connection, executes the SQL statements and closes the connection.
            SqlDataAdapter da = new SqlDataAdapter(com);

            //database table representation and provides a collection of columns and rows to store data in a grid form
            DataTable dt = new DataTable();

            // dataAdapter using its Fill() method is used to fill the DataSet or DataTable.
            da.Fill(dt);
            return dt;
        }
    }
}