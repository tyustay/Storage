using Storage.AppData;
using Storage.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Storage.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        public MaterialsPage()
        {
            InitializeComponent();
            var currentMaterial = ConnectOdb.conObj.Materials.ToList();
            LView.ItemsSource = currentMaterial;


        }

        private void Add(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Content = new PageAdd(null);
        }
        private void EditMaterialNavigate(object sender, RoutedEventArgs e)
        {

            Materials Select = (sender as Grid).DataContext as Materials;
            MainWindow.MainFrame.Content = new PageAdd(Select);
        }

        
    }

}
