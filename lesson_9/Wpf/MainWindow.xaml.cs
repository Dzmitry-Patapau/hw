using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using static System.Net.Mime.MediaTypeNames;

namespace Wpf
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

        private void Button_Reverse(object sender, RoutedEventArgs e)
        {
            label1.Content = Reverse(textBox2.Text);
        }

        private void Button_Split(object sender, RoutedEventArgs e)
        {
            listBox1.ItemsSource = Split(textBox1.Text);
        }

        static List<string> Split(string text)
        {
            List<string> tempList = text.Split().ToList();
            tempList.RemoveAll(x => string.IsNullOrWhiteSpace(x));
            return tempList;
        }

        static string Reverse(string text)
        {
            List<string> list = Split(text);
            StringBuilder sb = new StringBuilder();
            for (int n = 0; n <= list.Count - 1; n++)
            {
                sb.Append(list[list.Count - 1 - n] + " ");
            }
            return sb.ToString();
        }
    }
}
