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
using System.IO;
using System.Timers;

namespace The_Time_Project_5._9._1._3f
{
    public partial class alarm_control : UserControl
    {
        System.Timers.Timer timer;

        public alarm_control()
        {
            InitializeComponent();
            button3.Hide();
            pictureBox4.Hide();
        }

        private void alarm_control_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

        }

        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }



        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLabel;
                    if(bunifuCustomLabel1.InvokeRequired)
                    {
                        Invoke(upd, bunifuCustomLabel1, "Alarm is Finished.");
                    }
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\TTP_Ringtone\alarm1.wav";
                    player.Play();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            bunifuCustomLabel1.Text = "Alarm is Starting...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            bunifuCustomLabel1.Text = "Alarm Stopped!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            button3.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button3.Show();
            pictureBox4.Show();
        }
    }
    }
