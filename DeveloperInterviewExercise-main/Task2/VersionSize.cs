using System;
using Task2.Util;
using ThirdPartyTools;

namespace Task2
{
    public class VersionSize
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length!=2)
                {
                    Console.WriteLine("Make sure there are only 2 arguments present");
                    Console.ReadLine();
                    return;
                }
                var result = GetVersionOrSize(args[0], args[1]);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string GetVersionOrSize(string arg1, string arg2)
        {
            FileDetails fileDetails = new FileDetails();
            IdentifyArgument identifyArg = new IdentifyArgument();
            string result = string.Empty;

            if (identifyArg.isVersion(arg1))
                result = fileDetails.Version(arg1);

            else if (identifyArg.isSize(arg1))
                result = fileDetails.Size(arg1).ToString();

            else
                result = "No Version Or Size Found";

            return result;
        }

    }
}
