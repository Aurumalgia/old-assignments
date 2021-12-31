package pub;
/*
Class: BSTIdea

The terms "elem" and "data" are used interchangeably

Adding Data -- Data should be added into the tree like this:

	If newData is less than data at an existing node,
		- The newData should go to the LEFT
		- Otherwise to the right
	
Duplicates are allowed	
	
Visit (Implementing):

	The param to the visit methods is a Consumer
	It is a simple function (without return value).
	To execute it (e.g. to "visit") you would just do this:
	
		visitFct.accept(data);
		
	Where "data" is the data for the current (visited) node.
	
Visit (Using/Testing):

	Here is how simple it is to use the visit function.
	Here we print the tree in the specified order:
	
			bst.visitInOrder(data -> System.out.println("" + data));
			
	Where "bst" is an instance of the BST tree
	Where "data" is the data for the visited node
	
	
Trick for printing nicely formatted tree:

	Nice print to console in formatted tree format
	Reverse your inorder traversal
	I.e. [traverse right]-[visit current]-[traverse left]
	Then, at each level, first indent, then print
*/

import java.util.function.Consumer;

import linear.StructureIterator;

/*
	Generics
		  E - elem (data) type
		  K - key type
 */

public interface BSTIdea<E, K> {

	//Add elem (data) into tree in correct position (see above) 
	//Note: We're also going to learn "method cascading" here
	//To support "method cascading", simply return the tree itself
	//from this method -- e.g. "return this"	
	public BSTIdea<E, K> add(E elem);
	
	//-------------------------------------------------
	//Tree Traversal Methods
	//See note labeled "Visit" at top of this file
	
	//Visit the tree using "in-order" traversal	
	public void visitInOrder(Consumer<E> visitFct);
	
	//Visit the tree using "pre-order" traversal	
	public void visitPreOrder(Consumer<E> visitFct);
	
	//Visit the tree using "post-order" traversal	
	public void visitPostOrder(Consumer<E> visitFct);
	
	//-------------------------------------------------
	//Queries

	//Return height of tree (max number of node levels)
	public int height();

	//Return true if tree is empty, otherwise false
	boolean isEmpty();
	
	//Return the first match
	public E search(K key);
	
	//Return true if the tree contains the elem
	public boolean contains(K key);
	
	//-------------------------------------------------
	//Remove	
	
	//Remove the elem
	public void remove(K key);	
	
	//-------------------------------------------------
	//Iterators	

	//Return iterator for tree using "in-order" traversing
	//After construction, the first "next" sent to the iterator
	//should return the first node relative to "in-order" 
	public StructureIterator<E> toIterator();

	//Return iterator for tree using "pre-order" traversing
	//After construction, the first "next" sent to the iterator
	//should return the first node relative to "pre-order"	
	public StructureIterator<E> toPreOrderIterator();
	
	//====================================================
	//====================================================
	//All below are optional
	
	//------------------------------------------------
	//Optional (For Debugging)
	
	//This is real handy for debugging
	//Nice print to console in formatted tree format
	public default void printAsTree() {
		throw notImplemented(); 		
	}
	
	//------------------------------------------------
	//Optional (For Learning)	
	
	private static RuntimeException notImplemented() {
		return new RuntimeException("Not Implemented");
	}	
	
	

}