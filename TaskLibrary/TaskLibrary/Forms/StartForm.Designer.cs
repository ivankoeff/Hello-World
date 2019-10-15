using System;

namespace TaskLibrary
{
    partial class LibraryStart
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMergeLibrarys = new System.Windows.Forms.Button();
            this.btnCreateNewLibrary = new System.Windows.Forms.Button();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbShowAll = new System.Windows.Forms.CheckBox();
            this.cbShowFiction = new System.Windows.Forms.CheckBox();
            this.cbShowNews = new System.Windows.Forms.CheckBox();
            this.cbShowMagazines = new System.Windows.Forms.CheckBox();
            this.cbSciArticles = new System.Windows.Forms.CheckBox();
            this.cbTechLit = new System.Windows.Forms.CheckBox();
            this.listBoxShowLibrary = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 115);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMergeLibrarys
            // 
            this.btnMergeLibrarys.Location = new System.Drawing.Point(12, 144);
            this.btnMergeLibrarys.Name = "btnMergeLibrarys";
            this.btnMergeLibrarys.Size = new System.Drawing.Size(89, 23);
            this.btnMergeLibrarys.TabIndex = 4;
            this.btnMergeLibrarys.Text = "Merge librarys";
            this.btnMergeLibrarys.UseVisualStyleBackColor = true;
            this.btnMergeLibrarys.Click += new System.EventHandler(this.btnMergeLibrarys_Click);
            // 
            // btnCreateNewLibrary
            // 
            this.btnCreateNewLibrary.Location = new System.Drawing.Point(12, 28);
            this.btnCreateNewLibrary.Name = "btnCreateNewLibrary";
            this.btnCreateNewLibrary.Size = new System.Drawing.Size(100, 23);
            this.btnCreateNewLibrary.TabIndex = 31;
            this.btnCreateNewLibrary.Text = "Create new library";
            this.btnCreateNewLibrary.UseVisualStyleBackColor = true;
            this.btnCreateNewLibrary.Click += new System.EventHandler(this.btnCreateNewLibrary_Click);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(198, 19);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(322, 20);
            this.tbSearchBar.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(198, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(322, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbShowAll
            // 
            this.cbShowAll.AutoSize = true;
            this.cbShowAll.Location = new System.Drawing.Point(198, 70);
            this.cbShowAll.Name = "cbShowAll";
            this.cbShowAll.Size = new System.Drawing.Size(37, 17);
            this.cbShowAll.TabIndex = 50;
            this.cbShowAll.Text = "All";
            this.cbShowAll.UseVisualStyleBackColor = true;
            this.cbShowAll.CheckedChanged += new System.EventHandler(this.cbShowAll_CheckedChanged);
            // 
            // cbShowFiction
            // 
            this.cbShowFiction.AutoSize = true;
            this.cbShowFiction.Location = new System.Drawing.Point(241, 70);
            this.cbShowFiction.Name = "cbShowFiction";
            this.cbShowFiction.Size = new System.Drawing.Size(57, 17);
            this.cbShowFiction.TabIndex = 51;
            this.cbShowFiction.Text = "Fiction";
            this.cbShowFiction.UseVisualStyleBackColor = true;
            this.cbShowFiction.CheckedChanged += new System.EventHandler(this.cbShowFiction_CheckedChanged);
            // 
            // cbShowNews
            // 
            this.cbShowNews.AutoSize = true;
            this.cbShowNews.Location = new System.Drawing.Point(304, 70);
            this.cbShowNews.Name = "cbShowNews";
            this.cbShowNews.Size = new System.Drawing.Size(53, 17);
            this.cbShowNews.TabIndex = 52;
            this.cbShowNews.Text = "News";
            this.cbShowNews.UseVisualStyleBackColor = true;
            this.cbShowNews.CheckedChanged += new System.EventHandler(this.cbShowNews_CheckedChanged);
            // 
            // cbShowMagazines
            // 
            this.cbShowMagazines.AutoSize = true;
            this.cbShowMagazines.Location = new System.Drawing.Point(363, 70);
            this.cbShowMagazines.Name = "cbShowMagazines";
            this.cbShowMagazines.Size = new System.Drawing.Size(77, 17);
            this.cbShowMagazines.TabIndex = 53;
            this.cbShowMagazines.Text = "Magazines";
            this.cbShowMagazines.UseVisualStyleBackColor = true;
            this.cbShowMagazines.CheckedChanged += new System.EventHandler(this.cbShowMagazines_CheckedChanged);
            // 
            // cbSciArticles
            // 
            this.cbSciArticles.AutoSize = true;
            this.cbSciArticles.Location = new System.Drawing.Point(198, 93);
            this.cbSciArticles.Name = "cbSciArticles";
            this.cbSciArticles.Size = new System.Drawing.Size(106, 17);
            this.cbSciArticles.TabIndex = 54;
            this.cbSciArticles.Text = "Scientific Articles";
            this.cbSciArticles.UseVisualStyleBackColor = true;
            this.cbSciArticles.CheckedChanged += new System.EventHandler(this.cbSciArticles_CheckedChanged);
            // 
            // cbTechLit
            // 
            this.cbTechLit.AutoSize = true;
            this.cbTechLit.Location = new System.Drawing.Point(311, 93);
            this.cbTechLit.Name = "cbTechLit";
            this.cbTechLit.Size = new System.Drawing.Size(116, 17);
            this.cbTechLit.TabIndex = 55;
            this.cbTechLit.Text = "Technical Literatire";
            this.cbTechLit.UseVisualStyleBackColor = true;
            this.cbTechLit.CheckedChanged += new System.EventHandler(this.cbTechLit_CheckedChanged);
            // 
            // listBoxShowLibrary
            // 
            this.listBoxShowLibrary.FormattingEnabled = true;
            this.listBoxShowLibrary.Location = new System.Drawing.Point(198, 129);
            this.listBoxShowLibrary.Name = "listBoxShowLibrary";
            this.listBoxShowLibrary.Size = new System.Drawing.Size(322, 303);
            this.listBoxShowLibrary.TabIndex = 57;
            this.listBoxShowLibrary.DoubleClick += new System.EventHandler(this.listBoxShowLibrary_MouseDoubleClick);
            // 
            // LibraryStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 446);
            this.Controls.Add(this.listBoxShowLibrary);
            this.Controls.Add(this.cbTechLit);
            this.Controls.Add(this.cbSciArticles);
            this.Controls.Add(this.cbShowMagazines);
            this.Controls.Add(this.cbShowNews);
            this.Controls.Add(this.cbShowFiction);
            this.Controls.Add(this.cbShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.btnCreateNewLibrary);
            this.Controls.Add(this.btnMergeLibrarys);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Name = "LibraryStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMergeLibrarys;
        private System.Windows.Forms.Button btnCreateNewLibrary;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbShowAll;
        private System.Windows.Forms.CheckBox cbShowFiction;
        private System.Windows.Forms.CheckBox cbShowNews;
        private System.Windows.Forms.CheckBox cbShowMagazines;
        private System.Windows.Forms.CheckBox cbSciArticles;
        private System.Windows.Forms.CheckBox cbTechLit;
        private System.Windows.Forms.ListBox listBoxShowLibrary;
    }
}

