using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    class ConsoleUI : IUserInterface
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
        }

        public void SetUpMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Print all storage devices\n2. Add device\n" +
                 "3. Drop device\n4. Find device by name\n5. Exit");
            Console.WriteLine("\nInput your choice: ");
            switch (GetInt())
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Here are all your devices:");
                    if (PriceList.Instance.Print(Application.Instance.UI) == 0)
                    {
                        Console.WriteLine("No items in the list yet!");
                    }
                    break;
                case 2:
                    PriceList.Instance.Add(GetStorage());
                    break;
                case 3:
                    Console.Clear();
                    if (PriceList.Instance.Print(Application.Instance.UI) == 0)
                    {
                        Console.WriteLine("No items in the list yet!");
                        break;
                    }
                    Console.WriteLine("What device name you wanna drop: ");
                    try
                    {
                        PriceList.Instance.Drop(Console.ReadLine());
                        Console.WriteLine("Congrats, you've deleted the device from list");
                    }
                    catch (KeyNotFoundException e)
                    {
                        Console.WriteLine("Sorry, nothing found!");
                    }
                    
                    break;
                case 4:
                    Console.WriteLine("Input the name of the device you wanna find: ");
                    try
                    {
                        PriceList.Instance.FindByName(Console.ReadLine()).Print(Application.Instance.UI);
                    }catch (KeyNotFoundException e)
                    {
                        Console.WriteLine("Sorry, nothing found!");
                    }
                    break;
                case 5:
                    return;                
                default:
                    SetUpMainMenu();
                    break;
            }
            MenuOrExit();
        }

        private void MenuOrExit()
        {
            Console.WriteLine("\n1. Back to menu\n2. Exit");
            int choice = GetInt();
            if (choice == 1)
            {
                SetUpMainMenu();
            } else if(choice == 2)
            {
                return;
            }
        }

        private int GetInt()
        {
            string str = Console.ReadLine();
            int res;
            try
            {
                res = int.Parse(str);
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid value!");
                return GetInt();
            }
        }

        private Storage GetStorage()
        {
            Console.Clear();
            Console.WriteLine("What kind of storage do you wanna add?");
            Console.WriteLine("\n1. DVD\n2. HDD\n3. Flash Card\n");
            Storage newStorage = null;
            switch (GetInt())
            {
                case 1:
                    newStorage = new DVD();
                    SetStorageBasicData(newStorage);
                    Console.WriteLine("Input reading speed in Mb per second: ");
                    (newStorage as DVD).ReadingSpeedInMbPerSec = GetInt();
                    Console.WriteLine("Input writing speed in Mb per second: ");
                    (newStorage as DVD).WritingSpeedInMbPerSec = GetInt();
                    break;
                case 2:
                    newStorage = new HDD();
                    SetStorageBasicData(newStorage);
                    Console.WriteLine("Input speed in Mb per second: ");
                    (newStorage as HDD).SpeedInMbPerSec= GetInt();
                    Console.WriteLine("Input caapcity in Mb: ");
                    (newStorage as HDD).CapacityInMb = GetInt();
                    break;
                case 3:
                    newStorage = new FlashCard();
                    SetStorageBasicData(newStorage);
                    Console.WriteLine("Input speed in Mb per second: ");
                    (newStorage as FlashCard).SpeedInMbPerSec = GetInt();
                    Console.WriteLine("Input caapcity in Mb: ");
                    (newStorage as FlashCard).CapacityInMb = GetInt();
                    break;
            }
            return newStorage;
        }

        private void SetStorageBasicData( Storage item)
        {
            Console.WriteLine("\nInput name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Input manufacturer name: ");
            item.ManufacturerName = Console.ReadLine();
            Console.WriteLine("Input model: ");
            item.Model = Console.ReadLine();
            Console.WriteLine("Input price: ");
            item.Price = GetInt();
            Console.WriteLine("Input quantity: ");
            item.Quantity = GetInt();
        }

        
    }
}
