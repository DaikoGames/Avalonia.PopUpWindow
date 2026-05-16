using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
namespace PopUpWindowNamespace
{
    public class PopUp
    {
        public TextBlock MainText;
        public Button Button1button;
        public Button Button2button;
        public Button Button3button;

        public static void PopUpWindow(bool Markdown, int width, int height, string title, string text)
        {
            var ActualPopUp = new Window
            {
                Title = title,
                Width = width,
                Height = height
            };
            var PopUpWindowCanvas = new Canvas();
            var MainText = new TextBlock { Text = text };
            Canvas.SetLeft(MainText, 15);
            Canvas.SetTop(MainText, 15);
            PopUpWindowCanvas.Children.Add(MainText);
            ActualPopUp.Content = PopUpWindowCanvas;

            ActualPopUp.Show();

            
        }
    }
}
