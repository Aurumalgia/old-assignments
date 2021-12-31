package ss;

import linear.StructureIterator;

import java.util.List;

public interface BagStructure<T> {
    public void add(T newElem);
    public T any();
    public T remove(T searchElem);
    public boolean contains(T searchElem);
    public void clear();

    public boolean isEmpty();
    public int size();
    public List<T> toJavaList();
    public StructureIterator<T> toIterator();
}
