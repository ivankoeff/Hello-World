using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractDates
{
    public partial class Form1 : Form
    {
        string filePath;
        List<string> lines = new List<string>();

        public Form1()
        {
            InitializeComponent();
            loadTb.ScrollBars = ScrollBars.Vertical;
            resultTb.ScrollBars = ScrollBars.Vertical;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loadDatabt_Click(object sender, EventArgs e)
        {
            loadTb.Text = "";
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                filePath = fd.FileName;
                lines.LoadFile(filePath);
            }
            
            foreach (var item in lines)
            {
                loadTb.Text += item + Environment.NewLine;
            }
        }

        private void processDatabt_Click(object sender, EventArgs e)
        {
            string expression = @"(\d{1,2}(.|\.)\d{1,2}(.|\.)\d{4})|(\d{4}(.|\.)\d{1,2}(.|\.)\d{1,2})|(\d{1,2}(.|\.)\w{3,9}(.|\.)\d{4})";
            List<DateTime> dateFormatList = new List<DateTime>();
            Regex reg = new Regex(expression);
            Match m;
            DateTime start, finish;
            TimeSpan processingTime;            
            string[] formats = new string[] 
            {
              "d-MM-yyyy", "d.MM.yyyy", "d/MM/yyyy", "d MM yyyy", "d:MM:yyyy",
              "dd-MM-yyyy", "dd.MM.yyyy", "dd/MM/yyyy", "dd MM yyyy", "dd:MM:yyyy",
              "MM-dd-yyyy", "MM.dd.yyyy", "MM/dd/yyyy", "MM dd yyyy", "MM:dd:yyyy",
              "MM-d-yyyy", "MM.d.yyyy", "MM/d/yyyy", "MM d yyyy", "MM:d:yyyy",
              "M-dd-yyyy", "M.dd.yyyy", "M/dd/yyyy", "M dd yyyy", "M:dd:yyyy",
              "M-d-yyyy", "M.d.yyyy", "M/d/yyyy", "M d yyyy", "M:d:yyyy",
              "yyyy-dd-MM", "yyyy.dd.MM", "yyyy/dd/MM", "yyyy dd MM", "yyyy:dd:MM",
              "yyyy-d-MM", "yyyy.d.MM", "yyyy/d/MM", "yyyy d MM", "yyyy:d:MM",
              "yyyy-MM-dd", "yyyy.MM.dd", "yyyy/MM/dd", "yyyy MM dd", "yyyy:MM:dd",
              "yyyy-MM-d", "yyyy.MM.d", "yyyy/MM/d", "yyyy MM d", "yyyy:MM:d",
              "yyyy-M-dd", "yyyy.M.dd", "yyyy/M/dd", "yyyy M dd", "yyyy:M:dd",
              "yyyy-M-d", "yyyy.M.d", "yyyy/M/d", "yyyy M d", "yyyy:M:d",
              "dd-MMMM-yyyy", "dd.MMMM.yyyy", "dd/MMMM/yyyy", "dd MMMM yyyy", "dd:MMMM: yyyy",
              "d-MMMM-yyyy", "d.MMMM.yyyy", "d/MMMM/yyyy", "d MMMM yyyy", "d:MMMM: yyyy",
              "yyyy-MMMM-dd", "yyyy.MMMM.dd", "yyyy/MMMM/dd", "yyyy MMMM dd", "yyyy:MMMM:dd",
              "yyyy-MMMM-d", "yyyy.MMMM.d", "yyyy/MMMM/d", "yyyy MMMM d", "yyyy:MMMM:d",
            };
 
            start = DateTime.Now;

            foreach (var item in lines)
            {
                m = reg.Match(item);
                if (m.Success)
                {
                    dateFormatList.Add(DateTime.ParseExact(item, formats, CultureInfo.InvariantCulture, DateTimeStyles.None));
                }
            }
            dateFormatList.Sort((a, b) => a.CompareTo(b));
            List<DateTime> noDuplicatesList = dateFormatList.Distinct().ToList();
            finish = DateTime.Now;
            processingTime = finish - start;

            resultTb.Text = "Start time" + start.ToString("dd/MM/yyyy hh:mm:ss.fff") + Environment.NewLine;
            foreach(var item in dateFormatList)
            {
                resultTb.Text += item.ToString()+Environment.NewLine;
            }
            resultTb.Text += Environment.NewLine;
            resultTb.Text += "Finish time" + finish.ToString("dd/MM/yyyy hh:mm:ss.fff") + Environment.NewLine;
            resultTb.Text += "The processing time is" + processingTime.ToString() + Environment.NewLine;
            resultTb.Text += "The total count of dates in the text is" + dateFormatList.Count + Environment.NewLine;
            resultTb.Text += "The number of unique dates in the text is" + noDuplicatesList.Count + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}