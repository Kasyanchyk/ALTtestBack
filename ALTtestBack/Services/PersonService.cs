using ALTtestBack.DTO;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALTtestBack.Services
{
    public class PersonService
    {

        public Person CreatePerson(PersonDTO personDTO)
        {
            var person = new Person();
            if (personDTO.Names != null)
            {
                foreach (var nameDTO in personDTO.Names)
                {
                    var name = new HumanName();
                    foreach (var givenDTO in nameDTO.Givens)
                    {
                        name.WithGiven(givenDTO);
                    }
                    name.AndFamily(nameDTO.Family);
                    name.Use = nameDTO.Use;
                    person.Name.Add(name);
                }
            }
            if (personDTO.Telecoms != null)
            {
                foreach (var telecomeDTO in personDTO.Telecoms)
                {
                    var telecome = new ContactPoint();
                    telecome.Value = telecomeDTO.Value;
                    telecome.Use = telecomeDTO.Use;
                    telecome.System = telecomeDTO.System;
                    person.Telecom.Add(telecome);
                }
            }

            person.Gender = personDTO.Gender;

            person.BirthDate = personDTO.Birthday;

            if (personDTO.Addresses != null)
            {
                foreach (var addressDTO in personDTO.Addresses)
                {
                    var address = new Address();
                    address.Use = addressDTO.Use;
                    foreach (var lineDTO in addressDTO.Lines)
                    {
                        address.Line.ToList().Add(lineDTO);
                    }
                    address.City = addressDTO.City;
                    address.State = addressDTO.State;
                    address.PostalCode = addressDTO.PostalCode;
                    person.Address.Add(address);
                }
            }
            return person;
        }
    }
}
