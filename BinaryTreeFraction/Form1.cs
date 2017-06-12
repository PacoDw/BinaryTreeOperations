using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeOperations
{
    public partial class FormMain : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS ATTRIBUTES
        ListaNodos Linkedlista = new ListaNodos();
        BinaryTree binaryTree;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public FormMain()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //EVENT KEYPRESS
        private void txtFraction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter && (e.KeyChar == 42 || e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar == 47 || char.IsNumber(e.KeyChar)))
            {
                Nodo nuevo = new Nodo(e.KeyChar.ToString());
                Linkedlista.AddLast(nuevo);
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (Linkedlista.Count != 0)
                    {
                        bttonEvaluar.PerformClick();
                        bttonEvaluar.Focus();
                    }
                }
                else if (e.KeyChar == 8)
                    Linkedlista.RemoveLast();
                else
                    e.Handled = true;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON EVALUAR-CLICK
        private void bttonEvaluar_Click(object sender, EventArgs e)
        {
            binaryTree = new BinaryTree(Linkedlista);
            Linkedlista.Clear();

            txtInOrder.Text = binaryTree.InOrder();

            txtPreOrder.Text = binaryTree.PreOrder();
            txtMostrarPila.Text = binaryTree.ToStringStack();
            txtResPreOrder.Text = Convert.ToString(binaryTree.CalculoPreOrder());

            txtPostOrder.Text = binaryTree.PostOrder();
            txtMostrarCola.Text = binaryTree.ToStringQueue();
            txtResPostOrder.Text = Convert.ToString(binaryTree.CalculoPostOrder());
        }

        private void bttonReset_Click(object sender, EventArgs e)
        {
            txtFraction.Text = string.Empty;
            txtInOrder.Text = string.Empty;
            txtPreOrder.Text = string.Empty;
            txtPostOrder.Text = string.Empty;
            txtResPostOrder.Text = string.Empty;
            txtResPreOrder.Text = string.Empty;
            txtMostrarCola.Text = string.Empty;
            txtMostrarPila.Text = string.Empty;
        }
    }
}
