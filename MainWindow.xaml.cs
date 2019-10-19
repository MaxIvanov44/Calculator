using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static double first;
        public static double second;
        public static char oper;
        public MainWindow()
        {
            InitializeComponent();
            output.Text = null;
            this.Width = 328.979;
            this.Height = 469.583;
        }

        private void null_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 0;
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 1;
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 2;
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 3;
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 4;
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 5;
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 6;
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 7;
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 8;
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            output.Text += 9;
        }

        private void Komma_Click(object sender, RoutedEventArgs e)
        {
            output.Text += ",";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());

                oper = '+';

                output.Text = null;

                lbl.Content = first;

                lbl2.Content = "+";
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
           
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());

                oper = '-';

                output.Text = null;

                lbl.Content = first;

                lbl2.Content = "-";
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        private void umnozheniye_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());

                oper = '*';

                output.Text = null;

                lbl.Content = first;

                lbl2.Content = "*";
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        private void deleniye_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());

                oper = '/';

                output.Text = null;

                lbl.Content = first;

                lbl2.Content = "/";
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (output.Text.Length > 0) output.Text = output.Text.Substring(0, output.Text.Length - 1);
        }

        private void _C_Click(object sender, RoutedEventArgs e)
        {
            output.Text = null;
            lbl.Content = null;
            lbl3.Content = null;
            lbl2.Content = null;
        }

        private void _x2_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToDouble(output.Text.Trim());
            output.Text = Convert.ToString(Math.Pow(first, 2));
            lbl.Content = first + "^2";
        
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (this.Height == 469.583)  
            {
                this.Height = 585.583;
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("../../Resources/up.png", UriKind.Relative));
                brush.Stretch = Stretch.Uniform;
                add.Background = brush;
            }
            else
            {
                this.Height = 469.583;
                var brush2 = new ImageBrush();
                brush2.ImageSource = new BitmapImage(new Uri("../../Resources/down.png", UriKind.Relative));
                add.Background = brush2;
                brush2.Stretch = Stretch.Uniform;
            }
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                second = Convert.ToDouble(output.Text.Trim());
                lbl3.Content = second;
                switch (oper)
                {
                    case '+':
                        output.Text = Convert.ToString(first + second);
                        break;
                    case '-':
                        output.Text = Convert.ToString(first - second);
                        break;
                    case '*':
                        output.Text = Convert.ToString(first * second);
                        break;
                    case '/':
                        output.Text = Convert.ToString(first / second);
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());
                output.Text = Convert.ToString(Math.Sqrt(first));
                lbl.Content = "√";
                lbl2.Content = first;
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        private void sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());
                output.Text = Convert.ToString(Math.Sin(first));
                lbl.Content = "sin (" + first + ")";
                lbl2.Content = null;
                lbl3.Content = null;
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        private void tan_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());
                output.Text = Convert.ToString(Math.Tan(first));
                lbl.Content = "tan (" + first + ")";
                lbl2.Content = null;
                lbl3.Content = null;
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }

        }

        private void ctg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());
                output.Text = Convert.ToString(1.0 / Math.Tan(first));
                lbl.Content = "ctg (" + first + ")";
                lbl2.Content = null;
                lbl3.Content = null;
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }

        }

        private void cos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                first = Convert.ToDouble(output.Text.Trim());
                output.Text = Convert.ToString(Math.Cos(first));
                lbl.Content = "cos (" + first + ")";
                lbl2.Content = null;
                lbl3.Content = null;
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
           
        }
         private void Warning(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для открытия других функций нажмите ЛКМ 2 раза на стрелке.", "Warning");
            add_Copy.Visibility = Visibility.Hidden;
        }
    }
    }

