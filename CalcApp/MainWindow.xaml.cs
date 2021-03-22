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

namespace CalcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double first = 0;
        string operation = "";
        string output = "";
        public MainWindow()
        {
            InitializeComponent();

            //data context says where to look for binding variables.
            this.DataContext = this;
            DivideBtn.Content = "\u00F7";
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            //name= name of button
            string name = ((Button)sender).Name;

            switch (name) 
            {
                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;
                case "OneBtn":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;
                case "TwoBtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;
                case "ThreeBtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;
                case "FourBtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;
                case "FiveBtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;
                case "SixBtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;
                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;
                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;
                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if(output != "")
            {
                //store the string value ouput in temp of type double
                first = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                //store the string value ouput in temp of type double
                first = double.Parse(output);
                output = "";
                operation = "Times";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                //store the string value ouput in temp of type double
                first = double.Parse(output);
                output = "";
                operation = "Divide";
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                //store the string value ouput in temp of type double
                first = double.Parse(output);
                output = "";
                operation = "Plus";
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double result;
            switch (operation) 
            {
                case "Minus":
                    //result is first - second number
                    result = first - double.Parse(output);
                    //ToString converts result into string again
                    output = result.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Plus":
                    result = first + double.Parse(output);
                    output = result.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Divide":
                    if(double.Parse(output) != 0)
                    {
                        result = first / double.Parse(output);
                        output = result.ToString();
                        OutputTextBlock.Text = output;
                    }
                    break;
                case "Times":
                    result = first * double.Parse(output);
                    output = result.ToString();
                    OutputTextBlock.Text = output;
                    break;
            }

        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
        }
    }
}
