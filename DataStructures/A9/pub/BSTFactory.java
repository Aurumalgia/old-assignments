/*
class: BSTFactory
11/25/20
Constructs and returns new 
binary search (bst) trees 
*/
package pub;

import BinSearch.GenericBST;
import BinSearch.IntBinSearch;

import java.util.Comparator;
import java.util.function.BiFunction;


public class BSTFactory {
	
	public static IntegerBSTIdea newIntegerBST() {
		//Return new binary search tree		
		return new IntBinSearch();
	}
	
	public static <E, K> BSTIdea<E, K> newBST(Comparator<E> sortFct, 
												BiFunction<K, E, Integer> searchFct) {
		//Return new binary search tree
		return new GenericBST<E, K>(sortFct, searchFct);
	}	

}
