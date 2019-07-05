using System;
using System.Collections.Generic;

namespace CorePractise
{
    class Program
    {
        static void Main(string[] args)
        {
           
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
                    default:  this.Classific = "Nope"; break;
                }
            }
        }

        private double mass { get; set; }
        public double Mass { get { return mass; } set { if (value < 0) this.mass = 0; else this.mass = value; } }

        private string constellation { get; set; }
        public string Constellation { get { return constellation; } set { if (value.Length > 30) this.constellation = value.Remove(30); else this.constellation = value; } }

        public Stars()
        {
           
        }
       

    }
}
