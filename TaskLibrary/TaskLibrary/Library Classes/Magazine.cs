using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
   public class Magazine:PeriodicallyPublishedEdition
    {
        public string Topic { get; set; }
        public string Authors { get; set; }
        public string FrontCoverDescription { get; set; }

        public Magazine():base()
        {

        }
    }
}
