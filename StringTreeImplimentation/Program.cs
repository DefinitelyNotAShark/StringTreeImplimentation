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
            Tree myTree = new Tree(manager);//this is where the tree has to be created so it can use the info that the manager has
            //manager.DebugAskIfAddNode();
            //manager.DebugWriteOutChildren();
           // manager.AskIfRemoveNode();
            //manager.DebugWriteOutChildren();
            manager.DebugAskIfGetNode();
            manager.DebugWriteOutChildren();


            Console.WriteLine("\n");
            writer.WriteOutlineFile(manager.myNodes, "TreeOutlineFile");

            Console.ReadLine();
        }
    }
}
