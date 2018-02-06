using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    class JSONPriceListSerializer : IPriceListSerialize
    {
        public List<Storage> Load()
        {
            return new List<Storage>();
        }

        public void Save(List<Storage> list)
        {
            throw new NotImplementedException();
        }
    }
}
