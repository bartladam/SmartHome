using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_2
{
    internal class System
    {
        /// <summary>
        /// Rooms which are controlled by system
        /// </summary>
        public Room[] rooms { get; private set; }
        public System(Room[] rooms)
        {
            this.rooms = rooms;
        }
        /// <summary>
        /// Each room has own settings and this method shows this settings
        /// </summary>
        /// <returns></returns>
        private string GetInformationRooms()
        {
            string informationAboutRooms = "";
            foreach (Room item in rooms)
            {
                informationAboutRooms += item.GetInformation();
            }
            return informationAboutRooms;
        }
        /// <summary>
        /// This method helps user to orient in options this application
        /// </summary>
        public void UserInterface()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(GetInformationRooms());
                Console.WriteLine("--------------------");
                Console.WriteLine(@"
1 - Set heat
2 - Lock door
3 - Turn on lights
4 - Turn on Appliances
5 - Add Function");
                Console.Write("Your choice: ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                string selectedRoom;
                switch (choice)
                {
                    case '1':
                        selectedRoom = SelectedRoom();
                        foreach (Room item in rooms)
                        {
                            if (item.nameRoom.Equals(selectedRoom))
                            {
                                Console.Write("Select heat:");
                                int selectedHeat = int.Parse(Console.ReadLine());
                                item.SetHeat(selectedHeat);
                            }
                        }
                        break;
                    case '2':
                        selectedRoom = SelectedRoom();
                        foreach (Room item in rooms)
                        {
                            if (item.nameRoom.Equals(selectedRoom))
                            {
                                Console.Write("Lock door:");
                                bool selectStatus = bool.Parse(Console.ReadLine());
                                item.LockDoor(selectStatus);
                            }
                        }
                        break;
                    case '3':
                        selectedRoom = SelectedRoom();
                        foreach (Room item in rooms)
                        {
                            if (item.nameRoom.Equals(selectedRoom))
                            {
                                Console.Write("Turn on lights: ");
                                bool selectStatus = bool.Parse(Console.ReadLine());
                                item.TurnOnLights(selectStatus);
                            }
                        }
                        break;
                    case '4':
                        selectedRoom = SelectedRoom();
                        Console.Write("Which appliance: ");
                        string appliance = Console.ReadLine();
                        foreach (Room room in rooms)
                        {
                            foreach (Appliances appliances in room.appliances)
                            {
                                if (appliances.nameAppliance.Equals(appliance))
                                {
                                    Console.Write("Turn on appliance: ");
                                    bool selectStatus = bool.Parse(Console.ReadLine());
                                    Console.WriteLine($"{appliances.nameAppliance}: {appliances.StartAppliance(selectStatus)}");
                                    Console.ReadKey();
                                }

                            }
                        }
                        break;
                    case '5':
                        selectedRoom = SelectedRoom();
                        foreach (Room item in rooms)
                        {
                            if (item.nameRoom.Equals(selectedRoom))
                            {
                                Console.Write("Name appliances: ");
                                string nameAppliance = Console.ReadLine();
                                Console.Write("Turn on appliance: ");
                                bool selectStatus = bool.Parse(Console.ReadLine());
                                Console.WriteLine($"{nameAppliance}: {AddFunction(item, selectStatus, nameAppliance)}");
                            }

                        }
                        Console.ReadKey();
                        break;

                }
            }
        }
        /// <summary>
        /// Repeated part in each switch case
        /// </summary>
        /// <returns></returns>
        public string SelectedRoom()
        {
            string selectedRoom;
            Console.Write("Which room: ");
            while (string.IsNullOrWhiteSpace(selectedRoom = Console.ReadLine()))
            {
                Console.Write("Which room: ");
            }
            return selectedRoom;
        }
        /// <summary>
        /// User can add new function to system.
        /// </summary>
        /// <param name="room"></param>
        /// <param name="turnOn"></param>
        /// <param name="nameAppliance"></param>
        /// <returns></returns>
        private bool AddFunction(Room room, bool turnOn, string nameAppliance)
        {
            return room.TurnOnNewFunction(Function, new Appliances(nameAppliance), turnOn);
        }
        /// <summary>
        /// Added new function from user request
        /// </summary>
        /// <param name="appliances"></param>
        /// <param name="turnOn"></param>
        /// <returns></returns>
        private bool Function(Appliances appliances, bool turnOn)
        {
            return appliances.StartAppliance(turnOn);
        }
    }
}
