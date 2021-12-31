
import ss.*;

public class test {
    public static <T> void main(String[] args) {
        StructureFactory sf = new StructureFactory();
        BagStructure linkedStack = StructureFactory.newArrayedBag();

        linkedStack.add(23);
        linkedStack.add("hello");
        linkedStack.add(3.145);
        System.out.println(linkedStack.toString());
        System.out.println(linkedStack.any());
        System.out.println(linkedStack.any());
        System.out.println(linkedStack.any());
        System.out.println(linkedStack.any());



    }

}
