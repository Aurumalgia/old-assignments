package linear;
import iter.*;

import java.util.*;

public class DynamicArray<E> implements DynamicList<E>, IterableStructure<E> {
    private int anInitialCapacity;
    private int aGrowthFactor;
    private E element;
    private E[] array;
    private int size;

    public DynamicArray (int anInitialCapacity, int aGrowthFactor){
        this.size = 0;
        this.anInitialCapacity= anInitialCapacity;
        this.array = (E[]) new Object[anInitialCapacity];
        this.aGrowthFactor = aGrowthFactor;
    }

    public DynamicArray(){
        this.aGrowthFactor = 2;
        this.anInitialCapacity = 10;
        this.array = (E[]) new Object[anInitialCapacity];
    }



    @Override
    public int size() {
        return this.size;
    }

    @Override
    public boolean isEmpty() {
        if (this.size == 0){
            return true;
        }
        else
            return false;
    }

    @Override
    public E get(int index) {
        if (getElements().length -1 < index){
            throw new IndexOutOfBoundsException("Index Out of Bounds");
        }
        else
            return getElements()[index];
    }

    @Override
    public DynamicList subList(int start, int stop) {
        if (start < 0 || stop > size() -1 || stop <= start){
            throw new IndexOutOfBoundsException("Index Out of Bounds, or Indexes aren't ordered correctly");
        }
        else {
            DynamicArray sublist = new DynamicArray();
            for (int i = 0; i < stop - start; i++) {
                sublist.add(this.array[i + start]);
            }
            return sublist;
        }
    }

    @Override
    public E first() {
        if (size() == 0){
            throw new RuntimeException("Can't find first index of a list of nothing!");
        }
        else {
            return this.array[0];
        }
    }

    @Override
    public E last() {
        if (size() == 0){
            throw new RuntimeException("Can't find last index of a list of nothing!");
        }
        else {
            return this.array[this.array.length - 1];
        }
    }

    @Override
    public boolean contains(E searchElement) {
        for(int i = 0; i < this.array.length; i++){
            if (this.array[i] == searchElement){
                return true;
            }
        }
        return false;
    }

    @Override
    public void addFirst(E newData) {
        if (getCapacity() == size())
            grow();
        E[] newArray = (E[]) new Object[getCapacity()];
        for (int i = 0; i < size; i++){
            newArray[i+1] = this.array[i];
        }
        newArray[0] = (E) newData;
        this.array = newArray;
        this.size++;
    }

    @Override
    public void addLast(E newData) {
        add(newData);
    }

    @Override
    public void add(E newData) {
        if (getCapacity() == 0 || getElements() == null || getCapacity() <= size){
            grow();
        }
        this.size++;
        array[size-1] = element;
    }

    @Override
    public void addBefore(E searchElement, E newData) {
        int index = search((E) searchElement, this.array);
        if (index == -1){
            throw new RuntimeException("Object not found");
        }
        else {
            insert(index, newData);
            this.size++;
        }
    }

    @Override
    public void addAfter(E searchElement, E newData) {
        int index = search((E) searchElement, this.array);
        if (index == -1){
            throw new RuntimeException("Object not found");
        }
        else {
            insert(index + 1, newData);
            this.size++;
        }
    }

    @Override
    public void replace(E oldData, E newData) {
       int index  = search((E) oldData, this.array);
       if (index == -1){
           throw new RuntimeException("Object not found");
       }
       else if (index >= 0){
           this.array[index] = (E) newData;
       }
    }

    @Override
    public void insert(int index, E newData) {
        if (size() == getCapacity()){
            grow();
        }
        if (index < 0 || index > size()){
            throw new IndexOutOfBoundsException("Index out of Bounds");
        }
        else {
            for (int i = size() - 1; i >= index; i++) {
                this.array[i + 1] = this.array[i];
            }
            this.array[index] = (E) newData;
            this.size++;
        }
    }

    @Override
    public void clear() {
        this.array = (E[]) new Object [this.anInitialCapacity];
        this.size = 0;
    }

    @Override
    public E remove(E data) {
        int index = search((E) data, this.array);
        if (index != -1){
            return removeIndex(index);
        }
        return null;
    }

    @Override
    public E removeFirst() {
        if(size() == 0){
            throw new RuntimeException("Can't remove something from a list of nothing!");
        }
        else {
            E removeObject = this.array[0];
            for (int i = 0; i < size() - 1; i++) {
                this.array[i] = this.array[i + 1];
            }
            this.array[size-1] = null;
            size--;
            return removeObject;
        }
    }

    @Override
    public E removeLast() {
        if(size() == 0){
            throw new RuntimeException("Can't remove something from nothing!");
        }
        else {
            E object = this.array[size() - 1];
            this.array[size() - 1] = null;
            this.size--;
            return object;
        }
    }

    @Override
    public E removeIndex(int index) {
        if(index < 0 || index > size-1){
            throw new IndexOutOfBoundsException("Index out of bounds");
        }
        else{
            E data = this.array[index];
            for(int i = index; i < size()-1; i++){
                this.array[i] = this.array[i+1];
            }
            this.size--;
            this.array[size()-1] = null;
            return data;
        }
    }

    @Override
    public StructureIterator<E> toIterator() {
        return new DynArrayIterator<E>(this);
    }

    @Override
    public List toJavaList() {
        List<E> list = new ArrayList<>();
        for (E e : this.array){
            list.add(e);
        }
        return list;
    }


    public int getCapacity(){
        return array.length;
    }

    public E[] getElements(){
        return this.array;
    }

    public void grow(){
        E[] newArray = (E[]) new Object[this.size+10];
        for(int i = 0; i < this.array.length; i++){
            newArray[i] = this.array[i];
        }
    }

    @Override
    public String toString() {
        String s = "[";
        for(int i=size-1; i>0; i--){
            s += array[i] + ", ";
        }
        s += array[0] + "]";
        return s;
    }

    public int search(E object, E[] array){
        Boolean match = false;
        int i = 0;
        int index = -1;
        while (!match && i < array.length -1){
            if (array[i] == object){
                index = i;
                match = true;
            }
        }

        return index;
    }

}

