using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;
        
        public Node(int value)
        {
            leftChild = null;
            rightChild = null;
            value = 0;
        }

        public virtual int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public Node LeftChild
        {
            get
            {
                return leftChild;
            }
            set
            {
                leftChild = value;
            }
        }

        public Node RightChild
        {
            get
            {
                return rightChild;
            }
            set
            {
                rightChild = value;
            }
        }


    }
}
