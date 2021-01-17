using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Tree
    {
        private Node<int> root;

        public Tree()
        {
            this.root = null;
        }

        public Tree(Node<int> root)
        {
            this.root = root;
        }

        public Node<int> getRoot() { return this.root; }

        //print the tree
        public String toString()
        {
            StringBuilder treeSb = new StringBuilder();

            return treeSb.ToString();
        }

        //insert new node
        public void insert(int key)
        {
            root = insertRecursive(this.root, null, key);
        }

        public Node<int> insertRecursive(Node<int> root, Node<int> parent, int key)
        {
            if (root == null)
            {
                return new Node<int>(parent, key);
            }

            if (key < root.getData())
            {
                root.setLeft(insertRecursive(root.getLeft(), root, key));
            }
            else if (key > root.getData())
            {
                root.setRight(insertRecursive(root.getRight(), root, key));
            }
            return root;
        }

        //does tree contain a node
        public bool contains(int key)
        {
            Node<int> keyNode = this.searchRecursive(this.root, key);
            if (keyNode != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //find and return node
        public Node<int> search(int key)
        {
            return this.searchRecursive(this.root, key);
        }

        public Node<int> searchRecursive(Node<int> root, int key)
        {
            //base case is root null or key found
            if (root == null || root.getData().Equals(key))
            {
                return root;
            }
            //if key less than root key, traverse left subtree
            if (key < root.getData())
            {
                return searchRecursive(root.getLeft(), key);
            }
            //if key greater than root key, traverse right subtree
            return searchRecursive(root.getRight(), key);
        }

        //delete a node
        public void delete(int key)
        {
            root = deleteRecursive(root, key);
        }

        public Node<int> deleteRecursive(Node<int> root, int key)
        {
            if (root == null)
            {
                return root;
            }
            //if key less than root key, traverse left subtree
            if (key < root.getData())
            {
                root.setLeft(deleteRecursive(root.getLeft(), key));
            }
            //if key greater than root key, traverse right subtree
            else if (key > root.getData())
            {
                root.setRight(deleteRecursive(root.getRight(), key));
            }
            //found node to delete
            else
            {
                //node to delete has zero or one child node
                if (root.getLeft() == null)
                {
                    if (root.getRight() != null)
                    {
                        root.getRight().setParent(root.getParent());
                    }
                    return root.getRight();
                }
                else if (root.getRight() == null)
                {
                    if (root.getLeft() != null)
                    {
                        root.getLeft().setParent(root.getParent());
                    }
                    return root.getLeft();
                }

                //node to delete has two children, so find the smallest node on the right subtree
                //replace the node to delete with that node, then delete the smallest node on the right subtree
                root.setData(getMinValue(root.getRight()));
                root.setRight(deleteRecursive(root.getRight(), root.getData()));
            }

            return root;
        }

        //get smallest key from a tree
        public int getMinValue(Node<int> root)
        {
            int minValue = root.getData();
            while (root.getLeft() != null)
            {
                minValue = root.getLeft().getData();
                root = root.getLeft();
            }
            return minValue;
        }

        //get number of nodes
        public int getNumberOfNodes()
        {
            Queue<Node<int>> queue = new Queue<Node<int>>();
            int numNodes = 0;
            if (root == null) { return numNodes; }
            queue.Enqueue(root);

            //use a queue to list the nodes breadth first
            while (queue.Count != 0)
            {
                Node<int> n = queue.Dequeue();
                numNodes++;
                //if we have left node, add it to the end of the queue
                if (n.getLeft() != null)
                {
                    queue.Enqueue(n.getLeft());
                }
                //if we have right node, add it to the end of the queue
                if (n.getRight() != null)
                {
                    queue.Enqueue(n.getRight());
                }
            }

            return numNodes;
        }

        //get height of tree
        //height of empty tree is zero
        public int getHeight()
        {
            return this.getHeightRecursive(root);
        }

        public int getHeightRecursive(Node<int> root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                //get height of subtree
                int leftHeight = getHeightRecursive(root.getLeft());
                int rightHeight = getHeightRecursive(root.getRight());

                //return larger of the two heights
                if (leftHeight > rightHeight)
                {
                    return leftHeight + 1;
                }
                else
                {
                    return rightHeight + 1;
                }
            }
        }

        //in order (left root right)
        public void inOrder()
        {
            this.printInOrder(root);
        }

        public void printInOrder(Node<int> root)
        {
            if (root == null)
                return;

            //traverse left subtree recursively
            printInOrder(root.getLeft());

            //root node
            Console.Write(root.getData() + " ");

            //traverse right subtree recursively
            printInOrder(root.getRight());
        }

        //pre order (root left right)
        public void preOrder()
        {
            this.printPreOrder(root);
        }

        public void printPreOrder(Node<int> root)
        {
            if (root == null)
                return;

            //root node
            Console.Write(root.getData() + " ");

            //traverse left subtree recursively
            printPreOrder(root.getLeft());

            //traverse right subtree recursively
            printPreOrder(root.getRight());
        }

        //post order (left right root)
        public void postOrder()
        {
            this.printPostOrder(root);
        }

        public void printPostOrder(Node<int> root)
        {
            if (root == null)
                return;

            //traverse left subtree recursively
            printPostOrder(root.getLeft());

            //traverse right subtree recursively
            printPostOrder(root.getRight());

            //root node
            Console.Write(root.getData() + " ");
        }

        //first level, then second level, etc
        public void breadthFirst()
        {
            Queue<Node<int>> queue = new Queue<Node<int>>();
            if (root == null) { return; }
            queue.Enqueue(root);

            //use a queue to list the nodes breadth first
            while (queue.Count != 0)
            {
                Node<int> n = queue.Dequeue();
                Console.Write(n.getData() + " ");
                //if we have left node, add it to the end of the queue
                if (n.getLeft() != null)
                {
                    queue.Enqueue(n.getLeft());
                }
                //if we have right node, add it to the end of the queue
                if (n.getRight() != null)
                {
                    queue.Enqueue(n.getRight());
                }
            }
        }

        //balance tree
    }
    }

