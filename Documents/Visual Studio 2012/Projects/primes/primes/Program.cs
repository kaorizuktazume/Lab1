using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();/* ReadLine=ввод с консоли */
            string[] array = s.Split(' ');/* s.Split(' ')-пустое место=пробел таким образом делим массив*/
            int[] primes = new int[10];/*создал массив для 11 элементов*/
            int k = 0;
            int[] prr = new int[10];/*создал новый массив для простых чисел*/
            for (int i=0; i<array.Length; i++){ /*обращаюсь к любому элементу в строке*/
                primes[i] = int.Parse(array[i]);/*и присваеваю ему числовое значение*/
            }
            int q = 0;/*новая переменаная*/
            for (int i=0; i<array.Length; i++){ /*проверка числа на простоту*/
                for (int j = 1; j <= i; j++) {
                    if (primes[i] % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2) /*если число делится два раза то есть на себя и на 1 */
                {
                    prr[q] = primes[i];/* мы закидываем элемент массива prime в массив prr потому-что оно делится на себя и на 1*/
                    q++;/* при этом массив растёт получая новые элементы*/
                }
                k = 0;
            }
            for (int i = 0; i < q; i++) {
                Console.WriteLine(prr[i]);/*выводим все числа на консоль*/
            } 
            Console.ReadKey();
        }
    }
}
