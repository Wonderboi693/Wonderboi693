using SplashKitSDK;
using ShapeDrawer;

namespace _4._1P_Drawing_Program
{
    public class MyRectangle : Shape
    {
        private int _width;
        private int _height;

        public MyRectangle(Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 104, 104)
        { }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }

        public override void DrawOutline()
        {
            if (Selected)
            {
                SplashKit.FillRectangle(Color.Black, X - 4, Y - 4, Width + 8, Height + 8);
            }
        }

        public override bool IsAt(ShapeDrawer.Point2D pt)
        {
            return (pt.x >= X && pt.x <= X + Width && pt.y >= Y && pt.y <= Y + Height);
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

    }
}