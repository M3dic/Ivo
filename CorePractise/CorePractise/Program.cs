using System;
using System.Collections.Generic;

namespace CorePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stars[] stars = new Stars[2000];
            Stars s = new Stars("IvoRadev", 500.5848);
            Stars s1 = new Stars("IvoIvanovRadev14July2001.", -500);
            s.Print();
            s1.Print();
        }
    }
    public class Stars
    {
        private string name { get; set; }
        public string Name { get { return name; } set { if (value.Length > 20) { this.name = value.Remove(20); } else this.name = value; } }
        private double distance { get; set; }
        public double Distance { get { return this.distance; } set { if (value < 0) { this.distance = 0; } else this.distance = value; } }
        public enum classification { hipergigants, ultragigants, freshgigants, gigants, subgigants, dwarfs, subdwarfs, reddwarfs, browndwarfs };
        private string Classific { get; set; }
        private string NUmberClassification
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
                    default:
                        break;
                }
            }
        }

        public Stars(string name, double dis)
        {
            this.Name = name;
            this.Distance = dis;
        }
        public void Print()
        {
            Console.WriteLine(this.name + " " + this.distance);
        }

    }
}
