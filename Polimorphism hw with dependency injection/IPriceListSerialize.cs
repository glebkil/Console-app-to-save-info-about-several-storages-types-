using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    interface IPriceListSerialize
    {
        void Save(List<Storage> list);
        List<Storage> Load();
    }
}
