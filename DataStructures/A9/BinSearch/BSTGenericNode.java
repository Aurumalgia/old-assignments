package BinSearch;

public class BSTGenericNode<E> {
    BSTGenericNode parentNode;
    BSTGenericNode leftChild;
    BSTGenericNode rightChild;
    E data;

    public BSTGenericNode(BSTGenericNode parentNode, BSTGenericNode leftChild, BSTGenericNode rightChild, E data){
        this.parentNode = parentNode;
        this.leftChild = leftChild;
        this.rightChild = rightChild;
        this.data = data;
    }

    public BSTGenericNode getParentNode() {
        return parentNode;
    }

    public void setParentNode(BSTGenericNode parentNode) {
        this.parentNode = parentNode;
    }

    public BSTGenericNode getLeftChild() {
        return leftChild;
    }

    public void setLeftChild(BSTGenericNode leftChild) {
        this.leftChild = leftChild;
    }

    public BSTGenericNode getRightChild() {
        return rightChild;
    }

    public void setRightChild(BSTGenericNode rightChild) {
        this.rightChild = rightChild;
    }

    public E getData() {
        return data;
    }

    public void setData(E data) {
        this.data = data;
    }
}
