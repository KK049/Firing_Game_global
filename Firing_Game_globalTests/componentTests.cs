using Microsoft.VisualStudio.TestTools.UnitTesting;
using Firing_Game_global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firing_Game_global.Tests
{
    [TestClass()]
    public class componentTests
    {
        [TestMethod()]
        public void bulletTriggerTest()
        {
            component com = new component();
            int y = com.bulletTrigger();
            if (y > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void chkSound()
        {
            component com = new component();
            com.generateSound();

        }

    }
}