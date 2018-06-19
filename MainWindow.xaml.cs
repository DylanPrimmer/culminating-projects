//DylanPrimmer
//Culminating assignment
//Calculate even number sum in fibonacci sequence
//06.12.2018

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

namespace Fibonacci_culminating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {// creates variables for code and sets values
        int Total = 0;
        public static int Fibonacci(int n) {
            int x = 0;
            int y = 1;
            
            
            for (int i = 0; i < n; i++)  {

                int temp = x;
                x = y;
                y = temp + y;
                

            }
            return x;

                }
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 34; i ++)
            { 

                // shows output of code
                Console.WriteLine(Fibonacci(i));
                if (Fibonacci(i) % 2 == 0)
                    
                {
                    Console.WriteLine("even");
                    Total += Fibonacci(i);

                }
            }
            Console.Read();
            MessageBox.Show(Total.ToString());
        }
    }
}
