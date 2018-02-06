using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string ManufacturerName { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }

        public Storage() { }

        public Storage(string Name, string ManufacturerName, string Model, int Quantity, Decimal price)
        {
            this.Name = Name;
            this.ManufacturerName = ManufacturerName;
            this.Model = Model;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nManufacturer: " + ManufacturerName + 
                "\nModel: " + Model + "\nQuantity: " + Quantity + "\nPrice: " + Price;
        }

        public virtual void Print(IUserInterface printer)
        {
            printer.Print(ToString());
        }

    }
}
