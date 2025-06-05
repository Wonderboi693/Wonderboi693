using _4._1P_Drawing_Program;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {

        private enum ShapeKind
        {
            Rectangle,
            Circle,
            MyLine,
        }

        public static void Main()
        {
            ShapeKind kindtoAdd = 0;
            Window window = new Window("Shape Drawer", 800, 600);
            Drawing myDrawing = new Drawing(Color.White);
            Shape? newShape = null;
            do
            {
                SplashKit.ProcessEvents();

                SplashKitSDK.Point2D mousePoint = SplashKit.MousePosition();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {

                    if (SplashKit.KeyDown(KeyCode.CKey))
                    {
                        kindtoAdd = ShapeKind.Circle;
                    }
                    else if (SplashKit.KeyDown(KeyCode.RKey))
                    {
                        kindtoAdd = ShapeKind.Rectangle;
                    }
                    else if (SplashKit.KeyDown(KeyCode.LKey))
                    {
                        kindtoAdd = ShapeKind.MyLine;
                    }
                    else
                    {
                        kindtoAdd = ShapeKind.Rectangle; // Default to Rectangle if no key is pressed
                    }
                    switch (kindtoAdd)
                    {
                        case ShapeKind.Circle:
                            newShape = new MyCircle();
                            break;
                        case ShapeKind.MyLine:
                            newShape = new MyLine();
                            break;
                        case ShapeKind.Rectangle:
                            newShape = new MyRectangle();
                            break;
                        default:
                            break;
                    }
                    if (kindtoAdd == ShapeKind.MyLine)
                    {
                        //add the MyLine shape
                        int spacing = 10; // Space between lines

                        for (int i = 0; i < 4; i++)
                        {
                            newShape.X = SplashKit.MouseX();
                            newShape.Y = SplashKit.MouseY();
                            MyLine line = new MyLine();
                            line.X = newShape.X;
                            line.Y = newShape.Y + i * (line.Thick + spacing);
                            myDrawing.AddShape(line);
                        }
                    }
                    else
                    {
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        myDrawing.AddShape(newShape);
                    }
                    

                    
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = Color.RandomRGB(255);
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mousePoint = SplashKit.MousePosition();
                    Point2D myPoint = new Point2D((float)mousePoint.X, (float)mousePoint.Y);
                    myDrawing.SelectShapeAt(myPoint);
                }
                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    myDrawing.RemoveSelectedShape();
                }
                myDrawing.Draw();
                SplashKit.RefreshScreen();



            } while (!window.CloseRequested);
        }

    }
}

