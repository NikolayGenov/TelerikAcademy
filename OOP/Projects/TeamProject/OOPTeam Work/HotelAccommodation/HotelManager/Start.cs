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
            // Creating Receptionist
            Receptionist rc1 = new Receptionist(123, "Penka", 600);
            rc1.Languages = new List<Languages>();
            rc1.Languages.Add(Languages.BG);
            rc1.Languages.Add(Languages.RU);
            rc1.Languages.Add(Languages.DE);
            rc1.Languages.Add(Languages.EN);
            // Creating client
            Client cl1 = new Client(456, "Georgi Iliev");
            //IComunicate test
            Console.WriteLine("IComunicate test:");
            Console.WriteLine(rc1.Welcome(Languages.EN));
            try
            {
                Console.WriteLine(rc1.SayIt(Languages.EN, "How are you today?"));
            }
            catch (PersonException)
            {
                Console.WriteLine("Excuse me, I can't translate this. No connection to my brain!");
            }
            Console.WriteLine(rc1.GoodBye(Languages.EN));
            Console.WriteLine();
            Console.WriteLine(rc1.Welcome(Languages.RU));
            try
            {
                Console.WriteLine(rc1.SayIt(Languages.RU, "How are you today?"));
            }
            catch (PersonException)
            {
                Console.WriteLine("Excuse me, I can't translate this. No connection to my brain!");
            }
            Console.WriteLine(rc1.GoodBye(Languages.RU));
            Console.WriteLine();
            Console.WriteLine(rc1.Welcome(Languages.BG));
            try
            {
                Console.WriteLine(rc1.SayIt(Languages.BG, "How are you today?"));
            }
            catch (PersonException)
            {
                Console.WriteLine("Excuse me, I can't translate this. No connection to my brain!");
            }
            Console.WriteLine(rc1.GoodBye(Languages.BG));
            Console.WriteLine();
            Console.WriteLine(rc1.Welcome(Languages.DE));
            try
            {
                Console.WriteLine(rc1.SayIt(Languages.DE, "How are you today?"));
            }
            catch (PersonException)
            {
                Console.WriteLine("Excuse me, I can't translate this. No connection to my brain!");
            }
            Console.WriteLine(rc1.GoodBye(Languages.DE));
            Console.WriteLine();
            //IPay test
            Console.WriteLine("IPay test:");
            Console.WriteLine(cl1.Name + "'s balance: " + cl1.Ballance());
            cl1.CollectMoney(165.98M);
            Console.WriteLine(cl1.Name + "'s balance, after CollectMoney(): " + cl1.Ballance());
            rc1.CollectMoney(cl1.PayMoney(93M));
            Console.WriteLine(rc1.Name + "'s balance, after CollectMoney(): " + rc1.Ballance());
            Console.WriteLine(cl1.Name + "'s balance, after PayMoney(): " + cl1.Ballance());
            // Create hotel, personel and client
            Hotel ht1 = new Hotel(Category.FiveStar);
            Room room1 = new Room(RoomKind.Dbl, 2);
            ht1.AddRoom(room1, 5);
            Room room2 = new Room(RoomKind.Sgl, 1);
            ht1.AddRoom(room2, 3);
            
            Manager mn1 = new Manager(1245, "Petar Petrov", 2350);
            Housekeeping mate1 = new Housekeeping(5469, "Kaka Sijka", 150);
            ht1.HirePersonel(mn1); // Managers can be hired only by Hotels
            mn1.HirePersonel(rc1); // Other personel can be hired by Managers
            mn1.HirePersonel(mate1);
            Console.WriteLine();
            Console.WriteLine("Get all Receptionists:");
            Console.WriteLine(ht1.GetPersonalByType(typeof(Receptionist)));

            Console.WriteLine("Get all Personel:");
            Console.WriteLine(ht1.GetPersonalByType(typeof(Personel)));

            List<Client> clients = new List<Client>();
            clients.Add(cl1);
            //IAccommodate test
            ushort inRoom1 = rc1.CheckIn(clients);
            ushort inRoom2 = rc1.CheckIn(clients);
            Console.WriteLine("List of rooms after checkin:");
            Console.WriteLine(ht1.ListRooms());
            rc1.CheckOut(inRoom1);
            rc1.CheckOut(inRoom2);
            mate1.CleanRoom(inRoom1); //inRoom2 will remain unclean :) 
            Console.WriteLine("List of rooms after checkout:");
            Console.WriteLine(ht1.ListRooms());
        }
    }
}
