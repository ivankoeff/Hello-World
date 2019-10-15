namespace ExtractDates
{
    partial class Form1
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
            this.loadDatabt = new System.Windows.Forms.Button();
            this.loadedDatalb = new System.Windows.Forms.Label();
            this.processDatabt = new System.Windows.Forms.Button();
            this.resultlb = new System.Windows.Forms.Label();
            this.loadTb = new System.Windows.Forms.TextBox();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadDatabt
            // 
            this.loadDatabt.Location = new System.Drawing.Point(13, 27);
            this.loadDatabt.Name = "loadDatabt";
            this.loadDatabt.Size = new System.Drawing.Size(75, 23);
            this.loadDatabt.TabIndex = 0;
            this.loadDatabt.Text = "Load data";
            this.loadDatabt.UseVisualStyleBackColor = true;
            this.loadDatabt.Click += new System.EventHandler(this.loadDatabt_Click);
            // 
            // loadedDatalb
            // 
            this.loadedDatalb.AutoSize = true;
            this.loadedDatalb.Location = new System.Drawing.Point(39, 66);
            this.loadedDatalb.Name = "loadedDatalb";
            this.loadedDatalb.Size = new System.Drawing.Size(67, 13);
            this.loadedDatalb.TabIndex = 2;
            this.loadedDatalb.Text = "Loaded data";
            // 
            // processDatabt
            // 
            this.processDatabt.Location = new System.Drawing.Point(246, 27);
            this.processDatabt.Name = "processDatabt";
            this.processDatabt.Size = new System.Drawing.Size(75, 23);
            this.processDatabt.TabIndex = 3;
            this.processDatabt.Text = "Process data";
            this.processDatabt.UseVisualStyleBackColor = true;
            this.processDatabt.Click += new System.EventHandler(this.processDatabt_Click);
            // 
            // resultlb
            // 
            this.resultlb.AutoSize = true;
            this.resultlb.Location = new System.Drawing.Point(351, 66);
            this.resultlb.Name = "resultlb";
            this.resultlb.Size = new System.Drawing.Size(37, 13);
            this.resultlb.TabIndex = 4;
            this.resultlb.Text = "Result";
            // 
            // loadTb
            // 
            this.loadTb.Location = new System.Drawing.Point(13, 96);
            this.loadTb.Multiline = true;
            this.loadTb.Name = "loadTb";
            this.loadTb.Size = new System.Drawing.Size(159, 296);
            this.loadTb.TabIndex = 5;
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(246, 96);
            this.resultTb.Multiline = true;
            this.resultTb.Name = "resultTb";
            this.resultTb.Size = new System.Drawing.Size(238, 296);
            this.resultTb.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(529, 443);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.loadTb);
            this.Controls.Add(this.resultlb);
            this.Controls.Add(this.processDatabt);
            this.Controls.Add(this.loadedDatalb);
            this.Controls.Add(this.loadDatabt);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button loadDatabt;
        private System.Windows.Forms.Label loadedDatalb;
        private System.Windows.Forms.Button processDatabt;
        private System.Windows.Forms.Label resultlb;
        private System.Windows.Forms.TextBox loadTb;
        public System.Windows.Forms.TextBox resultTb;
    }
}

