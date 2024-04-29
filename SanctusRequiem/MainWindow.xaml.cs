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
    private void SearchViewItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("Вы нажали Поиск!");
    }
    private void DogItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("Вы нажали dog!");
    }
    
    private void CatItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("Вы нажали Cat!");
    }
    
    private void FishItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("Вы нажали Fish!");
    }
    
    private void HamsterItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("Вы нажали Hamster!");
    }
}