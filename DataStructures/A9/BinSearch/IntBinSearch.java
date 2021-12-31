package BinSearch;

import linear1.DynamicArray;
import pub.IntegerBSTIdea;

import java.util.function.Consumer;

public class IntBinSearch implements IntegerBSTIdea {
    BSTIntNode originNode;

    public IntBinSearch() {

    }


    @Override
    public IntegerBSTIdea add(Integer elem) {
        if (originNode == null) {
            originNode = new BSTIntNode(null, null, null, elem);
            return this;
        } else {
            BSTIntNode currentNode = originNode;
            while (true) {
                int compare = elem.compareTo(currentNode.getData());
                if (compare < 0) {
                    if (currentNode.getLeftChild() == null) {
                        currentNode.setLeftChild(new BSTIntNode(currentNode, null, null, elem));
                        return this;
                    }
                    else
                        currentNode = currentNode.getLeftChild();

                }
                else{
                    if (currentNode.getRightChild() == null){
                        currentNode.setRightChild(new BSTIntNode(currentNode, null, null, elem));
                        return this;
                    }
                    else
                        currentNode = currentNode.getRightChild();
                }
            }
        }
    }

    @Override
    public void visitInOrder(Consumer<Integer> visitFct) {
        BSTIntNode currentNode = originNode;
        DynamicArray<BSTIntNode> visitedNodes = new DynamicArray<BSTIntNode>();
        try {
            while (true) {
                if (currentNode.getLeftChild() != null && visitedNodes.contains(currentNode) == false) {
                    try {
                        if (!visitedNodes.contains(currentNode.getLeftChild())) {
                            currentNode = currentNode.getLeftChild();
                        } else {
                            visitFct.accept(currentNode.getData());
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
                    visitFct.accept(currentNode.getData());
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
    public void visitPreOrder(Consumer<Integer> visitFct) {
        BSTIntNode currentNode = originNode;
        DynamicArray<BSTIntNode> visitedNodes = new DynamicArray<BSTIntNode>();
        try{
            while (true){
                if (!visitedNodes.contains(currentNode)){
                    visitedNodes.add(currentNode);
                    visitFct.accept(currentNode.getData());
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
    public void visitPostOrder(Consumer<Integer> visitFct) {
        BSTIntNode currentNode = originNode;
        DynamicArray<BSTIntNode> visitedNodes = new DynamicArray<BSTIntNode>();
        try{
            while(true) {
                if (currentNode.getLeftChild() != null && !visitedNodes.contains(currentNode.getLeftChild())) {
                    currentNode = currentNode.getLeftChild();
                } else if (currentNode.getRightChild() != null && !visitedNodes.contains(currentNode.getRightChild())) {
                    currentNode = currentNode.getRightChild();
                } else {
                    visitFct.accept(currentNode.getData());
                    visitedNodes.add(currentNode);
                    currentNode = currentNode.getParentNode();
                }
            }
        }
        catch (Exception e){}

    }

    @Override
    public int height() {
        BSTIntNode currentNode = originNode;
        DynamicArray<BSTIntNode> visitedNodes = new DynamicArray<BSTIntNode>();
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
    public Integer search(Integer elem) {
        BSTIntNode currentNode = originNode;
        while (true){
            int compare = elem.compareTo(currentNode.getData());

            if (compare == 0){
                return currentNode.getData();
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
    public boolean contains(Integer elem) {
        if (search(elem) != null)
            return true;
        return false;
    }
}
