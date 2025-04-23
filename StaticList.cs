using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;

            Console.WriteLine("Feito por Gustavo Gualda");

            Console.WriteLine("=========================================================");

            string[] listFruits = new string[size];
            listFruits[0] = "uva";
            listFruits[1] = "banana";
            listFruits[2] = "framboesa";
            listFruits[3] = "limão";
            listFruits[4] = "banana";


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Indice {i}: {listFruits[i]}");
            }



            Console.WriteLine("=========================================================");

            int[] listNumbers = new int[size];
            listNumbers[0] = 530;
            listNumbers[1] = 803;
            listNumbers[2] = 132;
            listNumbers[3] = 245;
            listNumbers[4] = 326;


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Indice {i}: {listNumbers[i]}");
            }


            Console.WriteLine("=========================================================");

            string[] listNames = new string[size];
            listNames[0] = "Ana Clara";
            listNames[1] = "Karla";
            listNames[2] = "José";
            listNames[3] = "Camila";
            listNames[4] = "Samuel";

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Indice {i}: {listNames[i]}");
            }


            Console.WriteLine("=========================================================");

            string[] listGames = new string[size];
            listGames[0] = "God of War";
            listGames[1] = "Fortnite";
            listGames[2] = "Call of Duty";
            listGames[3] = "Warzone 2";
            listGames[4] = "Rocket League";

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Indice {i}: {listGames[i]}");
            }

            Console.WriteLine("=========================================================");

            string[] listHoobies = new string[size];
            listHoobies[0] = "Tocar Violão";
            listHoobies[1] = "Cantar";
            listHoobies[2] = "Tocar Baixo";
            listHoobies[3] = "Correr";
            listHoobies[4] = "Lutar Muay Thai";

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Indice {i}: {listHoobies[i]}");
            }
        }
    }
}
