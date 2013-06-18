using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArrayProject
{
    class BitArray64 : IEnumerable<int>
    {
        //Save the number here
        private ulong ulongNumber;

        public BitArray64(ulong number)
        {
            this.ulongNumber = number;
        }

        public int this[int position]
        {
            get
            {
                //Check if the position is correct
                if (position >= 0 && position < 64)
                {
                    //Move that digit of 1 to that position
                    ulong mask = (ulong)1 << position;
                    // Get the digit using bitwise And
                    ulong digit = this.ulongNumber & mask;
                    return digit != 0 ? 1 : 0;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (position >= 0 && position < 64)
                {
                    if (value == 1)
                    {
                        //Place 1 to that position
                        this.ulongNumber |= (ulong)(1 << position);
                    }
                    else
                    {
                        //Reverse it and place 0 to that position
                        this.ulongNumber &= (ulong)~(1 << position);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //Overiding those operators and Equals
        public static bool operator ==(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return firstNumber.Equals(secondNumber);
        }

        public static bool operator !=(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return !firstNumber.Equals(secondNumber);
        }
        
        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public bool Equals(BitArray64 value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }
            if (ReferenceEquals(this, value))
            {
                return true;
            }
            return this.ulongNumber == value.ulongNumber;
        }

        //Implementing the interface
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return ulongNumber.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}