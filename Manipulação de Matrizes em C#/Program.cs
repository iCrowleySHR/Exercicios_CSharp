﻿using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,]matriz = new int[3,3]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        
        Console.WriteLine($"valor, linha 1 coluna 2: {matriz[1,2]}");
    }
}