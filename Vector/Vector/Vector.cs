using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double? x, double? y, double? z)
        {
            X = x ?? 0.0;
            Y = y ?? 0.0;
            Z = z ?? 0.0;
        }

        public double VectorLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double? ScalarProduct(Vector vector)
        {
            if (vector == null)
            {
                return null;
            }
            else
            {
                return X * vector.X + Y * vector.Y + Z * vector.Z;
            }
        }

        public double? CosAngle(Vector vector)
        {
            var scalar = ScalarProduct(vector);
            var length1 = VectorLength();
            var length2 = vector?.VectorLength();
            return (!scalar.HasValue) || (!length2.HasValue) || (length2.Value < 1e-10) ? null : scalar.Value / (length1 * length2.Value);
        }

        public Vector Product(Vector vector)
        {
            if (vector == null)
            {
                return null;
            }
            else
            {

                return new Vector(Y * vector.Z - Z * vector.Y, Z * vector.X - X * vector.Z, X * vector.Y - Y * vector.X);
            }
        }

        public Vector Add(Vector vector)
        {
            if (vector == null)
            {
                return null;
            }
            else
            {

                return new Vector(X + vector.X, Y + vector.Y, Z + vector.Z);
            }
        }

        public Vector Substruct(Vector vector)
        {
            if (vector == null)
            {
                return null;
            }
            else
            {

                return new Vector(X - vector.X, Y - vector.Y, Z - vector.Z);
            }
        }

        /// <summary>
        /// Перегрузка оператор '*' взамен метода Product
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(
                vector1.Y * vector2.Z - vector1.Z * vector2.Y, 
                vector1.Z * vector2.X - vector1.X * vector2.Z, 
                vector1.X * vector2.Y - vector1.Y * vector2.X);
        }
        
        /// <summary>
        /// Перегрузка оператор '+' взамен метода Add
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector (vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);
        }

        /// <summary>
        /// Перегрузка оператор '-' взамен метода Substruct
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);
        }
    }
}
