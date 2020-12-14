using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firing_Game_global
{
   public class component
    {
        //create the object of the random class
        Random rd = new Random();

        //this method is used to return the signals to start the fire game 
        public int startGame() {
            return 1;
        }

        //this method is used to return the signals to 'load the bullet into the gun 
        public int loadGun()
        {
            return 1;
        }

        //this method is used to return the signals to 'spin the roller
        public int spinRoller()
        {
            return 1;
        }

        //this is trigger which is need to measure the trigger
        public int bulletTrigger() {
            return rd.Next(1, 6);
        }

        public void generateSound() {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Firing_Game_global.Properties.Resources.rfire);
            obj.Play();

        }
    }
}
