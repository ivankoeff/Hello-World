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
    public partial class AddScientificArticleForm : Form
    {
        int count = 0;
        public AddScientificArticleForm()
        {
            InitializeComponent();
        }

        private void AddScientificArticleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            /*LibRepository.Instance.Items.Add(new ScientificArticle()
            {
                ISBN = tbArticleISBN.Text,
                Title = tbArticleTitle.Text,
                Language = tbArticleLanguage.Text,
                Publishers = tbArticlePublisher.Text,
                ReleaseDate = DateTime.Parse(dtpArticleReleaseDate.Text),
                Authors = tbArticleAuthor.Text,
                PageCount = int.Parse(tbArticlePageCount.Text),
                ScientificFiled = tbArticleFiled.Text,
                RecomendedLiterature = tbArticleRecomendedLiterature.Text,
                CopiesAvailable = int.Parse(tbScientificArticleCopiesAvailable.Text)
            });
            LibRepository.count++;*/
            try
            {
                Library.listOfScientificArticles.Add(new ScientificArticle()
                {
                    ISBN = tbArticleISBN.Text,
                    Title = tbArticleTitle.Text,
                    Language = tbArticleLanguage.Text,
                    Publishers = tbArticlePublisher.Text,
                    ReleaseDate = DateTime.Parse(dtpArticleReleaseDate.Text),
                    Authors = tbArticleAuthor.Text,
                    PageCount = int.Parse(tbArticlePageCount.Text),
                    ScientificFiled = tbArticleFiled.Text,
                    RecomendedLiterature = tbArticleRecomendedLiterature.Text,
                    CopiesAvailable = int.Parse(tbScientificArticleCopiesAvailable.Text)
                });
                MessageBox.Show(Library.listOfScientificArticles[count].Title + " by " +
                    Library.listOfScientificArticles[count].Authors + " with scientific field " +
                    Library.listOfScientificArticles[count].ScientificFiled + " was added successfully to the system.");
                count++;
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("You have missed one filed!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input on some of the values!");
            }

            tbArticleISBN.Text = "";
            tbArticleTitle.Text = "";
            tbArticleLanguage.Text = "";
            tbArticlePublisher.Text = "";
            dtpArticleReleaseDate.Text = "";
            tbArticleAuthor.Text = "";
            tbArticlePageCount.Text = "";
            tbArticleFiled.Text = "";
            tbArticleRecomendedLiterature.Text = "";
            tbScientificArticleCopiesAvailable.Text = "";
        }

        public string ISBNValue
        {
            get { return tbArticleISBN.Text; }
            set { tbArticleISBN.Text = value; }
        }

        public string TitleValue
        {
            get { return tbArticleTitle.Text; }
            set { tbArticleTitle.Text = value; }
        }

        public string LanguageValue
        {
            get { return tbArticleLanguage.Text; }
            set { tbArticleLanguage.Text = value; }
        }

        public string PublisherValue
        {
            get { return tbArticlePublisher.Text; }
            set { tbArticlePublisher.Text = value; }
        }

        public string ReleaseDateValue
        {
            get { return dtpArticleReleaseDate.Text; }
            set { dtpArticleReleaseDate.Text = value; }
        }

        public string AuthorValue
        {
            get { return tbArticleAuthor.Text; }
            set { tbArticleAuthor.Text = value; }
        }

        public string PageCountValue
        {
            get { return tbArticlePageCount.Text; }
            set { tbArticlePageCount.Text = value; }
        }

        public string ScientificFieldValue
        {
            get { return tbArticleFiled.Text; }
            set { tbArticleFiled.Text = value; }
        }

        public string RecomendedLiteratureValue
        {
            get { return tbArticleRecomendedLiterature.Text; }
            set { tbArticleRecomendedLiterature.Text = value; }
        }

        public string CopiesAvailableValue
        {
            get { return tbScientificArticleCopiesAvailable.Text; }
            set { tbScientificArticleCopiesAvailable.Text = value; }
        }
    }
}
