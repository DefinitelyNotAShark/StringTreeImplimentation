using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class Node
    {
        public string nodeName;
        public bool isChild;
        private bool isBase;

        public Node(string name, bool child, bool isbase)//name is the text
        {
            nodeName = name;

            if (!child)
                isChild = false;

            else if (child)
                isChild = true;

            if (!isbase)
                isBase = false;

            else if (isbase)
                isBase = true;
        }
    }
}
   

