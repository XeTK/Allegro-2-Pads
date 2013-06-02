using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadsConvert
{
    class PadConvert
    {
        private string old_pad_name, new_pad_name, old_dot_pad_file, new_dot_pad_file;

        public string New_dot_pad_file
        {
            get { return new_dot_pad_file; }
            set { new_dot_pad_file = value; }
        }

        public string Old_dot_pad_file
        {
            get { return old_dot_pad_file; }
            set { old_dot_pad_file = value; }
        }

        public string New_pad_name
        {
            get { return new_pad_name; }
            set { new_pad_name = value; }
        }

        public string Old_pad_name
        {
            get { return old_pad_name; }
            set { old_pad_name = value; }
        }

    }
}
