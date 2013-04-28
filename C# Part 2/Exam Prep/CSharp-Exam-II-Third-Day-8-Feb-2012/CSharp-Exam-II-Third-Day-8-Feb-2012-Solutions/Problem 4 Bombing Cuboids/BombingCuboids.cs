#define DEBUG_MODE_OFF

using System;
namespace Problem_4_Bombing_Cuboids
{
    class BombingCuboids
    {
        static int width, height, depth;
        static char[, ,] cuboid;
        static readonly int[] cubesDestroyed = new int['Z' - 'A' + 1];

        private const char EmptyCell = '-';

        static void Main()
        {
            ReadCuboid();
            DetonateBombsAndFallDown();
            PrintResults();
        }

        private static void ReadCuboid()
        {
            // Read the cuboid size
            string cuboidSize = Console.ReadLine();
            string[] sizes = cuboidSize.Split();
            width = int.Parse(sizes[0]);
            height = int.Parse(sizes[1]);
            depth = int.Parse(sizes[2]);
            cuboid = new char[width, height, depth];

            // Read the cuboid data
            for (int h = 0; h < height; h++)
            {
                string line = Console.ReadLine();
                string[] letters = line.Split();
                for (int d = 0; d < depth; d++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        cuboid[w, h, d] = letters[d][w];
                    }
                }
            }
        }

        private static void DetonateBombsAndFallDown()
        {
            // Read the bombs and detonate them
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] coordinates = line.Split(' ');
                int w = int.Parse(coordinates[0]);
                int h = int.Parse(coordinates[1]);
                int d = int.Parse(coordinates[2]);
                int power = int.Parse(coordinates[3]);
                DetonateBomb(w, h, d, power);
                PrintCuboid("After detonation:"); // Used for debug purposes only
                FallDown(w, d, power);
                PrintCuboid("After fall down:"); // Used for debug purposes only
            }
        }

        private static void DetonateBomb(
            int positionWidth, int positionHeight, int positionDepth, int power)
        {
            int startW = Math.Max(0, positionWidth - power);
            int endW = Math.Min(positionWidth + power, width - 1);
            for (int w = startW; w <= endW; w++)
            {
                int startH = Math.Max(0, positionHeight - power);
                int endH = Math.Min(positionHeight + power, height - 1);
                for (int h = startH; h <= endH; h++)
                {
                    int startD = Math.Max(0, positionDepth - power);
                    int endD = Math.Min(positionDepth + power, depth - 1);
                    for (int d = startD; d <= endD; d++)
                    {
                        double distance = CalcEuclidianDistance3D(w, h, d,
                            positionWidth, positionHeight, positionDepth);
                        if (distance <= power)
                        {
                            // The cube is too close to the bomb --> destroy it
                            char cubeColor = cuboid[w, h, d];
                            if (cubeColor != EmptyCell)
                            {
                                cubesDestroyed[cubeColor - 'A']++;
                            }
                            cuboid[w, h, d] = EmptyCell;
                        }
                    }
                }
            }
        }

        private static double CalcEuclidianDistance3D(
            int w1, int h1, int d1, int w2, int h2, int d2)
        {
            double distance = Math.Sqrt(
                (w1 - w2) * (w1 - w2) +
                (h1 - h2) * (h1 - h2) +
                (d1 - d2) * (d1 - d2));
            return distance;
        }

        private static void FallDown(
            int positionWidth, int positionDepth, int power)
        {
            int startW = Math