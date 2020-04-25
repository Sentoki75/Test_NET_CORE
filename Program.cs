using System;

namespace Test_NET_CORE
{
    class Program
    {
        private const string HelloMessage = "Hello World!, there we go";

        static void Main(string[] args)
        {
            Console.WriteLine(HelloMessage);
            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
                counter++;
                Console.WriteLine($"Counter: {counter}");
                System.Threading.Tasks.Task.Delay(1000).Wait();
            }
        }
    }
}
