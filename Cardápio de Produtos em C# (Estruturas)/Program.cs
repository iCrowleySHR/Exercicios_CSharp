using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        struct Product
        {
            public string name;
            public double price;
            public string description;
            public string category;
            public string creator;
        }

        static void Main()
        {

            const int size = 5;
            Product[] cardapio = new Product[size];

            cardapio[0] = new Product { 
                name = "Sapato Virutal", 
                price = 25.00, 
                description = "Um produto de ótima qualidade" ,
                category = "Infoproduto",
                creator = "Carlos Drummont"
            };

            cardapio[1] = new Product
            {
                name = "Blusa Virutal",
                price = 39.00,
                description = "Um produto de ótima qualidade mesmo!",
                category = "Infoproduto",
                creator = "Roberto Mirando"
            };

            cardapio[2] = new Product
            {
                name = "Calça Virutal",
                price = 59.00,
                description = "Uma calça semi-nova!!",
                category = "Infoproduto",
                creator = "Roberto Carlos"
            };

            cardapio[3] = new Product
            {
                name = "Video Game - Nintendo 360",
                price = 590.00,
                description = "Um vídeo game novo para uso.",
                category = "Produto Físico",
                creator = "Silvio Santos"
            };


            cardapio[4] = new Product
            {
                name = "Video Game - PS4 360",
                price = 257.00,
                description = "Um vídeo game novo para uso.",
                category = "Produto Físico",
                creator = "Senor Abravanel"
            };

            Console.WriteLine("Produtos da loja:");
        
            foreach (var data in cardapio)
            {
                Console.WriteLine($"{data.name} \nR$ {data.price:F2} \nCategoria: {data.category} \nDescrição: {data.description} \nCriador: {data.creator} \n\n");
            }
        }
    }
}
