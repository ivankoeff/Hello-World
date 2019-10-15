using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractDates
{
   static class ListExtentions
    {
        public static void LoadFile(this List<string> list, string filePath)
        {
            try
            {
                string line;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        list.Add(line);
                        line = reader.ReadLine();
                    }
                }
            }
            catch(IOException)
            {
                MessageBox.Show("The path file is incorrect! Please check path file!","Warning!", 
                             MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.RightAlign,  true);
                Environment.Exit(0);
            }
        }

    }
}
