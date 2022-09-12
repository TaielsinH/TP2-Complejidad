using System;

namespace tp2
{
    class Program
    {
        static void Main (string[] args)
        {
            ArbolGeneral<int> a1 = new ArbolGeneral<int>(1);
            ArbolGeneral<int> b1 = new ArbolGeneral<int>(2);
            ArbolGeneral<int> b2 = new ArbolGeneral<int>(3);
            ArbolGeneral<int> c1 = new ArbolGeneral<int>(4);
            ArbolGeneral<int> c2 = new ArbolGeneral<int>(5);
            ArbolGeneral<int> d1 = new ArbolGeneral<int>(6);

            a1.agregarHijo(b1);
            a1.agregarHijo(b2);
            b2.agregarHijo(c1);
            b2.agregarHijo(c2);
            c2.agregarHijo(d1);

            Console.WriteLine(a1.altura());
        }
    }
}