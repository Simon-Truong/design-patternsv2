using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory appleFactory = new AppleFactory();
            IFactory windowsFactory = new WindowsFactory();

            Button appleButton = appleFactory.GetButton();
            Cursor appleCursor = appleFactory.GetCursor();
            Console.WriteLine(appleButton.Behaviour);
            Console.WriteLine(appleCursor.Behaviour);

            Button windowsButton = windowsFactory.GetButton();
            Cursor windowsCursor = windowsFactory.GetCursor();

            Console.WriteLine(windowsButton.Behaviour);
            Console.WriteLine(windowsCursor.Behaviour);

            Console.ReadLine();
        }
    }
}
