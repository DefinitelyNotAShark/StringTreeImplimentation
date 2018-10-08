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
                dataFileName = "textFile";
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
                char[] chars = s.ToCharArray();//turn string into char array
                int next = 0;//next is going to be our index

                while (Char.IsWhiteSpace(chars[next]))//until we hit a non blank space, we're gonna make a list of whitespaces
                {
                    next++;
                }

                if(next == 0)
                {
                    Console.WriteLine("base");
                    Node myNode = new Node(s, false, true);
                    manager.AddNode(myNode);
                }

                else if (next > prev)//now we check it against the previous index
                { 
                    Console.WriteLine("Child");
                    Node myNode = new Node(s, true, false);
                    manager.AddNode(myNode);
                }

                else if(next < prev)
                {
                    Console.WriteLine("Idk what this means yet");
                }

                else if (next == prev)
                {
                    Console.WriteLine("not child of prev, but child");
                    Node myNode = new Node(s, false, false);
                    manager.AddNode(myNode);
                }

                prev = next;
            }
        }
    }
}
