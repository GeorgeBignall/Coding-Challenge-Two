using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace Coding_Challenge_Two
{
    public class NumberToTls
    {
        public string ConvertToTls(int input)
        {
            BaseTwentySix convertToBase26 = new BaseTwentySix();
            int[] sequence = convertToBase26.Convert(input);
            char firstLetter = Convert.ToChar(sequence[0]+65);
            char secondLetter = Convert.ToChar(sequence[1] + 65);
            char thirdLetter = Convert.ToChar(sequence[2] + 65);

            return String.Concat(firstLetter, secondLetter, thirdLetter);
        }

        
    }
}