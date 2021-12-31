package linear1;

/*
 * An IterableStructure is a structure that can be iterated
 * over by a StructureIterator  
 */

import linear.StructureIterator;

public interface IterableStructure<T> {
	public StructureIterator<T> toIterator();
}
