using System;

namespace Coding_Challenge_Two
{
    public class CountProcessor
    {
        public void Execute(string source)
        {
            var iterate = new NumberToTls();
            var tls = new ThreeLetterSequence();

            for (int i = 0; i < 17576; i++)
            {
                var tlsString = iterate.ConvertToTls(i);
                int count = tls.Count(tlsString, source);
                Console.WriteLine("{0}.  {1}", tlsString, count);
            }

        }
    }

}