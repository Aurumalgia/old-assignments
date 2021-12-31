package iter;

import linear.DynamicList;
import linear.StructureIterator;

public class DynArrayRevIterator<T> implements StructureIterator {
    DynamicList<T> list;
    int nextIndex;

    public DynArrayRevIterator(DynamicList<T> list, int nextIndex){
        this.list = list;
        this.nextIndex = nextIndex;
    }

    public DynArrayRevIterator(DynamicList<T> list){
        this.list = list;
        nextIndex = 0;
        while (hasNext()){
            nextIndex++;
        }
    }


    @Override
    public Object next() {
        if (hasNext()){
            return(list.get(--nextIndex));
        }
        return null;
    }

    @Override
    public Object peek() {
        if (hasNext()){
            return(list.get(nextIndex-1));
        }
        return null;
    }

    @Override
    public boolean hasNext() {
        try{
            list.get(nextIndex-1);
            return true;
        }
        catch (Exception e){
            return false;
        }
    }
}
