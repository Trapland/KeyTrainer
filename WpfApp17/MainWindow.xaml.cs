using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;
using System.Windows;

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> LB = new List<Button>();
        List<Brush> LB_copy = new List<Brush>();
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += timer_Tick;
            timer.Start();
            foreach (var c in g.Children)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button button = (Button)c;
                    LB.Add(button);
                }
            }
            foreach (var c in h.Children)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button button = (Button)c;
                    LB.Add(button);
                }
            }
            foreach (var c in j.Children)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button button = (Button)c;
                    LB.Add(button);
                }
            }
            foreach (var c in k.Children)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button button = (Button)c;
                    LB.Add(button);
                }
            }
            foreach (var c in l.Children)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button button = (Button)c;
                    LB.Add(button);
                }
            }
            foreach (Button b in LB)
            {
                LB_copy.Add(b.Background);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Button b in LB)
            {
                if (b.Content.ToString().ToUpper() == e.Key.ToString().ToUpper() || "D" + b.Content.ToString().ToUpper() == e.Key.ToString().ToUpper())
                {
                    if (b.Background == Brushes.LightGray)
                    {
                        b.Background = Brushes.Gray;
                        break;
                    }
                    else if (b.Background == Brushes.LightPink)
                    {
                        b.Background = Brushes.Pink;
                        break;
                    }
                    else if (b.Background == Brushes.LightYellow)
                    {
                        b.Background = Brushes.Yellow;
                        break;
                    }
                    else if (b.Background == Brushes.LightGreen)
                    {
                        b.Background = Brushes.Green;
                        break;
                    }
                    else if (b.Background == Brushes.LightBlue)
                    {
                        b.Background = Brushes.Blue;
                        break;
                    }
                    else if (b.Background == Brushes.Magenta)
                    {
                        b.Background = Brushes.Purple;
                        break;
                    }
                    else if (b.Background == Brushes.SandyBrown)
                    {
                        b.Background = Brushes.Brown;
                        break;
                    }
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
        }
        void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < LB.Count; i++)
            {
                LB[i].Background = LB_copy[i];
            }
        }
    }
}
