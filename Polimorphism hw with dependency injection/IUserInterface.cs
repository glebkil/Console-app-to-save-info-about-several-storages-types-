using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    public interface IUserInterface
    {
        void SetUpMainMenu();
        void Print(string s);
    }
}
