package linear;

import java.util.Iterator;

public interface StructureIterator<E> extends Iterator<E> {
	
	public E next();
	public boolean hasNext();
	
	public default E peek() { return null; }

}
