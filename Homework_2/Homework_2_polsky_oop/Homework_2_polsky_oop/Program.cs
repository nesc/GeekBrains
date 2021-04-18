using System;

namespace Homework_2_polsky_oop
{
    class Element
    {
        public string symbol;
        public string type;

        public Element(string symbol)
        {
            this.symbol = symbol;
        }

        public void Initialization()
        {
            if (symbol == "+"
             || symbol == "-"
             || symbol == "*"
             || symbol == "/")
            {
                type = "Operation";
            }
            if (symbol == "1"
             || symbol == "2"
             || symbol == "3"
             || symbol == "4"
             || symbol == "5"
             || symbol == "6"
             || symbol == "7"
             || symbol == "8"
             || symbol == "9"
             || symbol == "0")
            {
                type = "Number";
            }
            if (symbol == "("
             || symbol == ")")
            {
                type = "Bracket";
            }
        }
    }

    class Result
    {
        protected string inner_string = "";
        public float result = 0;

        public Result(string inner_string) { this.inner_string = inner_string; }

        public void Calculate_result()
        {
            float operand1 = 0;
            float operand2 = 0;
            float operand3 = 0;
            float operand4 = 0;
            float operand5 = 0;
            int found = 0;

            for (int i = 0; i < inner_string.Length; i++)
            {
                Element resultElement = new Element(inner_string[i].ToString());
                resultElement.Initialization();

                if (resultElement.type == "Number")
                {
                    if (found == 0 && operand1 == 0)
                    { operand1 = inner_string[i] - '0'; found = 1; }
                    if (found == 0 && operand1 != 0 && operand2 == 0)
                    { operand2 = inner_string[i] - '0'; found = 1; }
                    if (found == 0 && operand1 != 0 && operand2 != 0 && operand3 == 0)
                    { operand3 = inner_string[i] - '0'; found = 1; }
                    if (found == 0 && operand1 != 0 && operand2 != 0 && operand3 != 0 && operand4 == 0)
                    { operand4 = inner_string[i] - '0'; found = 1; }
                    if (found == 0 && operand1 != 0 && operand2 != 0 && operand3 != 0 && operand4 != 0 && operand5 == 0)
                    { operand5 = inner_string[i] - '0'; }
                    found = 0;
                }

                if (resultElement.type == "Operation")
                {
                    if (resultElement.symbol == "+")
                    {
                        if (found == 0 && operand5 != 0)
                        { operand4 = (operand4 + operand5); operand5 = 0; found = 1; }
                        if (found == 0 && operand4 != 0)
                        { operand3 = (operand3 + operand4); operand4 = 0; found = 1; }
                        if (found == 0 && operand3 != 0)
                        { operand2 = (operand2 + operand3); operand3 = 0; found = 1; }
                        if (found == 0 && operand2 != 0)
                        { operand1 = (operand1 + operand2); operand2 = 0; found = 1; }
                        if (found == 0 && operand1 != 0) // && result != 0)
                        { result += operand1; operand1 = 0; }
                        found = 0;
                    }
                    if (resultElement.symbol == "-")
                    {
                        if (found == 0 && operand5 != 0)
                        { operand4 = (operand4 - operand5); operand5 = 0; found = 1; }
                        if (found == 0 && operand4 != 0)
                        { operand3 = (operand3 - operand4); operand4 = 0; found = 1; }
                        if (found == 0 && operand3 != 0)
                        { operand2 = (operand2 - operand3); operand3 = 0; found = 1; }
                        if (found == 0 && operand2 != 0)
                        { operand1 = (operand1 - operand2); operand2 = 0; found = 1; }
                        if (found == 0 && operand1 != 0) // && result != 0)
                        { result -= operand1; operand1 = 0; }
                        if (found == 0 && operand1 == 0 && result != 0)
                        { result *= (-1); }
                        found = 0;
                    }
                    if (resultElement.symbol == "*")
                    {
                        if (found == 0 && operand5 != 0)
                        { operand4 = (operand4 * operand5); operand5 = 0; found = 1; }
                        if (found == 0 && operand4 != 0)
                        { operand3 = (operand3 * operand4); operand4 = 0; found = 1; }
                        if (found == 0 && operand3 != 0)
                        { operand2 = (operand2 * operand3); operand3 = 0; found = 1; }
                        if (found == 0 && operand2 != 0)
                        { operand1 = (operand1 * operand2); operand2 = 0; found = 1; }
                        if (found == 0 && operand1 != 0) // && result != 0)
                        { result *= operand1; operand1 = 0; }
                        found = 0;
                    }
                    if (resultElement.symbol == "/")
                    {
                        if (found == 0 && operand5 != 0)
                        { operand4 = (operand4 / operand5); operand5 = 0; found = 1; }
                        if (found == 0 && operand4 != 0)
                        { operand3 = (operand3 / operand4); operand4 = 0; found = 1; }
                        if (found == 0 && operand3 != 0)
                        { operand2 = (operand2 / operand3); operand3 = 0; found = 1; }
                        if (found == 0 && operand2 != 0)
                        { operand1 = (operand1 / operand2); operand2 = 0; found = 1; }
                        if (found == 0 && operand1 != 0)
                        { result /= operand1; operand1 = 0; }
                        found = 0;
                    }
                }
            }
            if (result == 0 && operand1 != 0)
                result = operand1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string mode;
            string input_line = "";
            string output_line = "";
            string[] array_symbols = new string[100];
            int array_open = 0;
            int array_closed = 0;
            string array_symbols_out;
            string Operation_i = "";
            string Operation_j = "";
            float result = 0;

            Console.WriteLine("Укажите пожалуйста режим работы:\n1 - Своя формула (бой)\n2- Предзаполнение (тест) [2 / (3 + 2) * 5]");
            mode = Console.ReadLine();

            if (mode == "1")
            {
                Console.WriteLine("Введите пожалуйста математическое выражение:");
                input_line = Console.ReadLine();
            }
            else if (mode == "2")
            {
                input_line = "2 / (3 + 2) * 5";
                Console.WriteLine("Проверяем работу программы на выражении {0}", input_line);
            }

            if (input_line == "")
                Console.WriteLine("Строка выражения пустая, обработка невозмможна");

            if (input_line != "")
            {
                Console.WriteLine("Берем в обработку {0}", input_line);

                for (int i = 0; i < input_line.Length; i++)
                {
                    Element thisElement = new Element(input_line[i].ToString());
                    thisElement.Initialization();
                    //Если стек не открыт или закрыт
                    if (array_open == array_closed)
                    {
                        //Если найдено число кладем в строку вывода
                        if (thisElement.type == "Number")
                        {
                            output_line += thisElement.symbol + " ";

                            //Если нам встретилась в прошлой итерации математическая операция, мы ее кладем после текущего числа
                            if (Operation_i != "")
                            {
                                output_line += Operation_i + " ";
                                Operation_i = "";
                            }
                        }

                        //Если математическая операция
                        if (thisElement.type == "Operation")
                        {
                            if (Operation_i != "")
                            {
                                output_line += Operation_i + " ";
                                Operation_i = thisElement.symbol;
                            }
                            else
                                Operation_i = thisElement.symbol;
                        }
                    }

                    //Если открыт хотя бы один стек и не закрыт
                    if (array_open != 0 || array_open != array_closed)
                    {
                        //Если найдено число или математическая операция кладем в стек
                        if (thisElement.type == "Number" || thisElement.type == "Operation")
                            array_symbols[array_open] += thisElement.symbol;
                    }


                    //Если скобка открывается - объявляем стек
                    if (thisElement.symbol == "(")
                        array_open += 1;

                    //Если скобка закрывается - закрываем стек и разбираем его сразу
                    if (thisElement.symbol == ")")
                    {
                        array_closed += 1;
                        //собираем строку из стека
                        array_symbols_out = array_symbols[array_closed];
                        //Пройдем по полученной строке и разберем ее
                        for (int j = 0; j < array_symbols_out.Length; j++)
                        {
                            Element otherElement = new Element(array_symbols_out[j].ToString());
                            otherElement.Initialization();
                            //Если найдено число кладем в строку вывода
                            if (otherElement.type == "Number")
                            {
                                output_line += otherElement.symbol + " ";
                                //Если нам встретилась в прошлой итерации математическая операция, мы ее кладем после текущего числа
                                if (Operation_j != "")
                                {
                                    output_line += Operation_j + " ";
                                    Operation_j = "";
                                }
                            }

                            //Если математическая операция
                            if (otherElement.type == "Operation")
                            {
                                Operation_j = otherElement.symbol;
                            }
                            //Console.WriteLine("(6)Итерация i = {0} result_i = {1}, result_j = {2}, input_line[i] = {3}", i, result_i, result_j, input_line[i]);
                        }
                    }
                }

                Result getResult = new Result(output_line);
                getResult.Calculate_result();
                result = getResult.result;

                Console.WriteLine(output_line + "\n" + result);
                Console.ReadKey();
            }
        }
    }
}
