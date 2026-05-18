# Avalonia.PopUpWindow
This is a WIP nuget package that lets you run a pop up window easily in avalonia.

this is a good example of a code you can do with the nuget package: 

```
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using PopUpWindowNamespace;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace popUpTest
{
    public partial class MainWindow : Window
    {
        PopUp popup = new PopUp();
        public MainWindow()
        {
            InitializeComponent();
            TestingStuff();
        }
        public async void TestingStuff()
        {
            popup.PopUpWindow(false, Avalonia.Media.Colors.Black, Avalonia.Media.Colors.White, 500, 150, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Converter.ico"), "Example", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Converter.png"), "This is an easy example :)", true, true, true, true); 
            popup.YesButton.Click += YesClickVoid;
            popup.OkButton.Click += OkClickVoid;
            popup.NoButton.Click += NoClickVoid;
        }
        public void YesClickVoid (object ?sender, RoutedEventArgs e)
        {
            Trace.Write("\n Yes Button was pressed :) but outside the initialization void \n");
            popup.ActualPopUp.Close();
        }
        public void OkClickVoid(object? sender, RoutedEventArgs e)
        {
            Trace.Write("\n Ok Button was pressed :) but outside the initialization void \n");
        }
        public void NoClickVoid(object? sender, RoutedEventArgs e)
        {
            Trace.Write("\n No Button was pressed :) but outside the initialization void \n");
        }
    }
}
```
