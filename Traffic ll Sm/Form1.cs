using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_ll_Sm
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int elapsedSecond = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTrafficLight();
        }

        private void InitializeTrafficLight()
        {
            RedLight.BackColor = Color.Red;
            Yellowlight.BackColor = SystemColors.ControlDark;
            GreenLight.BackColor = SystemColors.ControlDark;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedSecond++;
            if (elapsedSecond==1)
            {
                Yellowlight.BackColor = Color.Yellow;
                RedLight.BackColor = SystemColors.ControlDark;

            }
            else if (elapsedSecond==5)
            {
                GreenLight.BackColor = Color.Green;
                Yellowlight.BackColor = SystemColors.ControlDark;

            }
            else if (elapsedSecond == 15)
            {
                RedLight.BackColor = Color.Red;
                GreenLight.BackColor = SystemColors.ControlDark;
                elapsedSecond = 0;
                timer.Stop();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Yellowlight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GreenLight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RedLight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpress_Click(object sender, EventArgs e)
        {
            elapsedSecond = 0;
            timer.Start();

        }
    }
}
