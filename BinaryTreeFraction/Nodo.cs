using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations
{
    class Nodo
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS PROPERTIES
        private string _valor;
        public string Valor { get { return _valor; } set { _valor = value; } }

        private Nodo _hleft;
        public Nodo Hleft { get { return _hleft; } set { _hleft = value; } }

        private Nodo _hright;
        public Nodo Hright { get { return _hright; } set { _hright = value; } }

        private Nodo _siguiente;
        public Nodo Siguiente { get { return _siguiente; } set { _siguiente = value; } }

        private Nodo _anterior;
        public Nodo Anterior { get { return _anterior; } set { _anterior = value; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONTRUCTOR
        public Nodo(string valor)
        {
            this._valor = valor;
            this._hleft = null;
            this._hright = null;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD TO-STRING()
        public override string ToString()
        {
            return Convert.ToString(_valor);
        }
    }
}
