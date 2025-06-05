using ShapeDrawer;
using SplashKitSDK;
namespace _4._1P_Drawing_Program
{
    internal class MyCircle : Shape
    {
        private int _radius;


        public MyCircle(Color color, int radius) : base(color)
        {
            _radius = radius;
        }

        public MyCircle() : this(Color.Blue, 54) { }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, (Radius + 4));
        }

        public override bool IsAt(ShapeDrawer.Point2D pt)
        {
            float dx = pt.x - X;
            float dy = pt.y - Y;
            return (dx * dx + dy * dy) <= (_radius * _radius);
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
    }
}
