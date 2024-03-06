using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кт
{
    internal class Vector
    {
        public double StartX { get; set; }
        public double StartY { get; set; }
        public double EndX { get; set; }
        public double EndY { get; set; }

        public Vector(double startX, double startY, double endX, double endY)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

        public static Vector operator *(double scalar, Vector vector)
        {
            Vector result = new Vector(
                scalar * vector.StartX,
                scalar * vector.StartY,
                scalar * vector.EndX,
                scalar * vector.EndY
            );
            return result;
        }
    }
}
