﻿/*
 Разработать приложение, которое формирует список носителей информации, 
 таких как, Flash-память, DVD - диск, съемный HDD. 
 Каждый носитель информации является объектом соответствующего класса:
- класс Flash - память;
- класс DVD - диск;
- класс съемный HDD.
Все три класса являются производными от абстрактного класса «Носитель информации».
Базовый класс содержит следующие поля: наименование носителя, имя производителя,
модель, количество, цена. Класс обладает всеми необходимыми свойствами для доступа к полям, 
а также виртуальными методами печати, загрузки из файла и сохранения в файл. 
В производных классах переопределяются методы печати, загрузки и сохранения. 
Кроме того, каждый из производных классов дополняется следующими полями:
- класс Flash-память: объем памяти, скорость USB;
- класс съемный HDD: размер диска, скорость USB;
- класс DVD - диск: скорость чтения и скорость записи.
Работа с объектами соответствующих классов производится через ссылки на базовый класс, которые хранятся в списке.
Приложение должно предоставлять следующие возможности:
добавление носителя информации в список;
удаление носителя информации из списка по заданному критерию;
печать списка;
изменение определённых параметров носителя информации;
поиск носителя информации по заданному критерию;
считывание данных из файла и запись данных в файл.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Instance.UI = new ConsoleUI();
            Application.Instance.Serializer = new XMLPriceListSerializer();
            Application.Instance.Run();
        }
    }
}
