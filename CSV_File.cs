using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace PadsConvert
{
    class CSV_File
    {
        private string path;

        private List<Pad_Line> pads = new List<Pad_Line>();

        public CSV_File(String path)
        {
            this.path = path;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string re1 = "(\\d+)";	// Integer Number 1
                string re2 = ".*?";	// Non-greedy match on filler
                string re3 = "((?:[a-z][a-z0-9_]*))";	// Variable Name 1
                string re4 = ".*?";	// Non-greedy match on filler
                string re5 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";	// Float 1
                string re6 = ".*?";	// Non-greedy match on filler
                string re7 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";	// Float 2
                string re8 = ".*?";	// Non-greedy match on filler
                string re9 = "(\\d+)";	// Integer Number 2
                string re10 = ".*?";	// Non-greedy match on filler
                string re11 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";	// Float 3
                string re12 = ".*?";	// Non-greedy match on filler
                string re13 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";	// Float 4
                string re14 = ".*?";	// Non-greedy match on filler
                string re15 = "(\\d+)";	// Integer Number 3

                Regex r = new Regex(re1 + re2 + re3 + re4 + re5 + re6 + re7 + re8 + re9 + re10 + re11 + re12 + re13 + re14 + re15, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (r.Match(line).Success)
                    pads.Add(new Pad_Line(line));
            }
        }

        internal List<Pad_Line> Pads
        {
            get { return pads; }
            set { pads = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
