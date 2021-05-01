using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Time_Project_5._9._1._3f
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        


        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            stopWatch_Control1.BringToFront();
            pictureBox4.Hide();
           

        }



        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Do You Want To Really Exit\n" + "The Program?";
            pictureBox4.Show();
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
            pictureBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            license.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            timer_control1.BringToFront();
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            timer_control1.BringToFront();
        }
    }
}
