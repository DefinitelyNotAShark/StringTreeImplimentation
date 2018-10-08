using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class NodeManager
    {
        public List<Node> myNodes = new List<Node>();

        public void AddNode(Node nodeToAdd)
        {
            myNodes.Add(nodeToAdd);               
        }

        public void RemoveNode(Node nodeToRemove)
        {
            myNodes.Remove(nodeToRemove);
        }
    }
}
