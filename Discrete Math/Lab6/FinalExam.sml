
(*Signatures (and structures) are demonstrated here, then used througout the code*)
open Array
open Substring
open TextIO


fun toNonOption(NONE) = ""
    | toNonOption(SOME a) = a;



(*Basic SQL is shown here*)
val questionType = array(100, "")
val question = array(100, "")
val answer = array(100, "")
val infile = "questionBank.txt";
val ins = openIn infile;
val instringNext = inputLine ins
val firstLine = toNonOption(instringNext)

(*This code demonstates Functions*)
fun createQA (100, _) = false
    |    createQA (n, (inString : string)) =
            let
              fun notc (c : char) = fn c' => c <> c'
              val (qtype, rest) = splitl (notc #"%") (full inString)
              val (q, a) = splitl (notc #"%") (triml 2 rest)
              val _ = update (questionType, n, string (trimr 1 qtype))
              val _ = update (question, n, string (trimr 1 q))
              val _ = update (answer, n, string (triml 2 (trimr 1 a)))
              val instringNext = inputLine ins
              val nextString = toNonOption(instringNext)
            in 
              createQA(n+1, nextString)
            end;

fun arrayToList arr = Array.foldr(op ::) [] arr;

fun printlist l = 
	print("[" ^ String.concatWith ", "  l ^ "] ");

fun printIntList l =
	print("["^(String.concatWith ", " (List.map Int.toString l))^"] ");


createQA(0, firstLine);


(*Jack Pope's random list code*)
fun seed () =
 let
    val aReal = Time.toReal(Time.now()) - 1.0e9
    val floorReal = Real.realFloor(aReal)
    val dec = aReal - floorReal
    val sd1 = Real.floor(dec);
    val sd2 = Real.floor(1000.0 * dec);
  in
     Random.rand(sd1,sd2)
 end;

fun randList (N, UpperBound) = 
  let fun subfun (N, i) intList =
    if N = 0 then intList
    else
      let 
        val tmp = Random.randRange(1, UpperBound)
        val randVal = tmp i
      in subfun (N - 1, i) (randVal :: intList)
      end;
  in subfun (N, seed()) []                      
  end;


fun sort (l) = ListMergeSort.uniqueSort (fn (x, y) => Int.compare(x, y)) l;

val qTemp = array(100, 0);



fun updateArray (array, position, data) =
    let
      val _ = update(array, position, data)
    in
      ()
    end;

fun makeOrderedArray(_, 100) = false
  | makeOrderedArray(array, n) =
    let
      val _ = update(array, n, n+1)
    in 
      makeOrderedArray(array, n+1)
    end;


val rng = seed();

(* select([5,6,7,8,9], 2) = (7, [5,6,8,9]) *)
fun select (y::xs, 0) = (y, xs)
  | select (x::xs, i) = let val (y, xs') = select (xs, i-1) in (y, x::xs') end
  | select (_, i) = raise Fail ("Short by " ^ Int.toString i ^ " elements.")

(* Recreates a list in random order by removing elements in random positions *)
fun shuffle xs =
    let fun rtake [] _ = []
          | rtake ys max =
            let val (y, ys') = select (ys, Random.randRange(0, max-1) rng)
            in y :: rtake ys' (max-1)
            end
    in rtake xs (List.length xs) end;


makeOrderedArray(qTemp, 0);
printIntList(arrayToList qTemp);
val questionOrder = (fromList (shuffle (arrayToList qTemp)));
printIntList (arrayToList questionOrder);

val qType = arrayToList questionType;
val qs = arrayToList question;
val ans = arrayToList answer;
val answerList = arrayToList answer;
val questionsAsked = array(30, 0);
val answered = array(30, "");
val correctOrNot = array(30, false);


fun getAnswer(questionIndex) =(
  let
    val userin = valOf(TextIO.inputLine TextIO.stdIn);
    val inchar = String.sub(userin, 0)
    val correctAnswer = List.nth(ans, List.nth(arrayToList questionOrder, questionIndex));
    val _ = update(questionsAsked, questionIndex, List.nth((arrayToList questionOrder), questionIndex));
    val _ = update(answered, questionIndex, userin);
  in
    print("\n");
    print("You answered: "^String.str inchar^"\n");
    print("The correct answer was: "^correctAnswer^"\n");

    case String.compare(String.str inchar, correctAnswer) of
      EQUAL =>  (updateArray(correctOrNot, questionIndex, true);
                print("Correct!\n");
                true)
      | LESS => (updateArray(correctOrNot, questionIndex, false);
                print("Incorrect...\n");
                false)
      | MORE => (updateArray(correctOrNot, questionIndex, false);
                print("Incorrect...\n");
                false)

  end
);

fun askQuestion(questionIndex, questionNumber) = 
  let
  in
    print(Int.toString(questionNumber)^") "^List.nth(qs, List.nth(arrayToList questionOrder, questionIndex))^"\n~ ");
    getAnswer(questionIndex)
  end;

fun printScore(score, count) =
    if count <> 1 then print("Your current score is: " ^ Int.toString score ^ "\n\n") else ();

(*Propositional logic, is shown here, I believe?*)
fun doTest (_, score, 30, _) = score
  | doTest(count, score, questionNumber, qTypeList) = 
    let
    in
        if List.exists (fn x => x = List.nth(qType, count)) qTypeList andalso List.length qTypeList < 8 andalso List.exists (fn x => x = List.nth(arrayToList questionOrder, count)) (arrayToList questionsAsked) then doTest(count+1, score, questionNumber, qTypeList)
        else(
        printScore(score, questionNumber);
        if askQuestion(count, questionNumber)
        then (
            doTest(count+1, score+1, questionNumber+1, qTypeList @ [List.nth(qType, count)])
        )
        else (
            doTest(count+1, score, questionNumber+1, qTypeList @ [List.nth(qType, count)])
            ))
    end;


fun fullTest =
    let 
        val score = doTest(1, 0, 1, []);
        val output = openAppend results.txt;
    in 
        print("Your final score was: " Int.toString score ^ "/30\n");

