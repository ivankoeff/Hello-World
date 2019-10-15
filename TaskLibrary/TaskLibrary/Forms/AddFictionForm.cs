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
    public partial class AddFictionForm : Form
    {
        int count = 0;
        public AddFictionForm()
        {
            InitializeComponent();
        }

        private void AddFictionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            /*  LibRepository.Instance.Items.Add(new Fiction()
              {
                  ISBN = tbFictionISBN.Text,
                  Title = tbFictionTitle.Text,
                  Language = tbFictionLanguage.Text,
                  Publishers = tbFictionPublisher.Text,
                  ReleaseDate = DateTime.Parse(dtpFictionReleaseDate.Text),
                  Authors = tbFictionAuthor.Text,
                  PageCount = int.Parse(tbFictionPageCount.Text),
                  EditionNumber = int.Parse(tbFictionEditionNumber.Text),
                  CoverType = tbFictionCoverType.Text,
                  Genre = tbFictionGenre.Text,
                  Audience = tbFictionAudience.Text,
                  CopiesAvailable = int.Parse(tbFictionCopiesAvailable.Text)
              });*/

            try
            {
                Library.listOfFictions.Add(new Fiction()
                {
                    ISBN = tbFictionISBN.Text,
                    Title = tbFictionTitle.Text,
                    Language = tbFictionLanguage.Text,
                    Publishers = tbFictionPublisher.Text,
                    ReleaseDate = DateTime.Parse(dtpFictionReleaseDate.Text),
                    Authors = tbFictionAuthor.Text,
                    PageCount = int.Parse(tbFictionPageCount.Text),
                    EditionNumber = int.Parse(tbFictionEditionNumber.Text),
                    CoverType = tbFictionCoverType.Text,
                    Genre = tbFictionGenre.Text,
                    Audience = tbFictionAudience.Text,
                    CopiesAvailable = int.Parse(tbFictionCopiesAvailable.Text)
                });
                MessageBox.Show(Library.listOfFictions[count].Title + " by " +
                Library.listOfFictions[count].Authors + " was added succsessfully to the system.");
                this.count++;
            }
            catch(NoNullAllowedException)
            {
                MessageBox.Show("You have missed one filed!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input on some of the values!");
            }

            tbFictionISBN.Text = "";
            tbFictionTitle.Text = "";
            tbFictionLanguage.Text = "";
            tbFictionPublisher.Text = "";
            dtpFictionReleaseDate.Text = "";
            tbFictionAuthor.Text = "";
            tbFictionPageCount.Text = "";
            tbFictionEditionNumber.Text = "";
            tbFictionCoverType.Text = "";
            tbFictionGenre.Text = "";
            tbFictionAudience.Text = "";
            tbFictionCopiesAvailable.Text = "";
        }

        public string ISBNValue
        {
            get { return tbFictionISBN.Text; }
            set { tbFictionISBN.Text = value; }
        }

        public string TitleValue
        {
            get { return tbFictionTitle.Text; }
            set { tbFictionTitle.Text = value; }
        }

        public string LanguageValue
        {
            get { return tbFictionLanguage.Text; }
            set { tbFictionLanguage.Text = value; }
        }

        public string PublisherValue
        {
            get { return tbFictionPublisher.Text; }
            set { tbFictionPublisher.Text = value; }
        }

        public string ReleaseDateValue
        {
            get { return dtpFictionReleaseDate.Text; }
            set { dtpFictionReleaseDate.Text = value.ToString(); }
        }

        public string AuthorValue
        {
            get { return tbFictionAuthor.Text; }
            set { tbFictionAuthor.Text = value; }
        }

        public string PageCountValue
        {
            get { return tbFictionPageCount.Text; }
            set { tbFictionPageCount.Text = value; }
        }

        public string EditionNumberValue
        {
            get { return tbFictionEditionNumber.Text; }
            set { tbFictionEditionNumber.Text = value; }
        }

        public string CoverTypeValue
        {
            get { return tbFictionCoverType.Text; }
            set { tbFictionCoverType.Text = value; }
        }

        public string GenreValue
        {
            get { return tbFictionGenre.Text; }
            set { tbFictionGenre.Text = value; }
        }

        public string AudienceValue
        {
            get { return tbFictionAudience.Text; }
            set { tbFictionAudience.Text = value; }
        }

        public string CopiesAvailableValue
        {
            get { return tbFictionCopiesAvailable.Text; }
            set { tbFictionCopiesAvailable.Text = value; }
        }

        public Button DoneButton
        {
            get { return btnDone; }
        }
    }
}
