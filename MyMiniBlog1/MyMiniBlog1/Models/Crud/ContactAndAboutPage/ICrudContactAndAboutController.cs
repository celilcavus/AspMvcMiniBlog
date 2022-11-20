using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBlog1.Models.Crud.ContactAndAboutPage
{
    public interface ICrudContact<T> where T : class
    {
       
        int contactAdd(T item);
        
    }
    public interface ICrudAbout<T> where T : class
    {
        List<T> getaboutList(string query);

    }

}