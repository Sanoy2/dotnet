using System;
using System.Collections.Generic;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInts = Int32.Parse(args[0]);
            bool sortOn = Boolean.Parse(args[1]);
            string directoryWithFiles = $"{args[2]}{numberOfInts}/";
            System.Console.WriteLine($"Number of ints: {numberOfInts}");
            System.Console.WriteLine($"Sorting on?: {sortOn}");
            System.Console.WriteLine($"Directory: {directoryWithFiles}");

            int numberOfFiles = 100;
            System.Console.WriteLine($"Number of files: {numberOfFiles}");

            var loader = new Loader();
            System.Console.Write("\n\n");
            
            // var list = loader.LoadToList(directoryWithFiles + "0.txt");
            // var array = loader.LoadToArray(directoryWithFiles + "0.txt");

            List<int> list;
            string path;

            for (int i = 0; i < numberOfFiles; i++)
            {
                path = directoryWithFiles + i + ".txt";
                list = loader.LoadToList(path);
                if(sortOn)
                    list.Sort();
            }
        }
    }
}
