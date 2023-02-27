global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
namespace _01._Tiles_Master
{
   
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Stack<int> whites = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

                Queue<int> grays = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
                int oven = 0;
                int sink = 0;
                int Countertop = 0;
                int Wall = 0;
                int floor = 0;
                while (whites.Count != 0 && grays.Count != 0)
                {
                    int white = whites.Pop();
                    int gray = grays.Dequeue();
                    if (white == gray)
                    {


                        int newTail = white + gray;
                        if (newTail == 40)
                        {
                            sink++;
                        }
                        else if (newTail == 50)
                        {
                            oven++;
                        }
                        else if (newTail == 60)
                        {
                            Countertop++;
                        }
                        else if (newTail == 70)
                        {
                            Wall++;
                        }
                        else
                        {
                            floor++;
                        }
                    }
                    if (white != gray)
                    {
                        whites.Push(white / 2);
                        grays.Enqueue(gray);
                    }
                }
                string whiteLeft = string.Join(", ", whites);
                string graysLeft = string.Join(", ", grays);
                if (whites.Count == 0)
                {
                    Console.WriteLine($"White tiles left: none");
                }
                else
                {
                    Console.WriteLine($"White tiles left: {whiteLeft}");
                }
                if (grays.Count == 0)
                {
                    Console.WriteLine($"Grays tiles left: none");
                }
                else
                {
                    Console.WriteLine($"White tiles left: {graysLeft}");
                }
                if (floor != 0)
                {
                    Console.WriteLine($"Floor: {floor}");
                }
                if (Countertop != 0)
                {
                    Console.WriteLine($"Countertop: {Countertop}");
                }
                if (Wall != 0)
                {
                    Console.WriteLine($"Wall: {Wall}");
                }
                if (oven != 0)
                {
                    Console.WriteLine($"Oven: {oven}");
                }
                if (sink != 0)
                {
                    Console.WriteLine($"Sink: {sink}");
                }

            }
        }
    }

   
