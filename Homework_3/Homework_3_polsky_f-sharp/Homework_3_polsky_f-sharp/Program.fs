open System

[<Literal>]
let example = "1 2 + 4 * 3 +"
let main_menu = sprintf "Добро пожаловать в программу по подсчету обратной польской нотации. Посчитаем формулу 1 2 + 4 * 3 +\nНажмите любую кнопку"
  
[<EntryPoint>]
let main argv =
    printf "\n%s" main_menu
    let ansver = Console.ReadLine();
    printf $"{example}\n"
    File1.calculate_polsky(example) 
    0

