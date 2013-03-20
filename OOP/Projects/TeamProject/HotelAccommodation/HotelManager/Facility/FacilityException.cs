using System;
using System.Runtime.Serialization;

namespace HotelManager.Facility
{
    class FacilityException : Exception, ISerializable
    {
        public FacilityException() : base()
        {
        }

        public FacilityException(string message) : base(message)
        {
        }

        public FacilityException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FacilityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}