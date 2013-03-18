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
            Receptionist recepOne = new Receptionist("Penka", 600);
            
            //  recepOne.CollOfLanguages.Add(Languages.EN);
            //  recepOne.CollOfLanguages.Add(Languages.RU);
            //  recepOne.CollOfLanguages.Add(Languages.DE);
            recepOne.CollOfLanguages.Add(Languages.BG);

            // Creating client
            Client clientOne = new Client("Georgi Iliev", 165.98M,RoomKind.Double);
            Client clientTwo = new Client("Georgi Georgiev", 250.98M, RoomKind.Single);

            ////COMMENTED - WORKING FOR NOW :)
            ////IComunicate test
            //TestComunications(recepOne);
            ////IPay test
            //Comment because of testing
            //Test Wakeup event
            // recepOne.WakeUpCall(8, clientOne);

            Console.WriteLine("Enter to continue");
            Console.ReadKey();
            Console.WriteLine("IPay test:");
            Console.WriteLine(clientOne.Name + "'s balance " + clientOne.Ballance());
            recepOne.CollectMoney(clientOne.PayForRoom((decimal)RoomPrice.Single));
            Console.WriteLine(recepOne.Name + "'s balance, after CollectMoney(): " + recepOne.Ballance());
            Console.WriteLine(clientOne.Name + "'s balance, after PayMoney(): " + clientOne.Ballance());
            // Create hotel, personel and client
            Hotel hotelOne = new Hotel(Category.FiveStar, numberOfPools: 3);
            SeaHotel seaHotel = new SeaHotel(Category.FourStar, 10);//fix this
            //When creating a room we should set it as free, clean and some beds inside
           
            Room room1 = new Room(RoomKind.Triple);
            hotelOne.CreateRoom(room1, 3);
            Room room2 = new Room(RoomKind.Single);
            Room room3 = new Room(RoomKind.Double);
            hotelOne.CreateRoom(room2, 3);
            hotelOne.TakenRooms = new List<Room>();
          
            Manager manager = new Manager("Petar Petrov", 2350);
            //Housekeeping maid1 = new Housekeeping(104324, "Gosho", 0m);
            Housekeeping maid = new Housekeeping("Kaka Sijka", 150);
            hotelOne.HirePersonel(manager); // Managers can be hired only by Hotels
            manager.HirePersonel(recepOne); // Other personel can be hired by Managers
            manager.HirePersonel(maid);
            
            Console.ReadLine();
            Console.WriteLine("Get all Receptionists:");
            Console.WriteLine(hotelOne.GetPersonalByType(typeof(Receptionist)));
            Console.WriteLine("Get all Personel:");
            Console.WriteLine(hotelOne.GetPersonalByType(typeof(Personel)));
            List<Client> clients = new List<Client>();
            clients.Add(clientOne);
            clients.Add(clientOne);
           
            //CHECK IN
            Console.WriteLine(recepOne.TryGivingRoom(clients));
            //IAccommodate test
            //  recepOne.GiveRoom(clients );
            //recepOne.GiveRoom(clients);
            
            Console.ReadLine();
            Console.WriteLine(hotelOne.ListTakenRooms());
            //Console.WriteLine("List of rooms after checkin:");
            //Console.WriteLine(hotelOne.ListRooms());
         
            //CHECK OUT
            Console.WriteLine( recepOne.TryCheckOutRoom(clientOne));
            maid.CleanRoom(); //inRoom2 will remain unclean :) 
            // maid.CleanRoom(); // can't clrean because it's not empty
            //Console.WriteLine("List of rooms after checkout:");
            Console.WriteLine(hotelOne.ListRooms());

            Console.ReadLine();
            Console.WriteLine("The End!");
            Console.ReadLine();
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
        //public static void CreatingSomeOtherObjects()
        //{
        //    Client chichkoTrevichko = new Client(7777, "Chichko Trevichko", 5000m); //Creating client.
        //    Chalet alekoHut = new Chalet(Category.FourStar); //Creating chalet.
        //    chichkoTrevichko.EducationLevel = 5; //Education level type byte?
        //    alekoHut.CheckIn
        //}
    }
}