using SplashKitSDK;
using ShapeDrawer;

namespace _4._1P_Drawing_Program
{
    public class MyLine : Shape
    {
        Shape tempShape = new MyRectangle(Color.Red, 0, 0, 5, 5);

        private int _length;
        private int _thick;
        public MyLine(Color color, int length, int thick) : base(color)
        {
            _length = length;
            _thick = thick;
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int Thick
        {
            get { return _thick; }
            set { _thick = value; }
        }

        public MyLine() : this(Color.Red, 100, 5)
        { }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, Length, Thick);      
        }

        public override void DrawOutline()
        {
            if (Selected)
            {
                SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, Length + 4, Thick + 4);
            }
        }

        public override bool IsAt(ShapeDrawer.Point2D pt)
        {
            return (pt.x >= X && pt.x <= X + Length && pt.y >= Y && pt.y <= Y + Thick);
        }
    }
}
