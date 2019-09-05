using Hl7.Fhir.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALTtestBack.DTO
{
    public class PersonNameDTO
    {
        public string Family { get; set; }

        public IEnumerable<string> Givens { get; set; }
        public HumanName.NameUse Use { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        //public enum NameUse
        //{
        //    Usual = 0,
        //    Official = 1,
        //    Temp = 2,
        //    Nickname = 3,
        //    Anonymous = 4,
        //    Old = 5,
        //    Maiden = 6
        //}
    }
}
