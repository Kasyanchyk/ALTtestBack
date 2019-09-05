using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using ALTtestBack.DTO;

namespace ALTtestBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private FhirClient client;

        public PersonController()
        {
            client = new FhirClient("http://hapi.fhir.org/baseR4");
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            Bundle results = client.Search<Person>();

            return results.Entry.Select(x => x.Resource).Cast<Person>().ToList();
        }

        [HttpPost]
        public ActionResult<PersonDTO> Create(PersonDTO personDTO)
        {



            return CreatedAtAction(nameof(Create), personDTO);
        }

    }
}