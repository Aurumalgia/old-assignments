(* Program name: lab_1-1a.sml *)
(* Author: bgoat *)
(* Date: January 31, 1889 *)

val myName = "bgoat";
val year = 1889;
val monthDay = "January 31";
val date = monthDay ^ ", " ^ Int.toString(year);
print "\n";
val output = "\n\tMy name is " ^ myName ^ ".\n\tThe date is " ^ date;
print "\n";
print output;
print "\n"
