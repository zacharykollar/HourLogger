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
        public HourForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Writes to the output file, appending to the end
        /// </summary>
        /// <param name="str"></param>
        public void WriteToFile(int hours)
        {
            using( StreamWriter sw = new StreamWriter())
            {
                sw.WriteLine(str)
            }
        }
    }
}
