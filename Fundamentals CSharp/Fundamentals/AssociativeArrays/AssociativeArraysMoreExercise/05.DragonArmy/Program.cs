using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HitlerArmy army = new HitlerArmy();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = SplitString(Console.ReadLine());

                string type = cmdArgs[0];

                Dragon dragon = ParseDragon(cmdArgs);

                army.AddDragon(type, dragon);
            }
            Console.Write(army);
        }
        private static string[] SplitString(string toSplit)
        {
            return toSplit.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }
        private static Dragon ParseDragon(string[] cmdArgs)
        {
            string name = cmdArgs[1];
            string damage = cmdArgs[2];
            string health = cmdArgs[3];
            string armors = cmdArgs[4];

            Dragon parsed = new Dragon(name,damage, health, armors);

            return parsed;
        }
    }
    public class HitlerArmy
    {
        private const string TypeFormat = "{0}::({1:F2}/{2:F2}/{3:F2})";
        private const string DragonBum = "-{0}";
        private Dictionary<string, Dictionary<string, Dragon>> typeOfDragons;
        public HitlerArmy()
        {
            this.typeOfDragons = new Dictionary<string, Dictionary<string, Dragon>>();
        }
        public void AddDragon(string type, Dragon dragon)
        {
            if (!this.typeOfDragons.ContainsKey(type))
            {
                this.typeOfDragons.Add(type, new Dictionary<string, Dragon>());
            }
            Dictionary<string, Dragon> dragonsName = this.typeOfDragons[type];
            dragonsName[dragon.Name] = dragon;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<string,Dictionary<string,Dragon>> kvp in this.typeOfDragons)
            {
                string type = kvp.Key;

                Dictionary<string, Dragon> dragonsByName = kvp.Value;

                double dragonsCount = dragonsByName.Count;
                double averageDamage = GetAverage(dragonsByName, d=>d.Damage, dragonsCount);
                double averageHealth = GetAverage(dragonsByName, d=>d.Health, dragonsCount);
                double averageArmor = GetAverage(dragonsByName, d=>d.Armor, dragonsCount);

                string formatted = string.Format(TypeFormat, type, averageDamage, averageHealth, averageArmor);
                result.AppendLine(formatted);

                foreach (KeyValuePair<string,Dragon> dragonAndName in dragonsByName.OrderBy(x=>x.Key))
                {
                    string dragonInfo = dragonAndName.Value.ToString();

                    formatted = string.Format(DragonBum, dragonInfo); 
                    result.AppendLine(formatted);
                }
            }

            return result.ToString().Trim();
        }
        private static double GetAverage(Dictionary<string, Dragon> dragonsByName,
                                         Func<Dragon, int> selector,
                                         double dragonsCount)
        {

            return dragonsByName.Sum(kvp => selector(kvp.Value)) / dragonsCount;
        }
    }
    public class Dragon
    {
        private const string ToStringFormatted = "{0} -> damage: {1}, health: {2}, armor: {3}";
        private const int DefaultHealth = 250;
        private const int DefaultDamage = 45;
        private const int DefaultArmor = 10;
        private const string Null = "null";

        private string name;
        private int health;
        private int damage;
        private int armor;

        
        public Dragon(string name,string damage, string health,string armor)
        {
            this.Name = name;
            this.damage = this.ParseDamage(damage);
            this.health = this.ParseHealth(health);
            this.armor = this.ParseArmor(armor);
        }
        public int Health
        {
            get
            {
                return this.health;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
        }
        public int Armor
        {
            get
            {
                return this.armor;
            }
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        private bool StringIsNull(string value)
        {
            return value == Null;
        }
        private int ParseHealth(string health)
        {
            if (this.StringIsNull(health))
            {
                return DefaultHealth;
            }
            return int.Parse(health);
        }
        private int ParseDamage(string damage)
        {

            if (this.StringIsNull(damage))
            {
                return DefaultDamage;
            }
            return int.Parse(damage);
        }
        private int ParseArmor(string armor)
        {
            if (this.StringIsNull(armor))
            {
                return DefaultArmor;
            }
            return int.Parse(armor);
        }
        public override string ToString()
        {
            string output = string.Format(ToStringFormatted, 
                                                  this.Name,
                                                  this.damage,
                                                  this.health,
                                                  this.armor);
            return output;
        }
    }
}
