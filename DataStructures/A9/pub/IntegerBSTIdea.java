package pub;
/*
Class: IntegerBSTIdea

The terms "elem" and "data" are used interchangeably

This is a simplified BST that does NOT have generics. It only 
handles Integer data.

This facilitates getting familiar with the mechanics of trees, 
and tinkering with them.

Data should be added into the tree like this:

	If newData is less than data at an existing node,
		- The newData should go to the LEFT
		- Otherwise to the right
	
Duplicates are allowed	
	
Reminder: 

	Integer "is-a" comparable.
	Thus we can do the following.
	Given Integer a, b
		int compareResult = a.compareTo(b);
		compareResult will be:
			Negative if a is less than b
			Zero if a is equal than b		
			Positive if a is greater than b
			
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

public interface IntegerBSTIdea {

	//Add elem (data) into tree in correct position (see above)
	//Note: We're also going to learn "method cascading" here
	//To support "method cascading", simply return the tree itself
	//from this method -- e.g. "return this"
	public IntegerBSTIdea add(Integer elem);

	//-------------------------------------------------
	//Tree Traversal Methods
	//See note labeled "Visit" at top of this file
	
	//Visit the tree using "in-order" traversal	
	public void visitInOrder(Consumer<Integer> visitFct);
	
	//Visit the tree using "pre-order" traversal	
	public void visitPreOrder(Consumer<Integer> visitFct);
	
	//Visit the tree using "post-order" traversal	
	public void visitPostOrder(Consumer<Integer> visitFct);
	
	//-------------------------------------------------	

	//Return height of tree (max number of node levels)
	public int height();

	//Return true if tree is empty, otherwise false
	boolean isEmpty();

	//Return the first match of the passed parameter (data)
	public Integer search(Integer elem);
	
	//Return true if the tree contains the passed param (data)
	public boolean contains(Integer elem);

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
	
	//Remove the elem	
	public default void remove(Integer elem) {
		throw notImplemented();
	}
	
	//Return iterator for tree using "in-order" traversing
	//After construction, the first "next" sent to the iterator
	//should return the first node relative to "in-order" 
	public default StructureIterator<Integer> toIterator() {
		throw notImplemented(); 		
	}

	//Return iterator for tree using "pre-order" traversing
	//After construction, the first "next" sent to the iterator
	//should return the first node relative to "pre-order"	
	public default StructureIterator<Integer> toPreOrderIterator() {
		throw notImplemented();		
	}
		
	private static RuntimeException notImplemented() {
		return new RuntimeException("Not Implemented");
	}	

}