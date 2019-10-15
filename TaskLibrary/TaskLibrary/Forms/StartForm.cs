using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace TaskLibrary
{
    public partial class LibraryStart : Form
    {
        public static LibraryInstance libraryInstance { get; set; }

        public LibraryStart()
        {
            InitializeComponent();
        }

        private void LibraryStart_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewLibrary_Click(object sender, EventArgs e)
        {
            Library.listOfFictions.Clear();
            Library.listOfMagazines.Clear();
            Library.listOfNewspaper.Clear();
            Library.listOfScientificArticles.Clear();
            Library.listOfTechLit.Clear();
            CategoryChoose categoryChoose = new CategoryChoose();
            categoryChoose.Show();
            this.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           CategoryChoose categoryChooseForm = new CategoryChoose();
           categoryChooseForm.Show();
           this.Hide();
        }
                
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (libraryInstance != null)
            {
                try
                {
                    string path = "";
                    SaveFileDialog fd = new SaveFileDialog();
                    fd.Title = "Saving directory";
                    if(fd.ShowDialog() == DialogResult.OK)
                    {
                        path = fd.FileName;
                        Helper.SaveLibrary(path, libraryInstance);
                        MessageBox.Show("Successfully saved!");
                    }                   
                }
                catch (IOException)
                {
                    MessageBox.Show("There was a problem with saving the file!");
                }
                catch (JsonSerializationException)
                {
                    MessageBox.Show("There was a problem with converting the file to JSON object!");
                }
            }
            else
            {
                MessageBox.Show("There is nothig to save yet!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = "";
                OpenFileDialog fd = new OpenFileDialog();
                fd.Title = "Select library";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    loadPath = fd.FileName;
                    libraryInstance = Helper.LoadLibrary(loadPath);
                    MessageBox.Show("The library was loaded successfully!");
                }                              
            }
            catch(IOException)
            {
                MessageBox.Show("There was a problem with opennign the file!");
            }
            catch(JsonException)
            {
                MessageBox.Show("The file does not contain JSON object or the object was corrupted!");
            }
           
        }

        private void btnMergeLibrarys_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryInstance mergingLibraryInstance = new LibraryInstance();
                string firstFilePath ="";
                string secondFilePath="";

                OpenFileDialog ofdOne = new OpenFileDialog();
                ofdOne.Title = "Select first file for merging";
                if(ofdOne.ShowDialog()==DialogResult.OK)
                {
                    firstFilePath = ofdOne.FileName;

                    OpenFileDialog ofdTwo = new OpenFileDialog();
                    ofdTwo.Title = "Select second library for merging";
                    if (ofdTwo.ShowDialog() == DialogResult.OK)
                    {
                        secondFilePath = ofdTwo.FileName;

                        mergingLibraryInstance = Helper.MergeLibrary(firstFilePath, secondFilePath);

                        string savingPath = "";

                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            savingPath = sfd.FileName;

                            Helper.SaveLibrary(savingPath, mergingLibraryInstance);
                            MessageBox.Show("Mergging libraries was successfull!");
                        } 
                        else
                        {
                            MessageBox.Show("There was no saving derectory. Library not saved!");
                        }
                    }                    
                }               
            }
            catch (IOException)
            {
              MessageBox.Show("Something went wrong with openning the files!");
            }
            catch (JsonException)
            {
              MessageBox.Show("The information from the file does not contain JSON object or the JSON object is corrupted!!");
            }       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowAll.Checked==true)
            {
                cbShowFiction.Checked = true;
                cbShowNews.Checked = true;
                cbShowMagazines.Checked = true;
                cbSciArticles.Checked = true;
                cbTechLit.Checked = true;
            }
            else
            {
                listBoxShowLibrary.Items.Clear();
            }
        }

        private void cbShowFiction_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbShowFiction.Checked == true)
                {
                    cbShowAll.Checked = false;

                        for (int i = 0; i < libraryInstance.listOfFictions.Count; i++)
                        {
                        listBoxShowLibrary.DisplayMember = libraryInstance.listOfFictions[i].Title + " by " + libraryInstance.listOfFictions[i].Authors + Environment.NewLine;
                        
                        listBoxShowLibrary.Items.Add(libraryInstance.listOfFictions[i]);
                            
                        }                    
                }
                else
                {
                    for (int i = 0; i <= listBoxShowLibrary.Items.Count; i++)
                    {
                        if (listBoxShowLibrary.Items[i] is Fiction)
                        {
                            listBoxShowLibrary.Items.RemoveAt(i);
                            listBoxShowLibrary.Refresh();
                        }
                    }
                    //listBoxShowLibrary.Items.Clear();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowFiction.Checked = false;
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowFiction.Checked = false;
            }

        }

        private void cbShowNews_CheckedChanged(object sender, EventArgs e)
        {
           try
            {
                if (cbShowNews.Checked == true)
                {
                    cbShowAll.Checked = false;

                        for (int i = 0; i < libraryInstance.listOfNewspaper.Count; i++)
                        {
                            listBoxShowLibrary.Items.Add(libraryInstance.listOfNewspaper[i]);
                            listBoxShowLibrary.DisplayMember = libraryInstance.listOfNewspaper[i].Title.ToString() + ", " + libraryInstance.listOfNewspaper[i].Type.ToString() + ", with topic of the edition " + libraryInstance.listOfNewspaper[i].MainTopicForTheEdition.ToString() + Environment.NewLine;
                        }             
                }
                else
                {
                    for (int i = 0; i <= listBoxShowLibrary.Items.Count; i++)
                    {
                        if (listBoxShowLibrary.Items[i] is Newspaper)
                        {
                            listBoxShowLibrary.Items.RemoveAt(i);
                            listBoxShowLibrary.Refresh();
                        }
                    }
                    //listBoxShowLibrary.Items.Clear();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowMagazines.Checked = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowFiction.Checked = false;
            }
        }

        private void cbShowMagazines_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbShowMagazines.Checked == true)
                {
                    cbShowAll.Checked = false;

                    for (int i = 0; i < libraryInstance.listOfMagazines.Count; i++)
                    {
                        listBoxShowLibrary.DisplayMember = libraryInstance.listOfMagazines[i].Title + " with edition topic " + libraryInstance.listOfMagazines[i].Topic + Environment.NewLine;
                        listBoxShowLibrary.Items.Add(libraryInstance.listOfMagazines[i]);
                    }

                }
                else
                {
                    for (int i = 0; i <= listBoxShowLibrary.Items.Count; i++)
                    {
                        if (listBoxShowLibrary.Items[i] is Magazine)
                        {
                            listBoxShowLibrary.Items.RemoveAt(i);
                            listBoxShowLibrary.Refresh();
                        }
                    }
                    //listBoxShowLibrary.Items.Clear();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowMagazines.Checked = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowFiction.Checked = false;
            }
        }

        private void cbSciArticles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSciArticles.Checked == true)
                {
                    cbShowAll.Checked = false;

                        for (int i = 0; i < libraryInstance.listOfScientificArticles.Count; i++)
                        {
                            listBoxShowLibrary.DisplayMember = libraryInstance.listOfScientificArticles[i].Title + " by " + libraryInstance.listOfScientificArticles[i].Authors + " with topic of " + libraryInstance.listOfScientificArticles[i].ScientificFiled + Environment.NewLine;
                            listBoxShowLibrary.Items.Add(libraryInstance.listOfScientificArticles[i]);
                        }
                        
                }
                else
                {
                    for (int i = 0; i <= listBoxShowLibrary.Items.Count; i++)
                    {
                        if (listBoxShowLibrary.Items[i] is ScientificArticle)
                        {
                            listBoxShowLibrary.Items.RemoveAt(i);
                            listBoxShowLibrary.Refresh();
                        }
                    }
                    //listBoxShowLibrary.Items.Clear();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbSciArticles.Checked = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowFiction.Checked = false;
            }

        }

        private void cbTechLit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTechLit.Checked == true)
                {
                    cbShowAll.Checked = false;

                        for (int i = 0; i < libraryInstance.listOfTechLit.Count; i++)
                        {
                            listBoxShowLibrary.DisplayMember = libraryInstance.listOfTechLit[i].Title + " by " + libraryInstance.listOfTechLit[i].Authors + " with topic of " + libraryInstance.listOfTechLit[i].ScientificField + Environment.NewLine;
                            listBoxShowLibrary.Items.Add(libraryInstance.listOfTechLit[i]);
                        }  
                }
                else
                {
                    for (int i = 0; i <= listBoxShowLibrary.Items.Count; i++)
                    {
                        if (listBoxShowLibrary.Items[i] is TechnicalLiterature)
                        {
                            listBoxShowLibrary.Items.RemoveAt(i);
                            listBoxShowLibrary.Refresh();
                        }
                    }
                    //listBoxShowLibrary.Items.Clear();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbTechLit.Checked = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There isn't any items in this section yet!");
                cbShowFiction.Checked = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyWord = tbSearchBar.Text;
            if(!string.IsNullOrWhiteSpace(keyWord))
            {                
                try
                {
                    listBoxShowLibrary.Items.Clear();
                    List<PaperWork> result = Helper.Search(keyWord, libraryInstance);
                        for (int i = 0; i < result.Count; i++)
                        {
                            if (result[i] is Fiction)
                            {
                                Fiction fiction = (Fiction)result[i];
                                listBoxShowLibrary.Items.Add(fiction);
                                //listBoxShowLibrary.Items.Add(fiction.Title + " by " + fiction.Authors + Environment.NewLine);
                            }
                            else if (result[i] is Newspaper)
                            {
                                Newspaper newspaper = (Newspaper)result[i];
                                listBoxShowLibrary.Items.Add(newspaper);
                                //listBoxShowLibrary.Items.Add(newspaper.Title + ", " + newspaper.Type + ", with topic " + Environment.NewLine);
                            }
                            else if (result[i] is Magazine)
                            {
                                Magazine magazine = (Magazine)result[i];
                                listBoxShowLibrary.Items.Add(magazine);
                                //listBoxShowLibrary.Items.Add(magazine.Title + " with topic " + magazine.Topic + Environment.NewLine);
                            }
                            else if (result[i] is ScientificArticle)
                            {
                                ScientificArticle sciArt = (ScientificArticle)result[i];
                                listBoxShowLibrary.Items.Add(sciArt);
                                //listBoxShowLibrary.Items.Add(sciArt.Title + " by " + sciArt.Authors + " with field " + sciArt.ScientificFiled + Environment.NewLine);
                            }
                            else if (result[i] is TechnicalLiterature)
                            {
                                TechnicalLiterature techLit = (TechnicalLiterature)result[i];
                                listBoxShowLibrary.Items.Add(techLit);
                                //listBoxShowLibrary.Items.Add(techLit.Title + " by " + techLit.Authors + " with field " + techLit.ScientificField + Environment.NewLine);
                            }
                        }

                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("There isn't any library loaded yet!");
                    tbSearchBar.Clear();
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("There were no results");
                }

            }
            else
            {
                MessageBox.Show("The search bar is empty!");
            }
        }

        private void listBoxShowLibrary_MouseDoubleClick(object sender, EventArgs e)
        {

            if (listBoxShowLibrary.SelectedItem is Fiction)
            {
                Fiction fiction = (Fiction)listBoxShowLibrary.SelectedItem;
                AddFictionForm aff = new AddFictionForm()
                {
                    ISBNValue = fiction.ISBN,
                    TitleValue = fiction.Title,
                    LanguageValue = fiction.Language,
                    PublisherValue = fiction.Publishers,
                    ReleaseDateValue = fiction.ReleaseDate.ToString(),
                    AuthorValue = fiction.Authors,
                    PageCountValue = fiction.PageCount.ToString(),
                    EditionNumberValue = fiction.EditionNumber.ToString(),
                    CoverTypeValue = fiction.CoverType,
                    GenreValue = fiction.Genre,
                    AudienceValue = fiction.Audience,
                    CopiesAvailableValue = fiction.CopiesAvailable.ToString()
                };
                aff.btnAddArticle.Hide();
                aff.Show();
            }
            else if (listBoxShowLibrary.SelectedItem is Newspaper)
            {
                Newspaper newspaper = (Newspaper)listBoxShowLibrary.SelectedItem;
                AddNewspaperForm anf = new AddNewspaperForm()
                {
                    ISBNValue = newspaper.ISBN,
                    TitleValue = newspaper.Title,
                    LanguageValue = newspaper.Language,
                    PublisherValue = newspaper.Publishers,
                    YearPublishedValue = newspaper.Year.ToString(),
                    EditionNumberValue = newspaper.EditionNumber.ToString(),
                    TypeValue = newspaper.Type,
                    EditorValue = newspaper.Editor,
                    TopicValue = newspaper.MainTopicForTheEdition,
                    CopiesAvailableValue = newspaper.CopiesAvailable.ToString()
                };
                anf.btnAddNewspaper.Hide();
                anf.Show();
            }
            else if (listBoxShowLibrary.SelectedItem is Magazine)
            {
                Magazine magazine = (Magazine)listBoxShowLibrary.SelectedItem;

                AddMagazineForm amf = new AddMagazineForm()
                {
                    ISBNValue = magazine.ISBN,
                    TitleValue = magazine.Title,
                    LanguageValue = magazine.Language,
                    PublisherValue = magazine.Publishers,
                    YearPublishedValue = magazine.Year.ToString(),
                    EditionNumberValue = magazine.EditionNumber.ToString(),
                    TopicValue = magazine.Topic,
                    AuthorValue = magazine.Authors,
                    CoverDescriptionValue = magazine.FrontCoverDescription,
                    CopiesAvailableValue = magazine.CopiesAvailable.ToString()
                };
                amf.btnAddMagazine.Hide();
                amf.Show();
            }
            else if (listBoxShowLibrary.SelectedItem is ScientificArticle)
            {
                ScientificArticle article = (ScientificArticle)listBoxShowLibrary.SelectedItem;

                AddScientificArticleForm asaf = new AddScientificArticleForm()
                {
                    ISBNValue = article.ISBN,
                    TitleValue = article.Title,
                    LanguageValue = article.Language,
                    PublisherValue = article.Publishers,
                    ReleaseDateValue = article.ReleaseDate.ToString(),
                    AuthorValue = article.Authors,
                    PageCountValue = article.PageCount.ToString(),
                    ScientificFieldValue = article.ScientificFiled,
                    RecomendedLiteratureValue = article.RecomendedLiterature,
                    CopiesAvailableValue = article.CopiesAvailable.ToString()
                };
                asaf.btnAddArticle.Hide();
                asaf.Show();
            }
            else if (listBoxShowLibrary.SelectedItem is TechnicalLiterature)
            {
                TechnicalLiterature techLit = (TechnicalLiterature)listBoxShowLibrary.SelectedItem;

                AddTechnicalLiteratureForm atlf = new AddTechnicalLiteratureForm()
                {
                    ISBNValue = techLit.ISBN,
                    TitleValue = techLit.Title,
                    LanguageValue = techLit.Language,
                    PublisherValue = techLit.Publishers,
                    ReleaseDateValue = techLit.ReleaseDate.ToString(),
                    AuthorValue = techLit.Authors,
                    PageCountValue = techLit.PageCount.ToString(),
                    EditionNumberValue = techLit.EditionNumber.ToString(),
                    CoverTypeValue = techLit.CoverType,
                    ScientificFieldValue = techLit.ScientificField,
                    AudienceLevelValue = techLit.AudienceLevel,
                    CopiesAvailableValue = techLit.CopiesAvailable.ToString()
                };
                atlf.btnAddTechLit.Hide();
                atlf.Show();
            }

        }       
    }
}
