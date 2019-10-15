using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
   public  class PaperWork
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Publishers { get; set; }
        public int CopiesAvailable { get; set; }

        public PaperWork()
        {
        }

    }
}
