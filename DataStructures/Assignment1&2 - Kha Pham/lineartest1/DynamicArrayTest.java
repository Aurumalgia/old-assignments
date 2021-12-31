package lineartest1;
import linear1.*;

public class DynamicArrayTest {
    public static void main(String[] args) {
        DynamicArrayTest D = new DynamicArrayTest();
        D.testAddAndGet();
        D.testGrow();
        D.testSize();
    }


    public void testAddAndGet(){
        DynamicArray test = new DynamicArray();
        Point point = new Point(10, 5);
        System.out.println("testAdd - Start:" + test);
        test.add(point);
        System.out.println("testAdd - After Add: " + test);
        test.add(new Point(5, 63));
        System.out.println("testAdd - 2nd Add: "+ test);
        System.out.println("Testing Get at Loc 0 - " + test.get(0));
        System.out.println("Testing Get at Loc 1 - " + test.get(1));
        System.out.println("Testing Get at Loc 4 - " + test.get(4));
        System.out.println("\n");
    }

    public void testGrow(){
        DynamicArray test = new DynamicArray();
        for (int i = 0; i<10; i++){
            test.add(i);
        }
        System.out.println("testGrow - initial array: "+test);
        test.add(10);
        System.out.println("testGrow - after add when full:"+test);
        System.out.println("\n");

    }

    public void testSize(){
        DynamicArray test = new DynamicArray();
        Ellipse ellipse = Ellipse.fromCenterAB(new Point(1, 2), 5, 10);
        test.add(ellipse);
        System.out.println("testSize - Initial Array:" + test);
        System.out.println("testSize - Initial Size: " + test.getSize());
        test.add(Ellipse.fromCenterAB(new Point(3, 5), 1, 5));
        test.add(Ellipse.fromCenterAB(new Point(4, 5), 2, 5));
        test.add(Ellipse.fromCenterAB(new Point(5, 5), 3, 5));
        System.out.println("testSize - Array after Add: " + test);
        System.out.println("testSize - Size after Add: " + test.getSize());
        System.out.println("\n");

    }



}
