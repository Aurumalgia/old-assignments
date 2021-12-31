package linear;

/*
 * An IterableStructure is a structure that can be iterated
 * over by a StructureIterator  
 */

public interface IterableStructure<T> {
	public StructureIterator<T> toIterator();
}
