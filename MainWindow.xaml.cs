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

using System;
using System.Windows;

namespace QuadraticEquationSolverWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(coeffATextBox.Text, out double a) ||
                !double.TryParse(coeffBTextBox.Text, out double b) ||
                !double.TryParse(coeffCTextBox.Text, out double c))
            {
                resultLabel.Content = "Некоректні коефіцієнти. Будь ласка, введіть дійсні числа.";
                return;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                resultLabel.Content = $"Дискримінант: {discriminant}\nРозв'язки: {root1}, {root2}";
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                resultLabel.Content = $"Дискримінант: {discriminant}\nРозв'язок: {root}";
            }
            else
            {
                resultLabel.Content = "Розв'язків немає.";
            }
        }
    }
}
