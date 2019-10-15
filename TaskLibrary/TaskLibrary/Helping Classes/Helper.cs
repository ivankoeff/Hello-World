using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLibrary
{
    public static class Helper
    {
        public static void SaveLibrary(string path, LibraryInstance saveLibrary)
        {
            string savedString = JsonConvert.SerializeObject(saveLibrary, Formatting.Indented);
            File.WriteAllText(path + ".json", savedString);
        }

        public static LibraryInstance LoadLibrary(string path)
        {
            string loadedData = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<LibraryInstance>(loadedData);
        }

        public static LibraryInstance MergeLibrary(string firstFilePath, string secondFilePath)
        {                       
            string firstMergngString = File.ReadAllText(firstFilePath);
            LibraryInstance firstMergingFile = JsonConvert.DeserializeObject<LibraryInstance>(firstMergngString);
            
            string secondMergingString = File.ReadAllText(secondFilePath);
            LibraryInstance secondMergingFile = JsonConvert.DeserializeObject<LibraryInstance>(secondMergingString);


            firstMergingFile.listOfFictions = CheckFiction(firstMergingFile, secondMergingFile);

            firstMergingFile.listOfMagazines = CheckMagazines(firstMergingFile, secondMergingFile);

            firstMergingFile.listOfNewspaper = CheckNewsPaper(firstMergingFile, secondMergingFile);

            firstMergingFile.listOfScientificArticles = CheckSciArticles(firstMergingFile, secondMergingFile);

            firstMergingFile.listOfTechLit = CheckTechLit(firstMergingFile, secondMergingFile);

            return firstMergingFile;
        }

        private static List<Fiction> CheckFiction(LibraryInstance firstMergingFile, LibraryInstance secondMergingFile)
        {
            if(firstMergingFile.listOfFictions!=null)
            {
                for (int i = 0; i < secondMergingFile.listOfFictions.Count; i++)
                {
                    for(int k=0; k < firstMergingFile.listOfFictions.Count; k++)
                    {
                        if(secondMergingFile.listOfFictions[i].Title == firstMergingFile.listOfFictions[k].Title
                           && secondMergingFile.listOfFictions[i].Authors == firstMergingFile.listOfFictions[k].Authors)
                        {
                            firstMergingFile.listOfFictions[k].CopiesAvailable += secondMergingFile.listOfFictions[i].CopiesAvailable;
                            continue;
                        }
                        else
                        {
                            firstMergingFile.listOfFictions.Add(secondMergingFile.listOfFictions[i]);
                        }
                    }
                }
            }
            else
            {
                for(int i=0; i<secondMergingFile.listOfFictions.Count;i++)
                {
                    firstMergingFile.listOfFictions.Add(secondMergingFile.listOfFictions[i]);
                }
            }
            return firstMergingFile.listOfFictions;
        }

        private static List<Magazine> CheckMagazines(LibraryInstance firstMergingFile, LibraryInstance secondMergingFile)
        {
            if (firstMergingFile.listOfMagazines != null)
            {
                for (int i = 0; i < secondMergingFile.listOfMagazines.Count; i++)
                {
                    for (int k = 0; k < firstMergingFile.listOfMagazines.Count; k++)
                    {
                        if (secondMergingFile.listOfMagazines[i].Title == firstMergingFile.listOfMagazines[k].Title
                           && secondMergingFile.listOfMagazines[i].Topic == firstMergingFile.listOfMagazines[k].Topic)
                        {
                            firstMergingFile.listOfMagazines[k].CopiesAvailable += secondMergingFile.listOfMagazines[i].CopiesAvailable;
                            continue;
                        }
                        else
                        {
                            firstMergingFile.listOfMagazines.Add(secondMergingFile.listOfMagazines[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondMergingFile.listOfMagazines.Count; i++)
                {
                    firstMergingFile.listOfMagazines.Add(secondMergingFile.listOfMagazines[i]);
                }
            }
            return firstMergingFile.listOfMagazines;
        }

        private static List<Newspaper> CheckNewsPaper (LibraryInstance firstMergingFile, LibraryInstance secondMergingFile)
        {
            if (firstMergingFile.listOfNewspaper != null)
            {
                for (int i = 0; i < secondMergingFile.listOfNewspaper.Count; i++)
                {
                    for (int k = 0; k < firstMergingFile.listOfNewspaper.Count; k++)
                    {
                        if (secondMergingFile.listOfNewspaper[i].Title == firstMergingFile.listOfNewspaper[k].Title
                           && secondMergingFile.listOfNewspaper[i].MainTopicForTheEdition == firstMergingFile.listOfNewspaper[k].MainTopicForTheEdition)
                        {
                            firstMergingFile.listOfNewspaper[k].CopiesAvailable += secondMergingFile.listOfNewspaper[i].CopiesAvailable;
                            continue;
                        }
                        else
                        {
                            firstMergingFile.listOfNewspaper.Add(secondMergingFile.listOfNewspaper[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondMergingFile.listOfNewspaper.Count; i++)
                {
                    firstMergingFile.listOfNewspaper.Add(secondMergingFile.listOfNewspaper[i]);
                }
            }
            return firstMergingFile.listOfNewspaper;
        }

        private static List<ScientificArticle> CheckSciArticles(LibraryInstance firstMergingFile, LibraryInstance secondMergingFile)
        {
            if (firstMergingFile.listOfScientificArticles != null)
            {
                for (int i = 0; i < secondMergingFile.listOfScientificArticles.Count; i++)
                {
                    for (int k = 0; k < firstMergingFile.listOfScientificArticles.Count; k++)
                    {
                        if (secondMergingFile.listOfScientificArticles[i].Title == firstMergingFile.listOfScientificArticles[k].Title
                           && secondMergingFile.listOfScientificArticles[i].ScientificFiled == firstMergingFile.listOfScientificArticles[k].ScientificFiled)
                        {
                            firstMergingFile.listOfScientificArticles[k].CopiesAvailable += secondMergingFile.listOfScientificArticles[i].CopiesAvailable;
                            continue;
                        }
                        else
                        {
                            firstMergingFile.listOfScientificArticles.Add(secondMergingFile.listOfScientificArticles[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondMergingFile.listOfScientificArticles.Count; i++)
                {
                    firstMergingFile.listOfScientificArticles.Add(secondMergingFile.listOfScientificArticles[i]);
                }
            }
            return firstMergingFile.listOfScientificArticles;
        }

        private static List<TechnicalLiterature> CheckTechLit (LibraryInstance firstMergingFile, LibraryInstance secondMergingFile)
        {
            if (firstMergingFile.listOfTechLit != null)
            {
                for (int i = 0; i < secondMergingFile.listOfTechLit.Count; i++)
                {
                    for (int k = 0; k < firstMergingFile.listOfTechLit.Count; k++)
                    {
                        if (secondMergingFile.listOfTechLit[i].Title == firstMergingFile.listOfTechLit[k].Title
                           && secondMergingFile.listOfTechLit[i].ScientificField == firstMergingFile.listOfTechLit[k].ScientificField)
                        {
                            firstMergingFile.listOfTechLit[k].CopiesAvailable += secondMergingFile.listOfTechLit[i].CopiesAvailable;
                            continue;
                        }
                        else
                        {
                            firstMergingFile.listOfTechLit.Add(secondMergingFile.listOfTechLit[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondMergingFile.listOfTechLit.Count; i++)
                {
                    firstMergingFile.listOfTechLit.Add(secondMergingFile.listOfTechLit[i]);
                }
            }
            return firstMergingFile.listOfTechLit;
        }

        public static List<PaperWork> Search(string keyWord, LibraryInstance instance)
        {
           List<PaperWork> result = new List<PaperWork>();
           for(int i=0; i<instance.listOfFictions.Count; i++)
            {
                if(instance.listOfFictions[i].Title.Contains(keyWord) || instance.listOfFictions[i].Authors.Contains(keyWord))
                {
                    result.Add(instance.listOfFictions[i]);
                }
            }

            for (int i = 0; i < instance.listOfMagazines.Count; i++)
            {
                if (instance.listOfMagazines[i].Title.Contains(keyWord) || instance.listOfMagazines[i].Topic.Contains(keyWord))
                {
                    result.Add(instance.listOfMagazines[i]);
                }
            }

            for (int i = 0; i < instance.listOfNewspaper.Count; i++)
            {
                if (instance.listOfNewspaper[i].Title.Contains(keyWord) || instance.listOfNewspaper[i].MainTopicForTheEdition.Contains(keyWord))
                {
                    result.Add(instance.listOfNewspaper[i]);
                }
            }

            for (int i = 0; i < instance.listOfScientificArticles.Count; i++)
            {
                if (instance.listOfScientificArticles[i].Title.Contains(keyWord) || instance.listOfScientificArticles[i].ScientificFiled.Contains(keyWord))
                {
                    result.Add(instance.listOfNewspaper[i]);
                }
            }

            for (int i = 0; i < instance.listOfTechLit.Count; i++)
            {
                if (instance.listOfTechLit[i].Title.Contains(keyWord) || instance.listOfTechLit[i].ScientificField.Contains(keyWord))
                {
                    result.Add(instance.listOfTechLit[i]);
                }
            }

            return result;
        }
    }
}
