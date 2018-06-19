//Dylan Primmer
// multiples of 3 and 5 up to 1000
//euler
//June 14 2018

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

namespace _3_and_5_culminating
{ 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i;

        public MainWindow()
        {
            InitializeComponent();

            int sum = 0;


            for (int i = 3; i < 1000; i = i + 1)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            // show sum of multiples of 3 and 5
            Console.WriteLine(sum);
            MessageBox.Show(sum.ToString());



        }
    }
}
