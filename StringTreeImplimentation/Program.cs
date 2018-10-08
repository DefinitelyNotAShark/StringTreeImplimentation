using System;
using System.Collections.Generic;
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
            parser.LoadText();
            parser.CheckCharsForNodes(manager);
            foreach(Node n in manager.myNodes)
            {
                Console.Write(n.nodeName);
                if(n.parent != null)
                {
                    Console.Write(" is child of: " + n.parent.nodeName + "\n");
                }
                if(n.parent == null)
                {
                    Console.Write(" is base.");
                }
            }
            Console.ReadLine();
        }
    }
}
