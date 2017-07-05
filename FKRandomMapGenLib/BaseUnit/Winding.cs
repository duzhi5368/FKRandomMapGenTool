//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    旋转方向
//------------------------------------------------------------

//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Winding
    {
        public static Winding CW = new Winding("Clockwise");
        public static Winding CCW = new Winding("Counterclockwise");
        public static Winding NONE = new Winding("None");
        private string name;

        private Winding(string name)
        {
            this.name = name;
        }
    }
}
