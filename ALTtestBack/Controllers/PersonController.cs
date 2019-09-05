﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using ALTtestBack.DTO;
using ALTtestBack.Services;

namespace ALTtestBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private FhirClient client;
        private PersonService personeService;

        public PersonController()
        {
            client = new FhirClient("http://hapi.fhir.org/baseR4");
            personeService = new PersonService();
        }

        [HttpGet]
        public PersonDTO Get()
        {
            //Bundle results = client.Search<Person>();

            //return results.Entry.Select(x => x.Resource).Cast<Person>().ToList();
            PersonDTO personDTO = new PersonDTO()
            {
                Names = new List<PersonNameDTO>()
                {
                    new PersonNameDTO(){ Family="Зубенко", Givens=new List<string>(){"Михаил"}, Use=HumanName.NameUse.Official},
                    new PersonNameDTO(){  Givens=new List<string>(){"Мишаня"}, Use=HumanName.NameUse.Usual}
                },
                Birthday = "1921-12-12",
                Gender = AdministrativeGender.Male,
                Addresses = new List<PersonAddressDTO>()
                {
                    new PersonAddressDTO(){City="Тернополь", Lines=new List<string>(){"улица Пушкина" } }
                }
            };

            return personDTO;
        }

        [HttpPost]
        public ActionResult<PersonDTO> Create(PersonDTO personDTO)
        {
            client.Create<Person>(personeService.CreatePerson(personDTO));
            return CreatedAtAction(nameof(Create), personDTO);
        }

    }
}