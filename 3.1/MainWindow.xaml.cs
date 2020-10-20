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

namespace _3._1
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
        public static double Factorial(int n)
        {
            double res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

            private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double W, Wr;
            Wr = 0;
            int k = int.Parse(BlockCount.Text);
            bool Check = int.TryParse(BlockCount.Text, out _);
            if (Check)
            {
                for (int i = -2; i < k; i++)
                {
                    W = (Math.Pow(-1, i) * Factorial(i + 3)) / (i - 4);
                    if (W == 0) continue;
                    if ((i - 4) == 0) continue;
                    Wr += W;
                }
                Result.Text = Convert.ToString(Wr);
            }
            else Result.Text = "Введено недопустимое значение k";

        }
    }
}
