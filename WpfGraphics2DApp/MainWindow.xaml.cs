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

namespace WpfGraphics2DApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 300;
            //rectangle.Height = 100;
            //rectangle.Fill = Brushes.Red;
            //rectangle.Stroke = Brushes.Blue;
            //rectangle.StrokeThickness = 4;

            //stack.Children.Add(rectangle);

            Polygon polygon = new Polygon();
            polygon.Points.Add(new Point(200, 10));
            polygon.Points.Add(new Point(400, 60));
            polygon.Points.Add(new Point(200, 120));
            polygon.Points.Add(new Point(0, 60));
            polygon.Fill = Brushes.Magenta;

            stack.Children.Add(polygon);

        }
    }
}