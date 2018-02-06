using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    public class FlashCard : Storage
    {
        public int CapacityInMb { get; set; }
        public int SpeedInMbPerSec { get; set; }

        public FlashCard() : base() { }

        public FlashCard(string Name, string ManufacturerName, string Model, int Quantity, 
            Decimal price, int CapacityInMb, int SpeedInMbPerSec) :
            base(Name, ManufacturerName, Model, Quantity, price)
        {
            this.CapacityInMb = CapacityInMb;
            this.SpeedInMbPerSec = SpeedInMbPerSec;
        }

        public override string ToString()
        {
            return "\nFlash card description:\n" + base.ToString() + "\nCapscity is " + CapacityInMb +
                "Mb\nSpeed is " + SpeedInMbPerSec + "Mb/s\n";
        }
    }
}
