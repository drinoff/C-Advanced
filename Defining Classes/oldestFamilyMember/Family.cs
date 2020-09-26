using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            List<Person> people = new List<Person>();
        }
        List<Person> people { get; set; }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }
        public Person GetOldestMember()
        {
            var people = this.people.OrderBy(x=>x.Age);
            var oldestMember = this.people[0];
            return oldestMember;
        }
    }
}
