package linear;

import java.util.List;

public class FlexibleList<T> implements DynamicList<T> {
    @Override
    public int size() {
        return 0;
    }

    @Override
    public boolean isEmpty() {
        return false;
    }

    @Override
    public T get(int index) {
        return null;
    }

    @Override
    public DynamicList subList(int start, int stop) {
        return null;
    }

    @Override
    public T first() {
        return null;
    }

    @Override
    public T last() {
        return null;
    }

    @Override
    public boolean contains(Object searchElement) {
        return false;
    }

    @Override
    public void addFirst(Object newData) {

    }

    @Override
    public void addLast(Object newData) {

    }

    @Override
    public void add(Object newData) {

    }

    @Override
    public void clear() {

    }

    @Override
    public T remove(T data) {
        return null;
    }

    @Override
    public T removeFirst() {
        return null;
    }

    @Override
    public T removeLast() {
        return null;
    }

    @Override
    public List toJavaList() {
        return null;
    }

    @Override
    public StructureIterator<T> toIterator() {
        return null;
    }

    @Override
    public void addBefore(T searchElement, T newData) {

    }

    @Override
    public void addAfter(T searchElement, T newData) {

    }

    @Override
    public void replace(T oldData, T newData) {

    }

    @Override
    public void insert(int index, T newData) {

    }

    @Override
    public T removeIndex(int index) {
        return null;
    }
}
