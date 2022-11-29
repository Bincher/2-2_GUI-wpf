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
using System.Windows.Threading;

namespace WpfApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        DispatcherTimer Timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            Timer.Interval = TimeSpan.FromMilliseconds(1000);
            Timer.Tick += new EventHandler(timer_Tick);
           
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            lbCnt.Content = String.Format("{0}", counter);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
              
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            counter = 0;
            lbCnt.Content = String.Format("{0}", counter);
        }
    }
}
