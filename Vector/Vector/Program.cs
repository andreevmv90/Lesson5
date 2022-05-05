using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This app works with vectors");
            
            Console.WriteLine("Vector1 : X = 1; Y = 2; Z = 3");
            Vector vector1 = new Vector(1, 2, 3);
            
            Console.WriteLine("Vector2 : X = 4; Y = 5; Z = 6");
            Vector vector2 = new Vector(4, 5, 6);

            /*
             * Расчет длин векторов
             */
            Console.WriteLine($"Vector1 Length : {vector1.VectorLength()}");
            Console.WriteLine($"Vector2 Length : {vector2.VectorLength()}");

            /*
             * Расчет скалярного произведения
             */
            if (vector1.ScalarProduct(vector2) != null)
                Console.WriteLine($"Scalar product Vector1 and Vector2 : {vector1.ScalarProduct(vector2)}");
            else
                Console.WriteLine("Scalar product Error");

            /*
             * Расчет угла между векторами
             */
            if (vector1.CosAngle(vector2) != null)
                Console.WriteLine($"Cos of angle between Vector1 and Vector2 : {vector1.CosAngle(vector2)}");
            else
                Console.WriteLine("Angle calculation Error");


            /*
             * Расчет произведения между векторами
             */
            Calculation(vector1, vector2, Operations.Product);

            /*
             * Расчет суммы между векторами
             */
            Calculation(vector1, vector2, Operations.Add);
            
            /*
             * Расчет разности между векторами
             */
            Calculation(vector1, vector2, Operations.Substract);

            Console.ReadKey();
        }

        private static void Calculation(Vector vector1, Vector vector2, Operations oper)
        {
            Vector result1;
            Vector result2;

            if (vector1 == null || vector2 == null)
                Console.WriteLine("Result2 calculation Error");

            switch (oper)
            {
                case Operations.Product:
                    result1 = vector1.Product(vector2);
                    if (result1 != null)
                        Console.WriteLine($"Product of Vector1 and Vector2 by method: X = {result1.X}, Y = {result1.Y}, Z = {result1.Z}");
                    else
                        Console.WriteLine("Product calculation Error");

                    result2 = vector1 * vector2;
                    Console.WriteLine($"Product of Vector1 and Vector2 by overload: X = {result2.X}, Y = {result2.Y}, Z = {result2.Z}");
                    break;
               
                case Operations.Add:
                    result1 = vector1.Add(vector2);
                    if (result1 != null)
                        Console.WriteLine($"Product of Vector1 and Vector2 by method: X = {result1.X}, Y = {result1.Y}, Z = {result1.Z}");
                    else
                        Console.WriteLine("Product calculation Error");

                    result2 = vector1 + vector2;
                    Console.WriteLine($"Product of Vector1 and Vector2 by overload: X = {result2.X}, Y = {result2.Y}, Z = {result2.Z}");
                    break;
               
                case Operations.Substract:
                    result1 = vector1.Substruct(vector2);
                    if (result1 != null)
                        Console.WriteLine($"Product of Vector1 and Vector2 by method: X = {result1.X}, Y = {result1.Y}, Z = {result1.Z}");
                    else
                        Console.WriteLine("Product calculation Error");

                    result2 = vector1 - vector2;
                    Console.WriteLine($"Product of Vector1 and Vector2 by overload: X = {result2.X}, Y = {result2.Y}, Z = {result2.Z}");
                    break;
            }


        }

    }
}
