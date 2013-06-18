using System;

namespace ExceptionProject
{
    class InvalidRangeException<T> : Exception
    //The template exception inherits the base exception class
    {
        //Template ranges
        public T StartRange { get; set; }

        public T StopRange { get; set; }

        //Some msg
        public static string ErrorMsg = "Value not in range";

        //And constructor with them
        public InvalidRangeException(T startRange, T stopRange) : base(ErrorMsg)
        {
            this.StartRange = startRange;
            this.StopRange = stopRange;
        }
    }
}