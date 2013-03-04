using System;

namespace MainPhone.GsmClass
{ 
    public class GSMTest
    {
        public GSMTest()
        {
        }
        
        public void PrintAllPhones(GSM[] phones)
        {
            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}