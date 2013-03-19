using System;
using System.Runtime.Serialization;

namespace HotelManager.Person
{
    class PersonException : Exception, ISerializable
    {
        public PersonException() : base()
        {
        }
        
        public PersonException(string message) : base(message)
        {
        }

        public PersonException(string message, Exception inner) : base(message, inner)
        {
        }

        protected PersonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}