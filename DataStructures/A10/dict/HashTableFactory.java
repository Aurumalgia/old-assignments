/*
class: HashTableFactory
12/8/2020
Constructs and returns new hash tables
*/

package dict;

import ahash.HashTable;

public class HashTableFactory {

	public static <K, V> HashTableIdea<K, V> newHashTable(
			int initialCapacity, double maxLoadRatio) {
		return new HashTable<K, V>(initialCapacity, maxLoadRatio);
	}

	public static <K, V> HashTableIdea<K, V> newHashTable() {
		return new HashTable<K, V>();
	}

}
