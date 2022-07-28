using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP(198, 168, 1, 1);

            var firstSegments = ip[0];

            Console.WriteLine($"IP ADDRESS: {ip.Address}");
            Console.WriteLine($"FIRST SEGMENTS: {firstSegments}");


            Console.ReadKey();
        }
    }

    public class IP
    {// Using Index With IP
        private int[] segments = new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }

            set
            {
                segments[index] = value;
            }
        }
        public IP(int segments1, int segments2, int segments3, int segments4)
        {
            segments[0] = segments1;
            segments[1] = segments2;
            segments[2] = segments3;
            segments[3] = segments4;
        }

        public string Address => string.Join(".", segments);
    }
}
