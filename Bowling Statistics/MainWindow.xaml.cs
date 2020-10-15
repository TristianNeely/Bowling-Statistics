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

namespace Bowling_Statistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double SeriesTotal;
        double gameOne;
        double gameTwo;
        double gameThree;
        double Average1;
        double Handicap1;
       


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {


            Result1.Text = "";
            Result2.Text = "";
            Result3.Text = "";
            SeriesResult.Text = "";
            AverageResult.Text = "";
            name.Text = "";
            HandicapResult.Text = "";
            HighGame.Text = "";
            
            
            



             
               
            


        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
             gameOne = double.Parse(Result1.Text);
            gameTwo = double.Parse(Result2.Text);
            gameThree = double.Parse(Result3.Text);

            SeriesTotal = gameOne + gameTwo + gameThree;

            SeriesResult.Text = Convert.ToString(SeriesTotal);

            Average1 = SeriesTotal / 3;

            AverageResult.Text = Convert.ToString(Average1);


            Handicap1 = 200 - Average1 * .8;

            HandicapResult.Text = Convert.ToString(Handicap1);

        }

        private void Average_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Handicap_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void High_Click(object sender, RoutedEventArgs e)
        {


           

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }
    }
}
