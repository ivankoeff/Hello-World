using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public static class Library
    {
        public static List<Fiction> listOfFictions = new List<Fiction>();
        public static List<Magazine> listOfMagazines = new List<Magazine>();
        public static List<Newspaper> listOfNewspaper = new List<Newspaper>();
        public static List<ScientificArticle> listOfScientificArticles = new List<ScientificArticle>();
        public static List<TechnicalLiterature> listOfTechLit = new List<TechnicalLiterature>();

        static Library()
        {

        }
    }
}
