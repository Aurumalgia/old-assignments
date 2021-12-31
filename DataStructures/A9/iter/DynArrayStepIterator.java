package iter;

import linear.DynamicList;
import linear.StructureIterator;

public class DynArrayStepIterator<T> implements StructureIterator {
    DynamicList<T> list;
    int nextIndex;
    int step;

    public DynArrayStepIterator(DynamicList<T> list, int nextIndex, int step){
        this.list = list;
        this.nextIndex = nextIndex;
        this.step = step;
    }

    public DynArrayStepIterator(DynamicList<T> list){
        this.list = list;
        this.nextIndex = 0;
        this.step = 1;
    }

    @Override
    public Object next() {
        if (hasNext()){
            nextIndex += step;
            return list.get(nextIndex);
        }
        return null;
    }

    @Override
    public Object peek() {
        if (hasNext()){
            return list.get(nextIndex + step);
        }
        return null;
    }

    @Override
    public boolean hasNext() {
        try{
            list.get(nextIndex  + step);
            return true;
        }
        catch (Exception e){
            return false;
        }
    }
}

