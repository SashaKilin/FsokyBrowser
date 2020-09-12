using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WebBrowser2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            web.Source = new Uri("http://google.com");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                web.Source = new Uri("https://www.google.com/search?sxsrf=ALeKk00MwQUowfx46r7MgnF5LJmUREtYVw%3A1599823609321&ei=-V5bX4uPE72HwPAPnvuP-A8&q=" + textBox.Text + "&oq=" + textBox.Text + "&gs_lcp=CgZwc3ktYWIQAzIECAAQQzIHCC4QsQMQQzIHCAAQsQMQQzIFCC4QsQMyBAguEEMyBQguELEDMgIIADICCAAyAggAMgUIABCxAzoECCMQJzoICAAQsQMQgwE6CgguELEDEEMQkwJQkWNY8GtguW5oAHAAeACAAXeIAfADkgEDMy4ymAEAoAEBqgEHZ3dzLXdpesABAQ&sclient=psy-ab&ved=0ahUKEwjL776v_-DrAhW9AxAIHZ79A_8Q4dUDCA0&uact=5");
                textBox.Text = "";
                textBox.Text = Convert.ToString(web.Source);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    web.Source = new Uri("https://www.google.com/search?sxsrf=ALeKk00MwQUowfx46r7MgnF5LJmUREtYVw%3A1599823609321&ei=-V5bX4uPE72HwPAPnvuP-A8&q=" + textBox.Text + "&oq=" + textBox.Text + "&gs_lcp=CgZwc3ktYWIQAzIECAAQQzIHCC4QsQMQQzIHCAAQsQMQQzIFCC4QsQMyBAguEEMyBQguELEDMgIIADICCAAyAggAMgUIABCxAzoECCMQJzoICAAQsQMQgwE6CgguELEDEEMQkwJQkWNY8GtguW5oAHAAeACAAXeIAfADkgEDMy4ymAEAoAEBqgEHZ3dzLXdpesABAQ&sclient=psy-ab&ved=0ahUKEwjL776v_-DrAhW9AxAIHZ79A_8Q4dUDCA0&uact=5");
                    textBox.Text = "";
                    textBox.Text = Convert.ToString(web.Source);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void web_Navigated(object sender, NavigationEventArgs e)
        {
            try
            {
                textBox.Text = Convert.ToString(web.Source);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            web.Source = new Uri("http://google.com");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                web.GoForward();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                web.GoBack();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                web.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            web.Refresh();
        }

        public double x;
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {

                x = ActualWidth;
                toolBar.Width = x;

                if (Convert.ToInt32(e.NewSize.Width) < Convert.ToInt32(e.PreviousSize.Width))
                {
                    double o = e.PreviousSize.Width - e.NewSize.Width;
                    textBox.Width = textBox.Width - o;
                }
                else if (Convert.ToInt32(e.NewSize.Width) > Convert.ToInt32(e.PreviousSize.Width))
                {
                    if (Convert.ToInt32(e.PreviousSize.Width) == 0)
                    {

                    }
                    else
                    {
                        double o = e.NewSize.Width - e.PreviousSize.Width;
                        textBox.Width = textBox.Width + o;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка: " + ee.Message);
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void MoreClick(object sender, RoutedEventArgs e)
        {
            More page = new More();
            page.Show();
        }
    }
}
