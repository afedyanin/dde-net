namespace SampleServer
{
    using System;
    using DdeNet.Server;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a server that will register the service name 'myapp'.
                using (DdeServer server = new MyServer("myapp"))
                {
                    // Register the service name.
                    server.Register();

                    // Wait for the user to press ENTER before proceding.
                    Console.WriteLine("Press ENTER to quit...");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Press ENTER to quit...");
                Console.ReadLine();
            }

        }
    }
}
