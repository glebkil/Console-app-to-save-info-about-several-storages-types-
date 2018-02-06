using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    class PriceList
    {
        private static PriceList instance;
        private List<Storage> list = new List<Storage>();

        private PriceList(){}

        public static PriceList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PriceList();
                }
                return instance;
            }
        }

        public void Add(Storage item)
        {
            list.Add(item);
        }

        ///<exception cref="System.Collections.Generic.KeyNotFoundException">Trown when key not found</exception>
        public void Drop(string name)
        {           
            list.Remove(FindByName(name));
        }

        public int Print(IUserInterface printer)
        {            
            foreach(Storage item in list)
            {
                item.Print(printer);
            }
            return list.Count;
        }

        ///<exception cref="System.Collections.Generic.KeyNotFoundException">Trown when key not found</exception>
        public Storage FindByName(string name){
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Name.ToUpper().IndexOf(name.ToUpper()) != -1)
                {
                    return list[i];
                }
            }
            throw new KeyNotFoundException();
        }
        
        public void Save(IPriceListSerialize serializer)
        {
            serializer.Save(list);
        }
        public void Load(IPriceListSerialize serializer)
        {
            list = serializer.Load();
        }
    }
}