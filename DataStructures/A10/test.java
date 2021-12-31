import ahash.HashTable;

import java.time.Duration;
import java.time.Instant;
import java.util.ArrayList;
import java.util.Random;

public class test {
    public static void main(String[] args) {
        Instant start, finish;
        HashTable h = new HashTable();
        ArrayList l = new ArrayList();
        System.out.println("Initializing Arrays");
        for(int i = 0; i < 1000000; i++){
            String r = getSaltString();
            l.add(r);
            h.put(r, i);
            System.out.println(i+": addded "+r);
        }
        System.out.println("Done\nStarting Test");
        start = Instant.now();
        for (Object s :l) {
            h.get(s);
        }
        finish = Instant.now();
        long
                timeElapsedNanos = Duration.between(start, finish).toNanos(),
                timeElapsedMs = Math.round(timeElapsedNanos / 1000000.0);
        double timeElapsedSecs = timeElapsedMs / 1000.0;
        System.out.println(timeElapsedSecs);
    }

    //Random string code from Suresh Atta - https://stackoverflow.com/questions/20536566/creating-a-random-string-with-a-z-and-0-9-in-java
    public static String getSaltString() {
        String SALTCHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        StringBuilder salt = new StringBuilder();
        Random rnd = new Random();
        while (salt.length() < 18) { // length of the random string.
            int index = (int) (rnd.nextFloat() * SALTCHARS.length());
            salt.append(SALTCHARS.charAt(index));
        }
        String saltStr = salt.toString();
        return saltStr;

    }
}
