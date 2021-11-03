using System;

namespace lesson2
{

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

    public class MyLinkedList : ILinkedList
    {
        private Node first;
        private Node last;

        public int GetCount()
        {
            int iter = 0;
            var node = first;
            if (node != null)
                while (node.NextNode != null)
                {
                    node = node.NextNode;
                    iter++;
                }
            return iter+1;
        }

        public void AddNode(int value)
        {
            var node = first;
            if (node != null)
            {
                while (node.NextNode != null)
                {
                    node = node.NextNode;
                }
                var newNode = new Node { Value = value };
                node.NextNode = newNode;
                newNode.PrevNode = node;
            }
            else
            {
                first = new Node { Value = value };
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var nextNode = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextNode;
            last = nextNode;
        }

        public void RemoveNode(int index)
        {
            // так как мы храним первый и последний элементы, считаю 1ым элементом не 0 а 1.
            var node = first;
            if (index == 0)
            {
                index = 1;
            }
            if (index == 1)
            {
                node = first.NextNode;
                first.NextNode = null;
                first = node;
            }
            else
            {
                int i = 1;
                while (i < index)
                {
                    node = node.NextNode;
                    i++;
                }
                if (i == index && node.NextNode != null)
                {
                    node.PrevNode.NextNode = node.NextNode;
                    node.NextNode.PrevNode = node.PrevNode;
                }
                else if (i == index && node.NextNode == null)
                {
                    node.PrevNode.NextNode = null;
                }
            }
        }

        public void RemoveNode(Node node)
        {
            
        }

        public Node FindNode(int searchValue)
        {
            return null;
        }

        public void printNode()
        {
            var node = first;
            Console.Write($"{node.Value} -> ");
            while (node.NextNode != null)
            {
                Console.Write($"{node.NextNode.Value} -> ");
                node = node.NextNode;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLinkedList ListNew = new MyLinkedList();
            ListNew.AddNode(5);
            ListNew.AddNode(13);
            ListNew.AddNode(6);
            ListNew.AddNode(9);
            ListNew.AddNode(62);
            ListNew.AddNode(36);
            ListNew.printNode();
            ListNew.RemoveNode(2);
            ListNew.printNode();

        }
    }
}
