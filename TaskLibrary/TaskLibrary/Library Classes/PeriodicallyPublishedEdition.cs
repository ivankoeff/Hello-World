using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class PeriodicallyPublishedEdition:PaperWork
    {
        public int Year { get; set; }
        public int EditionNumber { get; set; }

       public PeriodicallyPublishedEdition()
        {
        }
    }
}
