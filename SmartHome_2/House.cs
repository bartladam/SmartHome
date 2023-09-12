using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_2
{
    internal class House
    {
        /// <summary>
        /// Each smart house has application which is listening command remotely by mobile phone
        /// </summary>
        public System System { get; private set; }
        /// <summary>
        ///  House has rooms which are controled by system
        /// </summary>
        public Room[] rooms { get; private set; }
        public House(params Room[] rooms)
        {
            System = new System(rooms);
        }
        /// <summary>
        /// Show system interface focused on controlling house
        /// </summary>
        public void OpenUserInterface()
        {
            System.UserInterface();
        }
    }
}
