using System;
using System.Linq;

namespace MainPhone.Calls
{
    public class GSMCallHistoryTest
    {
        private CallHistory callHistory = null; 
        //Constructor
        public GSMCallHistoryTest(CallHistory callHistory)
        {
            this.callHistory = callHistory;
        }
        //Printing the price where we have calculated taking the constant 
        public void PrintCalculatedPrice(decimal pricePerMinute)
        {
            decimal price = this.callHistory.CalculateMoney(pricePerMinute);
            Console.WriteLine("The price to pay is : {0}", price);
        }
        //Methods for the basic stuff
        public void ClearList()
        {
            this.callHistory.ClearHistory();
        }

        public void PrintList()
        {
            Console.WriteLine(this.callHistory.ToString()); 
        }
        //This one takes the longest call so far
        public void RemoveLongestCall()
        {
            this.callHistory.RemoveCall(this.callHistory.GetLongestCall());
        }
        //This one takes position in the call list
        public void RemoveCallTest(int position)
        {
            this.callHistory.RemoveCall(position);
        }
    }
}