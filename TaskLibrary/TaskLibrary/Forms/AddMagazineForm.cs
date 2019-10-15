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
    public partial class AddMagazineForm : Form
    {
        int count = 0;
        public AddMagazineForm()
        {
            InitializeComponent();
        }

        private void AddMagazineForm_Load(object sender, EventArgs e)
        {
        }

        private void btnDone_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnAddNewspaper_Click(object sender, EventArgs e)
        {
            /*  LibRepository.Instance.Items.Add(new Magazine()
              {
                  ISBN = tbMagazineISBN.Text,
                  Title = tbMagazineTitle.Text,
                  Language = tbMagazineLanguage.Text,
                  Publishers = tbMagazinePublisher.Text,
                  Year = int.Parse(tbMagazineYearPublished.Text),
                  EditionNumber = int.Parse(tbMagazineEditionNumber.Text),
                  Topic = tbMagazineTopic.Text,
                  Authors = tbMagazineAuthor.Text,
                  FrontCoverDescription = tbMagazineCoverDescription.Text,
                  CopiesAvailable = int.Parse(tbMagazineCopiesAvailable.Text)
              });
              LibRepository.count++;*/
            try
            {
                Library.listOfMagazines.Add(new Magazine()
                {
                    ISBN = tbMagazineISBN.Text,
                    Title = tbMagazineTitle.Text,
                    Language = tbMagazineLanguage.Text,
                    Publishers = tbMagazinePublisher.Text,
                    Year = int.Parse(tbMagazineYearPublished.Text),
                    EditionNumber = int.Parse(tbMagazineEditionNumber.Text),
                    Topic = tbMagazineTopic.Text,
                    Authors = tbMagazineAuthor.Text,
                    FrontCoverDescription = tbMagazineCoverDescription.Text,
                    CopiesAvailable = int.Parse(tbMagazineCopiesAvailable.Text)
                });
                MessageBox.Show(Library.listOfMagazines[count].Title + " with topic " +
                    Library.listOfMagazines[count].Topic + " was added successfully to the system.");
                this.count++;
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("You have missed one filed!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input on some of the values!");
            }
            
            tbMagazineISBN.Text = "";
            tbMagazineTitle.Text = "";
            tbMagazineLanguage.Text = "";
            tbMagazinePublisher.Text = "";
            tbMagazineYearPublished.Text = "";
            tbMagazineEditionNumber.Text = "";
            tbMagazineTopic.Text = "";
            tbMagazineAuthor.Text = "";
            tbMagazineCoverDescription.Text = "";
            tbMagazineCopiesAvailable.Text = "";
        }



        public string ISBNValue
        {
            get { return tbMagazineISBN.Text; }
            set { tbMagazineISBN.Text = value; }
        }

        public string TitleValue
        {
            get { return tbMagazineTitle.Text; }
            set { tbMagazineTitle.Text = value; }
        }

        public string LanguageValue
        {
            get { return tbMagazineLanguage.Text; }
            set { tbMagazineLanguage.Text = value; }
        }

        public string PublisherValue
        {
            get { return tbMagazinePublisher.Text; }
            set { tbMagazinePublisher.Text = value; }
        }

        public string YearPublishedValue
        {
            get { return tbMagazineYearPublished.Text; }
            set { tbMagazineYearPublished.Text = value; }
        }

        public string EditionNumberValue
        {
            get { return tbMagazineEditionNumber.Text; }
            set { tbMagazineEditionNumber.Text = value; }
        }

        public string TopicValue
        {
            get { return tbMagazineTopic.Text; }
            set { tbMagazineTopic.Text = value; }
        }

        public string AuthorValue
        {
            get { return tbMagazineAuthor.Text; }
            set { tbMagazineAuthor.Text = value; }
        }

        public string CoverDescriptionValue
        {
            get { return tbMagazineCoverDescription.Text; }
            set { tbMagazineCoverDescription.Text = value; }
        }

        public string CopiesAvailableValue
        {
            get { return tbMagazineCopiesAvailable.Text; }
            set { tbMagazineCopiesAvailable.Text = value; }
        }
    }
}
