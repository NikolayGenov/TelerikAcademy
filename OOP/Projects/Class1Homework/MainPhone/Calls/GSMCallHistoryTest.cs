using System;
using System.Linq;

namespace MainPhone.Calls
{
    public class GSMCallHistoryTest
    {
        private CallHistory callHistory = null; 

        public GSMCallHistoryTest(CallHistory callHistory)
        {
            this.callHistory = callHistory;
        }

        public void PrintCalculatedPrice(decimal pricePerMinute)
        {
            decimal price = this.callHistory.CalculateMoney(pricePerMinute);
            Console.WriteLine("The price to pay is : {0}", price);
        }

        public void ClearList()
        {
            this.callHistory.ClearHistory();
        }

        public void PrintList()
        {
            Console.WriteLine(this.callHistory.ToString()); 
        }

        public void RemoveLongestCall()
        {
            this.callHistory.RemoveCall(this.callHistory.GetLongestCall());
        }

        public void RemoveCallTest(int position)
        {
            this.callHistory.RemoveCall(position);
        }
    }
}