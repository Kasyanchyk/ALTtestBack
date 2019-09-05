using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALTtestBack.DTO
{
    public class PersonTelecomDTO
    {
        public string Value { get; set; }

        public ContactPointSystem System { get; set; }

        public ContactPointUse Use { get; set; }

        public enum ContactPointSystem
        {
            Phone = 0,
            Fax = 1,
            Email = 2,
            Pager = 3,
            Url = 4,
            Sms = 5,
            Other = 6
        }

        public enum ContactPointUse
        {
            Home = 0,
            Work = 1,
            Temp = 2,
            Old = 3,
            Mobile = 4
        }
    }
}
