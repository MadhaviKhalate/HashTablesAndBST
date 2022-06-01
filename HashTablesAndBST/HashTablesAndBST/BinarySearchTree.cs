using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndBST
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T data)
        {
            this.NodeData = data;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T element)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(element) > 0))
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(element);
                else
                    this.LeftTree.Insert(element);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(element);
                else
                    this.RightTree.Insert(element);
            }
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size: " + (1 + this.leftCount + this.rightCount));
        }
    }
}
