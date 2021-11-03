﻿using System;

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
            }
            else
            {
                first = new Node { Value = value };
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            
        }

        public void RemoveNode(int index)
        {
            
        }

        public void RemoveNode(Node node)
        {
            
        }

        public Node FindNode(int searchValue)
        {
            return null;
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
        }
    }
}