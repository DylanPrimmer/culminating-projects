//Dylan Primmer
//Euler Power digit sum Project
//June 19, 2018
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

namespace power_digit_sum_culm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
            InitializeComponent();
            int[] digits = new int[350];

            
            digits[0] = 1;
            //2 to the power of 1000
            for (int i = 0; i < 1000; i++)
            {
                //multiply digits by 2
                for (int T = digits.Length - 2; T >= 0; T--)
                {
                    digits[T] *= 2;
                    digits[T + 1] += digits[T] / 10;
                    digits[T] %= 10;
                }
            }

            //find sum
            double sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }
            //show answer
            Console.WriteLine(sum);
            MessageBox.Show("The sum of the product of 2^1000");
            MessageBox.Show(sum.ToString());
        }
    }
}
    

