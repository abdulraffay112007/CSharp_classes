using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class5_stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msec=Convert.ToInt32(milsecond.Text);
            int sec=Convert.ToInt32(second.Text);
            int min=Convert.ToInt32(minute.Text);
            int hrs=Convert.ToInt32(hour.Text);

            msec= msec + 5;
            milsecond.Text = msec.ToString();
            if (msec >= 60)
            {
                 milsecond.Text = "00";
                 sec = sec + 1;
                 second.Text = sec.ToString();
            }else if (sec >= 60)
            {
                second.Text = "00";
                min = min + 1;
                minute.Text=min.ToString();
            }else if (min >= 60)
            {
                minute.Text = "00";
                hrs=hrs + 1;
                hour.Text=hrs.ToString();
            }
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled =false;
        }

        private void resumebtn_Click(object sender, EventArgs e)
        {
            int msec = Convert.ToInt32(milsecond.Text);
            int sec = Convert.ToInt32(second.Text);
            int min = Convert.ToInt32(minute.Text);
            int hrs = Convert.ToInt32(hour.Text);

            if(msec>0||sec>0||min>0||hrs>0){
                 timer1.Enabled = true;
            }
            else
            {
               MessageBox.Show("Please start the stopwatch first");

            }
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            milsecond.Text="00";
            second.Text="00";
            minute.Text= "00";
            hour.Text = "00";
            timer1.Enabled = false;
        }
    }
}

