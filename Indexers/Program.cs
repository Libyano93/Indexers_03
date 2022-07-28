using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP("198.103.1.1");

            var firstSegments = ip[0];
            var SecondSegments = ip[2];

            Console.WriteLine($"IP ADDRESS: {ip.Address}");
            Console.WriteLine($"FIRST SEGMENTS: {firstSegments}");
            Console.WriteLine($"SECOND SEGMENTS: {SecondSegments}");


            Console.ReadKey();
        }
    }


    public class IP
    {
        private int[] segments = new int[4];
        // Using Index With IP
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

        //=========================================
       // segments 1 - 255
        public IP(string IPAddress) // 125.126.114.1
        {
            var segs = IPAddress.Split(".");

            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }
        }

        //=========================================
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
