package linear1;

import java.util.Arrays;

public class DynamicArray<E> {

    private E element;
    private E[] array;
    private int size;

    public DynamicArray(){
        this.size = 0;
        this.array = (E[]) new Object[10];
    }

    public void add (E element){
        if (getCapacity() == 0 || getElements() == null || getCapacity() <= size){
            this.array = grow(array);
        }
        this.size++;
        array[size-1] = element;
    }

    public int getSize(){
        return this.size;
    }

    public int getCapacity(){
        return array.length;
    }

    public E[] getElements(){
        return this.array;
    }

    public E get(int index){
        if (index >= getCapacity() || index < 0){
            throw new RuntimeException("Invalid index - index out of bounds.");
        }
        else
            return this.array[index];
    }

    public E[] grow(E[] oldArray){
        E[] newArray = (E[]) new Object[this.size+10];
        for(int i = 0; i < oldArray.length; i++){
            newArray[i] = oldArray[i];
        }
        return newArray;
    }

    @Override
    public String toString() {
        return Arrays.toString(array);
    }
}
