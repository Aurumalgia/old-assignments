package BinSearch;

import linear.StructureIterator;
import linear1.DynamicArray;
import pub.BSTIdea;

import java.util.Comparator;
import java.util.function.BiFunction;
import java.util.function.Consumer;

public class GenericBST<E, K> implements BSTIdea<E, K> {
    BSTGenericNode originNode;
    Comparator<E> sortFct;
    BiFunction<K, E, Integer> searchFct;
    public GenericBST (Comparator<E> sortFct, BiFunction<K, E, Integer> searchFct){
        this.sortFct = sortFct;
        this.searchFct = searchFct;
    }


    @Override
    public BSTIdea<E, K> add(E elem) {
        if (originNode == null) {
            originNode = new BSTGenericNode(null, null, null, elem);
            return this;
        } else {
            BSTGenericNode currentNode = originNode;
            while (true) {
                int compare = sortFct.compare(elem, (E) currentNode.getData());
                if (compare < 0) {
                    if (currentNode.getLeftChild() == null) {
                        currentNode.setLeftChild(new BSTGenericNode(currentNode, null, null, elem));
                        return this;
                    }
                    else
                        currentNode = currentNode.getLeftChild();

                }
                else{
                    if (currentNode.getRightChild() == null){
                        currentNode.setRightChild(new BSTGenericNode(currentNode, null, null, elem));
                        return this;
                    }
                    else
                        currentNode = currentNode.getRightChild();
                }
            }
        }
    }

    @Override
    public void visitInOrder(Consumer<E> visitFct) {
        BSTGenericNode currentNode = originNode;
        DynamicArray<BSTGenericNode> visitedNodes = new DynamicArray<BSTGenericNode>();
        try {
            while (true) {
                if (currentNode.getLeftChild() != null && visitedNodes.contains(currentNode) == false) {
                    try {
                        if (!visitedNodes.contains(currentNode.getLeftChild())) {
                            currentNode = currentNode.getLeftChild();
                        } else {
                            visitFct.accept((E) currentNode.getData());
                            visitedNodes.add(currentNode);
                        }
                    } catch (Exception e) {
                        try {
                            if (!visitedNodes.contains(currentNode.getRightChild())) {
                                currentNode = currentNode.getRightChild();
                            } else {
                                if (currentNode.getParentNode() == null)
                                    break;
                                else
                                    currentNode = currentNode.getParentNode();
                            }
                        } catch (Exception f) {
                            if (currentNode.getParentNode() == null)
                                break;
                            else
                                currentNode = currentNode.getParentNode();
                        }
                    }
                } else if (currentNode.getLeftChild() == null && visitedNodes.contains(currentNode) == false) {
                    visitFct.accept((E) currentNode.getData());
                    visitedNodes.add(currentNode);
                } else if (currentNode.getRightChild() != null) {
                    try {
                        if (!visitedNodes.contains(currentNode.getRightChild()))
                            currentNode = currentNode.getRightChild();
                        else
                            currentNode = currentNode.getParentNode();
                    } catch (Exception e) {
                        currentNode = currentNode.getParentNode();
                    }
                } else if (currentNode.getParentNode() == null){
                    break;
                }
                else currentNode = currentNode.getParentNode();

            }
        }
        catch (Exception e){}
    }


    @Override
    public void visitPreOrder(Consumer<E> visitFct) {
        BSTGenericNode currentNode = originNode;
        DynamicArray<BSTGenericNode> visitedNodes = new DynamicArray<BSTGenericNode>();
        try{
            while (true){
                if (!visitedNodes.contains(currentNode)){
                    visitedNodes.add(currentNode);
                    visitFct.accept((E) currentNode.getData());
                }
                else if (currentNode.getLeftChild() != null && !visitedNodes.contains(currentNode.getLeftChild())){
                    currentNode = currentNode.getLeftChild();
                }
                else if (currentNode.getRightChild() != null && !visitedNodes.contains(currentNode.getRightChild())){
                    currentNode = currentNode.getRightChild();
                }
                else
                    currentNode = currentNode.getParentNode();
            }
        }
        catch (Exception e){}
    }

    @Override
    public void visitPostOrder(Consumer<E> visitFct) {
        BSTGenericNode currentNode = originNode;
        DynamicArray<BSTGenericNode> visitedNodes = new DynamicArray<BSTGenericNode>();
        try{
            while(true) {
                if (currentNode.getLeftChild() != null && !visitedNodes.contains(currentNode.getLeftChild())) {
                    currentNode = currentNode.getLeftChild();
                } else if (currentNode.getRightChild() != null && !visitedNodes.contains(currentNode.getRightChild())) {
                    currentNode = currentNode.getRightChild();
                } else {
                    visitFct.accept((E) currentNode.getData());
                    visitedNodes.add(currentNode);
                    currentNode = currentNode.getParentNode();
                }
            }
        }
        catch (Exception e){}

    }

    @Override
    public int height() {
        BSTGenericNode currentNode = originNode;
        DynamicArray<BSTGenericNode> visitedNodes = new DynamicArray<BSTGenericNode>();
        int count = 1;
        int max = 0;
        try{while(true) {
            if (currentNode.getLeftChild() != null && !visitedNodes.contains(currentNode.getLeftChild())) {
                currentNode = currentNode.getLeftChild();
                count++;
            } else if (currentNode.getRightChild() != null && !visitedNodes.contains(currentNode.getRightChild())) {
                currentNode = currentNode.getRightChild();
                count++;
            } else {
                visitedNodes.add(currentNode);
                currentNode = currentNode.getParentNode();
                if (max < count){
                    max = count;
                }
                count--;
            }
        }}
        catch (Exception e){
            return max;
        }
    }

    @Override
    public boolean isEmpty() {
        if (originNode == null){
            return true;
        }
        return false;
    }

    @Override
    public E search(K key) {
        BSTGenericNode currentNode = originNode;
        while (true){
            int compare = searchFct.apply(key, (E) currentNode.getData());

            if (compare == 0){
                return (E) currentNode.getData();
            }
            else if (compare < 0){
                if (currentNode.getLeftChild() == null){
                    return null;
                }
                else
                    currentNode = currentNode.getLeftChild();
            }
            else{
                if (currentNode.getRightChild() == null){
                    return null;
                }
                else
                    currentNode = currentNode.getRightChild();
            }
        }
    }

    @Override
    public boolean contains(K key) {
        if (search(key) != null)
            return true;
        return false;
    }

    @Override
    public void remove(K key) {
        BSTGenericNode currentNode = originNode;
        while (true){
            int compare = searchFct.apply(key, (E) currentNode.getData());

            if (compare == 0){
                if(currentNode.getParentNode().getLeftChild() == currentNode){
                    currentNode.getParentNode().setLeftChild(null);
                }
                else{
                    currentNode.getParentNode().setRightChild(null);
                }
                if(currentNode.getLeftChild() != null){
                    currentNode.getLeftChild().setParentNode(null);
                }
                if(currentNode.getRightChild() != null){
                    currentNode.getRightChild().setParentNode(null);
                }
                currentNode = null;
                break;
            }
            else if (compare < 0){
                if (currentNode.getLeftChild() == null){
                    System.out.println("Element not found");
                    break;
                }
                else
                    currentNode = currentNode.getLeftChild();
            }
            else{
                if (currentNode.getRightChild() == null){
                    System.out.println("Element not found");
                    break;
                }
                else
                    currentNode = currentNode.getRightChild();
            }
        }
    }

    @Override
    public StructureIterator<E> toIterator() {
        return null;
    }

    @Override
    public StructureIterator<E> toPreOrderIterator() {
        return null;
    }
}
