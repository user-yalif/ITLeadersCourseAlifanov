namespace ConsoleApp.CSharpBasics
{
    using System;
    using System.Collections.Generic;
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program
    {
        static void Main(string[] args)
        {
            int[] integersSequence;
            string[] userNames;

            integersSequence = new int[5];
            userNames = new string[3];

            integersSequence[0] = 1;
            userNames[1] = "John";

            double[] radiuses = new[] { 2.6, 1.2, 3.4 };
            char[] charArray = { 'A', 'B', 'C' };

            Out.WriteLine("Lenght of integer sequence: " + integersSequence.Length);
            Out.WriteLine("Lenght of radiuses array: " + radiuses.Length);

            int arrayLength = 12;

            double[] yearTemperature = new double[arrayLength];

            Out.WriteLine("First element of radiuses array: " + radiuses[0]);
            // Out.WriteLine("Second element of names array: " + userNames[userNames.Length]); // --> ERROR!!!

            int[] intArray = { 12, 24, 13, 48, 52 };
            int counter = 0;

            while (counter < intArray.Length)
            {
                Out.WriteLine($"intArray[{counter}] == {intArray[counter]}");

                counter++;
            }

            for (int i = 0; i < radiuses.Length; i++)
            {
                Out.WriteLine($"radiuses[{i}] == {radiuses[i]}");
            }

            for (int i = 0; i < integersSequence.Length; i++)
            {
                integersSequence[i] = i * 2;
            }

            Out.WriteLine("Program: Set direction");
            Out.WriteLine("Esc for exit");
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Out.WriteLine("UP");
                        break;
                    case ConsoleKey.DownArrow:
                        Out.WriteLine("DOWN");
                        break;
                    case ConsoleKey.LeftArrow:
                        Out.WriteLine("LEFT");
                        break;
                    case ConsoleKey.RightArrow:
                        Out.WriteLine("RIGHT");
                        break;
                    case ConsoleKey.Escape:
                        Out.WriteLine("Escaped! Bye!!!");
                        break;
                    default:
                        continue;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);

            int k = 0;

            foreach (var name in userNames)
            {
                Out.WriteLine($"userNames[{k}] == {name}");

                k++;
            }

            userNames[0] = "Vera";
            userNames[2] = "Sergii";

            List<string> arr = new List<string>() { "a", "b" };

            int xLength;
            int yLength = 5;

            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*
            for (int y = 0; y < yLength; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    Out.Write("*");
                }

                Out.WriteLine();

            }

            for (int y = yLength; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                    Out.Write("*");
                }

                Out.WriteLine();
            }

            integersSequence = new[]{ 1, 2, 3, 4, 5, 6 };

            // continue
            foreach (var integer in integersSequence)
            {
                if (integer % 2 != 0)
                {
                    continue;
                }

                Out.Write(integer + " ");
            }

            Out.WriteLine();

            // break
            foreach (var integer in integersSequence)
            {
                if (integer == 4)
                {
                    break;
                }

                Out.WriteLine(integer + " ");
            }
        }
    }
}
