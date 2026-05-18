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
        public async void PopUpWindow(bool Markdown, Avalonia.Media.Color WindowColor, Avalonia.Media.Color TextColor, int width, int height, string windowIcon, string title, string popUpIcon, string text, bool progressBar, bool okButton, bool yesButton, bool noButton)
        {
            var ActualPopUp = new Window
            {
                Title = title,
                Width = width,
                Height = height
            };
            ActualPopUp.CanResize = false;
            ActualPopUp.Icon = new WindowIcon(windowIcon);
            var PopUpWindowCanvas = new Canvas();
            PopUpWindowCanvas.Background = new SolidColorBrush(WindowColor);
            var MainText = new TextBlock { Text = text, Width = width - 30, Height = height - 15 };
            MainText.Background = Avalonia.Media.Brushes.Transparent;
            MainText.Foreground = new SolidColorBrush(TextColor);
            PopUpWindowCanvas.Children.Add(MainText);
            ActualPopUp.Content = PopUpWindowCanvas;

            if (popUpIcon == null)
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
                Progressbar.Width = width - 30;
                Progressbar.Height = 15;
                Progressbar.Foreground = new SolidColorBrush(TextColor);
                Canvas.SetLeft(Progressbar, 15);
                Canvas.SetTop(Progressbar, 50);
                PopUpWindowCanvas.Children.Add(Progressbar);
            }

            if(yesButton == true)
            {
                Button YesButton = new Button();
                YesButton.Width = 50;
                YesButton.Height = 30;
                Canvas.SetLeft(YesButton, width / 2);
                Canvas.SetTop(YesButton, 70);
                YesButton.Content = "Yes";
                YesButton.Foreground = new SolidColorBrush(TextColor);
                YesButton.BorderBrush = new SolidColorBrush(TextColor);
                PopUpWindowCanvas.Children.Add(YesButton);
            }

            if(okButton == true)
            {
                Button OkButton = new Button();
                OkButton.Width = 50;
                OkButton.Height = 30;
                Canvas.SetLeft(OkButton, width / 2 + 60);
                Canvas.SetTop(OkButton, 70);
                OkButton.Content = "Ok";
                OkButton.Foreground = new SolidColorBrush(TextColor);
                OkButton.BorderBrush = new SolidColorBrush(TextColor);
                PopUpWindowCanvas.Children.Add(OkButton);
            }

            if(noButton == true)
            {
                Button NoButton = new Button();
                NoButton.Width = 50;
                NoButton.Height = 30;
                Canvas.SetLeft(NoButton, width / 2 + 120);
                Canvas.SetTop(NoButton, 70);
                NoButton.Content = "No";
                NoButton.Foreground = new SolidColorBrush(TextColor);
                NoButton.BorderBrush = new SolidColorBrush(TextColor);
                PopUpWindowCanvas.Children.Add(NoButton);
            }
            
            ActualPopUp.Show();
        }
    }
}
