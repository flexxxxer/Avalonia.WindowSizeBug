using Avalonia.Controls;

namespace Avalonia.WindowSizeBug.Views;

public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    this.WindowState = WindowState.Minimized;
    this.Width = 350;
    this.Height = 420;
  }
}
