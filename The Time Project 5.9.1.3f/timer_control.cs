using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace The_Time_Project_5._9._1._3f
{
    public partial class timer_control : UserControl
    {
        private int hours;
        private int minutes;
        private int seconds;
        

        private int trig = 0;
        public timer_control()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 24;
            numericUpDown1.Minimum = 0;
            numericUpDown2.Maximum = 60;
            numericUpDown2.Minimum = 0;
            numericUpDown3.Maximum = 60;
            numericUpDown3.Minimum = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            minutes = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            seconds = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));

            label1.Text = appendZero(hours);
            label2.Text = appendZero(minutes);
            label3.Text = appendZero(seconds);
            if (trig == 0)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                trig = 1;
            }
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds <= 0)
            {
                if (minutes > 0 || hours > 0)
                {
                    if (minutes == 0)
                    {
                        if (hours >= 0)
                        {
                            hours = hours - 1;
                            minutes = 60;
                            if (hours < 0)
                            {
                                hours = 0;
                            }
                        }
                    }
                    minutes = minutes - 1;
                    seconds = 59;
                    timer1 = new Timer();
                    timer1.Interval = 1000;
                    timer1.Start();
                    label1.Text = appendZero(hours);
                    label2.Text = appendZero(minutes);
                    label3.Text = appendZero(seconds);
                    if (minutes < 0)
                    {
                        minutes = 0;
                    }

                }
                if (seconds < 0)
                {
                    seconds = 0;
                }
                timer1.Stop();
            }
            label1.Text = appendZero(hours);
            label2.Text = appendZero(minutes);
            label3.Text = appendZero(seconds);
        }

        private string appendZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }

       

    }
}

