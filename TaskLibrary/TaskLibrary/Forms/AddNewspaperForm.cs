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
    public partial class AddNewspaperForm : Form
    {
        int count = 0;
        public AddNewspaperForm()
        {
            InitializeComponent();
        }

        private void AddNewspaperForm_Load(object sender, EventArgs e)
        {
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            /* LibRepository.Instance.Items.Add(new Newspaper()
             {
                 ISBN = tbNewspaperISBN.Text,
                 Title = tbNewspaperTitle.Text,
                 Language = tbNewspaperLanguage.Text,
                 Publishers = tbNewspaperPublisher.Text,
                 Year = int.Parse(tbNewspaperYearPublished.Text),
                 EditionNumber = int.Parse(tbNewspaperEditionNumber.Text),
                 Type = tbNewspaperType.Text,
                 Editor=tbNewspaperEditorInChief.Text,
                 MainTopicForTheEdition = tbNewspaperTopic.Text,
                 CopiesAvailable = int.Parse(tbNewspaperCopiesAvailable.Text)
             });
             LibRepository.count++;*/
            try
            {
                Library.listOfNewspaper.Add(new Newspaper()
                {
                    ISBN = tbNewspaperISBN.Text,
                    Title = tbNewspaperTitle.Text,
                    Language = tbNewspaperLanguage.Text,
                    Publishers = tbNewspaperPublisher.Text,
                    Year = int.Parse(tbNewspaperYearPublished.Text),
                    EditionNumber = int.Parse(tbNewspaperEditionNumber.Text),
                    Type = tbNewspaperType.Text,
                    Editor = tbNewspaperEditorInChief.Text,
                    MainTopicForTheEdition = tbNewspaperTopic.Text,
                    CopiesAvailable = int.Parse(tbNewspaperCopiesAvailable.Text)
                });
                MessageBox.Show(Library.listOfNewspaper[count].Type + " " +
                    Library.listOfNewspaper[count].Title + " with main topic " +
                    Library.listOfNewspaper[count].MainTopicForTheEdition +
                    " was added successfully to the system.");
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

            tbNewspaperISBN.Text = "";
            tbNewspaperTitle.Text = "";
            tbNewspaperLanguage.Text = "";
            tbNewspaperPublisher.Text = "";
            tbNewspaperYearPublished.Text = "";
            tbNewspaperEditionNumber.Text = "";
            tbNewspaperType.Text = "";
            tbNewspaperEditorInChief.Text = "";
            tbNewspaperTopic.Text = "";
            tbNewspaperCopiesAvailable.Text = "";
        }

        public string ISBNValue
        {
            get { return tbNewspaperISBN.Text; }
            set { tbNewspaperISBN.Text = value; }
        }

        public string TitleValue
        {
            get { return tbNewspaperTitle.Text; }
            set { tbNewspaperTitle.Text = value; }
        }

        public string LanguageValue
        {
            get { return tbNewspaperLanguage.Text; }
            set { tbNewspaperLanguage.Text = value; }
        }

        public string PublisherValue
        {
            get { return tbNewspaperPublisher.Text; }
            set { tbNewspaperPublisher.Text = value; }
        }

        public string YearPublishedValue
        {
            get { return tbNewspaperYearPublished.Text; }
            set { tbNewspaperYearPublished.Text = value; }
        }

        public string EditionNumberValue
        {
            get { return tbNewspaperEditionNumber.Text; }
            set { tbNewspaperEditionNumber.Text = value; }
        }

        public string TypeValue
        {
            get { return tbNewspaperType.Text; }
            set { tbNewspaperType.Text = value; }
        }

        public string EditorValue
        {
            get { return tbNewspaperEditorInChief.Text; }
            set { tbNewspaperEditorInChief.Text = value; }
        }

        public string TopicValue
        {
            get { return tbNewspaperTopic.Text; }
            set { tbNewspaperTopic.Text = value; }
        }

        public string CopiesAvailableValue
        {
            get { return tbNewspaperCopiesAvailable.Text; }
            set { tbNewspaperCopiesAvailable.Text = value; }
        }


    }
}
