using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Facility;
using HotelManager.Person;

namespace HotelManager
{
    class Start // Renamed because of Compile Error: 'Main': member names cannot be the same as their enclosing type
    {
        static void Main()
        {
            //const decimal PricePerRoom = 93M;
            // Creating Receptionist
            Receptionist recepOne = new Receptionist(123, "Penka", 600);
            
            //  recepOne.CollOfLanguages.Add(Languages.EN);
            //  recepOne.CollOfLanguages.Add(Languages.RU);
            //  recepOne.CollOfLanguages.Add(Languages.DE);
            recepOne.CollOfLanguages.Add(Languages.BG);
            
            // Creating client
            Client clientOne = new Client(456, "Georgi Iliev", 165.98M);
           
            //COMMENTED - WORKING FOR NOW :)
                    ////IComunicate test
                    //TestComunications(recepOne);
                    //////IPay test
                    ////Comment because of testing

            Console.WriteLine("IPay test:");
            Console.WriteLine(clientOne.Name + "'s balance " + clientOne.Ballance());
            recepOne.CollectMoney(clientOne.PayForRoom((decimal)RoomPrice.Single));
            Console.WriteLine(recepOne.Name + "'s balance, after CollectMoney(): " + recepOne.Ballance());
            Console.WriteLine(clientOne.Name + "'s balance, after PayMoney(): " + clientOne.Ballance());
            // Create hotel, personel and client
            Hotel hotelOne = new Hotel(Category.FiveStar);
            //When creating a room we should set it as free, clean and some beds inside
            Room room1 = new Room(RoomKind.Double, 2);
            hotelOne.CreateRoom(room1, 3);
            Room room2 = new Room(RoomKind.Single, 1);
            
            hotelOne.CreateRoom(room2, 3);
            hotelOne.TakenRooms = new List<Room>();
            Manager manager = new Manager(1245, "Petar Petrov", 2350);
            //Housekeeping maid1 = new Housekeeping(104324, "Gosho", 0m);
            Housekeeping maid = new Housekeeping(5469, "Kaka Sijka", 150);
            hotelOne.HirePersonel(manager); // Managers can be hired only by Hotels
            manager.HirePersonel(recepOne); // Other personel can be hired by Managers
            manager.HirePersonel(maid);
            Console.WriteLine();
            Console.WriteLine("Get all Receptionists:");
            Console.WriteLine(hotelOne.GetPersonalByType(typeof(Receptionist)));
            Console.WriteLine("Get all Personel:");
            Console.WriteLine(hotelOne.GetPersonalByType(typeof(Personel)));
            List<Client> clients = new List<Client>();
            clients.Add(clientOne);
            //IAccommodate test
            recepOne.GiveRoom(clients, RoomPrice.Single);
            //  recepOne.CheckIn(clients);
            Console.WriteLine("List of rooms after checkin:");
            Console.WriteLine(hotelOne.ListRooms());
            recepOne.CheckOut(clientOne);
            //  recepOne.CheckOut(inRoom2);
            // maid.CleanRoom(inRoom1); //inRoom2 will remain unclean :) 
            Console.WriteLine("List of rooms after checkout:");
            Console.WriteLine(hotelOne.ListRooms());
        }
  
        private static void TestComunications(Receptionist recep)
        {
            //IComunicate test
            Console.WriteLine("IComunicate test:");
            Console.WriteLine("Pick a language:");
            bool parsed = false;
            int value = 0;
            Languages langCode = default(Languages);
            do
            {
                Console.WriteLine(recep.CanSpeak());
                parsed = int.TryParse(Console.ReadLine(), out value);
                langCode = (Languages)value;
            }
            while (!(Enum.IsDefined(langCode.GetType(), System.Convert.ToInt32(langCode)) &&
                     recep.IsAbleToSpeakIn().Contains(langCode) && parsed));
            try
            {
                Console.WriteLine(recep.Speak(langCode));
            }
            catch (PersonException)
            {
                Console.WriteLine("Excuse me, I can't translate this. No connection to my brain!");
            }
        }
    }
}