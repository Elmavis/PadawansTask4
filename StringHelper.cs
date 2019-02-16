using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        private static bool IsVowel(char a)
        {
            return a == 'a' || a == 'e' || a == 'i' || a == '0' || a == 'u';
        }
        public static int GetVowelCount(string str)
        {
            if (str == null)
                throw new ArgumentException();

            int counter = 0;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(arr[i]))
                    counter++;
            }

            return counter;
        }
    }
}
