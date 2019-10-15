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
    public partial class AddTechnicalLiteratureForm : Form
    {
        int count = 0;
        public AddTechnicalLiteratureForm()
        {
            InitializeComponent();
        }

        private void AddTechnicalLiteratureForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnAddTechLit_Click(object sender, EventArgs e)
        {
            /* LibRepository.Instance.Items.Add(new TechnicalLiterature()
             {
                 ISBN = tbTecLitISBN.Text,
                 Title = tbTecLitTitle.Text,
                 Language = tbTecLitLanguage.Text,
                 Publishers = tbTecLitPublisher.Text,
                 ReleaseDate = DateTime.Parse(dtpTecLitReleaseDate.Text),
                 Authors = tbTecLitAuthor.Text,
                 PageCount = int.Parse(tbTecLitPageCount.Text),
                 EditionNumber = int.Parse(tbTechLitEditionNumber.Text),
                 CoverType = tbTechLitCoverType.Text,
                 ScientificField = tbTecLitFiled.Text,
                 AudienceLevel = tbTecLitAudience.Text,
                 CopiesAvailable = int.Parse(tbTechLitCopiesAvailable.Text)
             });
             LibRepository.count++;*/
            try
            {
                Library.listOfTechLit.Add(new TechnicalLiterature()
                {
                    ISBN = tbTecLitISBN.Text,
                    Title = tbTecLitTitle.Text,
                    Language = tbTecLitLanguage.Text,
                    Publishers = tbTecLitPublisher.Text,
                    ReleaseDate = DateTime.Parse(dtpTecLitReleaseDate.Text),
                    Authors = tbTecLitAuthor.Text,
                    PageCount = int.Parse(tbTecLitPageCount.Text),
                    EditionNumber = int.Parse(tbTechLitEditionNumber.Text),
                    CoverType = tbTechLitCoverType.Text,
                    ScientificField = tbTecLitFiled.Text,
                    AudienceLevel = tbTecLitAudience.Text,
                    CopiesAvailable = int.Parse(tbTechLitCopiesAvailable.Text)
                });
                MessageBox.Show(Library.listOfTechLit[count].Title + " by " +
                    Library.listOfTechLit[count].Authors + " with scientific field of " +
                    Library.listOfTechLit[count].ScientificField + " was added successfully to the system.");
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


            tbTecLitISBN.Text = "";
            tbTecLitTitle.Text = "";
            tbTecLitLanguage.Text = "";
            tbTecLitPublisher.Text = "";
            dtpTecLitReleaseDate.Text = "";
            tbTecLitAuthor.Text = "";
            tbTecLitPageCount.Text = "";
            tbTechLitEditionNumber.Text = "";
            tbTechLitCoverType.Text = "";
            tbTecLitFiled.Text = "";
            tbTecLitAudience.Text = "";
            tbTechLitCopiesAvailable.Text = "";
        }

        public string ISBNValue
        {
            get { return tbTecLitISBN.Text; }
            set { tbTecLitISBN.Text = value; }
        }

        public string TitleValue
        {
            get { return tbTecLitTitle.Text; }
            set { tbTecLitTitle.Text = value; }
        }

        public string LanguageValue
        {
            get { return tbTecLitLanguage.Text; }
            set { tbTecLitLanguage.Text = value; }
        }

        public string PublisherValue
        {
            get { return tbTecLitPublisher.Text; }
            set { tbTecLitPublisher.Text = value; }
        }

        public string ReleaseDateValue
        {
            get { return dtpTecLitReleaseDate.Text; }
            set { dtpTecLitReleaseDate.Text = value; }
        }

        public string AuthorValue
        {
            get { return tbTecLitAuthor.Text; }
            set { tbTecLitAuthor.Text = value; }
        }

        public string PageCountValue
        {
            get { return tbTecLitPageCount.Text; }
            set { tbTecLitPageCount.Text = value; }
        }

        public string EditionNumberValue
        {
            get { return tbTechLitEditionNumber.Text; }
            set { tbTechLitEditionNumber.Text = value; }
        }

        public string CoverTypeValue
        {
            get { return tbTechLitCoverType.Text; }
            set { tbTechLitCoverType.Text = value; }
        }

        public string ScientificFieldValue
        {
            get { return tbTecLitFiled.Text; }
            set { tbTecLitFiled.Text = value; }
        }

        public string AudienceLevelValue
        {
            get { return tbTecLitAudience.Text; }
            set { tbTecLitAudience.Text = value; }
        }

        public string CopiesAvailableValue
        {
            get { return tbTechLitCopiesAvailable.Text; }
            set { tbTechLitCopiesAvailable.Text = value; }
        }
    }
}
