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

        public void AddNode(Node nodeToAdd, int index)
        {
            myNodes.Insert(index, nodeToAdd);
            IndexNodes();//re-index after adding
        }

        public void RemoveNode(int indexOfNode)
        {
            myNodes.RemoveAt(indexOfNode);
        }

        public void DebugWriteOutChildren()
        {
            foreach (Node n in myNodes)
            {
                Console.Write(n.nodeName + n.id);
                if (n.parent != null)
                {
                    Console.Write(" is child of: " + n.parent.nodeName + "\n");
                }
                if (n.parent == null)
                {
                    Console.Write(" is base.");
                }
            }
        }

        public void DebugAskIfAddNode()
        {
            int parentIDToInt;
            string nameOfNodeToAdd;
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

            AddNode(new Node(nameOfNodeToAdd, myNodes[parentIDToInt] ,depthOfNodeToAdd), parentIDToInt);
        }

        public void AskIfRemoveNode()
        {
            string indexInput;
            int indexToRemove;
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

        public void IndexNodes()
        {
            int temp = 0;
            foreach (Node n in myNodes)
            {
                n.id = temp;
                temp++;
            }
        }

    }
}
