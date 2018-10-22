using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            TextParser parser = new TextParser();
            NodeManager manager = new NodeManager();
            TextWriter writer = new TextWriter();
            parser.LoadText();
            parser.CheckCharsForNodes(manager);
            manager.IndexNodes();
            manager.DebugWriteOutChildren();//tell me who is a child of who
            manager.DebugAskIfAddNode();
            manager.DebugWriteOutChildren();


            Tree myTree = new Tree(manager);

            Console.WriteLine("\n");
            writer.WriteOutlineFile(manager.myNodes, "TreeOutlineFile");

            Console.ReadLine();
        }
    }
}
