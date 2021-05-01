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
    public partial class cerrent_time : UserControl
    {
        public cerrent_time()
        {
            InitializeComponent();
        }

        private void cerrent_time_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
            label4.Text = DateTime.Now.ToString("ss");
            label2.Text = DateTime.Now.ToString("yyyy년 MMM월 dd일");
            label3.Text = DateTime.Now.ToString("dddd");
        }
    }
}
