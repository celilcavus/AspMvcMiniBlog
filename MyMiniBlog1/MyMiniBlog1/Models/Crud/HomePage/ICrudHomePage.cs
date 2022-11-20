using MyMiniBlog1.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBlog1.Models.Crud.HomePage
{
    public interface ICrudHomePage <T> where T : class
    {
        List<T> getlist(string query);
        List<ViewMyBlog> getviewList(string query);
       
    }
}