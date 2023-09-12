using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class MobilePhone
    {
        /// <summary>
        /// We used for recognize which mobile phone is controlling house system
        /// </summary>
        public string nameMobilePhone { get; private set; }
        /// <summary>
        /// More specific detail than name mobile phone. This attributes say: which device is controlling house system
        /// </summary>
        public uint serialNumber { get; private set; }
        public MobilePhone(string nameMobilePhone, uint serialNumber)
        {
            this.nameMobilePhone = nameMobilePhone;
            this.serialNumber = serialNumber;
        }
        /// <summary>
        /// Mobile phone has application for controlling house. 
        /// </summary>
        /// <param name="house"></param>
        public void OpenHouseSystem(House house)
        {
            house.OpenUserInterface();
        }
    }
}
