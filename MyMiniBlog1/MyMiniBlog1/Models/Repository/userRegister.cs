using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBlog1.Models.Repository
{
    public class userRegister
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string userassword { get; set; }
        public string userEmail { get; set; }
        public string userGender { get; set; }
    }
}