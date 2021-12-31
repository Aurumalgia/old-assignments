package dict;

/*
DictionaryIdea - The idea for a Dictionary ADT
(Interface) 
*/

import java.util.function.Function;
import java.util.function.Supplier;

import linear.DynamicList;

public interface DictionaryIdea<K, V> {
	
	//-----------------------------------------------
	//Core

	//Return value at key or null if key not found
	public V get(K key);

	//Put "value" at "key", replace if already present
	//Return previous value at key (or null if none) 
	public V put(K key, V value);
	
	//-----------------------------------------------
	//Fundamental	
	
	//Remove key (and value at key)
	//Return previous value
	//If key is not found throw RuntimeException
	public V removeKey(K key);	
	
	//-----------------------------------------------	
	//Convenience
	
	//Return the number of keys in the dictionary 	
	public int size();	
	
	//Return true if dictionary contains key, else false
	public boolean containsKey(K key);	

	//-----------------------------------------------
	//Special	
	
	//If key is found, return value at key
	//If key is not found, construct new value using provider (with key as arg)
	//	and add new value to this lookup, and return new value
	/*Example Usage (lazily constructed -- when needed only):
		spec = ht.getIfAbsentPut(eachName, specName -> new ColorSpec(eachName)); */	
	public V getIfAbsentPut(K key, Function<K, V> provider);
	
	//Just like "removeKey" except if key is not found rather then
	//throwing exception we get value using supplier (and return it)
	/*Example Usage (soft remove -- e.g. "no exception thrown"):
		prev = ht.removeKeyIfAbsent(key, () -> null); */
	public V removeKeyIfAbsent(K key, Supplier<V> supplier);
	
	//-----------------------------------------------
	//Optional (helpful for debugging, etc)
	
	//Return list of all keys
	public default DynamicList<K> keys() { return null; }

}

