using System;
using System.Text;

namespace Test.Globaal
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
            //*********************************************************

            int delitel = 0;   
            double summa = 0;
            int[] massive = new int[7]; //одномерный массив целого типа, состоящий из  семи элементов.

            // записывает введенные с клавиатуры данные водномерный массив целого типа, состоящий из семи элементов.
            Console.WriteLine("Ввод массива целых чисел!");
            for (int i = 0; i < massive.Length; i++)
            {
                
                Console.Write(" a[{0}] = ",i);//подсказка с порядковым номером элемента.

                int chislo = Convert.ToInt32(Console.ReadLine()); //введенные с клавиатуры данные.
                massive[i] = chislo;
            }

            //Среднее арифметическое.
            Console.Write(" Элементы массива! " ); 
            foreach (int element in massive)//для перебора набора элементов.
            {
                Console.Write("{0,2},", element); //вывод введенного массива.
                summa += element;
                delitel++;
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов массива! : {0:0.00}", summa / delitel);//выводятся только 2 цифры после запятой.

            Console.WriteLine();
            //Максимальное и  минимальное значение.
            
            int max = 0; //Максимальное значение.   

            foreach (int element in massive)//снова использую перебор элементов.
            {
                if(element > max)
                {
                    max = element; // при переборе цикл  будет каждый раз проверять что бы "max" имел  наибольшее значение среди элементов  массива.
                }
            }
            Console.WriteLine("Максимальное значение из всех элементов массива! {0}", max);
            Console.WriteLine();

            int min = int.MaxValue; //Минимальное значение.
            foreach (int element in massive)
            {
                if(element < min)
                {
                    min = element; // при переборе цикл  будет каждый раз проверять что бы "min" имел  наименьшее значение среди элементов  массива.
                }
            }
            Console.WriteLine("Минимальное значение из всех элементов массива! {0}", min);



        }
    }
}
