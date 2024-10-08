using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biba27
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                {
                    Console.Write("Введите первое число (или exit для выхода):");

                    string nameOne = Console.ReadLine();

                    if (nameOne.ToLower() == "exit")
                    {
                        break;
                    }

                    // Преобразование первого числа
                    double numberOne;

                    if (!double.TryParse(nameOne, out numberOne))
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число.");
                        continue;
                    }

                    // Ввод второго числа
                    Console.WriteLine("Введите второе число: ");
                    string nameToo = Console.ReadLine();

                    double numberToo;

                    if (!double.TryParse(nameToo, out numberToo))
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число.");
                        continue;
                    }

                    // Ввод операции
                    Console.WriteLine("Введите операцию (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    // Выполнение операции
                    double result = 0;
                    bool validOperation = true;

                    switch (operation)
                    {
                        case "+":
                            result = numberOne + numberToo;
                            break;
                        case "-":
                            result = numberOne - numberToo;
                            break;
                        case "*":
                            result = numberOne * numberToo;
                            break;
                        case "/":
                            // Проверка деления на ноль
                            if (numberToo != 0)
                            {
                                result = numberOne / numberToo;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Деление на ноль!");
                                validOperation = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Неправильная операция! Введите одну из: +, -, *, /");
                            validOperation = false;
                            break;
                    }

                    // Вывод результата
                    if (validOperation)
                    {
                        Console.WriteLine("Результат: " + result);
                    }
                }

                Console.WriteLine("Программа завершена.");
            }




        }
    }
}