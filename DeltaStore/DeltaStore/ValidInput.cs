using System;

namespace DeltaStore
{
    public class ValidInput
    {
        public static string Name()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name.Length < 3 || name.Length > 11)
                return null;
            else
                return name;
        }
    }
}