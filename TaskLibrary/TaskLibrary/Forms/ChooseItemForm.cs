using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLibrary
{
    public partial class CategoryChoose : Form
    {
        LibraryInstance instance = new LibraryInstance();
        public CategoryChoose()
        {
            InitializeComponent();
        }
        private void CategoryChoose_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {       
            instance.listOfFictions = Library.listOfFictions;
            instance.listOfMagazines = Library.listOfMagazines;
            instance.listOfNewspaper = Library.listOfNewspaper;
            instance.listOfScientificArticles = Library.listOfScientificArticles;
            instance.listOfTechLit = Library.listOfTechLit;
            
            if(LibraryStart.libraryInstance!=null)
            {
                LibraryStart.libraryInstance.listOfFictions.AddRange(Library.listOfFictions);
                LibraryStart.libraryInstance.listOfNewspaper.AddRange(Library.listOfNewspaper);
                LibraryStart.libraryInstance.listOfMagazines.AddRange(Library.listOfMagazines);
                LibraryStart.libraryInstance.listOfScientificArticles.AddRange(Library.listOfScientificArticles);
                LibraryStart.libraryInstance.listOfTechLit.AddRange(Library.listOfTechLit);
            }
            else
            {
                LibraryStart.libraryInstance = this.instance;
            }

            LibraryStart libraryStartForm = new LibraryStart();
            libraryStartForm.Show();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();
            if(radioBtn!=null)
            {
                switch(radioBtn.Name)
                {
                    case "rbNewspaper":
                        AddNewspaperForm addNewspaperForm = new AddNewspaperForm();
                        addNewspaperForm.Show();
                       // this.Close();
                        break;
                    case "rbMagazine":
                        AddMagazineForm addMagazineForm = new AddMagazineForm();
                        addMagazineForm.Show();
                       // this.Close();
                        break;
                    case "rbScienceArticle":
                        AddScientificArticleForm addScientificArticle = new AddScientificArticleForm();
                        addScientificArticle.Show();
                       // this.Close();
                        break;
                    case "rbFiction":
                        AddFictionForm addFiction = new AddFictionForm();
                        addFiction.Show();
                       // this.Close();
                        break;
                    case "rbTechnicalLiterature":
                        AddTechnicalLiteratureForm addTechnicalLiterature = new AddTechnicalLiteratureForm();
                        addTechnicalLiterature.Show();
                       // this.Close();
                        break;
                }
            }
        }
    }
}
