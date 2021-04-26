using System;

using static System.Console;

namespace Poebota
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = true;
            while (flag)
            {
                Write("Enter a number (<=21): ");
                if (int.TryParse(ReadLine(), out var n))
                {
                    if (n > 21)
                        continue;

                    flag = false;

                    var rand = new Random();

                    var array = new double[n, n];

                    for (var i = 0; i < n; i++)
                    {
                        for (var j = 0; j < n; j++)
                        {
                            array[i, j] = (double)rand.Next(-100, 100) / 100;
                            Write($"{array[i, j]:f2}\t");
                        }
                        WriteLine();
                    }

                    WriteLine();

                    var sum = 0d;
                    //for (var i = 0; i < n / 2; i++)
                    for (var i = 0; i < (int)Math.Ceiling((double)n / 2); i++)
                    {
                        for (var j = 0; j < i + 1; j++)
                        {
                            sum += array[i, j];
                            Write($"{array[i, j]:f2}\t");
                        }
                        WriteLine();
                    }

                    WriteLine();

                    //for (var i = n / 2; i < n; i++)
                    for (var i = (int)Math.Ceiling((double)n / 2); i < n; i++)
                    {
                        //for (var j = 0; j < n / 2; j++)
                        for (var j = 0; j < (int)Math.Ceiling((double)n / 2); j++)
                        {
                            sum += array[i, j];
                            Write($"{array[i, j]:f2}\t");
                        }
                        WriteLine();
                    }

                    WriteLine($"sum: {sum:f2}");
                }
                else
                {
                    WriteLine("Value is not a number");
                }
            }
        }
    }
}
