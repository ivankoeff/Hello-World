using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
   public class Fiction:Book
    {
        public string Genre { get; set; }
        public string Audience { get; set; }

        public Fiction():base() {}
       
    }
}
