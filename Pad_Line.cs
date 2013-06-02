using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PadsConvert
{
    class Pad_Line
    {
        private int pin_no;

        private string pad_Stack;

        private float x, y, rotation, text_Offset_X, text_Offset_Y, text_Rotate, text_Mirror;

        public Pad_Line(string info)
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
            Match m = r.Match(info);
            if (m.Success)
            {
                pin_no = Convert.ToInt32(m.Groups[1].ToString());
                pad_Stack = m.Groups[2].ToString();
                x = Convert.ToSingle(m.Groups[3].ToString());
                y = Convert.ToSingle(m.Groups[4].ToString());
                rotation = Convert.ToSingle(m.Groups[5].ToString());
                text_Offset_X = Convert.ToSingle(m.Groups[6].ToString());
                text_Offset_Y = Convert.ToSingle(m.Groups[7].ToString());
                text_Rotate = Convert.ToSingle(m.Groups[8].ToString());
            }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public float Text_Offset_X
        {
            get { return text_Offset_X; }
            set { text_Offset_X = value; }
        }

        public float Text_Offset_Y
        {
            get { return text_Offset_Y; }
            set { text_Offset_Y = value; }
        }

        public float Text_Rotate
        {
            get { return text_Rotate; }
            set { text_Rotate = value; }
        }

        public float Text_Mirror
        {
            get { return text_Mirror; }
            set { text_Mirror = value; }
        }

        public int Pin_no
        {
            get { return pin_no; }
            set { pin_no = value; }
        }

        public string Pad_Stack
        {
            get { return pad_Stack; }
            set { pad_Stack = value; }
        }
    }
}
