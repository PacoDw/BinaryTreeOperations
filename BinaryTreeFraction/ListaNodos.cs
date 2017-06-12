using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations
{
    class ListaNodos
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS PROPERTIES
        private Nodo _inicio;
        public Nodo Inicio { get { return _inicio; } }

        private Nodo _ultimo;
        public Nodo Ultimo { get { return _ultimo; } }

        private int _count;
        public int Count { get { return _count; } set { _count = value; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public ListaNodos()
        {
            this._inicio = null;
            this._ultimo = null;
            this._count = 0;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD ADD-FIRST
        public void AddFirst(Nodo nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                _ultimo = nuevo;
            }
            else
            {
                _inicio.Anterior = nuevo;
                nuevo.Siguiente = _inicio;
                _inicio = nuevo;
            }
            _count++;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD ADD-LAST
        public void AddLast(Nodo nuevo)
        {
            if (_inicio == null)
                _inicio = nuevo;
            else
            {
                _ultimo.Siguiente = nuevo;
                nuevo.Anterior = _ultimo;
            }
            _ultimo = nuevo;
            _count++;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD REMOVE-LAST
        public void RemoveLast()
        {
            if (_inicio != null)
            {
                if (_ultimo == _inicio)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo.Anterior.Siguiente = null;
                    _ultimo = _ultimo.Anterior;
                }
                _count--;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD CLEAR
        public void Clear()
        {
            if (_inicio != null)
            {
                _inicio = null;
                _ultimo = null;
            }
        }
    }
}
