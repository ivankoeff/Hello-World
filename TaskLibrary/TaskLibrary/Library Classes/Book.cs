using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class Book : StandAloneEdition
    {
        public int EditionNumber { get; set; }
        public string CoverType { get; set; }
        public string HasImages { get; set; }

        public Book()
        {
        }
    }
}
