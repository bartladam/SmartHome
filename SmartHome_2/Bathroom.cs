﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_2
{
    internal class Bathroom:Room
    {
        public Bathroom(string nameRoom, int sizeRoom, params Appliances[] appliances) : base(nameRoom, sizeRoom, appliances)
        {

        }
        /// <summary>
        /// Remotly control appliance
        /// </summary>
        /// <param name="appliances"></param>
        /// <param name="turnOn"></param>
        /// <returns></returns>
        public bool TurnOnAppliance(Appliances appliances, bool turnOn) => appliances.StartAppliance(turnOn);
    }
}
