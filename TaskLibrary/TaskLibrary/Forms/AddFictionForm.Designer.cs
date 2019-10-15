using System;

namespace TaskLibrary
{
    partial class AddFictionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFictionAudience = new System.Windows.Forms.TextBox();
            this.dtpFictionReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lbFictionAudience = new System.Windows.Forms.Label();
            this.lbFictionGenre = new System.Windows.Forms.Label();
            this.lbFictionPageCount = new System.Windows.Forms.Label();
            this.lbFictionAuthor = new System.Windows.Forms.Label();
            this.lbFictionReleaseDate = new System.Windows.Forms.Label();
            this.tbFictionGenre = new System.Windows.Forms.TextBox();
            this.tbFictionPageCount = new System.Windows.Forms.TextBox();
            this.tbFictionAuthor = new System.Windows.Forms.TextBox();
            this.tbFictionPublisher = new System.Windows.Forms.TextBox();
            this.tbFictionLanguage = new System.Windows.Forms.TextBox();
            this.tbFictionTitle = new System.Windows.Forms.TextBox();
            this.lbFictionPublishers = new System.Windows.Forms.Label();
            this.lbFictionLanguage = new System.Windows.Forms.Label();
            this.lbFictionTitle = new System.Windows.Forms.Label();
            this.lbFictionISBN = new System.Windows.Forms.Label();
            this.tbFictionISBN = new System.Windows.Forms.TextBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbFictionCopiesAvailable = new System.Windows.Forms.TextBox();
            this.lbFictionCopiesAvailable = new System.Windows.Forms.Label();
            this.tbFictionCoverType = new System.Windows.Forms.TextBox();
            this.lbFictionCoverType = new System.Windows.Forms.Label();
            this.lbFictionEditionNumber = new System.Windows.Forms.Label();
            this.tbFictionEditionNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFictionAudience
            // 
            this.tbFictionAudience.Location = new System.Drawing.Point(94, 271);
            this.tbFictionAudience.Name = "tbFictionAudience";
            this.tbFictionAudience.Size = new System.Drawing.Size(175, 20);
            this.tbFictionAudience.TabIndex = 69;
            // 
            // dtpFictionReleaseDate
            // 
            this.dtpFictionReleaseDate.Location = new System.Drawing.Point(94, 115);
            this.dtpFictionReleaseDate.Name = "dtpFictionReleaseDate";
            this.dtpFictionReleaseDate.Size = new System.Drawing.Size(175, 20);
            this.dtpFictionReleaseDate.TabIndex = 68;
            // 
            // lbFictionAudience
            // 
            this.lbFictionAudience.AutoSize = true;
            this.lbFictionAudience.Location = new System.Drawing.Point(38, 274);
            this.lbFictionAudience.Name = "lbFictionAudience";
            this.lbFictionAudience.Size = new System.Drawing.Size(55, 13);
            this.lbFictionAudience.TabIndex = 67;
            this.lbFictionAudience.Text = "Audience:";
            // 
            // lbFictionGenre
            // 
            this.lbFictionGenre.AutoSize = true;
            this.lbFictionGenre.Location = new System.Drawing.Point(54, 248);
            this.lbFictionGenre.Name = "lbFictionGenre";
            this.lbFictionGenre.Size = new System.Drawing.Size(39, 13);
            this.lbFictionGenre.TabIndex = 66;
            this.lbFictionGenre.Text = "Genre:";
            // 
            // lbFictionPageCount
            // 
            this.lbFictionPageCount.AutoSize = true;
            this.lbFictionPageCount.Location = new System.Drawing.Point(28, 170);
            this.lbFictionPageCount.Name = "lbFictionPageCount";
            this.lbFictionPageCount.Size = new System.Drawing.Size(65, 13);
            this.lbFictionPageCount.TabIndex = 65;
            this.lbFictionPageCount.Text = "Page count:";
            // 
            // lbFictionAuthor
            // 
            this.lbFictionAuthor.AutoSize = true;
            this.lbFictionAuthor.Location = new System.Drawing.Point(52, 144);
            this.lbFictionAuthor.Name = "lbFictionAuthor";
            this.lbFictionAuthor.Size = new System.Drawing.Size(41, 13);
            this.lbFictionAuthor.TabIndex = 64;
            this.lbFictionAuthor.Text = "Author:";
            // 
            // lbFictionReleaseDate
            // 
            this.lbFictionReleaseDate.AutoSize = true;
            this.lbFictionReleaseDate.Location = new System.Drawing.Point(20, 121);
            this.lbFictionReleaseDate.Name = "lbFictionReleaseDate";
            this.lbFictionReleaseDate.Size = new System.Drawing.Size(73, 13);
            this.lbFictionReleaseDate.TabIndex = 63;
            this.lbFictionReleaseDate.Text = "Release date:";
            // 
            // tbFictionGenre
            // 
            this.tbFictionGenre.Location = new System.Drawing.Point(94, 245);
            this.tbFictionGenre.Name = "tbFictionGenre";
            this.tbFictionGenre.Size = new System.Drawing.Size(175, 20);
            this.tbFictionGenre.TabIndex = 62;
            // 
            // tbFictionPageCount
            // 
            this.tbFictionPageCount.Location = new System.Drawing.Point(94, 167);
            this.tbFictionPageCount.Name = "tbFictionPageCount";
            this.tbFictionPageCount.Size = new System.Drawing.Size(175, 20);
            this.tbFictionPageCount.TabIndex = 61;
            // 
            // tbFictionAuthor
            // 
            this.tbFictionAuthor.Location = new System.Drawing.Point(94, 141);
            this.tbFictionAuthor.Name = "tbFictionAuthor";
            this.tbFictionAuthor.Size = new System.Drawing.Size(175, 20);
            this.tbFictionAuthor.TabIndex = 60;
            // 
            // tbFictionPublisher
            // 
            this.tbFictionPublisher.Location = new System.Drawing.Point(94, 89);
            this.tbFictionPublisher.Name = "tbFictionPublisher";
            this.tbFictionPublisher.Size = new System.Drawing.Size(175, 20);
            this.tbFictionPublisher.TabIndex = 59;
            // 
            // tbFictionLanguage
            // 
            this.tbFictionLanguage.Location = new System.Drawing.Point(94, 63);
            this.tbFictionLanguage.Name = "tbFictionLanguage";
            this.tbFictionLanguage.Size = new System.Drawing.Size(175, 20);
            this.tbFictionLanguage.TabIndex = 58;
            // 
            // tbFictionTitle
            // 
            this.tbFictionTitle.Location = new System.Drawing.Point(94, 37);
            this.tbFictionTitle.Name = "tbFictionTitle";
            this.tbFictionTitle.Size = new System.Drawing.Size(175, 20);
            this.tbFictionTitle.TabIndex = 57;
            // 
            // lbFictionPublishers
            // 
            this.lbFictionPublishers.AutoSize = true;
            this.lbFictionPublishers.Location = new System.Drawing.Point(35, 92);
            this.lbFictionPublishers.Name = "lbFictionPublishers";
            this.lbFictionPublishers.Size = new System.Drawing.Size(58, 13);
            this.lbFictionPublishers.TabIndex = 56;
            this.lbFictionPublishers.Text = "Publishers:";
            // 
            // lbFictionLanguage
            // 
            this.lbFictionLanguage.AutoSize = true;
            this.lbFictionLanguage.Location = new System.Drawing.Point(35, 66);
            this.lbFictionLanguage.Name = "lbFictionLanguage";
            this.lbFictionLanguage.Size = new System.Drawing.Size(58, 13);
            this.lbFictionLanguage.TabIndex = 55;
            this.lbFictionLanguage.Text = "Language:";
            // 
            // lbFictionTitle
            // 
            this.lbFictionTitle.AutoSize = true;
            this.lbFictionTitle.Location = new System.Drawing.Point(63, 40);
            this.lbFictionTitle.Name = "lbFictionTitle";
            this.lbFictionTitle.Size = new System.Drawing.Size(30, 13);
            this.lbFictionTitle.TabIndex = 54;
            this.lbFictionTitle.Text = "Title:";
            // 
            // lbFictionISBN
            // 
            this.lbFictionISBN.AutoSize = true;
            this.lbFictionISBN.Location = new System.Drawing.Point(58, 14);
            this.lbFictionISBN.Name = "lbFictionISBN";
            this.lbFictionISBN.Size = new System.Drawing.Size(35, 13);
            this.lbFictionISBN.TabIndex = 53;
            this.lbFictionISBN.Text = "ISBN:";
            // 
            // tbFictionISBN
            // 
            this.tbFictionISBN.Location = new System.Drawing.Point(94, 11);
            this.tbFictionISBN.Name = "tbFictionISBN";
            this.tbFictionISBN.Size = new System.Drawing.Size(175, 20);
            this.tbFictionISBN.TabIndex = 52;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(194, 344);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 51;
            this.btnAddArticle.Text = "Add fiction";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(275, 344);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 50;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbFictionCopiesAvailable
            // 
            this.tbFictionCopiesAvailable.Location = new System.Drawing.Point(94, 297);
            this.tbFictionCopiesAvailable.Name = "tbFictionCopiesAvailable";
            this.tbFictionCopiesAvailable.Size = new System.Drawing.Size(175, 20);
            this.tbFictionCopiesAvailable.TabIndex = 70;
            // 
            // lbFictionCopiesAvailable
            // 
            this.lbFictionCopiesAvailable.AutoSize = true;
            this.lbFictionCopiesAvailable.Location = new System.Drawing.Point(6, 300);
            this.lbFictionCopiesAvailable.Name = "lbFictionCopiesAvailable";
            this.lbFictionCopiesAvailable.Size = new System.Drawing.Size(87, 13);
            this.lbFictionCopiesAvailable.TabIndex = 71;
            this.lbFictionCopiesAvailable.Text = "Copies available:";
            // 
            // tbFictionCoverType
            // 
            this.tbFictionCoverType.Location = new System.Drawing.Point(94, 219);
            this.tbFictionCoverType.Name = "tbFictionCoverType";
            this.tbFictionCoverType.Size = new System.Drawing.Size(175, 20);
            this.tbFictionCoverType.TabIndex = 75;
            // 
            // lbFictionCoverType
            // 
            this.lbFictionCoverType.AutoSize = true;
            this.lbFictionCoverType.Location = new System.Drawing.Point(32, 222);
            this.lbFictionCoverType.Name = "lbFictionCoverType";
            this.lbFictionCoverType.Size = new System.Drawing.Size(61, 13);
            this.lbFictionCoverType.TabIndex = 74;
            this.lbFictionCoverType.Text = "Cover type:";
            // 
            // lbFictionEditionNumber
            // 
            this.lbFictionEditionNumber.AutoSize = true;
            this.lbFictionEditionNumber.Location = new System.Drawing.Point(13, 196);
            this.lbFictionEditionNumber.Name = "lbFictionEditionNumber";
            this.lbFictionEditionNumber.Size = new System.Drawing.Size(80, 13);
            this.lbFictionEditionNumber.TabIndex = 73;
            this.lbFictionEditionNumber.Text = "Edition number:";
            // 
            // tbFictionEditionNumber
            // 
            this.tbFictionEditionNumber.Location = new System.Drawing.Point(94, 193);
            this.tbFictionEditionNumber.Name = "tbFictionEditionNumber";
            this.tbFictionEditionNumber.Size = new System.Drawing.Size(175, 20);
            this.tbFictionEditionNumber.TabIndex = 72;
            // 
            // AddFictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 385);
            this.Controls.Add(this.tbFictionCoverType);
            this.Controls.Add(this.lbFictionCoverType);
            this.Controls.Add(this.lbFictionEditionNumber);
            this.Controls.Add(this.tbFictionEditionNumber);
            this.Controls.Add(this.lbFictionCopiesAvailable);
            this.Controls.Add(this.tbFictionCopiesAvailable);
            this.Controls.Add(this.tbFictionAudience);
            this.Controls.Add(this.dtpFictionReleaseDate);
            this.Controls.Add(this.lbFictionAudience);
            this.Controls.Add(this.lbFictionGenre);
            this.Controls.Add(this.lbFictionPageCount);
            this.Controls.Add(this.lbFictionAuthor);
            this.Controls.Add(this.lbFictionReleaseDate);
            this.Controls.Add(this.tbFictionGenre);
            this.Controls.Add(this.tbFictionPageCount);
            this.Controls.Add(this.tbFictionAuthor);
            this.Controls.Add(this.tbFictionPublisher);
            this.Controls.Add(this.tbFictionLanguage);
            this.Controls.Add(this.tbFictionTitle);
            this.Controls.Add(this.lbFictionPublishers);
            this.Controls.Add(this.lbFictionLanguage);
            this.Controls.Add(this.lbFictionTitle);
            this.Controls.Add(this.lbFictionISBN);
            this.Controls.Add(this.tbFictionISBN);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnDone);
            this.Name = "AddFictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Fiction";
            this.Load += new System.EventHandler(this.AddFictionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox tbFictionAudience;
        private System.Windows.Forms.DateTimePicker dtpFictionReleaseDate;
        private System.Windows.Forms.Label lbFictionAudience;
        private System.Windows.Forms.Label lbFictionGenre;
        private System.Windows.Forms.Label lbFictionPageCount;
        private System.Windows.Forms.Label lbFictionAuthor;
        private System.Windows.Forms.Label lbFictionReleaseDate;
        private System.Windows.Forms.TextBox tbFictionGenre;
        private System.Windows.Forms.TextBox tbFictionPageCount;
        private System.Windows.Forms.TextBox tbFictionAuthor;
        private System.Windows.Forms.TextBox tbFictionPublisher;
        private System.Windows.Forms.TextBox tbFictionLanguage;
        private System.Windows.Forms.TextBox tbFictionTitle;
        private System.Windows.Forms.Label lbFictionPublishers;
        private System.Windows.Forms.Label lbFictionLanguage;
        private System.Windows.Forms.Label lbFictionTitle;
        private System.Windows.Forms.Label lbFictionISBN;
        private System.Windows.Forms.TextBox tbFictionISBN;
        public System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbFictionCopiesAvailable;
        private System.Windows.Forms.Label lbFictionCopiesAvailable;
        private System.Windows.Forms.TextBox tbFictionCoverType;
        private System.Windows.Forms.Label lbFictionCoverType;
        private System.Windows.Forms.Label lbFictionEditionNumber;
        private System.Windows.Forms.TextBox tbFictionEditionNumber;
    }
}