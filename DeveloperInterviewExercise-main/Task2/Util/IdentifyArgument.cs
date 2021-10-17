using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2.Util
{
    public class IdentifyArgument
    {
        public string[] versions = {"-v", "--v", "/v", "--version"};
        public string[] sizes = { "-s", "--s", "/s", "--size" };
        public bool isVersion(string arg)
        {
          return versions.Contains(arg)? true : false;
        }
        public bool isSize(string arg)
        {
            return sizes.Contains(arg) ? true : false;
        }
    }

}
