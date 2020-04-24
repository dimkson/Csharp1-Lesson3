using System;
using MenuLib;
using FC = MenuLib.FastConsole;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenu = new Menu.delMenu[] { Task01 };
            Menu menu = new Menu(delMenu);
        }
        #region Задание1
        static void Task01()
        {

        }
        #endregion
    }
}
