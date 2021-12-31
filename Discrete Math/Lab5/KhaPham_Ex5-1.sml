(* treeFractal.sml, making a SVG tree in tree.html. View in Browser.
    Credits to Jack Pope
*)

(*Image Dimention*)
val width = 1000.0;
val height = 1000.0;
val length = 250.0;
val scale = 1.0/1.4
;

val header = "<!DOCTYPE html><html><body><svg width = '1500' height = '1500' version = '1.1' xmlns='http://www.w3.org/2000/svg'>\n";
val footer = "</svg></body></html>";
val outfile = TextIO.openOut "KhaPham_EX5-1Output.html";

fun tree(x, y, length, angle) =
    if length > 1.0 then(
        let
            val x2 = x + length * (Math.cos angle)
            val y2 = y + length * (Math.sin angle)
            val outString = "<line x1='" ^ Real.toString x ^ "'"
                    ^ " y1='" ^ Real.toString y ^ "'"
                    ^ " x2='" ^ Real.toString x2 ^ "'"
                    ^ " y2='" ^ Real.toString y2 ^ "'"
                    ^ " style='stroke:black;stroke-width:1'/> \n"
        in
            print(outString);
            TextIO.output(outfile, outString);

            tree(x2, y2, length*scale, angle+Math.pi/5.0);
            tree(x2, y2, length*scale, angle-Math.pi/5.0)
            end
    )
    else();

    TextIO.output(outfile, header);
    tree(width/2.0, height, length, 3.0*Math.pi/2.0);
    TextIO.output(outfile, footer);
    TextIO.closeOut outfile;
