using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class NodeManager : INode
    {
        public NodeManager()
        {
            IndexNodes();
        }

        public List<Node> myNodes = new List<Node>();

        public void DebugWriteOutChildren()
        {
            foreach (Node n in myNodes)
            {
                Console.Write("(" + n.id + ")" + n.nodeName);
                if (n.parent != null)
                {
                    Console.Write(" is child of: " + n.parent.nodeName + "\n");
                }
                if (n.parent == null)
                {
                    Console.Write(" is base.\n");
                }
            }
        }

        public void DebugAskIfAddNode()
        {
            int parentIDToInt;
            string nameOfNodeToAdd;
            Console.WriteLine("ADD NODE");
            Console.WriteLine("Type the ID number of the parent node");
            string parentID = Console.ReadLine();//get a string input

            try//try to convert my input to an int
            {
                Convert.ToInt32(parentID);//try it
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a valid ID. Please type a number that lines up with a node");
                DebugAskIfAddNode();
            }

            parentIDToInt = Convert.ToInt32(parentID);//asssign it
            bool idMatch = false;

            foreach (Node n in myNodes)//make sure the number exists
            {
                if (Convert.ToInt32(parentID) == n.id)//check if you actually inputted an id that works
                {
                    idMatch = true;
                }
            }

            if (idMatch == false)
            {
                Console.WriteLine("That is not a valid ID. Please type a number that lines up with a node");
                DebugAskIfAddNode();//ask again if the motherfucker typed in the wrong shit
            }

            int depthOfNodeToAdd = myNodes[parentIDToInt].depth + 1;

            Console.WriteLine("Type the name of the node");
            nameOfNodeToAdd = Console.ReadLine();

            AddNode(new Node(nameOfNodeToAdd, myNodes[parentIDToInt], depthOfNodeToAdd), parentIDToInt);
        }

        public void AskIfRemoveNode()
        {
            string indexInput;
            int indexToRemove;
            Console.Write("REMOVE NODE");
            Console.WriteLine("Type the ID of the node that you want to remove");
            indexInput = Console.ReadLine();
            try//try to convert my input to an int
            {
                Convert.ToInt32(indexInput);//try it
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a valid ID. Please type a number that lines up with a node");
                AskIfRemoveNode();
            }
            indexToRemove = Convert.ToInt32(indexInput);
            RemoveNode(indexToRemove);
        }

        public void DebugAskIfGetNode()
        {
            string indexInput;
            int indexToGet;
            Console.WriteLine("GET NODE");
            Console.WriteLine("Please type the ID of the node branch you want to get");
            indexInput = Console.ReadLine();
            try
            {
                Convert.ToInt32(indexInput);
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a valid ID. Please type a number that lines up with a node");
                DebugAskIfGetNode();
            }
            indexToGet = Convert.ToInt32(indexInput);
            GetNode(indexToGet);
        }


        public void AddNode(Node nodeToAdd, int index)
        {
            myNodes.Insert(index + 1, nodeToAdd);
            IndexNodes();//re-index after adding
        }

        public void RemoveNode(int indexOfNode)
        {
            myNodes.RemoveAt(indexOfNode);
            IndexNodes();
        }


        public void GetNode(int index)
        {
            string parentName;
            Node currentNode = myNodes[index];//this is the node we start looking at
            if (currentNode.directChildren != null)//as long as the node we're looking at has a direct child, we're gonna get that node and then call it again for its child
            {
                try
                {
                    parentName = currentNode.parent.nodeName;
                }
                catch (Exception)
                {
                    parentName = "No parent";
                }

                Console.WriteLine("node: " + currentNode.nodeName + " index: " + currentNode.id + " parent: " + parentName + " depth: " + currentNode.depth);//this is the gotten node. We write it's info
                foreach (Node n in currentNode.directChildren)//for every direct child that node has, we're gonna get it
                {
                    Console.WriteLine("NODE CHILDREN: ");
                    GetNode(n.id);
                }
            }
            IndexNodes();
        }

        public void IndexNodes()
        {
            int temp = 0;
            foreach (Node n in myNodes)
            {
                n.id = temp;
                temp++;
            }
        }

        public void MoveNode(int nodeId, int parentID)//supposed to move all the children
        {
            throw new NotImplementedException();
        }
        public void FindNode(int nodeId)
        {
            throw new NotImplementedException();
        }

    }
}
