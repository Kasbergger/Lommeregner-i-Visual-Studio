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

namespace Lommeregner_VS
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

        //Sætter operationen til +
        private void Plus_Click(object sender, RoutedEventArgs e) => Operation.Text = "+";

        //Sætter operationen til -
        private void Minus_Click(object sender, RoutedEventArgs e) => Operation.Text = "-";

        //Sætter operationen til *
        private void Gange_Click(object sender, RoutedEventArgs e) => Operation.Text = "*";

        //Sætter operationen til /
        private void Dividere_Click(object sender, RoutedEventArgs e) => Operation.Text = "/";

        //Sætter operationen til x^y
        private void Potens_Click(object sender, RoutedEventArgs e) => Operation.Text = "^";

        //Indeholder hoved programmet og eksekvere det når der trykket =
        private void LigMed_Click(object sender, RoutedEventArgs e)
        {
            //Opsætter variabler
            String doOperation = Operation.Text;
            double num1 = 0;
            double num2 = 0;
            double resultat;

            //Tjekker om input 1 og 2 er tekst eller tal
            if (double.TryParse(Input1.Text, out double result1) == true) { num1 = double.Parse(Input1.Text); }
            else { Resultat.Text = "FEJL, prøv igen!"; doOperation = "?"; }
            if (double.TryParse(Input2.Text, out double result2) == true) { num2 = double.Parse(Input2.Text); }
            else { Resultat.Text = "FEJL, prøv igen!"; doOperation = "?"; }

            //Vælger operationen der skal udføres
            switch (doOperation)
            {
                case "+":
                    resultat = num1 + num2;
                    Resultat.Text = resultat.ToString();
                    break;
                case "-":
                    resultat = num1 - num2;
                    Resultat.Text = resultat.ToString();
                    break;
                case "*":
                    resultat = num1 * num2;
                    Resultat.Text = resultat.ToString();
                    break;
                case "/":
                    resultat = num1 / num2;
                    Resultat.Text = resultat.ToString();
                    break;
                case "^":
                    resultat = Math.Pow(num1, num2);
                    Resultat.Text = resultat.ToString();
                    break;
                default:
                    Resultat.Text = "FEJL, prøv igen!";
                    break;

            }
        }
    }
}
