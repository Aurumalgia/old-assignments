package dict;

/*
 HashTableIdea - The ideas for a hash table
 (Interface)
  NOTE WELL - See super interface for more information  
*/

public interface HashTableIdea<K, V> extends DictionaryIdea<K, V> {
	
	//-----------------------------------------------	
	//Convenience	
	
	//Return the length of the hash table (i.e. the number of "buckets") 	
	public int length();	

}
