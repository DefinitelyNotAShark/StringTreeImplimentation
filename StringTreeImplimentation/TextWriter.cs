using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class TextWriter
    {
        public string path(string fileName)
        {
            return fileName + ".txt"; //Path to the folder: " /AlgorithmsDataSortingApp/bin/Debug/ "
        }
        private string space = "\t";//it's a tab to make it look good
        private int spaceNum;

        public void WriteOutlineFile(List<Node> nodes, string fileName)
        {
            using (StreamWriter sw = File.CreateText(path(fileName)))
            {

                for (int i = 0; i < nodes.Count; i++)
                {
                    //spaceNum = 0;

                    if (nodes[i].parent == null)
                    {
                        //using (StreamWriter sw = new  StreamWriter(path(fileName)))
                        sw.WriteLine(nodes[i].nodeName);
                        spaceNum = 0;
                    }

                    //else
                    //{
                    //    int parentIndex = 0;//this is our index for checking if current or prev has parent

                    //    while (nodes[i].parent != nodes[i - parentIndex])//while what we're checking is NOT a base
                    //    { 
                    //        if (nodes[i].parent == nodes[i - 1])//else if they are a child of the prev 
                    //        {
                    //            spaceNum++;
                    //            break;
                    //        }

                    //        else if (nodes[i].parent == nodes[i - 1].parent)//if our parent is the prev parent WORKS
                    //        {
                    //            break;//no need to add or sub spaces. Should be the same
                    //        }

                    //        else
                    //        {
                    //            Console.WriteLine("My space num is " + spaceNum + " and my parent is " + nodes[i].parent.nodeName.ToString());
                    //        }
                    //        parentIndex++;

                    //}

                    else
                    {
                        spaceNum = nodes[i].parent.numOfSpaces + 1;//sorry I tried to do this but i just can't seem to muster the brainpower

                        for (int a = 0; a < spaceNum; a++)//prints out the node with the number of spaces it needs
                        {
                            //using (StreamWriter sw = new StreamWriter(path(fileName)))
                            sw.Write(space);//write out a space
                        }
                        sw.WriteLine(nodes[i].nodeName);
                    }
                    //using (StreamWriter sw = new StreamWriter (path(fileName)))
                }
            }

        }
    }
}
