using System;
using System.Collections.Generic;
using System.Linq;

namespace CorePractise
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Stars> stars = new List<Stars>();
            Console.Write("How many stars: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 2000) { Console.WriteLine("Number should be lower than 2000"); num = int.Parse(Console.ReadLine()); }
            for (int i = 0; i < num; i++)
            {
                string[] line = Console.ReadLine().Split(",").ToArray();
                Stars star = new Stars(line[0], double.Parse(line[1].Split().ToArray().Skip(1).First()), line[2], double.Parse(line[3].Split().ToArray().Skip(1).First()), line[4]);
                stars.Add(star);
            }
            PrintOrderedbyDistance(stars);
            Console.ReadLine();
            
        }

        private static void PrintOrderedbyDistance(List<Stars> stars)
        {
            stars.OrderBy(x => x.Distance);
            foreach (var item in stars)
            {
                Console.WriteLine(item.Name + " " + item.Distance + " " + item.Classific + " " + item.Mass + " " + item.Constellation);
            }
        }
    }
    public class Stars
    {
        public string Name { get; set; }
        private string name { get { return Name; } set { if (value.Length > 20) { this.Name = value.Remove(20); } else this.Name = value; } }

        public double Distance { get; set; }
        private double distance { get { return this.Distance; } set { if (value < 0) { this.Distance = 0; } else this.Distance = value; } }

        private enum classification { hipergigants, ultragigants, freshgigants, gigants, subgigants, dwarfs, subdwarfs, reddwarfs, browndwarfs };
        public string Classific { get; set; }
        private string NumberClassification
        {
            get { return Classific; }
            set
            {
                switch (value)
                {
                    case "1": this.Classific = classification.hipergigants.ToString(); break;
                    case "2": this.Classific = classification.ultragigants.ToString(); break;
                    case "3": this.Classific = classification.freshgigants.ToString(); break;
                    case "4": this.Classific = classification.gigants.ToString(); break;
                    case "5": this.Classific = classification.subgigants.ToString(); break;
                    case "6": this.Classific = classification.dwarfs.ToString(); break;
                    case "7": this.Classific = classification.subdwarfs.ToString(); break;
                    case "8": this.Classific = classification.reddwarfs.ToString(); break;
                    case "9": this.Classific = classification.browndwarfs.ToString(); break;
                    default: this.Classific = "Nope"; break;
                }
            }
        }

        public double Mass { get; set; }
        private double mass { get { return Mass; } set { if (value < 0) this.Mass = 0; else this.Mass = value; } }

        public string Constellation { get; set; }
        private string constellation { get { return Constellation; } set { if (value.Length > 30) this.Constellation = value.Remove(30); else this.Constellation = value; } }

        public Stars(string name, double distance, string clasification, double mass, string constellation)
        {
            this.name = name;
            this.distance = distance;
            this.NumberClassification = clasification;
            this.mass = mass;
            this.constellation = constellation;
        }


    }
}
