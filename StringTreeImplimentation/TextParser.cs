using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringTreeImplimentation
{
    class TextParser
    {
        private string dataFileName;
        private string path;
        private string[] lines;
        private bool isReady;

       

        private List<char> whiteSpaces = new List<char>();
        List<char> temp = new List<char>();

        public void LoadText()//turns text into a string array
        {
            try//this takes the text file and turns it into an array of strings
            {
                dataFileName = "people";
                path = dataFileName + ".txt"; //Path to the folder: " /StringTreeImplimentation/bin/Debug/ "
                lines = System.IO.File.ReadAllLines(path);
            }
            catch (Exception)
            {
                isReady = false;
                throw;
            }

            isReady = true;
        }

        public void CheckCharsForNodes(NodeManager manager)
        {           
            int prev = 0;

            foreach (string s in lines)//cycle through each string
            {
                string nameWithWhiteRemoved = "";
                char[] chars = s.ToCharArray();//turn string into char array
                int next = 0;//next is going to be our index

                while (Char.IsWhiteSpace(chars[next]))//until we hit a non blank space, we're gonna make a list of whitespaces
                {      
                    next++;                 
                }

                for( int i = next; i < chars.Length; i++)//make a new string to use for name
                {
                    nameWithWhiteRemoved += chars[i].ToString();
                }
                
                if(next == 0)//this is a base
                {
                    Node myNode = new Node(nameWithWhiteRemoved, 0);//this is a base, so we call the constructor that needs no parent
                    manager.AddNode(myNode);//this adds our node to a list of nodes
                }

                else if (next > prev)//this node is a child of the previous node
                { 
                    Node myNode = new Node(nameWithWhiteRemoved, manager.myNodes[manager.myNodes.Count - 1], next);//last node added is parent
                    manager.AddNode(myNode);
                }

                else if (next <= prev)//this node is a child of a previous node 2 or more ago
                {
                    List<Node> foundNodesWithSpecificSpaceNumber = new List<Node>();

                    foreach (Node n in manager.myNodes)//we search for a node that has -1 white spaces
                    {
                        if (n.numOfSpaces == (next - 1))
                        {
                            foundNodesWithSpecificSpaceNumber.Add(n);//we add all of the ones that have this to our list
                        }
                    }

                    Node myNode = 
                        new Node(nameWithWhiteRemoved, foundNodesWithSpecificSpaceNumber[foundNodesWithSpecificSpaceNumber.Count - 1], next);//our parent is the last one in the list

                    manager.AddNode(myNode);
                }
                prev = next;
            }
        }
    }
}
