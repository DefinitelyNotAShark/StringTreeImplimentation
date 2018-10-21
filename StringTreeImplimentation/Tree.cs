using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTreeImplimentation
{
    class Tree
    {
        public Tree(NodeManager manager)
        {
            AddPointersToDirectChildren(manager);
            //GetAllChildren(manager);
        }


        void AddPointersToDirectChildren(NodeManager manager)
        {
            foreach (Node n in manager.myNodes)//cycle through my nodes and add children based on parent
            {
                while (n.parent != null)//if it has a parent
                {
                    if (!n.parent.directChildren.Contains(n))
                        n.parent.directChildren.Add(n);//add the child to the parent
                    else break;
                }
            }
        }   
        
        //private void GetAllChildren(NodeManager manager)
        //{
        //}
    }
}
