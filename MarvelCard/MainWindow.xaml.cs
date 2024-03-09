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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarvelCard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public DoubleAnimation animation1 = new DoubleAnimation()
        {
            From = 180,
            To = 220,
            Duration = TimeSpan.FromSeconds(0.5)
        };
        public DoubleAnimation animation2 = new DoubleAnimation()
        {
            From = 250,
            To = 290,
            Duration = TimeSpan.FromSeconds(0.5)
        };
        public DoubleAnimation animation3 = new DoubleAnimation()
        {
            From = 180,
            To = 180,
            Duration = TimeSpan.FromSeconds(0.5)
        };
        public DoubleAnimation animation4 = new DoubleAnimation()
        {
            From = 250,
            To = 250,
            Duration = TimeSpan.FromSeconds(0.5)
        };
        public MainWindow()
        {
            InitializeComponent();

            b1.RenderTransform = new RotateTransform(-9);
            b2.RenderTransform = new RotateTransform(-8);
            b4.RenderTransform = new RotateTransform(8);
            b5.RenderTransform = new RotateTransform(9);
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {


        }

        private void b1_MouseEnter(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(b1, 1);
            Panel.SetZIndex(b2, 0);
            Panel.SetZIndex(b3, 0);
            Panel.SetZIndex(b4, 0);
            Panel.SetZIndex(b5, 0);
            b1.RenderTransform = new RotateTransform(0);
            b2.RenderTransform = new RotateTransform(-8);
            b4.RenderTransform = new RotateTransform(8);
            b5.RenderTransform = new RotateTransform(9);
            b1.BeginAnimation(Border.WidthProperty, animation1);
            b1.BeginAnimation(Border.HeightProperty, animation2);
            b2.BeginAnimation(Border.WidthProperty, animation3);
            b2.BeginAnimation(Border.HeightProperty, animation4);
            b3.BeginAnimation(Border.WidthProperty, animation3);
            b3.BeginAnimation(Border.HeightProperty, animation4);
            b4.BeginAnimation(Border.WidthProperty, animation3);
            b4.BeginAnimation(Border.HeightProperty, animation4);
            b5.BeginAnimation(Border.WidthProperty, animation3);
            b5.BeginAnimation(Border.HeightProperty, animation4);

        }

        private void b2_MouseEnter(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(b1, 0);
            Panel.SetZIndex(b2, 1);
            Panel.SetZIndex(b3, 0);
            Panel.SetZIndex(b4, 0);
            Panel.SetZIndex(b5, 0);
            b1.RenderTransform = new RotateTransform(-9);
            b2.RenderTransform = new RotateTransform(0);
            b4.RenderTransform = new RotateTransform(8);
            b5.RenderTransform = new RotateTransform(9);
            b2.BeginAnimation(Border.WidthProperty, animation1);
            b2.BeginAnimation(Border.HeightProperty, animation2);
            b1.BeginAnimation(Border.WidthProperty, animation3);
            b1.BeginAnimation(Border.HeightProperty, animation4);
            b3.BeginAnimation(Border.WidthProperty, animation3);
            b3.BeginAnimation(Border.HeightProperty, animation4);
            b4.BeginAnimation(Border.WidthProperty, animation3);
            b4.BeginAnimation(Border.HeightProperty, animation4);
            b5.BeginAnimation(Border.WidthProperty, animation3);
            b5.BeginAnimation(Border.HeightProperty, animation4);
        }

        private void b3_MouseEnter(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(b1, 0);
            Panel.SetZIndex(b2, 0);
            Panel.SetZIndex(b3, 1);
            Panel.SetZIndex(b4, 0);
            Panel.SetZIndex(b5, 0);
            b1.RenderTransform = new RotateTransform(-9);
            b2.RenderTransform = new RotateTransform(-8);
            b4.RenderTransform = new RotateTransform(8);
            b5.RenderTransform = new RotateTransform(9);
            b3.BeginAnimation(Border.WidthProperty, animation1);
            b3.BeginAnimation(Border.HeightProperty, animation2);
            b1.BeginAnimation(Border.WidthProperty, animation3);
            b1.BeginAnimation(Border.HeightProperty, animation4);
            b2.BeginAnimation(Border.WidthProperty, animation3);
            b2.BeginAnimation(Border.HeightProperty, animation4);
            b4.BeginAnimation(Border.WidthProperty, animation3);
            b4.BeginAnimation(Border.HeightProperty, animation4);
            b5.BeginAnimation(Border.WidthProperty, animation3);
            b5.BeginAnimation(Border.HeightProperty, animation4);

        }

        private void b4_MouseEnter(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(b1, 0);
            Panel.SetZIndex(b2, 0);
            Panel.SetZIndex(b3, 0);
            Panel.SetZIndex(b4, 1);
            b4.RenderTransform = new RotateTransform(0);
            Panel.SetZIndex(b5, 0);
            b1.RenderTransform = new RotateTransform(-9);
            b2.RenderTransform = new RotateTransform(-8);
            b4.RenderTransform = new RotateTransform(0);
            b5.RenderTransform = new RotateTransform(9);
            b4.BeginAnimation(Border.WidthProperty, animation1);
            b4.BeginAnimation(Border.HeightProperty, animation2);
            b1.BeginAnimation(Border.WidthProperty, animation3);
            b1.BeginAnimation(Border.HeightProperty, animation4);
            b2.BeginAnimation(Border.WidthProperty, animation3);
            b2.BeginAnimation(Border.HeightProperty, animation4);
            b3.BeginAnimation(Border.WidthProperty, animation3);
            b3.BeginAnimation(Border.HeightProperty, animation4);
            b5.BeginAnimation(Border.WidthProperty, animation3);
            b5.BeginAnimation(Border.HeightProperty, animation4);
        }

        private void b5_MouseEnter(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(b1, 0);
            Panel.SetZIndex(b2, 0);
            Panel.SetZIndex(b3, 0);
            Panel.SetZIndex(b4, 0);
            Panel.SetZIndex(b5, 1);
            b1.RenderTransform = new RotateTransform(-9);
            b2.RenderTransform = new RotateTransform(-8);
            b4.RenderTransform = new RotateTransform(8);
            b5.RenderTransform = new RotateTransform(0);
            b5.BeginAnimation(Border.WidthProperty, animation1);
            b5.BeginAnimation(Border.HeightProperty, animation2);
            b1.BeginAnimation(Border.WidthProperty, animation3);
            b1.BeginAnimation(Border.HeightProperty, animation4);
            b2.BeginAnimation(Border.WidthProperty, animation3);
            b2.BeginAnimation(Border.HeightProperty, animation4);
            b3.BeginAnimation(Border.WidthProperty, animation3);
            b3.BeginAnimation(Border.HeightProperty, animation4);
            b4.BeginAnimation(Border.WidthProperty, animation3);
            b4.BeginAnimation(Border.HeightProperty, animation4);

        }
        private void backbord_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void backbord_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b1.RenderTransform = new RotateTransform(-9);
            b2.RenderTransform = new RotateTransform(-8);
            b4.RenderTransform = new RotateTransform(8);
            b5.RenderTransform = new RotateTransform(9);
            Panel.SetZIndex(b1, 0);
            Panel.SetZIndex(b2, 0);
            Panel.SetZIndex(b3, 0);
            Panel.SetZIndex(b4, 0);
            Panel.SetZIndex(b5, 0);
            b1.BeginAnimation(Border.WidthProperty, animation3);
            b1.BeginAnimation(Border.HeightProperty, animation4);
            b2.BeginAnimation(Border.WidthProperty, animation3);
            b2.BeginAnimation(Border.HeightProperty, animation4);
            b3.BeginAnimation(Border.WidthProperty, animation3);
            b3.BeginAnimation(Border.HeightProperty, animation4);
            b4.BeginAnimation(Border.WidthProperty, animation3);
            b4.BeginAnimation(Border.HeightProperty, animation4);
            b5.BeginAnimation(Border.WidthProperty, animation3);
            b5.BeginAnimation(Border.HeightProperty, animation4);
        }
    }
}
