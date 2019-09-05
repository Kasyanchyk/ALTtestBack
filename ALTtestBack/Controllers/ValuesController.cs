using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace ALTtestBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //var pat = new Person();
            //pat.Name.Add(new HumanName()
            //.WithGiven("Homer").WithGiven("J.").AndFamily("Simpson"));
            //pat.Identifier.Add(new Identifier("http://acme.org/MRNs", "7000135"));
            //pat.Gender = AdministrativeGender.Male;
            //pat.Address.Add(new Address() { Use = Address.AddressUse.Home, Line = new List<string>{ },City="",State="", PostalCode="" });
            //pat.BirthDate = "";
            //// Create a client
            //var client = new FhirClient("http://hapi.fhir.org/baseR4");
            //// Use the client to store a new resource instance
            ////var outcome = client.Create<Person>(pat);
            //// Print the ID of the newly created resource
            ////Console.WriteLine(outcome.Id);


            //var q = new SearchParams().Where("name=Simpson").LimitTo(100);
            ////q.Add("birthdate", "lt2014-01-01");
            //Bundle results = client.Search<Person>(q);
            //// How many resources did we find?
            //Console.WriteLine("Number of results: " + results.Total);
            //// Print the ID of the first one
            //Console.WriteLine("First result id: " + results.Entry.First().Resource.Id);
            //return new string[] { "value1", "value2" };
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
