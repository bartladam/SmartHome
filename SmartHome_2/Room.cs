using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_2
{
    abstract class Room
    {
        /// <summary>
        /// We give appliances to room and we have to know where is the appliance. Name room help us to recognize it
        /// </summary>
        public string nameRoom { get; private set; }
        /// <summary>
        /// More specific attribute about room
        /// </summary>
        public int sizeRoom { get; private set; }
        /// <summary>
        /// We set heat in room for best comfort user. This give us information about currently heat in room
        /// </summary>
        public int actualHeat { get; private set; } = 25;
        /// <summary>
        /// Each door in house we can lock/unlock for user safe
        /// </summary>
        public bool lockDoor { get; private set; }
        /// <summary>
        /// Turn on turn off lights without touch 
        /// </summary>
        public bool turnOnLight { get; private set; }
        /// <summary>
        /// user can add new function to system
        /// </summary>
        /// <param name="appliance"></param>
        /// <param name="turnOn"></param>
        /// <returns></returns>
        public delegate bool newFunction(Appliances appliance, bool turnOn);
        public Appliances[] appliances { get; private set; }
        public Room(string nameRoom, int sizeRoom, Appliances[] appliances)
        {
            this.nameRoom = nameRoom;
            this.sizeRoom = sizeRoom;
            this.appliances = appliances;
        }
        /// <summary>
        /// Each room has information about heat, doors etc
        /// </summary>
        /// <returns></returns>
        public string GetInformation() => string.Format($"Room: {nameRoom}\nSizeRoom: {sizeRoom} m2\nActual heat: {actualHeat} C°\nLock door: {lockDoor}\nTurn on lights: {turnOnLight}\n\n");

        /// <summary>
        /// User can set heat in his room
        /// </summary>
        /// <param name="heat"></param>
        /// <returns></returns>
        public int SetHeat(int heat)
        {
            actualHeat = heat;
            return actualHeat;
        }
        /// <summary>
        /// User can lock/unlock door
        /// </summary>
        /// <param name="lockDoor"></param>
        /// <returns></returns>
        public bool LockDoor(bool lockDoor)
        {
            this.lockDoor = lockDoor;
            return lockDoor;
        }
        /// <summary>
        ///  User can remotly turn on/ turn off lights
        /// </summary>
        /// <param name="turnOnLight"></param>
        /// <returns></returns>
        public bool TurnOnLights(bool turnOnLight)
        {
            this.turnOnLight = turnOnLight;
            return turnOnLight;
        }
        /// <summary>
        /// Open / close new function. For example: windows
        /// </summary>
        /// <param name="newFunction"></param>
        /// <param name="appliance"></param>
        /// <param name="turnOn"></param>
        /// <returns></returns>
        public bool TurnOnNewFunction(newFunction newFunction, Appliances appliance, bool turnOn)
        {
            return newFunction.Invoke(appliance, turnOn);
        }
    }
}
