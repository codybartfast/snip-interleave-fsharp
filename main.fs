// https://stackoverflow.com/a/55963025/53252

let interleave = Seq.transpose >> Seq.concat

let sequences =
  seq{
      yield seq{ yield "1"; yield "2"; yield "3"; yield "4"; yield "5"};
      yield seq{ yield "FIRST"};
      yield seq{ yield "aaa"; yield "bbb"; yield "ccc"; yield "ddd"; 
                  yield "eee"; yield "fff"; yield "ggg" }
  }

let result = interleave sequences   

System.Console.WriteLine(String.concat ", " result)
