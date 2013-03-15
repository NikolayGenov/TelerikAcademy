using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Facility
{
    class FacilityException : Exception, ISerializable
    {
        public FacilityException()
            : base()
        {
            // Add implementation.
        }

        public FacilityException(string message)
            : base(message)
        {
            // Add implementation.
        }

        public FacilityException(string message, Exception inner)
            :base(message, inner)
        {
            // Add implementation.
        }

        protected FacilityException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
