package linear1;

public class EllipseDynamicArray {

    private Ellipse[] ellipses;
    private int size;

    public EllipseDynamicArray(){
        this.size = 0;
    }

    public void add (Ellipse ellipse){
        if (getCapacity() == 0 || getEllipses() == null || getCapacity() <= size){
            this.ellipses = grow(ellipses);
        }
        ellipses[size-1] = ellipse;
        this.size++;
    }

    public int getSize(){
        return this.size;
    }

    public int getCapacity(){
        return ellipses.length;
    }

    public Ellipse[] getEllipses(){
        return this.ellipses;
    }

    public Ellipse get(int index){
        if (index > getCapacity() || index < 0){
            throw new RuntimeException("Invalid index - index out of bounds.");
        }
        else
            return this.ellipses[index];
    }

    public Ellipse[] grow(Ellipse[] oldArray){
        Ellipse[] newArray = new Ellipse[this.size+10];
        for(int i = 0; i < oldArray.length; i++){
            newArray[i] = oldArray[i];
        }
        return newArray;
    }
}
