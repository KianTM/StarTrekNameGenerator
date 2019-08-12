using System;
using System.Collections.Generic;

namespace StarTrekNameGenerator.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vocals = new string[] { "a", "e", "i", "o", "u", "y" };
            string[] vulcanMaleFirst = new string[] { "S", "Sp", "Sk", "Sk", "T" };
            string[] vulcanMaleSecond = new string[] { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] vulcanMaleLast = new string[] { "q", "p", "k", "ck", "l" };
            string[] vulcanFemaleFirst = new string[] { "T'" };
            string[] vulcanFemaleSecond = new string[] { "P", "K", "Q" };
            string[] vulcanFemaleLast = new string[] { "r", "j", "'p", "k", "l" };
            List<string> vulcanMaleNames = new List<string>();
            List<string> vulcanFemaleNames = new List<string>();

            

            foreach (var male1 in vulcanMaleFirst)
            {
                foreach (var male2 in vocals)
                {
                    foreach (var male3 in vulcanMaleSecond)
                    {
                        foreach (var male4 in vocals)
                        {
                            foreach (var male5 in vulcanMaleLast)
                            {
                                string name = $"{male1}{male2}{male3}{male4}{male5}";
                                vulcanMaleNames.Add(name);
                            }
                        }
                    }
                }
            }

            foreach (var male1 in vulcanMaleFirst)
            {
                foreach (var male2 in vocals)
                {
                    foreach (var male3 in vulcanMaleLast)
                    {
                        string name = $"{male1}{male2}{male3}";
                        vulcanMaleNames.Add(name);
                    }
                }
            }

            foreach (var female1 in vulcanFemaleFirst)
            {
                foreach (var female2 in vulcanFemaleSecond)
                {
                    foreach (var female3 in vocals)
                    {
                        foreach (var female4 in vulcanFemaleLast)
                        {
                            string name = $"{female1}{female2}{female3}{female4}";
                            vulcanFemaleNames.Add(name);
                        }
                    }
                }
            }



            while (true)
            {
                Console.WriteLine("Star Trek Name Generator");
                Console.WriteLine("========================");
                Console.WriteLine("Male names = 'M'");
                Console.WriteLine("Female names = 'F'");
                Console.WriteLine("Exit program = 'X'");
                string input = Console.ReadLine();
                Console.Clear();
                int nameIndex = 0;
                bool inLoop = false;

                if (input.ToLower() == "x")
                {
                    Environment.Exit(1);
                }

                if (input.ToLower() == "m")
                {
                    inLoop = true;
                    int num = 0;
                    while (inLoop)
                    {
                        Console.Clear();
                        Console.WriteLine("Count = " + vulcanMaleNames.Count);
                        Console.WriteLine("Index = " + nameIndex);
                        num = 20 * nameIndex;
                        if (num >= vulcanMaleNames.Count - 20)
                        {
                            num = vulcanMaleNames.Count - 20;
                        }
                        Console.WriteLine("Num = " + num);
                        for (int i = num; i < num + 20; i++)
                        {
                            Console.Write(vulcanMaleNames[i]);
                            Console.Write("\t");
                            i++;
                            Console.Write(vulcanMaleNames[i]);
                            Console.Write("\t");
                            i++;
                            Console.Write(vulcanMaleNames[i]);
                            Console.Write("\t");
                            i++;
                            Console.WriteLine(vulcanMaleNames[i]);
                        }

                        if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                        {
                            nameIndex--;
                            if (nameIndex < 0)
                            {
                                nameIndex = (vulcanMaleNames.Count - 1) / 20;
                            }
                        }

                        if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                        {
                            nameIndex++;
                            if (nameIndex > (vulcanMaleNames.Count - 1) / 20)
                            {
                                nameIndex = 0;
                            }
                        }

                        if (Console.ReadKey(false).Key == ConsoleKey.Escape)
                        {
                            inLoop = false;
                            Console.Clear();
                        }
                    }
                }

                if (input.ToLower() == "f")
                {
                    inLoop = true;
                    int num = 0;
                    while (inLoop)
                    {
                        Console.Clear();
                        Console.WriteLine("Count = " + vulcanFemaleNames.Count);
                        Console.WriteLine("Index = " + nameIndex);
                        num = 20 * nameIndex;
                        if (num >= vulcanFemaleNames.Count - 20)
                        {
                            num = vulcanFemaleNames.Count - 20;
                        }
                        Console.WriteLine("Num = " + num);
                        for (int i = num; i < num + 20; i++)
                        {
                            Console.Write(vulcanFemaleNames[i]);
                            Console.Write("\t");
                            i++;
                            Console.Write(vulcanFemaleNames[i]);
                            Console.Write("\t");
                            i++;
                            Console.Write(vulcanFemaleNames[i]);
                            Console.Write("\t");
                            i++;
                            Console.WriteLine(vulcanFemaleNames[i]);
                        }

                        if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                        {
                            nameIndex--;
                            if (nameIndex < 0)
                            {
                                nameIndex = (vulcanFemaleNames.Count - 1) / 20;
                            }
                        }

                        if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                        {
                            nameIndex++;
                            if (nameIndex > (vulcanFemaleNames.Count - 1) / 20)
                            {
                                nameIndex = 0;
                            }
                        }

                        if (Console.ReadKey(false).Key == ConsoleKey.Escape)
                        {
                            inLoop = false;
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}
