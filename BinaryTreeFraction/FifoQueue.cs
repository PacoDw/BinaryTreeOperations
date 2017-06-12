using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations
{
    class FifoQueue
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS ATTRIBUTES
        private ListaNodos _lista;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS PROPERTIES
        public int Count { get { return _lista.Count; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public FifoQueue()
        {
            this._lista = new ListaNodos();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD ENQUEUE
        public void Enqueue(Nodo nuevo)
        {
            nuevo.Siguiente = null;
            nuevo.Anterior = null;
            _lista.AddFirst(nuevo);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD PEEK
        public Nodo Peek()
        {
            return _lista.Ultimo;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD DEQUEUE
        public Nodo Dequeue()
        {
            Nodo temp = _lista.Ultimo;

            _lista.RemoveLast();

            return temp;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD CLEAR
        public void Clear()
        {
            _lista.Clear();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD OVERRIDE TO-STRING
        public override string ToString()
        {
            string cadena = string.Empty;

            Nodo temp = _lista.Ultimo;

            while (temp != null)
            {
                cadena += temp.Valor + Environment.NewLine;
                temp = temp.Anterior;
            }
            return cadena;
        }

    }
}
