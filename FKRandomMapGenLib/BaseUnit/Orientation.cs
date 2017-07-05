//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    朝向/方向
//------------------------------------------------------------

//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Orientation
    {
        public static Orientation LEFT = new Orientation("LEFT");
        public static Orientation RIGHT = new Orientation("RIGHT");
        public string name;

        public Orientation(string name)
        {
            this.name = name;
        }

        public static Orientation Other(Orientation orientation)
        {
            return (orientation == LEFT ? RIGHT : LEFT);
        }
    }
}
