using System;

namespace Test_Wheelzy
{


    public class Program
    {
        //size of grid board of cheese 8x8 in this case
        const int grid = 8;

        static void Main()
        {
            List<string> validMoves = moveknight(6, 2);

            Console.WriteLine("Movimientos válidos del caballo:");
            foreach (string move in validMoves)
            {
                Console.WriteLine(move);
            }
        }

        public static List<string> moveknight(int x, int y)
        {
            int[] xposible = { 1, 1, 2, 2, -1, -1, -2, -2 };
            int[] yposible = { 2, -2, 1, -1, 2, -2, 1, -1 };
            List<string> validMoves = new List<string>();


            for (int i = 0; i < xposible.Length; i++)
            {
                int newX = x + xposible[i];
                int newY = y + yposible[i];


                if (Isvalid(newX, newY))
                {
                    validMoves.Add($"({newX},{newY})");
                }
            }
            return validMoves;
        }

        private static bool Isvalid(int x, int y)
        {
            if (x > 0 && x <= grid && y > 0 && y <= grid)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
     
    }
}