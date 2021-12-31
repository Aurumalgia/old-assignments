package iter;
import linear1.DynamicList;
import linear1.StructureIterator;

public class DynArrayIterator<T> implements StructureIterator {
    DynamicList<T> list;
    int nextIndex;

    public DynArrayIterator(DynamicList<T> list, int nextIndex){
        this.list = list;
        this.nextIndex = nextIndex;
    }

    public DynArrayIterator(DynamicList<T> list){
        this.list = list;
        nextIndex = 0;
    }
    @Override
    public Object next() {
        if (hasNext()){
            nextIndex++;
            return list.get(nextIndex);
        }
        return null;
    }

    @Override
    public Object peek() {
        if (hasNext()){
            return list.get(nextIndex + 1);
        }
        return null;
    }

    @Override
    public boolean hasNext() {
        try{
            list.get(nextIndex + 1);
            return true;
        }
        catch (Exception e){
            return false;
        }
    }
}
