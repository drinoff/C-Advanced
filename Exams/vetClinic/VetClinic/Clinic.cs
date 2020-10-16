using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace VetClinic
{
    class Clinic
    {
        private List<Pet> data;

        public int Capacity { get; set; }
        public int Count
        {
            get { return this.data.Count; }
        }
        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            data = new List<Pet>();
        }
        public void Add(Pet pet)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            var forRemoving = this.data.Find(x => x.Name == name);
            if (this.data.Contains(forRemoving))
            {
                this.data.Remove(forRemoving);
                return true;
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            var petToGet = this.data.Find(x => x.Name == name);
            if (this.data.Contains(petToGet))
            {
                return petToGet;
            }
            else
                return null;
        }
        public Pet GetOldestPet()
        {

            var oldestPet = this.data.OrderByDescending(x => x.Age).Take(1).ToList();
            return oldestPet[0];
        }
        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.Append("The clinic has the following patients:" + Environment.NewLine);
            foreach (var pet in this.data)
            {
                sb.Append($"Pet {pet.Name} with owner: {pet.Owner}" + Environment.NewLine);
            }
            return sb.ToString().Trim();
                


        }

    }
}
