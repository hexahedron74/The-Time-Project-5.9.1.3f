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
    public partial class developer : UserControl
    {
        string textBox;
        public developer()
        {
            InitializeComponent();
            textBox1.Hide();
        }

        private void developer_Load(object sender, EventArgs e)
        {
            
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            
            textBox1.Show();
            textBox = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "GSLKJPROGRAMMER0704")
            {
                label3.Text = "This Program is made by Lee Ki Joon From GS";
            }
            else
            {
                label3.Text = "Hmm... This is an EasterEgg but.... not the real EasterEgg... But... Well Done!";
            }
        }

        
    }
}
