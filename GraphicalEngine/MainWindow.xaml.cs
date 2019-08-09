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

namespace GraphicalEngine
{
    
    public partial class MainWindow : Window
    {
        Brush defaultButtonBrush;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            defaultButtonBrush = TestButton.Background;

            GameGrid.Children.Add(new GameManager());

        }

        private void TestButton_MouseEnter(object sender, MouseEventArgs e)
        {
            TestButton.Background = Brushes.LightBlue;
        }

        private void TestButton_MouseLeave(object sender, MouseEventArgs e)
        {
            TestButton.Background = defaultButtonBrush;
        }

        private void TestButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TestButton.Background = Brushes.Blue;
        }

  
    }
}
