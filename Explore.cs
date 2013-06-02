using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PadsConvert
{
    class Explore
    {
        public String[] find_CSV(String parent_Dir)
        {
            return find_FileType(parent_Dir, ".csv");
        }
        public String[] find_PADS(string parent_Dir)
        {
            return find_FileType(parent_Dir, ".pad");
        }

        private String[] find_FileType(string parent_Dir, string file_type)
        {
            string[] filepaths = Directory.GetFiles(parent_Dir + "\\");

            List<string> files = new List<string>();

            for (int i = 0; i < filepaths.Length; i++)
                if (filepaths[i].EndsWith(file_type))
                    files.Add(filepaths[i]);

            return files.ToArray();
        }
    }
}
