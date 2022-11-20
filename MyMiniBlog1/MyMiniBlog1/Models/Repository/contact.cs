using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBlog1.Models.Repository
{
    public class contact
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string userlastname { get; set; }
        public string useremail { get; set; }
        public string usermessage { get; set; }
    }
}