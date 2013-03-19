using System;
using HotelManager.Facility;
using HotelManager.Person;

namespace HotelManager
{
    public static class TestClass
    {
        public static void GeneralTest()
        { 
            //Creating some Clients
            Client firstClient = new Client("Jim Morrison", 203.54M,RoomKind.Double);
            Client secondClient = new Client("Ruppert Wane", 1882.33M, RoomKind.Single);
            Client thirdClient = new Client("Ann Smith", 4022.09M, RoomKind.Triple);
            Client fourtClient = new Client("Martin Oliver", 1020.77M, RoomKind.Single);
            Client fifthClient = new Client("Gennifer Green", 7233.12M, RoomKind.Apartment);
          
            //Creating some facilities
            Hotel hotelRome = new Hotel("Hotel Rome",Category.FourStar, numberOfPools: 3);
            Motel motelVega = new Motel("Motel Vega",Category.TwoStar, numberOfParkingPlaces: 50);
            Chalet chaletViva = new Chalet("Viva Chalet",Category.ThreeStar, numberOfSkiLifts: 3);
            SeaHotel sunnyBeachHotel = new SeaHotel("Sunny Beach Hotel",Category.FiveStar, numberOfPools: 5, numberOfBeachSpots: 250);
            //For Golf and Spa facility
            GolfFacility golfPravec = new GolfFacility(numberOfHoles: 18, dificultyLevel: 10);
            GolfAndSpa spaAndGolfPravec = new GolfAndSpa("Spa and Gold Complex Pravec",Category.FiveStar, golfPravec, numberOfPools: 2);

            //Creating rooms
            Room singleRoom = new Room(RoomKind.Single);
            Room doubleRoom = new Room(RoomKind.Double);
            Room tripleRoom = new Room(RoomKind.Triple);
            Room apartment = new Room(RoomKind.Apartment);

            //Add number of rooms to given facility
            hotelRome.AddRoomsToFacility(singleRoom, 2);
            hotelRome.AddRoomsToFacility(doubleRoom, 3);
            hotelRome.AddRoomsToFacility(apartment, 1);
            motelVega.AddRoomsToFacility(tripleRoom, 3);
            spaAndGolfPravec.AddRoomsToFacility(apartment, 2);
            spaAndGolfPravec.AddRoomsToFacility(doubleRoom, 2);
            chaletViva.AddRoomsToFacility(singleRoom);
            sunnyBeachHotel.AddRoomsToFacility(apartment, 200);

            //Creating personel
            Manager firstManager = new Manager("Bill McBrain", 3040.44M);
            Manager secondManager = new Manager("Vince Carter", 4000.33M);
            Housekeeping firstHousekeeper = new Housekeeping("Nick Watch", 500.40M);
            Housekeeping secondHousekeeper = new Housekeeping("Judy Baker", 500.40M);
            GolfInstructor golfInstructor = new GolfInstructor("James Dean", 1405M);
            
            //Create some receptionists
            Receptionist receptionist = new Receptionist("Pesho Armqnov", 930.94M);
            Receptionist receptionistPenka = new Receptionist("Penka  Ivanova", 346.49M);
            receptionist.AddLanguages(Languages.RU, Languages.DE, Languages.BG);
            receptionistPenka.AddLanguages(Languages.DE);

            //Process hotel 
            //
            Console.WriteLine("Hotel info\n");
            //Getting managers
            hotelRome.HirePersonel(firstManager);

            //Hire some Personel
            firstManager.HirePersonel(firstHousekeeper);
            firstManager.HirePersonel(receptionist);

            //Housekeepers are waiting for orders
            firstHousekeeper.WaitingForOders(receptionist);
            
            //Add some clients
            hotelRome.Clients.Add(firstClient);
            hotelRome.Clients.Add(secondClient);

            //Print some personel
            Console.WriteLine("Some personel:");
            Console.WriteLine(hotelRome.GetPersonalByType(typeof(Receptionist)));
            Console.WriteLine(hotelRome.GetPersonalByType(typeof(Housekeeping)));

            //Test receptionists
            TestComunications(receptionist);

            Console.WriteLine("Before Check in :");
            Console.WriteLine("{0}'s balance: {1}", hotelRome.FacilityName, hotelRome.Finance);
            Console.WriteLine("{0}'s balance: {1}\n", firstClient.Name, firstClient.Ballance());

            //Check IN all the clients
            Console.WriteLine(receptionist.TryGivingRooms());

            Console.WriteLine("After Check in :");
            Console.WriteLine("{0}'s balance: {1}", hotelRome.FacilityName, hotelRome.Finance);
            Console.WriteLine("{0}'s balance: {1}\n", firstClient.Name, firstClient.Ballance());

            //List of taken rooms and all in hotel            
            Console.WriteLine(hotelRome.ListTakenRooms());
            Console.WriteLine(hotelRome.ListRooms());
            
            //Check out 
            Console.WriteLine(receptionist.TryCheckOutRoom(firstClient));
            //Status of the rooms after check out of 1 client
            Console.WriteLine("After check out: ");
            Console.WriteLine(hotelRome.ListTakenRooms());
            Console.WriteLine(hotelRome.ListRooms());
            Console.WriteLine("End of info about the hotel\n");
            ///
            ///END OF HOTEL

            //
            //
            //Process Golf and Spa
            Console.WriteLine("Golf and Spa info\n");
            //Getting managers
            spaAndGolfPravec.HirePersonel(secondManager);
            
            //Hire some Personel
            secondManager.HirePersonel(secondHousekeeper);
            secondManager.HirePersonel(golfInstructor);
            secondManager.HirePersonel(receptionistPenka);

            //Housekeepers are waiting for orders
            secondHousekeeper.WaitingForOders(receptionistPenka);
            
            //Add some clients
            spaAndGolfPravec.Clients.Add(thirdClient);
            spaAndGolfPravec.Clients.Add(fifthClient);
            spaAndGolfPravec.Clients.Add(fourtClient);

            //Print some personel
            Console.WriteLine("Some personel:");
            Console.WriteLine(spaAndGolfPravec.GetPersonalByType(typeof(Manager)));
            Console.WriteLine(spaAndGolfPravec.GetPersonalByType(typeof(GolfInstructor)));

            //Test receptionists
            TestComunications(receptionistPenka);
            Console.WriteLine("Before Check in :");
            Console.WriteLine("{0}'s balance: {1}", spaAndGolfPravec.FacilityName, spaAndGolfPravec.Finance);
            Console.WriteLine("{0}'s balance: {1}\n", thirdClient.Name, thirdClient.Ballance());

            //Check IN all the clients
            Console.WriteLine(receptionistPenka.TryGivingRooms());

            Console.WriteLine("After Check in :");
            Console.WriteLine("{0}'s balance: {1}", spaAndGolfPravec.FacilityName, spaAndGolfPravec.Finance);
            Console.WriteLine("{0}'s balance: {1}\n", thirdClient.Name, thirdClient.Ballance());
            ////List of taken rooms

            //List of taken rooms and all in golf and spa complex            
            Console.WriteLine(spaAndGolfPravec.ListTakenRooms());
            Console.WriteLine(spaAndGolfPravec.ListRooms());

            //Check out 
            Console.WriteLine(receptionistPenka.TryCheckOutRoom(fourtClient));
            
            //Status of the rooms after check out of 1 client
            Console.WriteLine("After check out: ");
            Console.WriteLine(spaAndGolfPravec.ListTakenRooms());
            Console.WriteLine(spaAndGolfPravec.ListRooms());
            Console.WriteLine("End of info about the Golf and Spa\n");
        }

        public static void TestComunications(Receptionist recep)
        {
            //IComunicate test
            Console.WriteLine("Comunication test:");
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