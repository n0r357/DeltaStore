using System;
using System.Collections.Generic;
using System.Linq;

namespace DeltaStore
{
    public class ValidInput
    {
        public static string Name(List<string> existingNames)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name.Length < 3 || name.Length > 11)
                return null;
            else
            {
                var single = existingNames.SingleOrDefault(singleName => singleName.ToUpper().Equals(name.ToUpper()));
                if (single != null)
                    return null;
                else
                    return name;
            }
        }
    }
}