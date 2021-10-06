/// Chapter No. 5		Exercise No. 1
/// File Name: MainWindow.xaml.cs
/// @author: Chester Brock 
/// Date:  Sep 20, 2021
///
/// Problem Statement: calculates a person’s BMI and prints a message telling whether they below, within, or above the healthy range.
/// 
/// 
/// Overall Plan:
/// 1) Prompt for the users weight and height 
/// 2) use the formula weight (lb) / height (in) / height (in)] x 720.
/// 3) display the results (blue) - under (green) - met (yellow) - over
/// 
///

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

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int weight = Int32.Parse(YourWeightTextBox.Text);
            int Height = Int32.Parse(YourHeightTextBox.Text);

            // Calculations for converting to BMI 
            int bmi = (weight * 703)/(Height * Height) * 7;

            if(bmi < 15.0)
            {
                Canvas.Background = Brushes.Blue;
                MessageBox.Show("Below BMI: " + bmi);
            }
            else if (bmi >=15.0 && bmi<= 26.0)
            {
                Canvas.Background = Brushes.Green;
                MessageBox.Show("Good BMI: " + bmi);                
            }
            else if(bmi < 26.0)
            {
                Canvas.Background = Brushes.Yellow;
                MessageBox.Show("BMI Over: " + bmi);                
            }
            else
            {
                Canvas.Background = Brushes.Red;
                MessageBox.Show("Invalid Input ");                
            }
        }
    }
}
