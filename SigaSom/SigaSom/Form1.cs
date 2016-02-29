using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigaSom



{

    public enum Tone
    {
        REST = 0,
        GbelowC = 196,
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415
    }
    public partial class Form1 : Form
    {
        int nivel = 0;

        int but;
        List<int> Simon = new List<int>();
        Random rnd = new Random();

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int som = rnd.Next(4) + 1;

            Simon.Add(som);

            foreach (int a in Simon ){
                
                switch (a)
                {
                    case 1: button1.BackColor = Color.White; break;

                    case 2: button2.BackColor = Color.White; break;
                    case 3: button3.BackColor = Color.White; break;
                    case 4: button4.BackColor = Color.White; break;
                }

                
                MessageBox.Show(a.ToString());
                Console.Beep(a * 1000, 500);
                
                switch (a)
                {
                    case 1: button1.BackColor = Color.Blue; break;

                    case 2: button2.BackColor = Color.Yellow; break;
                    case 3: button3.BackColor = Color.Red; break;
                    case 4: button4.BackColor = Color.Green; break;
                }



            }



            nivel++;
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
            int but = Simon.Last();
            if (nivel == 1 && but == 1)
            {
                MessageBox.Show("Nivel 1 Concluido");
            }
            else
            {
            }

            if (nivel == 2 && but == 1)
            {
                MessageBox.Show("Nivel 2 Concluido");
            }
            else
            {
            }

            if (nivel == 3 && but == 1)
            {
                MessageBox.Show("Nivel 3 Concluido");
            }
            else
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int but = Simon.Last();
            if (nivel == 1 && but == 2)
            {
                MessageBox.Show("Nivel 1 Concluido");
            }
            else
            {
            }

            if (nivel == 2 && but == 2)
            {
                MessageBox.Show("Nivel 2 Concluido");
            }
            else
            {
            }

            if (nivel == 3 && but == 2)
            {
                MessageBox.Show("Nivel 3 Concluido");
            }
            else
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int but = Simon.Last();
            if (nivel == 1 && but == 3)
            {
                MessageBox.Show("Nivel 1 Concluido");
            }
            else
            {
            }

            if (nivel == 2 && but == 3)
            {
                MessageBox.Show("Nivel 2 Concluido");
            }
            else
            {
            }

            if (nivel == 3 && but == 3)
            {
                MessageBox.Show("Nivel 3 Concluido");
            }
            else
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int but = Simon.Last();
            if (nivel == 1 && but == 4)
            {
                MessageBox.Show("Nivel 1 Concluido");
            }
            else
            {
                
            }

            if (nivel == 2 && but == 4)
            {
                MessageBox.Show("Nivel 2 Concluido");
            }
            else
            {
                
            }

            if (nivel == 3 && but == 4)
            {
                MessageBox.Show("Nivel 3 Concluido");
            }
            else
            {
                
            }
        }
    }
}
