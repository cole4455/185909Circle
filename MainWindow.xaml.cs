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

namespace _185909DrawingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
    
            
                for (int i = 7; i >0; i--)
                {
                    Ellipse w = new Ellipse();
                    w.Height = i*100;
                    w.Width = i*100;
                    if ((i * i) %2 == 0)
                    {
                        w.Fill = Brushes.Black;
                    }
                    else
                    {
                        w.Fill = Brushes.Red;
                    }
                    canvas.Children.Add(w);
                    Canvas.SetTop(w, 400 - (w.Width / 2));
                    Canvas.SetLeft(w, 400- (w.Width /2));
                }

            




        }
    }
}