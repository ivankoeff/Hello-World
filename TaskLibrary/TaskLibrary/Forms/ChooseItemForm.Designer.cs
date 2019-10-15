namespace TaskLibrary
{
    partial class CategoryChoose
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbNewspaper = new System.Windows.Forms.RadioButton();
            this.rbMagazine = new System.Windows.Forms.RadioButton();
            this.rbScienceArticle = new System.Windows.Forms.RadioButton();
            this.rbFiction = new System.Windows.Forms.RadioButton();
            this.rbTechnicalLiterature = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbNewspaper
            // 
            this.rbNewspaper.AutoSize = true;
            this.rbNewspaper.Location = new System.Drawing.Point(12, 12);
            this.rbNewspaper.Name = "rbNewspaper";
            this.rbNewspaper.Size = new System.Drawing.Size(79, 17);
            this.rbNewspaper.TabIndex = 2;
            this.rbNewspaper.TabStop = true;
            this.rbNewspaper.Text = "Newspaper";
            this.rbNewspaper.UseVisualStyleBackColor = true;
            // 
            // rbMagazine
            // 
            this.rbMagazine.AutoSize = true;
            this.rbMagazine.Location = new System.Drawing.Point(12, 36);
            this.rbMagazine.Name = "rbMagazine";
            this.rbMagazine.Size = new System.Drawing.Size(71, 17);
            this.rbMagazine.TabIndex = 3;
            this.rbMagazine.TabStop = true;
            this.rbMagazine.Text = "Magazine";
            this.rbMagazine.UseVisualStyleBackColor = true;
            // 
            // rbScienceArticle
            // 
            this.rbScienceArticle.AutoSize = true;
            this.rbScienceArticle.Location = new System.Drawing.Point(12, 60);
            this.rbScienceArticle.Name = "rbScienceArticle";
            this.rbScienceArticle.Size = new System.Drawing.Size(95, 17);
            this.rbScienceArticle.TabIndex = 4;
            this.rbScienceArticle.TabStop = true;
            this.rbScienceArticle.Text = "Science article";
            this.rbScienceArticle.UseVisualStyleBackColor = true;
            // 
            // rbFiction
            // 
            this.rbFiction.AutoSize = true;
            this.rbFiction.Location = new System.Drawing.Point(12, 83);
            this.rbFiction.Name = "rbFiction";
            this.rbFiction.Size = new System.Drawing.Size(56, 17);
            this.rbFiction.TabIndex = 6;
            this.rbFiction.TabStop = true;
            this.rbFiction.Text = "Fiction";
            this.rbFiction.UseVisualStyleBackColor = true;
            // 
            // rbTechnicalLiterature
            // 
            this.rbTechnicalLiterature.AutoSize = true;
            this.rbTechnicalLiterature.Location = new System.Drawing.Point(12, 107);
            this.rbTechnicalLiterature.Name = "rbTechnicalLiterature";
            this.rbTechnicalLiterature.Size = new System.Drawing.Size(119, 17);
            this.rbTechnicalLiterature.TabIndex = 7;
            this.rbTechnicalLiterature.TabStop = true;
            this.rbTechnicalLiterature.Text = "Technical Literature";
            this.rbTechnicalLiterature.UseVisualStyleBackColor = true;
            // 
            // CategoryChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 204);
            this.Controls.Add(this.rbTechnicalLiterature);
            this.Controls.Add(this.rbFiction);
            this.Controls.Add(this.rbScienceArticle);
            this.Controls.Add(this.rbMagazine);
            this.Controls.Add(this.rbNewspaper);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "CategoryChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose item category";
            this.Load += new System.EventHandler(this.CategoryChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbNewspaper;
        private System.Windows.Forms.RadioButton rbMagazine;
        private System.Windows.Forms.RadioButton rbScienceArticle;
        private System.Windows.Forms.RadioButton rbFiction;
        private System.Windows.Forms.RadioButton rbTechnicalLiterature;
    }
}