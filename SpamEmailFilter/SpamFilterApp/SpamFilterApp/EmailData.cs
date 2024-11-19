using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamFilterApp
{
    public class EmailData
    {
        public string label { get; set; }  // Nhãn spam hay không spam
        public string content { get; set; } // Nội dung email
    }
}
