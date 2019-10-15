using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class Newspaper:PeriodicallyPublishedEdition
    {
        public string Type { get; set; }
        public string Editor { get; set; }
        public string MainTopicForTheEdition { get; set; }

        public Newspaper() : base()
        { 
        }      
    }
}
