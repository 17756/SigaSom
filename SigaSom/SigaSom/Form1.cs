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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            Random rnd = new Random();
            int but = rnd.Next(1, 5);
            switch (but)
            {
                case 1:
                    button1.BackColor = Color.DeepPink;
                    System.Media.SystemSounds.Beep.Play();
                    break;
                case 2:
                    button2.BackColor = Color.DeepPink;
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                case 3:
                    button3.BackColor = Color.DeepPink;
                    System.Media.SystemSounds.Exclamation.Play();
                    break;
                case 4:
                    button4.BackColor = Color.DeepPink;
                    System.Media.SystemSounds.Hand.Play();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
}
