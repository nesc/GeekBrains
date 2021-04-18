using System;

namespace Homework_1_Polsky_3_0
{
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
            float operand1 = 0;
            float operand2 = 0;
            float operand3 = 0;
            float operand4 = 0;
            float operand5 = 0;
            int found = 0;

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
                    //Если стек не открыт или закрыт
                    if (array_open == 0 || array_open == array_closed)
                    {
                        //Если найдено число кладем в строку вывода
                        if (input_line[i].ToString() == "0"
                         || input_line[i].ToString() == "1"
                         || input_line[i].ToString() == "2"
                         || input_line[i].ToString() == "3"
                         || input_line[i].ToString() == "4"
                         || input_line[i].ToString() == "5"
                         || input_line[i].ToString() == "6"
                         || input_line[i].ToString() == "7"
                         || input_line[i].ToString() == "8"
                         || input_line[i].ToString() == "9"
                        )
                        {
                            output_line += input_line[i].ToString() + " ";

                            //Если нам встретилась в прошлой итерации математическая операция, мы ее кладем после текущего числа
                            if (Operation_i != "")
                            {
                                output_line += Operation_i + " ";
                                Operation_i = "";
                            } 
                        }

                        //Если математическая операция
                        if (input_line[i].ToString() == "+"
                         || input_line[i].ToString() == "-"
                         || input_line[i].ToString() == "*"
                         || input_line[i].ToString() == "/"
                         )
                        {
                            if (Operation_i != "")
                            {
                                output_line += Operation_i + " ";
                                Operation_i = input_line[i].ToString();
                            }
                            else
                                Operation_i = input_line[i].ToString();
                        }
                    }

                    //Если открыт хотя бы один стек и не закрыт
                    if (array_open > 0 && array_open != array_closed) 
                    {
                            //Если найдено число или математическая операция кладем в стек
                            if (input_line[i].ToString() == "0"
                         || input_line[i].ToString() == "1"
                         || input_line[i].ToString() == "2"
                         || input_line[i].ToString() == "3"
                         || input_line[i].ToString() == "4"
                         || input_line[i].ToString() == "5"
                         || input_line[i].ToString() == "6"
                         || input_line[i].ToString() == "7"
                         || input_line[i].ToString() == "8"
                         || input_line[i].ToString() == "9"
                         || input_line[i].ToString() == "+"
                         || input_line[i].ToString() == "-"
                         || input_line[i].ToString() == "*"
                         || input_line[i].ToString() == "/"
                          )
                        {
                            array_symbols[array_open] += input_line[i].ToString();
                        }
                    }
                    
                    //Если скобка открывается - объявляем стек
                    if (input_line[i].ToString() == "(")
                    {
                        array_open += 1;
                    }

                    //Если скобка закрывается - закрываем стек и разбираем его сразу
                    if (input_line[i].ToString() == ")")
                    {
                        array_closed += 1;
                        //собираем строку из стека
                        array_symbols_out = array_symbols[array_closed];
                        //Пройдем по полученной строке и разберем ее
                        for (int j = 0; j < array_symbols_out.Length; j++)
                        {
                            //Если найдено число кладем в строку вывода
                            if (array_symbols_out[j].ToString() == "0"
                             || array_symbols_out[j].ToString() == "1"
                             || array_symbols_out[j].ToString() == "2"
                             || array_symbols_out[j].ToString() == "3"
                             || array_symbols_out[j].ToString() == "4"
                             || array_symbols_out[j].ToString() == "5"
                             || array_symbols_out[j].ToString() == "6"
                             || array_symbols_out[j].ToString() == "7"
                             || array_symbols_out[j].ToString() == "8"
                             || array_symbols_out[j].ToString() == "9"
                            )
                            {
                                output_line += array_symbols_out[j].ToString() + " ";

                                //Если нам встретилась в прошлой итерации математическая операция, мы ее кладем после текущего числа
                                if (Operation_j != "")
                                {
                                    output_line += Operation_j + " ";
                                    Operation_j = "";
                                }
                            }

                            //Если математическая операция
                            if (array_symbols_out[j].ToString() == "+"
                             || array_symbols_out[j].ToString() == "-"
                             || array_symbols_out[j].ToString() == "*"
                             || array_symbols_out[j].ToString() == "/"
                             )
                            {
                                Operation_j = array_symbols_out[j].ToString();
                            }
                            //Console.WriteLine("(6)Итерация i = {0} result_i = {1}, result_j = {2}, input_line[i] = {3}", i, result_i, result_j, input_line[i]);
                        }
                    }
                }

                for (int i = 0; i < output_line.Length; i++) 
                {
                    if (output_line[i].ToString() != " "
                     && output_line[i].ToString() != "+"
                     && output_line[i].ToString() != "-"
                     && output_line[i].ToString() != "*"
                     && output_line[i].ToString() != "/")
                    {
                        if (found == 0 && operand1 == 0) 
                            {operand1 = output_line[i] - '0'; found = 1; }
                        if (found == 0 && operand1 != 0 && operand2 == 0)
                            { operand2 = output_line[i] - '0'; found = 1; }
                        if (found == 0 && operand1 != 0 && operand2 != 0 && operand3 == 0)
                            { operand3 = output_line[i] - '0'; found = 1; }
                        if (found == 0 && operand1 != 0 && operand2 != 0 && operand3 != 0 && operand4 == 0)
                            { operand4 = output_line[i] - '0'; found = 1; }
                        if (found == 0 && operand1 != 0 && operand2 != 0 && operand3 != 0 && operand4 != 0 && operand5 == 0)
                            { operand5 = output_line[i] - '0';}
                        found = 0;
                    }

                    if (output_line[i].ToString() != " "
                     && (output_line[i].ToString() == "+"
                     || output_line[i].ToString() == "-"
                     || output_line[i].ToString() == "*"
                     || output_line[i].ToString() == "/"))
                    {
                        if (output_line[i].ToString() == "+")
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
                        if (output_line[i].ToString() == "-")
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
                        if (output_line[i].ToString() == "*")
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
                        if (output_line[i].ToString() == "/")
                        {
                            if (found == 0 && operand5 != 0)
                            { operand4 = (operand4 / operand5); operand5 = 0; found = 1; }
                            if (found == 0 && operand4 != 0)
                            { operand3 = (operand3 / operand4); operand4 = 0; found = 1; }
                            if (found == 0 && operand3 != 0)
                            { operand2 = (operand2 / operand3); operand3 = 0; found = 1; }
                            if (found == 0 && operand2 != 0)
                            {operand1 = (operand1 / operand2); operand2 = 0; found = 1; }
                            if (found == 0 && operand1 != 0) // && result != 0)
                            { result /= operand1; operand1 = 0; }
                            found = 0;
                        }
                    }
                }
                if (result == 0 && operand1 != 0)
                    result = operand1;

                Console.WriteLine(output_line + "\n" + result);
                Console.ReadKey();
            }
        }
    }
}
