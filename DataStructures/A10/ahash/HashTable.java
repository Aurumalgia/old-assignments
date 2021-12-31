package ahash;

import dict.HashTableIdea;


import java.util.List;
import java.util.function.Function;
import java.util.function.Supplier;
import linear.*;
import java.lang.Math;

public class HashTable<K, V> implements HashTableIdea<K, V> {
    private DynamicArray<LinkedList<Association>> hashArray;
    private int capacity;
    private double maxLoadRatio;
    private int elemCount = 0;


    public HashTable(){
        this.maxLoadRatio = 0.75;
        this.capacity = 10;
        this.hashArray = new DynamicArray<LinkedList<Association>>(10, 2);
        makeTable(hashArray, capacity);
    }

    public HashTable(int initialCapacity, double maxLoadRatio){
        this.maxLoadRatio = maxLoadRatio;
        this.capacity = initialCapacity;
        this.hashArray = new DynamicArray<LinkedList<Association>>(initialCapacity, 2);
        makeTable(hashArray, capacity);
    }

    private void makeTable(DynamicArray<LinkedList<Association>> array, int capacity){
        for(int i = array.size(); i < array.getCapacity(); i++){
            array.add(new LinkedList<Association>());
        }
    }



    @Override
    public int length() {
        return hashArray.getCapacity();
    }

    @Override
    public V get(K key) {
        int hash = Math.abs(key.hashCode());
        int index = hash % capacity;
        for(int i = 0; i < hashArray.get(index).size(); i++){
            if(key == hashArray.get(index).get(i).getKey()){
                return (V) hashArray.get(index).get(i).getValue();
            }
        }
        return null;
    }

    @Override
    public V put(K key, V value) {
        checkReHash();
        int hash = Math.abs(key.hashCode());
        int index = hash % capacity;
        hashArray.get(index).add(new Association(key, value));
        elemCount++;
        return value;
    }

    @Override
    public V removeKey(K key) {
        int hash = Math.abs(key.hashCode());
        int index = hash % capacity;
        Association as = null;
        for(int i = 0; i < hashArray.get(index).size(); i++){
            if (hashArray.get(index).get(i).getKey() == key){
                as = hashArray.get(index).get(i);
            }
        }
        if (as != null) {
            elemCount --;
            return (V) hashArray.get(index).remove(as).getValue();
        }
        return null;
    }

    @Override
    public int size() {
        return elemCount;
    }

    @Override
    public boolean containsKey(K key) {
        int hash = key.hashCode();
        int index = hash % capacity;
        for(int i = 0; i < hashArray.get(index).size(); i++){
            if(hashArray.get(index).get(i).getKey() == key){
                return true;
            }
        }
        return false;
    }

    @Override
    public V getIfAbsentPut(K key, Function<K, V> provider) {
        V result = get(key);
        if (result == null){
            result = put(key, provider.apply(key));
        }
        return result;
    }

    @Override
    public V removeKeyIfAbsent(K key, Supplier<V> supplier) {
        V result = removeKey(key);
        if (result == null){
            result = supplier.get();
        }
        return result;
    }

    private void checkReHash(){
        if ((double)elemCount/(double)length() > maxLoadRatio){
            rehash();
        }
    }
    
    private void rehash(){
        System.out.println("Rehashing...");
        DynamicArray<LinkedList<Association>> newArray = new DynamicArray<LinkedList<Association>>(capacity*2, 2);
        makeTable(newArray, capacity*2);
        capacity = capacity*2;
        for (LinkedList<Association> l: hashArray) {
            if(l.size() > 0) {
                for (Association data : l) {
                    if (data != null) {
                        int index = Math.abs(data.hashCode() % newArray.getCapacity());
                        newArray.get(index).add(new Association(data.getKey(), data.getValue()));
                        System.out.println(data);
                    }
                }
            }
        }
        hashArray = newArray;



    }

}
