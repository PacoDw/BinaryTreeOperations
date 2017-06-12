using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations
{
    class BinaryTree
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS ATTRIBUTES
        private Nodo _raiz;
        private ListaNodos _listaEnlazada;
        private LifoStack _pila;
        private FifoQueue _cola;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS PROPERTIES
        private int _count;
        public int Count { get { return _count; } }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public BinaryTree(ListaNodos listaEnlazada)
        {
            this._listaEnlazada = listaEnlazada;
            this._raiz = null;
            this._count = _listaEnlazada.Count;
            this._pila = new LifoStack();
            this._cola = new FifoQueue();
            ToBinaryTree();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - CONVERT FROM LINKED LIST TO BINARY TREE
        private void ToBinaryTree()
        {
            if (_listaEnlazada.Count != 0)
            {
                ToBinaryTree(_listaEnlazada.Inicio, "*", "/");
                ToBinaryTree(_listaEnlazada.Inicio, "+", "-");
            }
        }
        private void ToBinaryTree(Nodo temp, string c1, string c2)
        {
            if (temp != null)
            {
                _raiz = temp;
                if (_raiz.Valor.Equals(c1) || _raiz.Valor.Equals(c2))
                {
                    _raiz.Hleft = _raiz.Anterior;
                    _raiz.Anterior = _raiz.Hleft.Anterior;

                    if (_raiz.Anterior != null)
                        _raiz.Anterior.Siguiente = _raiz;

                    _raiz.Hright = _raiz.Siguiente;
                    _raiz.Siguiente = _raiz.Hright.Siguiente;

                    _raiz.Hright.Siguiente = null;
                    _raiz.Hright.Anterior = null;

                    if (_raiz.Siguiente != null)
                        _raiz.Siguiente.Anterior = _raiz;
                }
                ToBinaryTree(temp.Siguiente, c1, c2);
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - IN-ORDER
        public string InOrder()
        {
            if (_raiz != null)
                return InOrder(_raiz);

            return string.Empty;
        }
        private string InOrder(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                if (raiz.Hleft != null)
                    res += InOrder(raiz.Hleft);

                res += raiz.ToString();

                if (raiz.Hright != null)
                    res += InOrder(raiz.Hright);
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - PRE-ORDER
        public string PreOrder()
        {
            _pila.Clear();

            if (_raiz != null)
                return PreOrden(_raiz);

            return string.Empty;
        }
        private string PreOrden(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                res += raiz.ToString();
                _pila.Push(raiz);


                if (raiz.Hleft != null)
                    res += PreOrden(raiz.Hleft);

                if (raiz.Hright != null)
                    res += PreOrden(raiz.Hright);
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - CALCULO PRE-ORDER
        public double CalculoPreOrder()
        {
            LifoStack auxPila = new LifoStack();

            return Convert.ToDouble(CalculoPreOrder(_pila, auxPila).Valor);
        }
        private Nodo CalculoPreOrder(LifoStack pila, LifoStack auxPila)
        {
            Nodo temp = new Nodo("");
            double num1 = 0;
            double num2 = 0;

            if (pila.Peek() != null)
            {
                if (char.IsNumber(Convert.ToChar(pila.Peek().Valor)))
                {
                    auxPila.Push(pila.Pop());

                    temp = CalculoPreOrder(pila, auxPila);
                }
                else
                {
                    num1 = Convert.ToDouble(auxPila.Pop().Valor.ToString());
                    num2 = Convert.ToDouble(auxPila.Pop().Valor.ToString());

                    if (pila.Peek().Valor.Equals("+"))
                        temp.Valor = Convert.ToString(num1 + num2);
                    else if (pila.Peek().Valor.Equals("-"))
                        temp.Valor = Convert.ToString(num1 - num2);
                    else if (pila.Peek().Valor.Equals("*"))
                        temp.Valor = Convert.ToString(num1 * num2);
                    else if (pila.Peek().Valor.Equals("/"))
                        temp.Valor = Convert.ToString(num1 / num2);

                    pila.Pop();
                    auxPila.Push(temp);

                    if (pila.Peek() != null)
                        temp = CalculoPreOrder(pila, auxPila);
                    else
                        temp = auxPila.Pop();
                }
            }
            return temp;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - POST-ORDER
        public string PostOrder()
        {
            _cola.Clear();

            if (_raiz != null)
                return PostOrden(_raiz);

            CalculoPostOrder();

            return string.Empty;
        }
        private string PostOrden(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                if (raiz.Hleft != null)
                    res += PostOrden(raiz.Hleft);

                if (raiz.Hright != null)
                    res += PostOrden(raiz.Hright);

                res += raiz.ToString();
                _cola.Enqueue(raiz);
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - CALCULO POST-ORDER
        public double CalculoPostOrder()
        {
            LifoStack auxCola = new LifoStack();

            return Convert.ToDouble(CalculoPostOrder(_cola, auxCola).Valor);
        }
        private Nodo CalculoPostOrder(FifoQueue cola, LifoStack auxCola)
        {
            Nodo temp = new Nodo("");
            double num1 = 0;
            double num2 = 0;

            if (cola.Peek() != null)
            {
                if (char.IsNumber(Convert.ToChar(cola.Peek().Valor)))
                {
                    auxCola.Push(cola.Dequeue());

                    temp = CalculoPostOrder(cola, auxCola);
                }
                else
                {
                    num1 = Convert.ToDouble(auxCola.Pop().Valor.ToString());
                    num2 = Convert.ToDouble(auxCola.Pop().Valor.ToString());

                    if (cola.Peek().Valor.Equals("+"))
                        temp.Valor = Convert.ToString(num2 + num1);
                    else if (cola.Peek().Valor.Equals("-"))
                        temp.Valor = Convert.ToString(num2 - num1);
                    else if (cola.Peek().Valor.Equals("*"))
                        temp.Valor = Convert.ToString(num2 * num1);
                    else if (cola.Peek().Valor.Equals("/"))
                        temp.Valor = Convert.ToString(num2 / num1);

                    cola.Dequeue();
                    auxCola.Push(temp);

                    if (cola.Peek() != null)
                        temp = CalculoPostOrder(cola, auxCola);
                    else
                        temp = auxCola.Pop();
                }
            }
            return temp;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - TO STRING STACK
        public string ToStringStack()
        {
            return _pila.ToString();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //MEHTOD - TO STRING QUEUE
        public string ToStringQueue()
        {
            return _cola.ToString();
        }
    }
}
