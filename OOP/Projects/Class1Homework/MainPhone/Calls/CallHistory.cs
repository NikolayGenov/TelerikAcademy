using System;
using System.Collections.Generic;
using System.Linq;

namespace MainPhone.Calls
{
    public class CallHistory
    {
        private List<Call> callHistory = null;
        private uint callCount = 0;

        public CallHistory()
        {
            this.callHistory = new List<Call>();     
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
            callCount++;
        }

        public void RemoveCall(int position)
        {
            if (callHistory.Count < position)
            {
                throw new ArgumentException("The position is not valid");
            }
            this.callHistory.RemoveAt(position);
            callCount--;
        }

        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
            callCount--;
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public Call GetLongestCall()
        {
            Call maxCall = this.callHistory.Max();
            return maxCall;
        }

        public decimal CalculateMoney(decimal pricePerMinute)
        {
            int timeInSeconds = 0;
            foreach (Call call in callHistory)
            {
                timeInSeconds += call.Duration.Value;
            }
            decimal total = (timeInSeconds / 60.0m) * pricePerMinute;
            return total;
        }

        public override string ToString()
        {
            string text = null;
            foreach (Call call in callHistory)
            {
                text += call.ToString() + "\n";
            }
            return text;
        }
    }
}