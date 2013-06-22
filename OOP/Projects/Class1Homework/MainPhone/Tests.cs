using System;
using System.Linq;
using MainPhone.Calls;
using MainPhone.GsmClass;

namespace MainPhone
{
    public class Tests
    {
        static void Main()
        {
            const decimal PricePerMinute = 0.37m;
            //Array of 5 phones
            GSM[] phones = new GSM[5];
            // Different types of batteries and displays
            Battery battery1 = new Battery(Battery.BatteryType.NiMH, 50, 10);
            Battery battery2 = new Battery(Battery.BatteryType.LiIon, 40, 5);
            Battery battery3 = new Battery(Battery.BatteryType.ZnChl, 100, 40);
            Display display1 = new Display(5.0, 1000000);
            Display display2 = new Display(5.5, 103530050);
            Display display3 = new Display(4, 425324);

            //Some phones created
            phones[0] = new GSM("Samsung Galaxy S4", "Samsung" , 1444.44 , "Pesho Ivanov" , battery: battery1 , display: display1);
            phones[1] = new GSM("iPhone 5", "Apple", 1500, "Bill Gates", battery: battery2, display: display3);
            phones[2] = new GSM("HTC One X", "HTC", 1200, "Someone Else", battery: battery3);
            phones[3] = new GSM("Nokia 3310", "Nokia",null,null,null,display: display2);
            phones[4] = GSM.PIPhone4S;

            //Using the class GSMtest we print all the phones using method
            Console.WriteLine("PHONES:");
            Console.WriteLine();
            GSMTest gsmTestPrint = new GSMTest();
            gsmTestPrint.PrintAllPhones(phones);

            Console.WriteLine("CALLS:");
            Console.WriteLine();
            //For the first phone we create call history
            phones[0].CallHistory = new CallHistory();
            CallHistory history = phones[0].CallHistory;
            //Adding 4 calls with different params
            Call testCall1 = new Call(DateTime.Now.AddHours(2), 450, 532423);
            Call testCall2 = new Call(DateTime.UtcNow, 440, 12532423);
            Call testCall3 = new Call(DateTime.MinValue, 29, 94532423);
            Call testCall4 = new Call(DateTime.MaxValue, 90, 3532423);
            history.AddCall(testCall1);
            history.AddCall(testCall2);
            history.AddCall(testCall3);
            history.AddCall(testCall4);
            //Then we test the history
            GSMCallHistoryTest callHistoryTest = new GSMCallHistoryTest(phones[0].CallHistory);
            //We print the list  and then the first calculated price
            callHistoryTest.PrintList();
            callHistoryTest.PrintCalculatedPrice(PricePerMinute);
            //Then we remove the longest call and print the total price again
            callHistoryTest.RemoveLongestCall();
            callHistoryTest.PrintCalculatedPrice(PricePerMinute);
            //Then we remove a call on position in the list - 1  and print the price we have to pay again
            callHistoryTest.RemoveCallTest(position:1);
            callHistoryTest.PrintCalculatedPrice(PricePerMinute);
            //We print the remaining calls on the list to show it's not empty yet
            Console.WriteLine();
            Console.WriteLine("The remaining items on the call list:");
            callHistoryTest.PrintList();
            //Finally we clear the list and print it
            callHistoryTest.ClearList();
            callHistoryTest.PrintList();
        }
    }
}