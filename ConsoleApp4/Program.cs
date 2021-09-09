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
               int tryNumber = 0;
                do
                {
                    Console.WriteLine("Программа для подсчета комплексных чисел\n");
                    Console.WriteLine("Введите цифру 1 - для сложения комплексных чисел\nВведите цифру 2 - для вычитания комплексных чисел\nВведите цифру 3 - Для произведения комплексных чисел\n====================");
                    tryNumber = int.Parse(Console.ReadLine());

                    switch (tryNumber)
                    {
                        case 1:
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
                            Complex complexsum = complex1.Plus(complex2);
                            Console.WriteLine($"Сумма комплексныъ чисел : {complex1} + {complex2} = {complexsum}\n====================");
                            break;



                        default:

                            Console.Write("Неккоректный ввод задачи попробуйте снова");
                            return;

                    }
                }
                while (tryNumber != 0);
                Console.ReadLine();










            }
        }
    }
}
