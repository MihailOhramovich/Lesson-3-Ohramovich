using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        #region описание структуры Комплекса
        struct Complex
        {
            public double re;


            public double im;


            public Complex Plus(Complex x)
            {
                Complex y;
                y.re = re + x.re;
                y.im = im + x.im;

                return y;
            }
            public override string ToString()
            {
                return $"{re}+{im}i";
            }
            public Complex Minus(Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;

                return y;

            }
            public Complex Proizved(Complex x)
            {
                Complex y;
                y.re = re * x.re;
                y.im = im * x.im;

                return y;
            }

            #endregion

            static void Main(string[] args)
            {

                Console.WriteLine("Домашняя работа Охрамовича Михаила");
                Console.WriteLine("Для выбора задания введите\n задание-1 : Первое задание \n задания-2 : Второе задание\n задание-3 : Тертье задание\n=============");
                string Number = Console.ReadLine();
                switch (Number)
                {



                    #region
                    case "задание-1":
                        int tryNumber = 0;
                        Console.WriteLine(" Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.\nб) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\nв) Добавить диалог с использованием switch демонстрирующий работу класса.");
                        Console.Write("Введите действительную часть первого комплексного числа: ");
                        Complex complex1;
                        complex1.re = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите мнимую часть первого комплексного числа: ");
                        complex1.im = double.Parse(Console.ReadLine());
                        Console.WriteLine($"ПЕРВОЕ КОМПЛЕКСНОЕ ЧИСЛО : z1={complex1.re}+{complex1.im}");
                        Console.WriteLine("Введите действительную часть второго комплексного числа: ");
                        Complex complex2;
                        complex2.re = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите мнимую часть второго комплексного числа: ");
                        complex2.im = double.Parse(Console.ReadLine());
                        Console.WriteLine($"ВТОРОЕ КОМПЛЕКСНОЕ ЧИСЛО : z1={complex1.re}+{complex1.im}");
                        do
                        {

                            Console.WriteLine("Программа для подсчета комплексных чисел\n");
                            Console.WriteLine("Введите цифру 1 - для сложения комплексных чисел\nВведите цифру 2 - для вычитания комплексных чисел\nВведите цифру 3 - Для произведения комплексных чисел\n====================");
                            tryNumber = int.Parse(Console.ReadLine());

                            switch (tryNumber)
                            {
                                case 1:
                                    ;
                                    Complex complexsum = complex1.Plus(complex2);
                                    Console.WriteLine($"Сумма комплексныъ чисел : {complex1} + {complex2} = {complexsum}\n====================");
                                    break;

                                case 2:
                                    Complex complexmin = complex1.Minus(complex2);
                                    Console.WriteLine($"При вычитание комплексных чисел {complex1} - {complex2} = {complexmin}");
                                    break;

                                case 3:
                                    Complex complexpr = complex1.Proizved(complex2);
                                    Console.WriteLine($"Произведение комплексного числа{complex1} и {complex2} = {complexpr}");
                                    break;



                                default:

                                    Console.Write("Неккоректный ввод задачи попробуйте снова");
                                    return;

                            }
                        }
                        while (tryNumber != 0);
                        Console.ReadLine();
                        break;
                    #endregion

                    #region Задание 2
                    case "задание-2":
                        Console.WriteLine("а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
                        int score;
                        
                        int score2 = 0;
                        

                        do
                        {
                            Console.WriteLine("Введите число :");
                            string a = Console.ReadLine();
                            bool result = int.TryParse(a, out score);
                            if (result == true && score > 0 && score % 2 != 0)
                            {

                                score2 += score;
                                Console.WriteLine($"Число {a} подходит под условие задачи ");
                            
                            }
                            else
                                Console.WriteLine($"Число {a} не подходит под условие задачи ");
                        }

                        while (score != 0);
                        {
   
                            Console.WriteLine($"Сумма чисел удовлетворяющих условиям задачи = {score2}"); 
                            Console.ReadKey();

                        }
                        break;
                        #endregion

                }
            }

        }
    }
}

