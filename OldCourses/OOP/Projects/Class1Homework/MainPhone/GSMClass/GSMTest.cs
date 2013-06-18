using System;

namespace MainPhone.GsmClass
{ 
    public class GSMTest
    {
        public GSMTest()
        {
        }
        //Taking as a param all the phones in array and just print them with the new ToString 
        public void PrintAllPhones(GSM[] phones)
        {
            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}