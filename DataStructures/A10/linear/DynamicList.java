package linear;

import java.util.Iterator;

/*
	A DynamicList is the concept for a structure that
	supports indexed access and also changes in
	structure size 
*/

import java.util.List;

public interface DynamicList<E> extends Iterable<E> {
	
	public int size();
	public boolean isEmpty();
	public E get(int index);
	public DynamicList<E> subList(int start, int stop);
	public E first();
	public E last();
	public boolean contains(E searchElement);
 		
	public void addFirst(E newData);
	public void addLast(E newData);
	public void add(E newData);
 		
	public void clear();
	public E remove(E data);
	public E removeFirst();
	public E removeLast();
 		
	public default StructureIterator<E> toIterator() { return null; }
	public List<E> toJavaList();
	
	//Optional
	public default void addBefore(E searchElement, E newData) { throw notImplemented(); }
	public default void addAfter(E searchElement, E newData) { throw notImplemented(); }
	public default void replace(E oldData, E newData) { throw notImplemented(); }
	public default void insert(int index, E newData) { throw notImplemented(); }
	public default E removeIndex(int index) { throw notImplemented(); }	
	
	private static RuntimeException notImplemented() {
		return new RuntimeException("Not Implemented");
	}
	
	//No need to override
	public default Iterator<E>	iterator() { return toIterator(); }
	
	

}
