using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public int Count => this.data.Count();

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public  void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            var removedHero = this.data.Find(x => x.Name == name);
            this.data.Remove(removedHero);            
        }
        public Hero GetHeroWithHighestStrength()
        {
            var highestStrengthHero = this.data.OrderByDescending(x=>x.Item.Strength).Take(1).ToList();
            return highestStrengthHero[0];
        }
        public Hero GetHeroWithHighestAbility()
        {
            var highestStrengthHero = this.data.OrderByDescending(x => x.Item.Ability).Take(1).ToList();
            return highestStrengthHero[0];
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            var highestStrengthHero = this.data.OrderByDescending(x => x.Item.Intelligence).Take(1).ToList();
            return highestStrengthHero[0];
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var hero in this.data)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().Trim();
        
        }
    }
}
