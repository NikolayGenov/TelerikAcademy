using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFifteen
{
    public class Matrix
    {
        private int[,] matrix;
     
        private int dimention;

        private int numValue;
        private int curWidth;
        private int curHeight;

        public Matrix(int dimention)
        {
            this.Dimention = dimention;
            this.matrix = new int[Dimention, Dimention];
        }

        public int CurHeight
        {
            get
            {
                return curHeight;
            }
            set
            {
                curHeight = value;
            }
        }

        public int CurWidth
        {
            get
            {
                return curWidth;
            }
            set
            {
                curWidth = value;
            }
        }
        
        public int NumValue
        {
            get
            {
                return numValue;
            }
            set
            {
                numValue = value;
            }
        }
        
        public int Dimention
        {
            get
            {
                return this.dimention;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Given value can't be null");
                }
                if (value <= 0)
                {
                    throw new ArgumentException("Dimention can't be negative or zero");
                }
                this.dimention = value;
            }
        }
    }
}