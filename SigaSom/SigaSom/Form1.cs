using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigaSom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Random rnd = new Random();
            int but = rnd.Next(1, 5);
            switch (but)
            {
                case 1:
                    button1.ForeColor = Color.Chocolate;
                    System.Media.SystemSounds.Beep.Play();
                    System.Threading.Thread.Sleep(1000);
                    button1.BackColor = Color.Blue;
                    break;
                case 2:
                    button2.ForeColor = Color.Chocolate;
                    System.Media.SystemSounds.Asterisk.Play();
                    System.Threading.Thread.Sleep(1000);
                    button2.BackColor = Color.Yellow;
                    break;
                case 3:
                    button3.ForeColor = Color.Chocolate;
                    System.Media.SystemSounds.Exclamation.Play();
                    System.Threading.Thread.Sleep(1000);
                    button3.BackColor = Color.Red;
                    break;
                case 4:
                    button4.ForeColor = Color.Chocolate;
                    System.Media.SystemSounds.Hand.Play();
                    System.Threading.Thread.Sleep(1000);
                    button4.BackColor = Color.Green;
                    break;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
            button1.BackColor = Color.Blue;
            button2.Enabled = true;
            button2.BackColor = Color.Yellow;
            button3.Enabled = true;
            button3.BackColor = Color.Red;
            button4.Enabled = true;
            button4.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
