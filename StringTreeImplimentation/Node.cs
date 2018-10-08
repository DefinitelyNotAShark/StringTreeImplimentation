using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class Node
    {
        public string nodeName;
        public Node parent;
        public int numOfSpaces;//if an object has a parent, you find out the num of spaces of the parent and then add 1 to make child.

        public List<Node> children = new List<Node>();//maybe we'll use this maybe not

        public Node(string name, Node nodeParent, int spaces)//name is the text//if there is no parent, pass in itself
        {
            parent = nodeParent;
            nodeName = name;//name is the string that defines it
            numOfSpaces = spaces;
        }

        public Node(string name, int spaces)//call this if it's a base
        {
            nodeName = name;
            numOfSpaces = spaces;
        }
    }
}
   

