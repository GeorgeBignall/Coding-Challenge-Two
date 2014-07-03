using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coding_Challenge_Two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the desired frequency: ");
            int inputFrequency = Convert.ToInt32(Console.ReadLine());
            string source = System.IO.File.ReadAllText(@"C:\Users\gwb\Documents\Coding challenges\tls.txt");
            SourceReformat stringReformat = new SourceReformat();
            source = stringReformat.Reformat(source);
            CountProcessor processor = new CountProcessor();
            processor.Execute(source, inputFrequency);
        }

    }
}
