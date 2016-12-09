using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binerytree
{

    class binaryTree
    {
         
        Node root; 

        public binaryTree()
        {
            this.root = null;
        }

        public binaryTree(int data)
        {
            this.root = new Node(data);
        }

        public Node Root()
        {
            return this.root;
        }

        public Node AddInOrder(Node root, int value)
        {
            if (!isEmpty())
            {
                Node newNode = new Node(value);
                root = newNode;
                root.lNode = null;
                root.rNode = null;
            }
            else 
            { 
                if(value < root.data)
                {
                    root.lNode = AddInOrder(root.lNode, value);
                }

                if (value > root.data)
                {
                    root.rNode = AddInOrder(root.rNode, value);
                }    
            }
            return root;
        }

        public int search(Node root, int key)
        {
            try
            {
                if (key < root.data)
                {
                    return search(root.lNode, key);
                }
                else if (key > root.data)
                {
                    return search(root.rNode, key);
                }
                
                return root.data;
            }
            catch (NullReferenceException)
            {
                return -1;
            }
        }

        public void printInOrder(Node root)
        {

            if (root == null)
            {
                Console.WriteLine("root Tree is Empty");
            }
            else
            {
                //print left
                if (root.lNode != null)
                {
                    printInOrder(root.lNode);
                }

                //print node
                Console.Write(root.data + " ");
                
                //print rigth
                if (root.rNode != null)
                {
                    printInOrder(root.rNode);
                }     
            }
        }

        public void printPostOrder(Node root)
        {

            if (root == null)
            {
                Console.WriteLine("root Tree is Empty");
            }
            else
            {
                //print left
                if (root.lNode != null)
                {
                    printPostOrder(root.lNode);
                }

                //print right
                if (root.rNode != null)
                {
                    printPostOrder(root.rNode);
                }
                
                //print Node
                Console.Write(root.data + " ");

            }
        }

        public void printPreOrder(Node root)
        {

            if (root == null)
            {
                Console.WriteLine("root Tree is Empty");
            }
            else
            {
                //print Node
                Console.Write(root.data + " ");
                
                //print Left
                if (root.lNode != null)
                {
                    printPreOrder(root.lNode);
                }

                //print Right
                if (root.rNode != null)
                {
                    printPreOrder(root.rNode);
                }   

            }
        }

        public int findSmallest(Node root)
        {

            if (isEmpty())
            {
                return -1;
            }
            else
            {
                if (root.lNode != null)
                {
                    root = root.lNode;
                    return findSmallest(root);
                }
            }

            return root.data;
        }

        public int findHighest(Node root)
        {
            
            if (isEmpty())
            {
                return -1;
            }
            else
            {
                if (root.rNode != null)
                {
                    root = root.rNode;
                    return findHighest(root);
                }
            }

            return root.data;
        }

        public bool isEmpty()
        {
            return root == null ? true : false;
        }

    }
}
