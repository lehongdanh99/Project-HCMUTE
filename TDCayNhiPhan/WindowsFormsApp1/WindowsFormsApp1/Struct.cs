using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Node
    {
        public string value;
        public string meaning;
        public Node left;
        public Node right;
    }

    public class Tree
    {
        public Node insert(Node root, string v,string mean)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
                root.meaning = mean;
            }
            else if (string.Compare(root.value, v) == 1)
            {
                root.left = insert(root.left, v,mean);
            }
            else if (string.Compare(root.value, v) == -1)
            {
                root.right = insert(root.right, v,mean);
            }
            return root;
        }
        public string traverse(Node root,string searchItem)
        {
            if (string.Compare(root.value,searchItem)==0)
            {
                return root.meaning ;
            }
            else if(string.Compare(root.value, searchItem)==1)
                    return traverse(root.left, searchItem);
                 else
                return traverse(root.right, searchItem);            
        }
    }   
}
