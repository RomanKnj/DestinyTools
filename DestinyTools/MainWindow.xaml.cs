using System.Windows;
using DestinyTools.ViewModel;
using DestinyTools.Model;
using System.Windows.Controls;

namespace DestinyTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxClasses_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {


            comBoxSubclasses.ItemsSource = ((Class)((ComboBox)sender).SelectedItem).subclasses;
            comBoxSubclasses.IsEnabled = true;
        }
    }
}
