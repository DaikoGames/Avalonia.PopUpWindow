using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System.Runtime.CompilerServices;

namespace PopUpWindowNamespace
{
    public class PopUp
    {
        public TextBlock MainText;
        public Button Button1button;
        public Button Button2button;
        public Button Button3button;

        public static void PopUpWindow(bool Markdown, byte WindowRed, byte WindowGreen, byte WindowBlue, byte TextRed, byte TextGreen, byte TextBlue, int width, int height, string title, string windowIcon, string popUpIcon, string text, bool progressBar, bool okButton, bool yesButton, bool noButton)
        {
            var ActualPopUp = new Window
            {
                Title = title,
                Width = width,
                Height = height
            };
            ActualPopUp.Icon = new WindowIcon(windowIcon);
            var PopUpWindowCanvas = new Canvas();
            PopUpWindowCanvas.Background = new SolidColorBrush(Avalonia.Media.Color.FromRgb(WindowRed, WindowGreen, WindowBlue));
            var MainText = new TextBlock { Text = text };
            MainText.Background = Avalonia.Media.Brushes.Transparent;
            MainText.Foreground = new SolidColorBrush(Avalonia.Media.Color.FromRgb(TextRed, TextGreen, TextBlue));
            if(popUpIcon == null)
            {
                Canvas.SetLeft(MainText, 15);
                Canvas.SetTop(MainText, 15);
            }

            if(popUpIcon != null)
            {
                Image PopUpImage = new Image();
                PopUpImage.Source = new Bitmap(popUpIcon);
                PopUpImage.Width = 25;
                PopUpImage.Height = 25;

                Canvas.SetLeft(PopUpImage, 15);
                Canvas.SetTop(PopUpImage, 15);
                Canvas.SetLeft(MainText, 70);
                Canvas.SetTop(MainText, 15);
                PopUpWindowCanvas.Children.Add(PopUpImage);
            }

            if(progressBar == true)
            {
                ProgressBar Progressbar = new ProgressBar();
                Progressbar.Width = 100;
                Progressbar.Height = 25;
                Canvas.SetLeft(Progressbar, 15);
                Canvas.SetTop(Progressbar, 50);
                PopUpWindowCanvas.Children.Add(Progressbar);
            }

            PopUpWindowCanvas.Children.Add(MainText);
            ActualPopUp.Content = PopUpWindowCanvas;

            ActualPopUp.Show();

            
        }
    }
}
