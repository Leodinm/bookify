using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
    public sealed class Apartment :Entity
    {
        public Apartment(Guid id) : base(id)
        {
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }

        public Address Address { get; private set; }
        

       public Money price { get; private set; }
        public Money CleaningFee { get; private set; }


        public DateTime?  LastBookonUtc { get; private set; }

        public List<Amenity> amenities { get; private set; } = new();

    }
}
