using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SanctusRequiem;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    //
    private void MenuButton_Click(object sender, RoutedEventArgs e)
    {
        ContextMenuPopup.IsOpen = true;
    }

    private void MenuItem_Click(object sender, RoutedEventArgs e)
    {
        ContextMenuPopup.IsOpen = false; 
    }

    private void GitHubButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo("https://github.com/alex-gx1") { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR, THIS LINK NOW IS UNABLE: {ex.Message}");
        }
    }
    
    private void SearchViewItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("IN PROCCES!");
    }
    private void DogItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("IN PROCCES!");
    }
    
    private void CatItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("IN PROCCES!");
    }
    
    private void FishItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("IN PROCCES!");
    }
    
    private void HamsterItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("IN PROCCES!");
    }
}