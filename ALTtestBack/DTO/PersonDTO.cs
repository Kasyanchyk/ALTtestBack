using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace ALTtestBack.DTO
{
    public class PersonDTO
    {
        public IEnumerable<PersonNameDTO> Names { get; set; }

        public IEnumerable<PersonTelecomDTO> Telecoms { get; set; }

        public string Birthday { get; set; }

        public IEnumerable<PersonAddressDTO> Addresses { get; set; }

        public AdministrativeGender Gender { get; set; }


    }
}
