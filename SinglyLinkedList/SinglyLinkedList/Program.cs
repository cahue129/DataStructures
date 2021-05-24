using System;

namespace SinglyLinkedList
{
    public class Node {
        public string data;
        public Node next;

        public Node() {
            this.data = null;
            this.next = null;
        }

        public Node(string data) {
            this.data = data;
            this.next = null;
        }

    }

    public class List {
        public Node head;
        int count;

        public List() {
            this.head = null;
        }

        public void AddNodeToFront(string data) {
            Node newNode = new Node(data);
            newNode.next = head; //
            head = newNode;
            count++;
        }

        public void AddNodeToEnd(string data) {
            Node newNode = new Node(data);
            Node runner = new Node();
            runner = head;
            while (runner!=null) {
                if (runner.next==null) {
                    runner.next = newNode;
                    break;
                }

                runner = runner.next;
            }
        }
        //delete front
        public void DeleteFromFront() {
            Node tmp = new Node();
            tmp = head;
            head = head.next;
            Delete(tmp);
        }
        //find and delete node
        public void FindAndDelete(String data) {
            Node runner = new Node();
            Node trailer = new Node();
            runner = head;
            trailer = head;
            while (runner != null) {
                if (runner.data == data) {
                    trailer.next = runner.next;
                    Delete(runner);
                    break;
                }
                trailer = runner;
                runner = runner.next;
            }

        }
        //Delete from end
        public void DeleteFromEnd() {
            Node runner = new Node();
            Node trailer = new Node();
            runner = head;
            trailer = head;
            while (runner != null) {
                if (runner.next==null) {
                    trailer.next = null;
                    Delete(runner);
                    break;
                }
                trailer = runner;
                runner = runner.next;
            }
        }


        public void Print() {
            Node runner = new Node();
            runner = head;

            while (runner != null) {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }

        public void Delete(Node tmp) {
            tmp = null;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();

            Console.WriteLine();
            myList.AddNodeToFront("0");
            myList.AddNodeToFront("1");
            myList.AddNodeToFront("2");
            myList.AddNodeToFront("3");
            myList.AddNodeToFront("5");
            myList.Print();
            Console.WriteLine();
            myList.DeleteFromEnd();
            myList.Print();
            Console.WriteLine();
            


        }
    }
}
