package ss;

import linear.StructureIterator;

import java.util.*;

public interface StackStructure<T> {
    public void push(T newElem);
    public T pop();
    public T peek();

    public boolean isEmpty();
    public int size();
    public void clear();
    public List<T> toJavaList();
    public StructureIterator<T> toIterator();
    public void add(T newElem);


}
