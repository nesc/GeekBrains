module File1

open System.Text.RegularExpressions

let inline charToInt c = int c - int '0'
let inline charToIntDec c = (int c - int '0') * 10

let (|Regex|_|) regex input = 
  let res = Regex.Match(input, regex)
  if res.Success then Some (List.tail [for g in res.Groups -> g.Value])
  else None

let calculate_polsky (input_string) =     
    let mutable continueLooping = true
    let mutable input_string = input_string
    let mutable i = 0
    while continueLooping do
       if (Regex.IsMatch(input_string, "^([0-9])([ ])([0-9])([ ])([\+])")) then 
           let left = input_string.Chars(0) |> charToInt in let right = input_string.Chars(2) |> charToInt in let result = left + right
           input_string <- result.ToString() + input_string.[5..]           
       if (Regex.IsMatch(input_string, "^([0-9])([ ])([0-9])([ ])([\-])")) then 
           let left = input_string.Chars(0) |> charToInt in let right = input_string.Chars(2) |> charToInt in let result = left - right
           input_string <- result.ToString() + input_string.[5..]           
       if (Regex.IsMatch(input_string, "^([0-9])([ ])([0-9])([ ])([\*])")) then 
           let left = input_string.Chars(0) |> charToInt in let right = input_string.Chars(2) |> charToInt in let result = left * right
           input_string <- result.ToString() + input_string.[5..]           
       if (Regex.IsMatch(input_string, "^([0-9])([ ])([0-9])([ ])([\/])")) then 
           let left = input_string.Chars(0) |> charToInt in let right = input_string.Chars(2) |> charToInt in let result = left / right
           input_string <- result.ToString() + input_string.[5..]           
       if (Regex.IsMatch(input_string, "^[0-9]{2}[ ][0-9][ ][+]")) then 
           let leftDec = input_string.[0] |> charToIntDec in let leftEd = input_string.[1] |> charToInt in let left = leftDec + leftEd in let right = input_string.[3] |> charToInt in let result = left + right
           input_string <- result.ToString() + input_string.[6..]           
       if (Regex.IsMatch(input_string, "^[0-9]{2}[ ][0-9][ ][+]")) then 
           let leftDec = input_string.[0] |> charToIntDec in let leftEd = input_string.[1] |> charToInt in let left = leftDec + leftEd in let right = input_string.[3] |> charToInt in let result = left - right
           input_string <- result.ToString() + input_string.[6..]           
       if (Regex.IsMatch(input_string, "^[0-9]{2}[ ][0-9][ ][+]")) then 
           let leftDec = input_string.[0] |> charToIntDec in let leftEd = input_string.[1] |> charToInt in let left = leftDec + leftEd in let right = input_string.[3] |> charToInt in let result = left * right
           input_string <- result.ToString() + input_string.[6..]           
       if (Regex.IsMatch(input_string, "^[0-9]{2}[ ][0-9][ ][+]")) then 
           let leftDec = input_string.[0] |> charToIntDec in let leftEd = input_string.[1] |> charToInt in let left = leftDec + leftEd in let right = input_string.[3] |> charToInt in let result = left / right
           input_string <- result.ToString() + input_string.[6..]           
       if not (Regex.IsMatch(input_string, "[ ]")) then
           continueLooping <- false
       printf $"{input_string}"
    0 