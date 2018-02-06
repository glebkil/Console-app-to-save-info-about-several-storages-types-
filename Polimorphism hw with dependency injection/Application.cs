using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    class Application
    {
        private static Application instance;
        public IUserInterface UI { get; set; }
        public IPriceListSerialize Serializer { get; set; }
        public PriceList PriceList { get; private set; }

        private Application()
        {
            PriceList = PriceList.Instance;
            UI = new ConsoleUI();
            Serializer = new JSONPriceListSerializer();
        }

        public static Application Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Application();
                }
                return instance;
            }
        }

        public void Run()
        {
            PriceList.Load(Serializer);
            UI.SetUpMainMenu();
            PriceList.Save(Serializer);
        }
    }
}
