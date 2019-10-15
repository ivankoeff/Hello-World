using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class StandAloneEdition:PaperWork
    {
        public DateTime ReleaseDate { get; set; }
        public string Authors { get; set; }
        public int PageCount { get; set; }

        public StandAloneEdition()
        {
        }
    }
}
