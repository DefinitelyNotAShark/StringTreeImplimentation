using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    interface INode
    {
        void MoveNode(int nodeId, int parentID);//supposed to move all the children
        void FindNode(int nodeId);
        void GetNode(int index);
        void AddNode(Node nodeToAdd, int index); ////enforce unique on add
        void RemoveNode(int indexOfNode);
        //FindNode(content id); // might return list of matches
    }
}
