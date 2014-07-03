using System;

namespace Coding_Challenge_Two
{
    public class CountProcessor
    {
        public void Execute(string source)
        {
            NumberToTls iterate = new NumberToTls();
            ThreeLetterSequence tls = new ThreeLetterSequence();

            for (int i = 0; i < 17576; i++)
            {
                string tlsString = iterate.ConvertToTls(i);
                int count = tls.Count(tlsString, source);

                if (count == 99)
                {
                    Console.WriteLine("{0}.  {1}", tlsString, count);
                }
                    

            }

        }
    }

}