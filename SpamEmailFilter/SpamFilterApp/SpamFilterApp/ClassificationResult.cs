using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamFilterApp
{
    public class ClassificationResult
    {
        public int Index { get; set; }
        public string Content { get; set; }
        public string Result { get; set; }
        public double SpamProbability { get; set; }
        public double NotSpamProbability { get; set; }
    }
}
