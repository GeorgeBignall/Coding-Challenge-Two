using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace Coding_Challenge_Two
{
    public class NumberToTls
    {
        public string ConvertToTls(int input)
        {
            var convertToBase26 = new BaseTwentySix();
            var sequence = convertToBase26.Convert(input);
            var firstLetter = Convert.ToChar(sequence[0]+65);
            var secondLetter = Convert.ToChar(sequence[1] + 65);
            var thirdLetter = Convert.ToChar(sequence[2] + 65);

            return String.Concat(firstLetter, secondLetter, thirdLetter);
        }

        
    }
}