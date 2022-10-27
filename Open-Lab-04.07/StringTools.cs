using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] reversedString = original.ToCharArray();
            string reverse = String.Empty;
            for (int i = reversedString.Length - 1; i > -1; i--)
            {
                reverse += reversedString[i];
            }
            return reverse;
            }
    }             
}
