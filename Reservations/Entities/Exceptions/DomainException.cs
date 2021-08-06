using System;

namespace Reservations.Entities.Exceptions
{
    class DomainException:ApplicationException
    {
        //Constructor
        public DomainException(string message):base(message)
        {
        }
    }
}
