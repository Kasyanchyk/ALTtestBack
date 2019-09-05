using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace ALTtestBack.DTO
{
    public class PersonAddressDTO
    {
        public Address.AddressUse Use { get; set; }

        public IEnumerable<string> Lines { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string State { get; set; }

        //public enum AddressUse
        //{
        //    Home = 0,
        //    Work = 1,
        //    Temp = 2,
        //    Old = 3,
        //    Billing = 4
        //}
    }
}
