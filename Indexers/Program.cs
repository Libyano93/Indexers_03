using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ip = new IP("198.103.1.1");

            //var firstSegments = ip[0];
            //var SecondSegments = ip[1];

            //Console.WriteLine($"IP ADDRESS: {ip.Address}");
            //Console.WriteLine($"FIRST SEGMENTS: {firstSegments}");
            //Console.WriteLine($"SECOND SEGMENTS: {SecondSegments}");
            //********************************************************

            int[,] inputs = new int[,]
            {
                {8,3,5,4,1,6,9,2,4 },
                {1,9,3,4,1,6,9,2,7 },
                {2,4,6,8,1,6,9,2,9 },
                {5,3,9,4,1,6,9,2,6 },
                {6,8,5,6,1,6,9,2,2 },
                {3,5,7,4,1,3,9,2,7 },
                {5,9,6,4,1,6,5,2,4 },
                {8,2,5,2,1,1,9,2,7 },
                {9,3,8,4,1,6,9,2,9 },
            };
            var suduko = new Suduko(inputs);
            Console.WriteLine(suduko[10, 3]); //-1
            suduko[4, 3] = -10;
            Console.WriteLine(suduko[4, 3]);//6

            Console.ReadKey();
        }
    }

    public class Suduko
    {
        private int[,] _matrix;

        public int this[int row, int colm]
        {
            get
            {
                //Validation Code
                if (row < 0 || row > _matrix.GetLength(0) - 1)
                    return -1;

                if (colm < 0 || colm > _matrix.GetLength(1) - 1)
                    return -1;
                return _matrix[row, colm];
            }

            set
            {
                if (value < 1 || value > _matrix.GetLength(0) )
                    return;

                _matrix[row, colm] = value;
            }
        }
        public Suduko(int[,] matrix)
        {
            _matrix = matrix;
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
