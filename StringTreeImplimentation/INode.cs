using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    interface INode
    {
        void MoveNode(string nodeId, string parentID);//supposed to move all the children
        void FindNode(string nodeId);
    }
}
