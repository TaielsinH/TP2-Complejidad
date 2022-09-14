using System;

namespace tp2
{
    class Program
    {
        static void Main (string[] args)
        {
            
        }
        static void imprimirLista(int[] lista)
        {
            for (int i = 0; i<lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}