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
                Console.WriteLine("name: " + n.nodeName + ".  Is child is: " + n.isChild.ToString());
            }
            Console.ReadLine();
        }
    }
}
