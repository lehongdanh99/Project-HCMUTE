using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AnhVIet
{

    public class NODE
    {
        public string Word;         //Từ tiếng anh
        public string Mean;      //Nghĩa tiếng việt
        public NODE Left;
        public NODE Right;
    }

    public class Tree
    {

        public NODE Insert(NODE root, string word, string mean)
        {
            if (root == null)
            {
                root = new NODE();
                root.Word = word;
                root.Mean = mean;
            }
            //compare dùng để so sánh hai từ bằng giá trị ASCII 

            else if (string.Compare(root.Word, word) == 1)          // ==1 là Word>word
            {
                root.Left = Insert(root.Left, word, mean);      //từ nhỏ hơn sẽ đi về phía bên trái của cây
            }
            else if (string.Compare(root.Word, word) == -1)          // ==-1 là Word<word
            {
                root.Right = Insert(root.Right, word, mean);      //từ nhỏ hơn sẽ đi về phía bên phải của cây
            }
            return root;
        }

        public string Seacrch(NODE root, string FindWord)                   //gọi đệ quy hàm search
        {
            if (root != null)
            {
                if (string.Compare(root.Word.ToLower(), FindWord.ToLower()) == 0)           //giống nhau: trả ra cái nghĩa
                { return root.Mean; }
                else if (string.Compare(root.Word.ToLower(), FindWord.ToLower()) == 1)          //Word>word thì từ cần tìm chạy về phía bên trái
                    return Seacrch(root.Left, FindWord);
                else if (string.Compare(root.Word.ToLower(), FindWord.ToLower()) == -1)
                    return Seacrch(root.Right, FindWord);
            }
            return null;
        }
        public void Replace(NODE p, NODE q)
        {
            if (q.Left != null)
                Replace(p, q.Left);
            else
            {
                p.Word = q.Word;
                p.Mean = q.Mean;
                p = q;
                q = p.Right;
            }
        }
        public bool Del(ref NODE root, string DelWord)
        {
            if (root == null)
                return false;
            if (string.Compare(root.Word.ToLower(), DelWord.ToLower()) == 1)
            {
                return Del(ref root.Left, DelWord);
            }

            if (string.Compare(root.Word.ToLower(), DelWord.ToLower()) == -1)
            {
                return Del(ref root.Right, DelWord);
            }

            NODE p = root;
            if (root.Left == null)
            {
                root = root.Right;
            }
            else
            {
                if (root.Right == null)
                    root = root.Left;
                else
                {
                    Replace(p, root.Right);
                }
            }

            p = null;
            return true;
        }
        public void Traverse(NODE tree)
        {
            if(tree != null)
            {
                Traverse(tree.Left);
                StreamWriter sw = new StreamWriter("D:\\Tudien.txt", true);
                //Write a line of text
                sw.WriteLine(tree.Word.ToString() + ":" + tree.Mean.ToString());
                sw.Close();
                Traverse(tree.Right);
            }

        }

        public void Destroy(ref NODE root)
        {
            Destroy(ref root.Left);
            Destroy(ref root.Right);
            root = null;
            System.GC.Collect();

        }
    }
}

