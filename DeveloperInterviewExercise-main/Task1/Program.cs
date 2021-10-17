using System;
using ThirdPartyTools;

namespace Task1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Make sure there are only 2 arguments present");
                Console.ReadLine();
                return;
            }
            var result = GetVersion(args[0], args[1]);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static string GetVersion(string arg1, string arg2)
        {
            FileDetails fileDetails = new FileDetails();
            var result = arg1 == "-v"?fileDetails.Version(arg2): "No Version Found";
            return result;
        }
    }
}
