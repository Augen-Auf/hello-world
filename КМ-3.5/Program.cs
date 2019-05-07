using BubbleSortLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КМ_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Сколько чисел сортировать?");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите эти числа:");
           // int[] numbers = { 4, 7, 2, 1, 3 };
            //string l = numbers.ToString();
            int[] massive = { 1, 2, 3, 4, 5 };
            
            //string[] array = l.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //if (massive.Length < array.Length)
            //Console.Write("Ошибка!Количество заданных чисел не соотвествует количеству введеных!");
            // else
            //{
            /*HashSet<int> forCheck = new HashSet<int>();//
            int[] newMassive = new int[0]; //
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = int.Parse(array[i]);
                forCheck.Add(massive[i]);//
            }
            Array.Resize(ref newMassive, forCheck.Count);//
            for(int j = 0;j < forCheck.Count;j++)//
                newMassive[j] = forCheck.ElementAt(j);//
            Console.WriteLine("Без повторяющихся чисел:");//
            foreach (int el in forCheck) //
                Console.Write(el + " "); //
            Console.WriteLine();*/
            //BubbleSort(newMassive); // or massive
           Console.WriteLine( BubbleS.BubbleSort(massive));
               /* Console.WriteLine("После сортировки:");
                foreach (int el in massive) // or massive 
                {
                    Console.Write(el + " ");
                }*/
           // }
            Console.ReadKey();
        }
        
        
    }
    
}
