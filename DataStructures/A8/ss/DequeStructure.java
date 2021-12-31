package ss;

import linear.StructureIterator;

import java.util.List;

public interface DequeStructure<T> {
    public void addFirst(T newElem);
    public void addLast(T newElem);
    public T removeFirst();
    public T removeLast();
    public T first();
    public T last();

    public boolean isEmpty();
    public int size();
    public void clear();
    public List<T> toJavaList();
    public StructureIterator<T> toIterator();

    public void add(T newElem);
}
