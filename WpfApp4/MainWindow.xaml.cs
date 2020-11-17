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

namespace WpfApp4
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
            double x = Math.Abs(double.Parse(inX.Text)), n = double.Parse(inN.Text);
            double sum = 0, aTan = Math.Atan(x);
            double c = n;

            if(x > 1)
            {
                count.Content = "Ошибочный Х";
                res.Content = "";
                resAtan.Content = "";
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                double s = 2 * i - 1;
                sum += Math.Pow(-1, i - 1) * (Math.Pow(x, s) / s);

                if(sum.Equals(aTan))
                {
                    c = i;
                    break;
                }
            }

            res.Content = "Мой результат - " + sum;
            resAtan.Content = "Argt - " + aTan;
            count.Content ="Хватило бы " + c + " итр.";
        }
    }
}
