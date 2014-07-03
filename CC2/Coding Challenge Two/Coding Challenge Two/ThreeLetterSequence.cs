using System;

namespace Coding_Challenge_Two
{
    public class ThreeLetterSequence
    {
        public int Count(string tls, string source)
        {
            int count = 0;
            for (int i = 0; i < source.Length-2; i++)
            {
                if (string.Equals(source.Substring(i, 3),tls))
                {
                    count++;
                }
            }
            return count;
        }
    }
}