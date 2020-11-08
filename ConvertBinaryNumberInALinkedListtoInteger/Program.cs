using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBinaryNumberInALinkedListtoInteger
{
    class Program
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node(int data)
            {
                val = data;
                next = null;
            }
        }

        public class LinkedList
        {
            Node root;

            public LinkedList()
            {
                root = null;
            }

            public void insertElement(int data)
            {
                Node newNode = new Node(data);
                if(this.root !=null)
                {
                    newNode.next = root;
                }
                this.root = newNode;
            }

           

            public void show()
            {
                ShowList(root);
            }

            private void ShowList(Node root)
            {
                while(root !=null)
                {
                    Console.Write(root.val + " ");
                    root = root.next;
                }
            }

            
           //reverse list and multiply with 2th power and add in variable
           
            public void Reverse_List()
            {
                root = reverse(root);
            }
            public Node reverse(Node root)
            {
                if (root == null || root.next == null)
                    return root;
                Node newnode = reverse(root.next);
                root.next.next = root;
                root.next = null;

                return newnode;
            }

            //Reverse at specific position
            public void Reverse_ListSpecificPosition(int k)
            {
                root = reverse_SpecificPosition(root,k);
            }
            public Node reverse_SpecificPosition(Node root,int k)
            {
                if (root == null || root.next == null || k == 0)
                    return root;
                else
                {
                    k--;
                    Node newnode = reverse_SpecificPosition(root.next, k--);
                    root.next.next = root;
                    root.next = null;
                    return newnode;
                }
            }



            //public int func()
            //{
            //    return func_pro(Node);
            //}
        }
        static void Main(string[] args)
        {
            LinkedList ls = new LinkedList();
            ls.insertElement(1);
            ls.insertElement(2);
            ls.insertElement(3);
            ls.insertElement(4);
            ls.insertElement(5);
            ls.insertElement(6);
            ls.insertElement(7);
            ls.insertElement(8);
            ls.insertElement(9);
            ls.show();

            Console.ReadLine();
            ls.Reverse_ListSpecificPosition(3);
            ls.show();
            Console.ReadLine();
            //Input: head = [1, 0, 1]
            //Output: 5
            //Explanation: (101) in base 2 = (5) in base 10
        }
    }
}
