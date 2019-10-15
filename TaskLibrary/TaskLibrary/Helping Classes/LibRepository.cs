using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class LibRepository
    {
        private static LibRepository instance;
        private static object syncRoot = new object();
        private LibRepository() { }
        public static LibRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new LibRepository();
                        }
                    }
                }
                return instance;
            }
        }
       public List<PaperWork> Items { get; private set; } = new List<PaperWork>();
       public List<T> GetItems<T> ()where T:class 
        {
            List<T> res = new List<T>();
            foreach(var i in Items)
            {
                if(i is T)
                {
                   // res.Add((T)i);
                }
            }
            return res;
        }
        public static int count=0;
    }
}
