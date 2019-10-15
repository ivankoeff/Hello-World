using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class LibraryInstance
    {
        public List<Fiction> listOfFictions { get; set; }
        public List<Magazine> listOfMagazines { get; set; }
        public List<Newspaper> listOfNewspaper { get; set; }
        public List<ScientificArticle> listOfScientificArticles { get; set; }
        public List<TechnicalLiterature> listOfTechLit { get; set; }
    }
}
