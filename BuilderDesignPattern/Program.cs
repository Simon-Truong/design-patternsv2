using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder robotBuilder = new RobotBuilder("Puppy Pal");

            Robot robotA = robotBuilder
                .SetHead("plastic")
                .SetBody("metal")
                .SetLimbs("plastic")
                .SetManual(true)
                .Build();

            Console.WriteLine(robotA.Head);
            Console.WriteLine(robotA.Body);
            Console.WriteLine(robotA.Limbs);
            Console.WriteLine(robotA.Manual);

            Builder robotBuilder2 = new RobotBuilder("Simple Robot");

            Robot robotB = robotBuilder2
                .SetManual(true)
                .Build();

            Console.WriteLine("==========");
            Console.WriteLine(robotB.Head);
            Console.WriteLine(robotB.Body);
            Console.WriteLine(robotB.Limbs);
            Console.WriteLine(robotB.Manual);

            Console.ReadLine();
        }
    }
}
