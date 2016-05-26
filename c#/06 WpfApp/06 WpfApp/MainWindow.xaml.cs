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

namespace _06_WpfApp
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

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            var newRandom = random.Next(1, 10);
            var textFromUser = this.textFromUser.Text;
            var valueFromUser = 0;
            var messege = "No: ";


            if (int.TryParse(textFromUser, out valueFromUser) && valueFromUser == newRandom)
            {
                messege = "Yes: ";
            }
            

            this.labelResult.Content = messege + newRandom;
            


        }
    }
}
