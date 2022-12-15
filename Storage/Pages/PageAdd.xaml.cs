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
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        private Materials MyMaterial = new Materials();
        private bool isAdd = true;
        public PageAdd(AppData.Materials SelectMaterial)
        {
            InitializeComponent();
            VIDid.ItemsSource = ConnectOdb.conObj.Unit_of_measurement.ToList();
            NRSklad.ItemsSource = ConnectOdb.conObj.Storage.ToList();
            VIDid.SelectedIndex = 0;
            if (SelectMaterial != null)
            {
                DataContext = SelectMaterial;
                isAdd = false;
            }

        }

        
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MyMaterial.Numder = int.Parse(TxtTitle.Text);
            MyMaterial.Name = Txtcost.Text;
            MyMaterial.Remains = int.Parse(TxtOstatok.Text);
            MyMaterial.Storage = int.Parse(NRSklad.Text);
            if (isAdd == true)
            {
                ConnectOdb.conObj.Materials.Add(MyMaterial);
            }
            ConnectOdb.conObj.SaveChanges();

            MainWindow.MainFrame.Content = new Pages.MaterialsPage();
        }

        private void TxtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
