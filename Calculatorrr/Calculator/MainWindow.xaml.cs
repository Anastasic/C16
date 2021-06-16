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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate cal = new Calculate();

        public MainWindow()
        {
            InitializeComponent();
            buttonsbox.IsEnabled = false;
            displayTextbox.IsEnabled = false;
        }

        private void NumOpButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (displayTextbox.Text == "Error! Try again.")
            {
                displayTextbox.Text = "";
                Button button = (Button)sender;
                displayTextbox.Text += button.Content.ToString();
            }
            
            else if(displayTextbox.Text == "На ноль делить нельзя!")
            {
                displayTextbox.Text = "";
                Button button = (Button)sender;
                displayTextbox.Text += button.Content.ToString();
            }
            else
            {
                Button button = (Button)sender;
                displayTextbox.Text += button.Content.ToString();
            }
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                
                foreach(char er in displayTextbox.Text)
                {
                    
                    if (char.IsNumber(er) == true)
                    {
                        //char f = Convert.ToChar(displayTextbox.Text);
                        displayTextbox.Text = Convert.ToString(displayTextbox.Text);
                    }
                    else
                    {
                        displayTextbox.Text = "Error! Try again.";
                    }

                }
               
                
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string g1 = displayTextbox.Text;
            int d = g1.Length;
            g1 = g1.Remove(d);

        }
        private void FuncButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == onButton)
            {
                displayTextbox.Text = "";
                buttonsbox.IsEnabled = true;
                displayTextbox.IsEnabled = true;
            }
            else if (sender == offButton)
            {
                displayTextbox.Text = "Off";
                buttonsbox.IsEnabled = false;
                displayTextbox.IsEnabled = false;
            }
            else if (sender == clearButton)
            {
                displayTextbox.Text = "";
            }
        }
        

        private void Calculate()
        {
            int opPos = 0;
            double value1 = 0;
            double value2 = 0;
            double result = 0;
            string op = "";

            
            if (displayTextbox.Text.Contains("*"))
            {
                opPos = displayTextbox.Text.IndexOf("*");
            }
            else if (displayTextbox.Text.Contains("/"))
            {
                opPos = displayTextbox.Text.IndexOf("/");
            }
            else if (displayTextbox.Text.Contains("+"))
            {
                opPos = displayTextbox.Text.IndexOf("+");
            }
            else if (displayTextbox.Text.Contains("-"))
            {
                opPos = displayTextbox.Text.IndexOf("-");
            }
            else if (displayTextbox.Text.Contains(","))
            {
                opPos = displayTextbox.Text.IndexOf(",");
            }
            else if (displayTextbox.Text.Contains("%"))
            {
                opPos = displayTextbox.Text.IndexOf("%");
            }

            value1 = Double.Parse(displayTextbox.Text.Substring(0, opPos));
            op = displayTextbox.Text.Substring(opPos, 1);
            string a = op;
            value2 = Double.Parse(displayTextbox.Text.Substring(opPos + 1, displayTextbox.Text.Length - opPos - 1));
            if (op == "*")
            {
                result = cal.multiply(value1, value2);
                displayTextbox.Text = result.ToString();
            }
            else if (op == "/")
            {
                if (value2 == 0)
                {
                    displayTextbox.Text = "На ноль делить нельзя!";
                }
                else
                {
                    result = cal.divide(value1, value2);
                    displayTextbox.Text = result.ToString();
                }
            }
            else if (op == "+")
            {
                result = cal.add(value1, value2);
                displayTextbox.Text = result.ToString();
            }
            else if (op == "-")
            {
                result = cal.subtract(value1, value2);
                displayTextbox.Text =  result.ToString();
            }
            else if (op == "%")
            {
                result = cal.proz(value1, value2);
                displayTextbox.Text = result.ToString();
            }
        }
    }
}
