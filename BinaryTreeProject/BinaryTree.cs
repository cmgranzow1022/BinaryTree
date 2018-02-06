using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class BinaryTree 
    {
        Node root;
        int value;
        Node currentNode;
        Node node;
        string userInput;
        string nodeValue;
        string num;

        
        public BinaryTree()
        {

        }


        public void Add(int value)
        {
            Console.WriteLine("What value do you want to add to the Binary Tree?");
            userInput = Console.ReadLine();
            

            value = Int32.Parse(userInput);

            node = new Node(value);
            if (root == null)                           
            {
                root = node;
                BinaryTreeProject();
            }
            Node currentNode = root;
            while (currentNode != null)
            {
                int compareNewChildValue = CompareValues();
                if (compareNewChildValue < 0)
                {
                    currentNode = currentNode.LeftChild;
                }

                else if (compareNewChildValue > 0)
                {
                    currentNode = currentNode.RightChild;
                }
            }
            BinaryTreeProject();
            }
        

        public string BinaryTreeSearch (Node node, int value)
        {
            if (root == null)
            {
                Console.WriteLine("There are no values in the tree. Please add values to the tree before searching.");
                BinaryTreeProject();
            }
            else
            {
                Console.WriteLine("What number do you want to search for?");
                userInput = Console.ReadLine();
                value = Int32.Parse(userInput);
                while (node != null)
                {
                   int compareValue = CompareValues();
                    
                    if (compareValue == 0)
                    {
                        Console.WriteLine("The value you are looking for has been found!");
                        BinaryTreeProject();
                    }
                    else if (compareValue < 0)
                    {

                        Console.WriteLine("Left");
                        node = node.LeftChild;
                    }
                    else if (compareValue > 0)
                    {
                        Console.WriteLine("Right");
                        node = node.RightChild;
                    }
               BinaryTreeProject();
                }
            }
            return ":)";
            Console.ReadLine();
            BinaryTreeProject();
        }


        public void ConvertTwoValues(Node node, int number)
        {
             nodeValue = node.Value.ToString();
             num = number.ToString();
        }

        public int CompareValues()
        {
            ConvertTwoValues(node, value);
            int nodeValueInt = Int32.Parse(nodeValue);
            int numInt = Int32.Parse(num);
            if (nodeValueInt > numInt)
                return 1;
            if (nodeValueInt < numInt)
                return -1;
            else
                return 0;
        }

        public void BinaryTreeProject()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1 to add a number to the binary tree");
            Console.WriteLine("Enter 2 to search through the binary tree for a specific number");
            Console.WriteLine("Enter 0 to quit");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Add(value);
                    break;
                case "2":
                    BinaryTreeSearch(node, value);
                    break;
                default:
                    Console.WriteLine("You have entered an invalid option. Please try again.");
                    BinaryTreeProject();
                    break;
            }
        }
    }
}
