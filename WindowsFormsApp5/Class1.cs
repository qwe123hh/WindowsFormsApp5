using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    internal class Class1
    {
    }
}




public class DBConnection
{
    private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SportsDB;Integrated Security=True";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}