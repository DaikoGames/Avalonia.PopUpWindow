using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System.Runtime.CompilerServices;
using Markdown.Avalonia;

namespace PopUpWindowNamespace
{
    public class PopUp
    {
        public Window ActualPopUp = new Window();
        public TextBlock MainText = new TextBlock();
        public ProgressBar Progressbar = new ProgressBar();
        public Button YesButton = new Button();
        public Button OkButton = new Button();
        public Button NoButton = new Button();
        public bool okButtonPressed = false;
        public bool noButtonPressed = false;
        public bool yesButtonPressed = false;

        public async void PopUpWindow(bool Markdown, Avalonia.Media.Color WindowColor, Avalonia.Media.Color TextColor, int width, int height, string windowIcon, string title, string popUpIcon, string text, bool progressBar, bool okButton, bool yesButton, bool noButton)
        {
            ActualPopUp.Title = title;
            ActualPopUp.Width = width;
            ActualPopUp.Height = height;
            ActualPopUp.CanResize = false;
            ActualPopUp.Icon = new WindowIcon(windowIcon);
            var PopUpWindowCanvas = new Canvas();
            PopUpWindowCanvas.Background = new SolidColorBrush(WindowColor);
            MainText.Background = Avalonia.Media.Brushes.Transparent;
            MainText.Foreground = new SolidColorBrush(TextColor);
            PopUpWindowCanvas.Children.Add(MainText);

            if(Markdown == true)
            {
                var MarkdownView = new MarkdownScrollViewer();
                MarkdownView.Width = width - 30;
                MarkdownView.Height = height - 50;
                MarkdownView.Markdown = text;
                PopUpWindowCanvas.Children.Add(MarkdownView);
            }

            if(Markdown == false)
            {
                ActualPopUp.Content = PopUpWindowCanvas;
                MainText.Text = text;
                MainText.Width = width - 30;
                MainText.Height = height - 15;
            }

            if (popUpIcon == null)
            {
                Canvas.SetLeft(MainText, 15);
                Canvas.SetTop(MainText, 15);
            }

            if(popUpIcon != null)
            {
                Image PopUpImage = new Image();
                PopUpImage.Source = new Bitmap(popUpIcon);
                PopUpImage.Width = 50;
                PopUpImage.Height = 50;
                Canvas.SetLeft(PopUpImage, 15);
                Canvas.SetTop(PopUpImage, 15);
                Canvas.SetLeft(MainText, 70);
                Canvas.SetTop(MainText, 15);
                PopUpWindowCanvas.Children.Add(PopUpImage);
            }

            if(progressBar == true)
            {
                Progressbar.Width = width - 30;
                Progressbar.Height = 15;
                Progressbar.Background = Avalonia.Media.Brushes.Gray;
                Progressbar.Foreground = new SolidColorBrush(TextColor);
                Canvas.SetLeft(Progressbar, 15);
                Canvas.SetTop(Progressbar, height - 35);
                PopUpWindowCanvas.Children.Add(Progressbar);
            }

            if(yesButton == true)
            {
                YesButton.Width = 50;
                YesButton.Height = 30;
                Canvas.SetLeft(YesButton, width / 2);
                Canvas.SetTop(YesButton, height - 15);
                YesButton.Content = "Yes";
                YesButton.Foreground = new SolidColorBrush(TextColor);
                YesButton.BorderBrush = new SolidColorBrush(TextColor);
                PopUpWindowCanvas.Children.Add(YesButton);
                YesButton.Click += YesClick;
            }

            if(okButton == true)
            {
                OkButton.Width = 50;
                OkButton.Height = 30;
                Canvas.SetLeft(OkButton, width / 2 + 60);
                Canvas.SetTop(OkButton, height - 15);
                OkButton.Content = "Ok";
                OkButton.Foreground = new SolidColorBrush(TextColor);
                OkButton.BorderBrush = new SolidColorBrush(TextColor);
                PopUpWindowCanvas.Children.Add(OkButton);
                OkButton.Click += OkClick;
            }

            if(noButton == true)
            {
                NoButton.Width = 50;
                NoButton.Height = 30;
                Canvas.SetLeft(NoButton, width / 2 + 120);
                Canvas.SetTop(NoButton, height - 15);
                NoButton.Content = "No";
                NoButton.Foreground = new SolidColorBrush(TextColor);
                NoButton.BorderBrush = new SolidColorBrush(TextColor);
                PopUpWindowCanvas.Children.Add(NoButton);
                NoButton.Click += NoClick;
            }
            
            ActualPopUp.Show();
        }

        public void YesClick(object ?sender, RoutedEventArgs e)
        {
            yesButtonPressed = true;
        }
        public void OkClick(object? sender, RoutedEventArgs e)
        {
            okButtonPressed = true;
        }
        public void NoClick(object? sender, RoutedEventArgs e)
        {
            noButtonPressed = true;
        }
    }
}
