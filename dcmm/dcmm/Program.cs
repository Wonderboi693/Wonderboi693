using SplashKitSDK;

namespace CreatingUserInterfaces
{
    public class Program
    {
        public static void Main()
        {
            // open a window and clear it to white
            Window window = new Window("My Interface!", 800, 600);
            //while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                window.Clear(Color.White);

                SplashKit.DrawText("Nguyen Lam Minh Huy. ID: 105543704", Color.Black, 50, 50);

                window.Refresh();
                SplashKit.Delay(704);
            }

            // close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}