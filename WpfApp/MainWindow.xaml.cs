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

namespace WpfApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello, WPF");
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();

            //var uri = new System.Uri("C:\\Users\\seongbin\\source\\repos\\WpfApp\\WpfApp\\image.png", UriKind.Absolute);
            var uri = new System.Uri(@"images\image.png", UriKind.RelativeOrAbsolute);
            bitmap.UriSource = uri;
            bitmap.EndInit();

            image1.Source = bitmap;
        }

        private void image1_MouseMove(object sender, MouseEventArgs e)
        {
            //Point pos = e.GetPosition(this);
            Point pos = Mouse.GetPosition(image1);
            String strPos = String.Format("{0,10:f} {1,10:f}", pos.X, pos.Y);
            tbPos.Text = strPos;
        }
    }
}
