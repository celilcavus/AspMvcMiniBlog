using MyMiniBlog1.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBlog1.Models.Views
{
    public class ViewMyBlog : blogPost
    {
        public string blogTagName { get; set; }
    }
}