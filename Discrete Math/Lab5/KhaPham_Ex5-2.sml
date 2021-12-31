val width = 1000.0;
val height = 1000.0;
val length = 250.0;
val scale = 1.0/1.618
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

fun tree2(x, y, length, angle) =
    let
        val x1 = x
        val y1 = y
        val x2 = x 
        val y2 = y
        val outString = "";
        val ang1 = angle;
        val ang2 = angle;
        val len = length;
        in 
            x2 := x + len * (Math.cos ang);
            y2 := y + len * (Math.sin ang);
            outString := "<line x1='" ^ Real.toString x ^ "'"
                ^ " y1='" ^ Real.toString y ^ "'"
                ^ " x2='" ^ Real.toString x2 ^ "'"
                ^ " y2='" ^ Real.toString y2 ^ "'"
                ^ " style='stroke:black;stroke-width:1'/> \n";
                TextIO.output(outfile, outString);

            while(len > 1.0) do
                ang1 := ang1 + Math.pi/5.0
                x2 := x1 + len * (Math.cos angle);
                y2 := y1 + len * (Math.sin angle);
                outString := "<line x1='" ^ Real.toString x1 ^ "'"
                ^ " y1='" ^ Real.toString y1 ^ "'"
                ^ " x2='" ^ Real.toString x2 ^ "'"
                ^ " y2='" ^ Real.toString y2 ^ "'"
                ^ " style='stroke:black;stroke-width:1'/> \n";
                TextIO.output(outfile, outString);

                ang2 := ang2 - Math.pi/5.0;
                x2 := x1 + len * (Math.cos angle);
                y2 := y1 + len * (Math.sin angle);
                outString := "<line x1='" ^ Real.toString x1 ^ "'"
                ^ " y1='" ^ Real.toString y1 ^ "'"
                ^ " x2='" ^ Real.toString x2 ^ "'"
                ^ " y2='" ^ Real.toString y2 ^ "'"
                ^ " style='stroke:black;stroke-width:1'/> \n";
                TextIO.output(outfile, outString);

                len := len*scale;
                x1 := x2;
                y1 := y2;
            end
            
        end
                
