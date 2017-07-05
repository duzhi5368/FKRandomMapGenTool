//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    多边形
//------------------------------------------------------------
using System;
using System.Collections.Generic;
//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Polygon
    {
        private List<Point> vertices;

        public Polygon(List<Point> vertices)
        {
            this.vertices = vertices;
        }

        public double Area()
        {
            return Math.Abs(SignedDoubleArea() * 0.5);
        }

        public Winding GetWinding()
        {
            double signedDoubleArea = SignedDoubleArea();

            if (signedDoubleArea < 0)
            {
                return Winding.CW;
            }
            if (signedDoubleArea > 0)
            {
                return Winding.CCW;
            }

            return Winding.NONE;
        }

        private double SignedDoubleArea()
        {
            int index;
            int nextIndex;
            int n = vertices.Count;
            Point p;
            Point next;
            double signedDoubleArea = 0;

            for (index = 0; index < n; ++index)
            {
                nextIndex = (index + 1) % n;
                p = vertices[index];
                next = vertices[nextIndex];
                signedDoubleArea += ((p.x * next.y) - (next.x * p.y));
            }

            return signedDoubleArea;
        }
    }
}
