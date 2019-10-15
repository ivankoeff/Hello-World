using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
   public class TechnicalLiterature:Book
    {
        public string ScientificField { get; set; }
        public string AudienceLevel { get; set; }

        public TechnicalLiterature():base()
        {

        }
    }
}
