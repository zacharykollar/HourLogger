using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourLogger
{
    public partial class HourForm : Form
    {
        private bool working;
        private DateTime startTime;

        public bool Working { get => working; set => working = value; }
        public string OutputFile 
        { 
            get => Properties.Settings.Default.OutputFile;
            
            set
            {
                Properties.Settings.Default.OutputFile = value;
            }
        }

        public DateTime StartTime { get => startTime; }

        public HourForm()
        {
            InitializeComponent();

            if (OutputFile.Equals(""))
            {
                ChangeOutputFile();
            }
            WriteToFile(0);
            Working = false;
            GetHoursWorked();
        }

        /// <summary>
        /// Gets the hours worked from the logfile and puts it on the screen
        /// </summary>
        private void GetHoursWorked()
        {
            var lines = File.ReadLines(OutputFile);
            double hoursWorked = 0;
            foreach (var line in lines)
            {
                hoursWorked += double.Parse(line.Trim());
            }
            textboxHours.Text = hoursWorked.ToString();
        }


        /// <summary>
        /// Brings up file window to select where to log the file
        /// </summary>
        private void ChangeOutputFile()
        {

        }
        /// <summary>
        /// Writes to the output file, appending to the end
        /// </summary>
        /// <param name="str"></param>
        public void WriteToFile(double hours)
        {
            using( StreamWriter sw = new StreamWriter(OutputFile))
            {
                sw.WriteLine(hours);
            }
        }
        
        private void StopWork()
        {
            Working = false;
            double hoursWorked = DateTime.Now.Subtract(StartTime).TotalHours;
            WriteToFile(hoursWorked);
            GetHoursWorked();
        }
        
        private void StartWork()
        {
            Working = true;
            startTime = DateTime.Now;
        }

        private void buttonStartEndWork_Click(object sender, EventArgs e)
        {
            if (working)
            {
                StopWork();
            }
            else
            {
                StartWork();
            }
        }
    }
}
