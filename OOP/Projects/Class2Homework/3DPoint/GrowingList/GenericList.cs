using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrowingList
{
    public class GenericList<T> 
    {
        //Were we store all the elements of the array
        private T[] members;
        private long counter = 0;
        
        //Properties
        public long Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("You can't remove more elements than you already have");
                }
                //If the value that the counter is being set reached the capacity then we double the size
                if (value == this.Capacity)
                    MoveToBiggerSize();
                counter = value;
            }
        }

        public long Capacity { get; set; }

        public T this[int i]
        {
            get
            {
                return members[i];
            }
            set
            {
                //Using this to insert a new element on that position and push the elements back
                Insert(i);
                this.members[i] = value;
            }
        }

        //Constructors 

        //In this case - if no capacity was given we make it 1
        public GenericList() : this(1)
        {
        }

        public GenericList(long capacity)
        {
            if (capacity == 0)
            {
                throw new ArgumentException("Can't create list with capacity 0");
            }
            this.Capacity = capacity;
            members = new T[this.Capacity];
            this.Counter = 0;
        }

        private void MoveToBiggerSize()
        {
            //Make temp list and move all the elements there and then copy the elements, double the size and more the elements back
            T[] temp = new T[this.Capacity];
            Array.Copy(members, temp, this.Capacity);
            Capacity *= 2;
            members = new T[this.Capacity];
            Array.Copy(temp, members, this.Capacity / 2);
        }

        //We just add 1 to the counter and then put it to the last position
        public void Add(T element)
        {
            this.Counter++; //then trigger if needed
            this.members[this.Counter - 1] = element;
        }
        
        //We first have to check if the position it's not empty or below 0 and then process by moving the array
        public void Remove(long position)
        {
            if (position < 0 || position >= this.Counter)
            {
                throw new IndexOutOfRangeException("No element on that position");
            }
            this.Counter--;
            members[position] = default(T);
            Array.Copy(members, position + 1, members, position, this.Capacity - (position + 1));
        }

        //Inserting at a given position it's called by the T[] = structure and we add one to the counter (add new space if needed and then move the array
        public void Insert(long position)
        {
            this.Counter++;
            if (this.Counter <= position)
            {
                throw new ArgumentOutOfRangeException("Can't add element out of the capacity");
            }
            Array.Copy(members, position, members, position + 1, this.Capacity - (position + 1));
        }

        //If we want to clear the list just set the main prop to def values and make a new list so we can add more to it
        public void Clear()
        {
            this.Counter = 0;
            this.Capacity = 1;
            members = new T[this.Capacity];
        }

        //Using some value we search for it and return the index and if none - return -1
        public int FindIndex(T key)
        {
            return Array.IndexOf(this.members, key);
        }
         
        //Checking for elements and then loop and compare, finally return the min 
        public T Min()
        {
            if (this.Counter != 0)
            {
                T min = this.members[0];
                for (int i = 0; i < this.Counter; i++)
                {
                    if (Comparer<T>.Default.Compare(this.members[i], min) < 0)
                    {
                        min = this.members[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentException("No values to compare");
            }
        }

        //Same concept - return max
        public T Max()
        {
            if (this.Counter != 0)
            {
                T max = this.members[0];
                for (int i = 0; i < this.Counter; i++)
                {
                    if (Comparer<T>.Default.Compare(this.members[i], max) > 0)
                    {
                        max = this.members[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentException("No values to compare");
            }
        }

        //Overriding the method and printing all the members of the list
        public override string ToString()
        {
            if (Counter == 0)
            {
                return ("The list of elements is empty");
            }
            else if (Counter < 0)
            {
                throw new ArgumentException("The counter can't be negative ");
            }
            else
            {
                StringBuilder text = new StringBuilder();
                text.AppendLine("The list :");
                for (int i = 0; i < this.Counter; i++)
                {
                    text.AppendLine(string.Format("Element[{0}] = {1}", i, members[i]));            
                }
                return text.ToString();
            }
        }
    }
}