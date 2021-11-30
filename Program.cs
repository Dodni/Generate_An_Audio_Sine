using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                writetext.WriteLine("");
            }
            using (StreamReader readtext = new StreamReader("write.txt"))
            {
                string readText = readtext.ReadLine();
                Console.WriteLine(readText);
            }
            //string asd;
            var asd = new StringBuilder();
            int sampleRate = 8000;
            short[] buffer = new short[8000];
            double amplitude = 0.25 * short.MaxValue;
            double frequency = 1000;
            for (int n = 0; n < buffer.Length; n++)
            {
                buffer[n] = (short)(amplitude * Math.Sin((2 * Math.PI * n * frequency) / sampleRate));
                asd.Append(" " + buffer[n].ToString() + "\n");
                
                
            }

            using (StreamWriter writetext = new StreamWriter("write4.csv"))
            {
                writetext.WriteLine(asd);
            }
        }
    }
}
