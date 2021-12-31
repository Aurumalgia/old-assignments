(* Program name: lab_1-1b.sml *)
(* Author: Kha Pham *)
(* Date: September 6, 2020*)

val myName = "Kha";
val year = 2020;
val monthDay = "September 6";
val date = monthDay ^ ", " ^ Int.toString(year);
print "\n";
val output = "\n\tMy name is " ^ myName ^ ".\n\tThe date is " ^ date;
print "\n";
print output;
print "\n"

(*Line 5, 6, and 7 just initialize and set a variable to an... input? that's not the right word, but I think you'll understand what I mean b that.
Line 8 initializes Date, and sets it to monthDay, using SMl's concatenator, ^.
Line 9 just outputs an empty line.
Line 10 sets output to a concatenation of all other variables in a sentence
Lines 11-13 print out more lines, consisting of text surrounded by 2 blank lines.  
*)

