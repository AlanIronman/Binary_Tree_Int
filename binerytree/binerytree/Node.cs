using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binerytree
{
    class Node
    {
        public int data;
        public Node lNode;
        public Node rNode;

        public Node()
        {
            this.lNode = null;
            this.rNode = null;
        }

        public Node(int data)
        {
            this.data = data;
            this.lNode = null;
            this.rNode = null;
        }
    }
}
