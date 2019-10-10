using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingExample.Models
{
    public static class StringHelper
    {

        public static bool IsTextFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return false;
            }
            fileName = fileName.ToLower();
            if (!fileName.EndsWith(".txt"))
            {
                return false;
            }
            return true;

        }


    }
}
