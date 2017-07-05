//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    
//------------------------------------------------------------

//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Circle
    {
        public Point center;
        public double radius;

        public Circle(double centerX, double centerY, double radius)
        {
            this.center = new Point(centerX, centerY);
            this.radius = radius;
        }
    }
}
