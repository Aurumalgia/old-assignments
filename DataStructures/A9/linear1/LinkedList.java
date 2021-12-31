package linear1;

import iter.DynArrayIterator;
import linear.StructureIterator;

import java.util.ArrayList;
import java.util.List;

public class LinkedList<E> implements DynamicList<E> {
    Node firstNode;
    Node lastNode;
    int size = 0;
    public LinkedList(){

    }





    @Override
    public int size() {
        return size;
    }

    @Override
    public boolean isEmpty() {
        return size == 0;
    }

    @Override
    public E get(int index) {
        Node currentNode = firstNode;
        for(int i = 0; i < index; i++){
            currentNode = currentNode.getNextNode();
        }
        return (E) currentNode.getCurrentObject();
    }

    @Override
    public DynamicList subList(int start, int stop) {
        Node currentNode = firstNode;
        LinkedList l = new LinkedList();
        for(int i = 0; i < start; i++){
            currentNode =  currentNode.getNextNode();
        }
        for(int j = start; j <= stop; j++){
            l.add(currentNode.getCurrentObject());
            currentNode = currentNode.getNextNode();
        }
        return l;
    }

    @Override
    public E first() {
        return (E) firstNode.getCurrentObject();
    }

    @Override
    public E last() {
        return (E) lastNode.getCurrentObject();
    }

    @Override
    public boolean contains(E searchElement) {
        boolean containsElement = false;
        Node currentNode = firstNode;
        while(!containsElement && currentNode != null){
            if (currentNode.getCurrentObject() == searchElement){
                containsElement = true;
            }
            else{
                currentNode = currentNode.getNextNode();
            }
        }
        return containsElement;
    }

    @Override
    public void addFirst(E newData) {
        if (size == 0){
            initialNode(newData);
        }
        else{
            firstNode.setPreviousNode(new Node(newData, firstNode, null));
            firstNode = firstNode.getPreviousNode();
            size++;
            if (size == 2){
                lastNode = firstNode.getNextNode();
            }
        }

    }

    @Override
    public void addLast(E newData) {
        if (size == 0){
            initialNode(newData);
        }
        else {
            lastNode.setNextNode(new Node(newData, null, lastNode));
            lastNode = lastNode.getNextNode();
            size++;
        }
    }

    @Override
    public void add(E newData) {
        addLast(newData);
    }

    @Override
    public void clear() {
        while(firstNode != lastNode){
            removeFirst();
        }
        firstNode.delete();
    }

    @Override
    public E remove(E data) {
        boolean containsElement = false;
        Node currentNode = firstNode;
        while(!containsElement && currentNode != null){
            if (currentNode.getCurrentObject() == data){
                containsElement = true;
            }
            else{
                currentNode = currentNode.getNextNode();
            }
        }
        if (!containsElement)
            throw new ArrayIndexOutOfBoundsException("Element not Found");
        else {
            E t = removeNode(currentNode);
            return t;
        }
    }

    public E removeNode(Node node){

        E t = (E) node.getCurrentObject();
        if (node == firstNode) {
            t = removeFirst();
        }
        else if (node == lastNode) {
            t = removeLast();
        }
        else {
            link2Nodes(node.getPreviousNode(), node.getNextNode());
            node.delete();
            size--;
        }
        return t;
    }

    @Override
    public E removeFirst() {
        Node node = firstNode;
        E t = (E) node.getCurrentObject();
        firstNode = node.getNextNode();
        node.getNextNode().setPreviousNode(null);
        node.delete();
        size--;
        return t;
    }

    @Override
    public E removeLast() {
        Node node = lastNode;
        E t = (E) node.getCurrentObject();
        lastNode = node.getPreviousNode();
        node.getPreviousNode().setNextNode(null);
        node.delete();
        size--;
        return t;
    }

    @Override
    public List toJavaList() {
        List<E> l = new ArrayList<E>();
        Node currentNode = firstNode;
        while(currentNode != null){
            l.add((E) currentNode.getCurrentObject());
            currentNode = currentNode.getNextNode();
        }
        return l;
    }

    public void initialNode(E newData){
        firstNode = new Node(newData,  null, null);
        lastNode = firstNode;
        size++;
    }

    public void link2Nodes(Node formerNode, Node latterNode){
        formerNode.setNextNode(latterNode);
        latterNode.setPreviousNode(formerNode);
    }

    @Override
    public String toString(){
        Node currentNode = firstNode;
        String s = "[";
        while(currentNode != null){
            if(currentNode.getNextNode() == null){
                s += currentNode.getCurrentObject();
            }
            else {
                s += currentNode.getCurrentObject() + ", ";
            }
            currentNode = currentNode.getNextNode();
        }
        s += "]";
        return s;
    }

    @Override
    public void addBefore(E searchElement, E newData) {
        Node currentNode = firstNode;
        Boolean eFound = false;
        while (currentNode != null && !eFound){
            if(currentNode.getCurrentObject() == searchElement){
                eFound = true;
            }
            else{
                currentNode = currentNode.getNextNode();
            }
        }
        if(currentNode == null){
            throw nodeNotFound();
        }
        else {
            Node newNode = new Node(newData, currentNode, currentNode.getPreviousNode());
            currentNode.getPreviousNode().setNextNode(newNode);
            currentNode.setPreviousNode(newNode);
            size++;
        }
    }

    @Override
    public void addAfter(E searchElement, E newData) {
        Node currentNode = firstNode;
        Boolean eFound = false;
        while (currentNode != null && !eFound){
            if(currentNode.getCurrentObject() == searchElement){
                eFound = true;
            }
            else{
                currentNode = currentNode.getNextNode();
            }
        }
        if(currentNode == null){
            throw nodeNotFound();
        }
        else {
            Node newNode = new Node(newData, currentNode.getNextNode(), currentNode);
            currentNode.getNextNode().setPreviousNode(newNode);
            currentNode.setNextNode(newNode);
            size++;
        }
    }

    @Override
    public void replace(E oldData, E newData) {
        Node currentNode = firstNode;
        Boolean eFound = false;
        while (currentNode != null && !eFound){
            if(currentNode.getCurrentObject() == oldData){
                eFound = true;
            }
            else{
                currentNode = currentNode.getNextNode();
            }
        }
        if(currentNode == null){
            throw nodeNotFound();
        }
        else{
            currentNode.setCurrentObject(newData);
        }
    }

    @Override
    public void insert(int index, E newData) {
        Node currentNode = firstNode;
        if (index <= size) {
            for (int i = 0; i < index; i++) {
                currentNode = currentNode.getNextNode();
            }
        }
        else {
            System.out.println("Index out of Bounds");
        }
        Node newNode = new Node(newData, currentNode, currentNode.getPreviousNode());
        currentNode.getPreviousNode().setNextNode(newNode);
        currentNode.setPreviousNode(newNode);
        size++;
    }

    @Override
    public E removeIndex(int index) {
        Node currentNode = firstNode;
        for (int i = 0; i < index; i++){
            currentNode = currentNode.getNextNode();
        }
        return removeNode(currentNode);
    }

    @Override
    public StructureIterator<E> toIterator() {
        return (StructureIterator<E>) new DynArrayIterator<E>(this);
    }


    private static RuntimeException nodeNotFound(){
        return new RuntimeException("Node not found.");
    }
}
