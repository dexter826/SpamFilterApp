using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamFilterApp
{
    public class Email
    {
        public string Content { get; set; }
        public bool IsSpam { get; set; }
        public double SpamProbability { get; set; } // Xác suất email là spam
        public double NotSpamProbability { get; set; } // Xác suất email không phải spam
    }
}
