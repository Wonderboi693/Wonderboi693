using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {

        }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void RemoveSelectedShape()
        {
            if (SelectedShapes.Count > 0)
            {
                foreach (Shape shape in SelectedShapes)
                {
                    _shapes.Remove(shape);
                }
            }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
            SplashKit.RefreshScreen();
        }

        public virtual void SelectShapeAt(Point2D pt)
        {
            foreach (Shape shape in _shapes)
            {
                if (shape.IsAt(pt))
                {
                    shape.Selected = !shape.Selected;
                    break;
                }
            }
        }
        

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> selectedShapes = new List<Shape>();
                foreach (Shape shape in _shapes)
                {
                    if (shape.Selected)
                    {
                        selectedShapes.Add(shape);
                    }
                }
                return selectedShapes;
            }
        }
    }
}
