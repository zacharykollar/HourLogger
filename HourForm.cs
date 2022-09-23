using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private System.Windows.Forms.Timer workTimer;
        public HourForm()
        {
            workTimer = new();
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
        /// Gets the hours worked from the logfile and puts it on the screen in textboxHours.
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
            throw new NotImplementedException();
        }
        /// <summary>
        /// Writes to the output file, appending to the end.
        /// </summary>
        /// <param name="hours">The number of hours as a double. can be any number of digits, but two decimal places perferred.</param>
        public void WriteToFile(double hours)
        {
            using( StreamWriter sw = File.AppendText(OutputFile))
            {
                sw.WriteLine(hours);
            }
            GetHoursWorked();
        }
        
        /// <summary>
        /// Called via the stop button or an overtime condition. Handles calling the WriteToFile and switches button text.
        /// </summary>
        private void StopWork()
        {
            Working = false;
            double hoursWorked = Math.Round(DateTime.Now.Subtract(StartTime).TotalHours, 2);
            buttonStartEndWork.Text = "Start Work";
            WriteToFile(hoursWorked);
            textBoxLoggedHours.Text = "";
            workTimer.Stop();
            workTimer.Dispose();
        }
        
        /// <summary>
        /// Called via the start button. Handles switching the start time on, and handles changing button text.
        /// </summary>
        private void StartWork()
        {
            Working = true;
            buttonStartEndWork.Text = "Stop Work";
            startTime = DateTime.Now;
            workTimer = new()
            {
                Interval = 36000,
            };
            workTimer.Tick += new EventHandler(WorkTimerTick);
            workTimer.Start();
        }

        /// <summary>
        /// Handled by the workTimer. Updates the logged hours textbox when called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WorkTimerTick(object? sender, EventArgs e)
        {
            textBoxLoggedHours.Text = Math.Round((DateTime.Now - startTime).TotalHours, 2).ToString();
        }

        #region Designer Event Handlers
        /// <summary>
        /// Calls the two methods StartWork and StopWork. No actual work is done here. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStartEndWork_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Calls WriteToFile to input time from the updown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInputHours_Click(object sender, EventArgs e)
        {
            WriteToFile((double) UpDownInputHours.Value);
            UpDownInputHours.Value = 0;
        }

        /// <summary>
        /// Clears the output file.
        /// TODO: autosend email capability?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewWeek_Click(object sender, EventArgs e)
        {
            File.WriteAllText(OutputFile, string.Empty);
            GetHoursWorked();
        }
        #endregion
    }
}
