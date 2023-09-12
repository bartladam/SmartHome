using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_2
{
    internal class Appliances
    {
        /// <summary>
        /// Appliance has always name for recognize what we turn on / off
        /// </summary>
        public string nameAppliance { get; private set; }
        /// <summary>
        /// Is appliance active or not
        /// </summary>
        public bool applianceWork { get; private set; }
        public Appliances(string nameAppliance)
        {
            this.nameAppliance = nameAppliance;
        }
        /// <summary>
        /// User remotly control aplliance 
        /// </summary>
        /// <param name="turnOn"></param>
        /// <returns></returns>
        public bool StartAppliance(bool turnOn)
        {
            applianceWork = turnOn;
            return applianceWork;
        }
    }
}
