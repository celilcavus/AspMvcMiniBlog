using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBlog1.Models.Repository
{
    public class blogPost
    {
        public int? userId { get; set; }
        public string blogimage { get; set; }
        public string blogtitle { get; set; }
        public string blogContact { get; set; }
        public string blogLinkedlinLink { get; set; }
        public string blogGithupLink { get; set; }
        public string blogInstagramLink { get; set; }
        public string blogTwitterLink { get; set; }
        public string blogFacebookLink { get; set; }
        public byte? blogPostTag { get; set; }
        public DateTime? blogYayinTarih { get; set; }
    }
}