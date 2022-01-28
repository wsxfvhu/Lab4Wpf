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

namespace Lab4Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resRouble = rateDollar * sumDollar;
            resSum.Text = resRouble.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate1.Text);
            double sumEvro = Convert.ToDouble(sum1.Text);
            double resRouble = rateEvro * sumEvro;
            resSum1.Text = resRouble.ToString();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate2.Text);
            double sumGriv = Convert.ToDouble(sum2.Text);
            double resRouble = rateGriv * sumGriv;
            resSum2.Text = resRouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resRouble = rateDram * sumDram;
            resSum3.Text = resRouble.ToString();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            m1.Text = (Convert.ToDouble(d.Text) * 0.0254).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            m2.Text = (Convert.ToDouble(f.Text) * 0.3048).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            m3.Text = (Convert.ToDouble(ml.Text) * 1609.34).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            m4.Text = (Convert.ToDouble(v.Text) * 1066.8).ToString();
        }
    }
}
