﻿//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    点
//------------------------------------------------------------
using System;
//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Point
    {
        public double x;
        public double y;

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double L2()
        {
            return (x * x) + (y * y);
        }

        public double Length()
        {
            return Math.Sqrt((x * x) + (y * y));
        }
    }
}
