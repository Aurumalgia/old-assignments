package ss;

import linear.StructureIterator;

import java.util.List;

public interface QueueStructure<E> {
    public void enqueue(E newElem);
    public E dequeue();
    public E peek();

    public boolean isEmpty();
    public int size();
    public void clear();
    public List<E> toJavaList();
    public StructureIterator<E> toIterator();

    public void add(E newElem);




}
