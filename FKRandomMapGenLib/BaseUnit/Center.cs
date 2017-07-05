﻿//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    
//------------------------------------------------------------
using System;
using System.Collections.Generic;
//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Center
    {
        public int index;
        public Point loc;
        public List<Corner> corners = new List<Corner>();
        public List<Center> neighbors = new List<Center>();
        public List<DelaunayEdge> borders = new List<DelaunayEdge>();
        public bool border;
        public bool ocean;
        public bool water;
        public bool coast;
        public double elevation;
        public double moisture;
        public Enum biome;
        public double area;

        public Center()
        {

        }

        public Center(Point loc)
        {
            this.loc = loc;
        }
    }
}
