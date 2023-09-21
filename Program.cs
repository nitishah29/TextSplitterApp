using System;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length != 2 || !int.TryParse(args[1], out int x))
        {
            Console.WriteLine("Usage: dotnet run <string> <int>");
            return;
        }

        string inputString = args[0];

        var splitterAndIndenter = new TextSplitterAndIndenter();
        await splitterAndIndenter.Process(inputString, x);

        Console.WriteLine("Processing complete.");
    }
}
