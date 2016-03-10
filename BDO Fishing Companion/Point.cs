
namespace BDO_Fishing_Companion
{
    public class Point
    {
        public int X;
        public int Y;
        public string Name;

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
