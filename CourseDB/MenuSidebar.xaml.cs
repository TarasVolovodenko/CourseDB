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

namespace CourseDB
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class MenuSidebar : UserControl
    {
        public MenuSidebar()
        {
            InitializeComponent();
        }

        private void ProfileClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Profile());
        }

        private void MyDormClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new MyDorm());
        }

        private void MyFacultyClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new MyFaculty());
        }

        private void SearchStudentClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Pages.DefaultUser());
            //Style = (Style)Application.Current.Resources["MenuCurrent"]; // create my own class extends Hyperlink, add method to change style
        }

        private void DormsClick(object sender, RoutedEventArgs e)
        {
           Switcher.Switch(new Pages.DormsInfo());
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Pages.Auth());
            // reset authorization
        }
    }
}
