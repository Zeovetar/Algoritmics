using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new ChangeTree();
            tree.AddItem(10);
            tree.AddItem(7);
            tree.AddItem(11);
            tree.AddItem(9);
            var strRoot = tree.GetRoot();
            Console.WriteLine(strRoot.Value);
            var searchNode = tree.GetNodeByValue(8);
            try
            {
                Console.WriteLine($"Value: {searchNode.Value}, LeftChild: {searchNode.LeftChild}, RightChild: {searchNode.RightChild}");
            }
            catch (NullReferenceException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            tree.PrintTree();
        }
    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node == null)
                return false;

            return node.Value == Value;
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }

    public interface ITree
    {
        TreeNode GetRoot();
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
    }

    public class ChangeTree : ITree
    {
        private TreeNode root;
        private int depth = 0;
        public void AddItem(int value)
        {
            if (root == null)
                root = new TreeNode { Value = value };
            else
            {
                var tempNode = root;
                do
                {
                    if (value < tempNode.Value)
                    {
                        if (tempNode.LeftChild != null)
                        {
                            tempNode = tempNode.LeftChild;
                            depth++;
                        }
                        else
                        {
                            tempNode.LeftChild = new TreeNode { Value = value };
                        }
                    }
                    if (value > tempNode.Value)
                    {
                        if (tempNode.RightChild != null)
                        {
                            tempNode = tempNode.RightChild;
                            depth++;
                        }
                        else
                        {
                            tempNode.RightChild = new TreeNode { Value = value };
                        }
                    }
                } while (tempNode.LeftChild != null || tempNode.RightChild != null);
            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            var tempNode = root;
            do
            {
                if (value == tempNode.Value)
                    return tempNode;

                if (value < tempNode.Value)
                {
                    if (tempNode.LeftChild != null)
                    {
                        if (value == tempNode.LeftChild.Value)
                            return tempNode.LeftChild;
                        else
                        {
                            tempNode = tempNode.LeftChild;
                        }
                    }
                    
                }
                if (value > tempNode.Value)
                {
                    if (tempNode.RightChild != null)
                    {
                        if (value == tempNode.RightChild.Value)
                            return tempNode.RightChild;
                        else
                        {
                            tempNode = tempNode.RightChild;
                        }
                    }
                    
                }
            } while (tempNode.LeftChild != null || tempNode.RightChild != null);
            return null;
        }

        public TreeNode GetRoot()
        {
            return root;
        }

        public void PrintTree()
        {
            if (root != null)
            {
                printRecursive(root);
            }
        }

        public void printRecursive(TreeNode root)
        {
            Console.WriteLine("", root.Value);
            printRecursive(root.LeftChild);
            printRecursive(root.RightChild);
        }

        public void RemoveItem(int value)
        {
            var tempNode = root;
            if (value == root.Value)
            {
                root.LeftChild = null;
                root.RightChild = null;
                Console.WriteLine("Tree was elliminated successfull!");
            }
/*            else 
            {
                do
                {
                    if (value == tempNode.Value && tempNode)
                    {
                        
                    }
                } while (tempNode.LeftChild != null || tempNode.RightChild != null);
            }*/
        }
    }

    public static class TreeHelper
    {
        public static NodeInfo[] GetTreeInLine(ITree tree)
        {
            var bufer = new Queue<NodeInfo>();
            var returnArray = new List<NodeInfo>();
            var root = new NodeInfo() { Node = tree.GetRoot() };
            bufer.Enqueue(root);

            while (bufer.Count != 0)
            {
                var element = bufer.Dequeue();
                returnArray.Add(element);

                var depth = element.Depth + 1;

                if (element.Node.LeftChild != null)
                {
                    var left = new NodeInfo()
                    {
                        Node = element.Node.LeftChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(left);
                }
                if (element.Node.RightChild != null)
                {
                    var right = new NodeInfo()
                    {
                        Node = element.Node.RightChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(right);
                }
            }

            return returnArray.ToArray();
        }
    }

    public class NodeInfo
    {
        public int Depth { get; set; }
        public TreeNode Node { get; set; }
    }
}
