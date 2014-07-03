using System;

namespace Coding_Challenge_Two
{
    public class CountProcessor
    {
        public void Execute(string source, int frequency)
        {
            NumberToTls iterate = new NumberToTls();
            ThreeLetterSequence tls = new ThreeLetterSequence();

            for (int i = 0; i < 17576; i++)
            {
                string tlsString = iterate.ConvertToTls(i);
                int count = tls.Count(tlsString, source);

                if (count == frequency)
                {
                    Console.WriteLine("{0} occurs exactly   {1}   times.", tlsString, count);
                }
                    

            }

        }
    }

}