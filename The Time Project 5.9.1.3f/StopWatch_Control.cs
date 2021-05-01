using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Time_Project_5._9._1._3f
{
    public partial class StopWatch_Control : UserControl
    {
        System.Timers.Timer t;
        int seconds;
        int minutes;
        int hours;
        public StopWatch_Control()
        {
            InitializeComponent();
        }

    }
}
