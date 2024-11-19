using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamEmaiAlpp
{
    public class Email
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public bool IsSpam { get; set; }
        public double SpamProbability { get; set; } // Xác suất email là spam
        public double NotSpamProbability { get; set; } // Xác suất email không phải spam

        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public DateTime DateTime { get; set; }
    }
}
