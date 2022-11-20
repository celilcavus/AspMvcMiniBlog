using MyMiniBlog1.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using MyMiniBlog1.Models.Crud.CrudHelperMetot;

namespace MyMiniBlog1.Models.Crud.ContactAndAboutPage
{
    public class CrudContactAndAboutPage : DbContext.DbContext, ICrudAbout<about>, ICrudContact<contact>
    {
        public int contactAdd(contact item)
        {
            return conn.Execute($"insert into {TableName.contact.ToString()} (userid,username,userlastname,useremail,usermessage) values ({item.userid},'{item.username}','{item.userlastname}','{item.useremail}','{item.usermessage}')");
        }

        public List<about> getaboutList(string query)
        {
            return conn.Query<about>(query).ToList();
        }
    }
}