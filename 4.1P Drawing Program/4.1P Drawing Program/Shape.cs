using SplashKitSDK;

namespace ShapeDrawer
{
    public struct Point2D
    {
        public float x;
        public float y;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public abstract class Shape // Changed to abstract class
    {
        private Color _color;
        private float _x;
        private float _y;
        private bool _selected;

        public Shape(Color color)
        {
            _color = color;
            _x = 0.0f;
            _y = 0.0f;
            _selected = false;
        }

        public Shape() : this(Color.Yellow)
        { }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public abstract void Draw();

        public abstract bool IsAt(Point2D pt);

        public abstract void DrawOutline(); // Removed the body
    }
}
