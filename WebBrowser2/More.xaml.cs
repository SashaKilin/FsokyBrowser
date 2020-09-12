using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WebBrowser2
{
    /// <summary>
    /// Логика взаимодействия для More.xaml
    /// </summary>
    public partial class More : Window
    {
        public More()
        {
            InitializeComponent();
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("FsokyBrows - прикладное программное обеспечение для просмотра страниц, содержания веб-документов, компьютерных файлов и их каталогов; управления веб-приложениями; а также для решения других задач.\nРазработчик: STuLLeXy#7777\n\n©Copyright 2020 year", "About Fsoky Browser", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GoToCommandClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Если хотешь попасть в команду 'FsokyDev' - то пиши мне в вк: http://vk.com/maybetrue1 \nИли Discord: STuLLeXy#7777", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
