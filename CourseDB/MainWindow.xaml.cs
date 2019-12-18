using System;
using System.Collections.Generic;
using System.Linq;
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
using CourseDB.Pages;

namespace CourseDB
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Auth start;
        public MainWindow()
        {
            InitializeComponent();
            start = new Auth();
            Switcher.pageSwitcher = this;
            AuthPage();
        }
        public void AuthPage()
        {
            Content = start;
        }
        public void Navigate(UserControl page)
        {
            Content = page;
        }
    }
}

