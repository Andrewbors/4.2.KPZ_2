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
using static CalculatorWpfApp.Algebra;

namespace CalculatorWpfApp
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

        public double getNum1()
        {
            string num1 = ___Num1_.Text;
            double Num1 = System.Convert.ToDouble(num1);
            return Num1;
        }

        public double getNum2()
        {
            string num2 = ___Num2_.Text;
            double Num2 = System.Convert.ToDouble(num2);
            return Num2;
        }

        public void PlC(object sender, RoutedEventArgs e)
        {
            double res = DOD(getNum1(), getNum2());
            string result = System.Convert.ToString(res);
            ___Res_.Text = result;
        }

        public void MiC(object sender, RoutedEventArgs e)
        {
            double res = VID(getNum1(), getNum2());
            string result = System.Convert.ToString(res);
            ___Res_.Text = result;
        }

        public void MnC(object sender, RoutedEventArgs e)
        {
            double res = MN(getNum1(), getNum2());
            string result = System.Convert.ToString(res);
            ___Res_.Text = result;
        }

        public void DiC(object sender, RoutedEventArgs e)
        {
            double res;
            string result;

            if (getNum2() != 0)
            {
                res = DIL(getNum1(), getNum2());
                result = System.Convert.ToString(res);
            }
            else
            {
                result = "Number 2 is wrong";
            }
            
            ___Res_.Text = result;
        }

        public void ClC(object sender, RoutedEventArgs e)
        {
            ___Num1_.Clear();
            ___Num2_.Clear();
            ___Res_.Clear();
        }
    }
}
