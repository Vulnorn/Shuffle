using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace DataBasePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 10;
            int maxElementArray = 100;

            Random random = new Random();

            int[] array = new int[sizeArray];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(maxElementArray);
            }

            Console.WriteLine("Массив до перемешивания");
            ShowArray(array);
            Shuffle(array, random);

            Console.WriteLine($"\nМассив после перемешивания");
            ShowArray(array);

            Console.ReadKey();
        }

        static void Shuffle(int[] array, Random random)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = i;

                while (randomIndex == i)
                {
                    randomIndex = random.Next(array.Length);
                }

                int elementArray = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = elementArray;
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
        }
    }
}