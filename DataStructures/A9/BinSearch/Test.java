package BinSearch;

public class Test {
    public static void main(String[] args) {
        IntBinSearch test = new IntBinSearch();

        test.add(85);
        test.add(21);
        test.add(25);
        test.add(102);
        test.add(10);
        System.out.println(test.search(21));
        System.out.println(test.contains(25));
        test.visitInOrder(data -> System.out.println("" + data));
        System.out.println();
        test.visitPreOrder(data -> System.out.println("" + data));
        System.out.println();
        test.visitPostOrder(data -> System.out.println(""+ data));
        System.out.println();
        System.out.println(test.height());
        test.add(5);
        System.out.println(test.height());
        System.out.println(test.search(28));
    }
}
