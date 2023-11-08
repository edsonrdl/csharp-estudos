#langversion 11.0
#nullable enable
using System;


    public struct Point
    {
        public int X;
        public int Y;
        public int Z;

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    class MyPoint
    {
        static void Main()
        {
            var pointTeste1 = new Point[2]; // Criar um Array de struct
            // Passar o valor para o primeiro 
            pointTeste1[0] = new Point(1, 2, 3);
            // Passar o valor para o segundo
            pointTeste1[1] = new Point(1, 2, 3);

            // Exibir os valores
           Console.WriteLine(1.pointTeste1[0].X);

    }
}
