
using MyMiniBlog1.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MyMiniBlog1.Models.Crud.CrudHelperMetot;
using Dapper;
using MyMiniBlog1.Models.Views;

namespace MyMiniBlog1.Models.Crud.HomePage
{
    public class CrudHomePage : DbContext.DbContext, ICrudHomePage<blogPost>
    {
        public List<blogPost> getlist(string query)
        {
            return conn.Query<blogPost>(query).ToList();
        }

        public List<ViewMyBlog> getviewList(string query)
        {
            return conn.Query<ViewMyBlog>(query).ToList();
        }
    }
}