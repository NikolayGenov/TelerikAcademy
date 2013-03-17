using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Person
{
    class PersonException : Exception, ISerializable
    {
        public PersonException() : base()
        {
            // Add implementation.
        }

        public PersonException(string message) : base(message)
        {
            // Add implementation.
        }

        public PersonException(string message, Exception inner) : base(message, inner)
        {
            // Add implementation.
        }

        protected PersonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}