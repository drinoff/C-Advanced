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
            this.people = new List<Person>();
        }

        public List<Person> people { get; set; }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }
        public Person GetOldestMember()
        {
              
            
            return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
