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

namespace HostApp
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private readonly NavigationService _nav;

        public Page1(Frame host)
        {
            InitializeComponent();
            _nav = host.NavigationService;
        }

        private void OnGo(object sender, System.Windows.RoutedEventArgs e)
        {
            _nav.Navigate(new Page2());
        }
    }
}
