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
            menu.ChooseMenu();
        }
        #region Задание1
        static void Task01()
        {
            Complex complex1;
            complex1.im = 1;
            complex1.re = 1;
            Complex complex2;
            complex2.im = 2;
            complex2.re = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            FC.Pause();
        }
        struct Complex
        {
            public double im;
            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = im * x.im + re * x.im;
                y.re = re * x.im + im * x.re;
                return y;
            }
            public override string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        #endregion
    }
}
