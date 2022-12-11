using Storage.AppData;
using Storage.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
    /// Логика взаимодействия для PageStorage.xaml
    /// </summary>
    public partial class PageStorage : Page
    {
        public PageStorage()
        {
            InitializeComponent();
            var Storage = ConnectOdb.conObj.Storage.ToList();
            SDiewTours.ItemsSource = Storage;


        }
    }
}
