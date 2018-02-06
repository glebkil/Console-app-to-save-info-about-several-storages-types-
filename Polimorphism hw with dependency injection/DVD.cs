using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    public class DVD : Storage
    {
        public int ReadingSpeedInMbPerSec { get; set; }
        public int WritingSpeedInMbPerSec { get; set; }

        public DVD() : base() { }

        public DVD(string Name, string ManufacturerName, string Model, int Quantity,
            Decimal price, int ReadingSpeedInMbPerSec, int WritingSpeedInMbPerSec) :
            base(Name, ManufacturerName, Model, Quantity, price)
        {
            this.ReadingSpeedInMbPerSec = ReadingSpeedInMbPerSec;
            this.WritingSpeedInMbPerSec = WritingSpeedInMbPerSec;
        }

        public override string ToString()
        {
            return "\nDVD description:\n" + base.ToString() + "\nReading speed is " + ReadingSpeedInMbPerSec + 
                "Mb/S\nWriting speed is " + WritingSpeedInMbPerSec + "Mb/s\n";
        }
    }
}
