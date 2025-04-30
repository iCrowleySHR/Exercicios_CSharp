using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            int[,] firstHeadquarters = new int[size, size];
            int[,] secondHeadquarters = new int[size, size];
            int[,] thirdHeadquarters = new int[size, size];
            int[,] fourthHeadquarters = new int[size, size];
            int[,] fifthHeadquarters = new int[size, size];
            int[,] sixthHeadquarters = new int[size, size];

            Console.WriteLine("Mostrando primeira matriz: ");
            for (int i = 0; i < size; i++)
            {
                firstHeadquarters[i, 0] = 1;
            }
            showHeadquarters(firstHeadquarters);

            Console.WriteLine("Mostrando segunda matriz: ");
            for (int i = 0; i < size; i++)
            {
                secondHeadquarters[0, i] = 1;
            }
            showHeadquarters(secondHeadquarters);


            Console.WriteLine("Mostrando terceira matriz: ");
            for (int i = 0; i < size; i++)
            {
                thirdHeadquarters[i, i] = 1;
 
            }
            showHeadquarters(thirdHeadquarters);

            Console.WriteLine("Mostrando quarta matriz: ");
            for (int i = 0; i < size; i++)
            {
                fourthHeadquarters[0 , i] = 1;
                fourthHeadquarters[i, 0] = 1;
                fourthHeadquarters[7, i] = 1;
                fourthHeadquarters[i, 7] = 1;

            }
            showHeadquarters(fourthHeadquarters);

            Console.WriteLine("Mostrando quinta matriz: ");
            for (int i = 0; i < size; i++)
            {
                fifthHeadquarters[0, i] = 1;
                fifthHeadquarters[i, 0] = 1;
                fifthHeadquarters[i, i] = 1;
            }
            showHeadquarters(fifthHeadquarters);

            Console.WriteLine("Mostrando sexta matriz: ");
            for (int i = 0; i < size; i++)
            {
                sixthHeadquarters[i, i] = 1;
                sixthHeadquarters[i, size - 1 - i] = 1;
            }
            showHeadquarters(sixthHeadquarters);


            void showHeadquarters(int[,] nameHeadquarters)
            {
                for (int i = 0; i < nameHeadquarters.GetLength(0); i++)
                {
                    for (int j = 0; j < nameHeadquarters.GetLength(1); j++)
                    {
                        Console.Write(nameHeadquarters[i, j] + " | ");
                    }
                    Console.WriteLine("");
                }
            }

        }
    }


    
    
}
