﻿using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory1();

            Client client = new Client(factory);

            Console.WriteLine("Program started...");

            client.Run();
        }
    }
}
