package linear;

public class Node<E> {
    private E currentObject;
    private Node nextNode;
    private Node previousNode;

    public Node(E currentObject, Node nextNode, Node previousNode){
        this.currentObject = currentObject;
        this.nextNode = nextNode;
        this.previousNode = previousNode;
    }

    public E getCurrentObject() {
        return currentObject;
    }

    public void setCurrentObject(E currentObject) {
        this.currentObject = currentObject;
    }

    public Node getNextNode() {
        return nextNode;
    }

    public void setNextNode(Node nextNode) {
        this.nextNode = nextNode;
    }

    public Node getPreviousNode() {
        return previousNode;
    }

    public void setPreviousNode(Node previousNode) {
        this.previousNode = previousNode;
    }

    public void delete(){
        setNextNode(null);
        setPreviousNode(null);
        setCurrentObject(null);
    }
}
