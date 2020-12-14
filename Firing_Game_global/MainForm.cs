using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firing_Game_global
{
    public partial class MainForm : Form
    {
        component option = new component();
        int count = 0;
        int trigger = 0;
        int firechance = 0;
        int triggerAway = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //first of all i am going to disable the rest button excpt the start button 
            btnStart.Enabled = true;
            btnLoad.Enabled = false;
            btnSpin.Enabled = false;
            btnFire.Enabled = false;
            btnFireAway.Enabled = false;
            pbBox.Image = Firing_Game_global.Properties.Resources.str;
            trigger = option.bulletTrigger();
            triggerAway = option.bulletTrigger();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //when the user click on the start button then the load of the gun button willbe enable to take the second step
            if (option.startGame()==1) {
                btnStart.Enabled = false;
                btnLoad.Enabled = true;
                //visible the image
                pbBox.Image=Firing_Game_global.Properties.Resources.str2;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //when the user click on the Load button then the Spin of the gun button willbe enable to take the third step
            if (option.loadGun() == 1)
            {
                btnLoad.Enabled = false;
                btnSpin.Enabled = true;
                //visible the image
                pbBox.Image = Firing_Game_global.Properties.Resources.str3;
            }

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            //when the user click on the Spin button then the fire, fireaway of the gun button willbe enable to take the last step
            if (option.spinRoller() == 1)
            {
                btnSpin.Enabled = false;
                btnFire.Enabled = true;
                btnFireAway.Enabled = true;
                //visible the image
                pbBox.Image = Firing_Game_global.Properties.Resources.str4;
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            //this code is used to count how much time we click on the fire button
            count++;
            option.generateSound();

            if (count == trigger)
            {
                MessageBox.Show("Contestant is dead! ");
                btnFire.Enabled = false;
                btnFireAway.Enabled = false;
                btnStart.Enabled = true;
                count = 0;

            }
            else if (count == 4)
            {
                MessageBox.Show("Hurry you are still Alive");
                btnFire.Enabled = false;
                btnFireAway.Enabled = false;
                btnStart.Enabled = true;
                count = 0;

            }
            else {
                MessageBox.Show("You saved ");
            }



        }

        private void btnFireAway_Click(object sender, EventArgs e)
        {
            firechance++;
            option.generateSound();
            if (firechance == trigger)
            {
                MessageBox.Show("contestant dead ");
                btnFire.Enabled = false;
                btnFireAway.Enabled = false;
                btnStart.Enabled = true;
                firechance = 0;
            }
            else if (firechance == 2)
            {
                MessageBox.Show("Going to die ");
                btnFire.Enabled = false;
                btnFireAway.Enabled = false;
                btnStart.Enabled = true;
                firechance = 0;
            }
            else {
                MessageBox.Show("Shoot Again ");
            }
        }
    }
}
