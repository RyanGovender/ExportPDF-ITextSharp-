using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PdfConvert.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentNumber { get; set; }
        public string Course { get; set; }
    }
}