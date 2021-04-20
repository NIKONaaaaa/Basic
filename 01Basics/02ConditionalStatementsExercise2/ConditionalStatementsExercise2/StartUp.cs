namespace PipesinPool
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int vol = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipeTotal = pipe1 * hours + pipe2 * hours;
            if (pipeTotal <= vol)
            {
                Console.WriteLine($"The pool is {pipeTotal / vol * 100:f2}% full. Pipe 1: {pipe1 * hours / pipeTotal * 100:f2}%. Pipe 2: {pipe2 * hours / pipeTotal * 100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {pipeTotal - vol} liters.");
            }
        }
    }
}