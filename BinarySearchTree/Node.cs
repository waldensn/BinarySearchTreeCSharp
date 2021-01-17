namespace BinarySearchTree
{

    public class Node<T>
    {
        private T data;
        private Node<T> parent;
        private Node<T> left;
        private Node<T> right;

        public Node(T data)
        {
            this.data = data;
            this.parent = null;
            this.left = null;
            this.right = null;
        }

        public Node(Node<T> parent, T data)
        {
            this.data = data;
            this.parent = parent;
            this.left = null;
            this.right = null;
        }

        public T getData() { return this.data; }
        public Node<T> getParent() { return this.parent; }
        public Node<T> getLeft() { return this.left; }
        public Node<T> getRight() { return this.right; }

        public void setData(T data) { this.data = data; }
        public void setParent(Node<T> parent) { this.parent = parent; }
        public void setLeft(Node<T> left) { this.left = left; }
        public void setRight(Node<T> right) { this.right = right; }
    }
}

