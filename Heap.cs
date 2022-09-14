using System;
using System.Collections;

namespace tp2
{
    public class Heap
    {
        private int[] dato;
        private bool tipoHeap; //true si es maxHeap, false si es minHeap

        public Heap(int[]lista, bool tipoHeap)
        {
            dato = lista;
            this.tipoHeap = tipoHeap;
           
        }
        private void filtradoAbajo()
        {
            for (int i = 0; i< this.dato.Length -1; i++)
            {
                if (this.dato[i] > this.dato[2*i]);
            }
        }
        
    }
}