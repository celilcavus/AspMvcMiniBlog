using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace MyMiniBlog1.Models.DbContext
{
    public class DbContext
    {

        public SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=myblog1;Integrated Security=True");
        public DbContext()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}