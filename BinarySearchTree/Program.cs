using System;

namespace BinarySearchTree
{
    class Program
    {
        //Tree diagram
        //                 50
        //
        //         30             90
        //
        //      10   45         70   95
        //
        //     5    35  48    55       105
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(50);
            tree.insert(30);
            tree.insert(80);
            tree.insert(10);
            tree.insert(45);
            tree.insert(70);
            tree.insert(95);
            tree.insert(5);
            tree.insert(35);
            tree.insert(48);
            tree.insert(55);
            tree.insert(90);
            tree.insert(105);

            Console.WriteLine("Tree has a height of " + tree.getHeight() + ".");
            tree.insert(120);
            Console.WriteLine("Tree has a height of " + tree.getHeight() + ".");
            tree.insert(4);
            tree.insert(3);
            Console.WriteLine("Tree has a height of " + tree.getHeight() + ".");

            Console.WriteLine("Tree has " + tree.getNumberOfNodes() + " nodes.");

            Console.WriteLine("Is 70 in the tree? " + (tree.contains(70) ? "Yes" : "No"));
            Console.WriteLine("Is 12 in the tree? " + (tree.contains(12) ? "Yes" : "No"));
            Console.WriteLine("Is 55 in the tree? " + (tree.contains(55) ? "Yes" : "No"));
            Console.WriteLine("Is 40 in the tree? " + (tree.contains(40) ? "Yes" : "No"));
            Console.WriteLine("Is 5 in the tree? " + (tree.contains(5) ? "Yes" : "No"));
            Console.WriteLine("Is 6 in the tree? " + (tree.contains(6) ? "Yes" : "No"));
            Console.WriteLine("Is 48 in the tree? " + (tree.contains(48) ? "Yes" : "No"));
            Console.WriteLine("Is 47 in the tree? " + (tree.contains(47) ? "Yes" : "No"));

            Node<int> node45 = tree.search(45);
            String leftNode45 = node45.getLeft() == null ? "empty" : node45.getLeft().getData().ToString();
            String rightNode45 = node45.getRight() == null ? "empty" : node45.getRight().getData().ToString();
            String parentNode45 = node45.getParent() == null ? "empty" : node45.getParent().getData().ToString();
            Console.WriteLine("Node 45 left child: " + leftNode45 + " right child: " + rightNode45 + " parent: " + parentNode45);

            Node<int> node70 = tree.search(70);
            String leftNode70 = node70.getLeft() == null ? "empty" : node70.getLeft().getData().ToString();
            String rightNode70 = node70.getRight() == null ? "empty" : node70.getRight().getData().ToString();
            String parentNode70 = node70.getParent() == null ? "empty" : node70.getParent().getData().ToString();
            Console.WriteLine("Node 70 left child: " + leftNode70 + " right child: " + rightNode70 + " parent: " + parentNode70);

            Node<int> node105 = tree.search(105);
            String leftNode105 = node105.getLeft() == null ? "empty" : node105.getLeft().getData().ToString();
            String rightNode105 = node105.getRight() == null ? "empty" : node105.getRight().getData().ToString();
            String parentNode105 = node105.getParent() == null ? "empty" : node105.getParent().getData().ToString();
            Console.WriteLine("Node 105 left child: " + leftNode105 + " right child: " + rightNode105 + " parent: " + parentNode105);

            tree.delete(80);
            Node<int> node90 = tree.search(90);
            String leftNode90 = node90.getLeft() == null ? "empty" : node90.getLeft().getData().ToString();
            String rightNode90 = node90.getRight() == null ? "empty" : node90.getRight().getData().ToString();
            String parentNode90 = node90.getParent() == null ? "empty" : node90.getParent().getData().ToString();
            Console.WriteLine("Node 90 left child: " + leftNode90 + " right child: " + rightNode90 + " parent: " + parentNode90);

            Node<int> node95 = tree.search(95);
            String leftNode95 = node95.getLeft() == null ? "empty" : node95.getLeft().getData().ToString();
            String rightNode95 = node95.getRight() == null ? "empty" : node95.getRight().getData().ToString();
            String parentNode95 = node95.getParent() == null ? "empty" : node95.getParent().getData().ToString();
            Console.WriteLine("Node 95 left child: " + leftNode95 + " right child: " + rightNode95 + " parent: " + parentNode95);

            Node<int> node50 = tree.search(50);
            String leftNode50 = node50.getLeft() == null ? "empty" : node50.getLeft().getData().ToString();
            String rightNode50 = node50.getRight() == null ? "empty" : node50.getRight().getData().ToString();
            String parentNode50 = node50.getParent() == null ? "empty" : node50.getParent().getData().ToString();
            Console.WriteLine("Node 50 left child: " + leftNode50 + " right child: " + rightNode50 + " parent: " + parentNode50);


            Console.Write("Inorder: ");
            tree.inOrder();
            Console.WriteLine();
            Console.Write("Preorder: ");
            tree.preOrder();
            Console.WriteLine();
            Console.Write("Postorder: ");
            tree.postOrder();
            Console.WriteLine();
            Console.Write("Breadth first: ");
            tree.breadthFirst();
            Console.WriteLine();
        }
    }
}
