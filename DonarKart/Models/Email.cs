using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonarKart.Models
{
    public class Email
    {
        public string ToEmail { get; set; }
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}