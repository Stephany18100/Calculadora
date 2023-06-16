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

namespace Calculadora
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
        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                string value = (string)button.Content;

                if (IsNumber(value))
                {
                    HandelNumbers(value);
                }
                else if (IsOperator(value))
                {
                    HandleOperador(value);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("sucedio un error" + ex.Message);
            }


        }

        //  Metodos auxiliares
        private bool IsNumber(string num)
        {
            //if(double.TryParse(num, out _))
            //{
            //    return true;
            //}
            //return false;

            return double.TryParse(num, out _);
        }

        private void HandelNumbers(string value)
        {
            if (String.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text = value;

            }
            else
            {
                Screen.Text += value;
            }
        }

        private bool IsOperator(string possibleOperator)
        {
            //if(possibleOperator=="+" || possibleOperator == "-" || possibleOperator=="*" || possibleOperator =="/")
            //{
            //    return true;
            //}
            //return false;

            return possibleOperator == "+" || possibleOperator == "-" || possibleOperator == "*" || possibleOperator == "/";
        }
        private void HandleOperador(string value)
        {
            if (!String.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text += value;
            }
        }
    }
}
