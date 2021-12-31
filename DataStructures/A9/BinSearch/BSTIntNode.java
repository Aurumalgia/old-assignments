package BinSearch;

public class BSTIntNode {
    BSTIntNode parentNode;
    BSTIntNode leftChild;
    BSTIntNode rightChild;
    int data;

    public BSTIntNode(BSTIntNode parentNode, BSTIntNode leftChild, BSTIntNode rightChild, int data){
        this.parentNode = parentNode;
        this.leftChild = leftChild;
        this.rightChild = rightChild;
        this.data = data;
    }

    public BSTIntNode getParentNode() {
        return parentNode;
    }

    public void setParentNode(BSTIntNode parentNode) {
        this.parentNode = parentNode;
    }

    public BSTIntNode getLeftChild() {
        return leftChild;
    }

    public void setLeftChild(BSTIntNode leftChild) {
        this.leftChild = leftChild;
    }

    public BSTIntNode getRightChild() {
        return rightChild;
    }

    public void setRightChild(BSTIntNode rightChild) {
        this.rightChild = rightChild;
    }

    public int getData() {
        return data;
    }

    public void setData(int data) {
        this.data = data;
    }
}
