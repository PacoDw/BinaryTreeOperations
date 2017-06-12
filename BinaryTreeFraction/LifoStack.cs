using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations
{
    class LifoStack
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS ATTRIBUTES
        private ListaNodos _list;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS PROPERTIES
        public int Count { get { return _list.Count; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public LifoStack()
        {
            this._list = new ListaNodos();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD POP
        public Nodo Pop()
        {
            Nodo temp = _list.Ultimo;

            _list.RemoveLast();

            return temp;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD PEEK
        public Nodo Peek()
        {
            return _list.Ultimo;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD PUSH
        public void Push(Nodo nuevo)
        {
            nuevo.Siguiente = null;
            nuevo.Anterior = null;
            _list.AddLast(nuevo);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD CLEAR
        public void Clear()
        {
            _list.Clear();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD OVERRIDE TO-STRING
        public override string ToString()
        {
            string cadena = string.Empty;

            Nodo temp = this._list.Ultimo;

            while (temp != null)
            {
                cadena += temp.Valor + Environment.NewLine;
                temp = temp.Anterior;
            }
            return cadena;
        }
    }
}
