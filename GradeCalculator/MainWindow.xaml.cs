using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GradeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            one.Text = "Assignment 1";
            two.Text = "Assignment 2";
            three.Text = "Assignment 3";
            four.Text = "Assignment 4";
            five.Text = "Assignment 5";
            six.Text = "Assignment 6";
            seven.Text = "Assignment 7";
            eight.Text = "Assignment 8";
            modechange.SelectedIndex  = 0;
            
            
        }
        decimal percentage1,percentage2,percentage3,percentage4,percentage5,percentage6,percentage7,percentage8;
        decimal graded1, graded2, graded3, graded4, graded5, graded6,graded7,graded8;
        decimal answer;
        bool percentSelected, pointsSelected;

        public bool PercentCheck()
        {
            decimal totalpercent = percentage1*100 + percentage2*100 + percentage3*100 + percentage4*100 + percentage5*100 + percentage6*100 + percentage7*100 + percentage8*100;
            if (totalpercent != 100 )
            {
                MessageBox.Show("Sum of all percents does not equal 100","Error");
                return false;
                
            }
            else
            {
                
                return true;
            }
         }


        public bool PointsCheck()
        {

            if (graded1 <= percentage1 * 100 && graded2 <= percentage2 * 100 && graded3 <= percentage3 * 100 && graded4 <= percentage4 * 100 && graded5 <= percentage5 * 100 && graded6 <= percentage6 * 100 && graded7 <= percentage7 * 100 && graded8 <= percentage8 * 100)
            {

                return true;

            }
            else
            {
                if (MessageBox.Show("The total number of points exceeds the maximum allowed, would you like to calculate anyways?", "Error", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            
        }
        private void percent1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage1 = Convert.ToDecimal(percent1.Text)/100;
          
            }
            catch (Exception g)
            {
                MessageBox.Show("Only Digits Please","Error");
                
            }
        }
        private void percent2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage2 = Convert.ToDecimal(percent2.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Only Digits Please", "Error");
               
            }
        }
        private void percent3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage3 = Convert.ToDecimal(percent3.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void percent4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage4 = Convert.ToDecimal(percent4.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void percent5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage5 = Convert.ToDecimal(percent5.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void percent6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage6 = Convert.ToDecimal(percent6.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void percent7_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage7 = Convert.ToDecimal(percent7.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void percent8_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                percentage8 = Convert.ToDecimal(percent8.Text) / 100;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded1 = Convert.ToDecimal(grade1.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded2 = Convert.ToDecimal(grade2.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded3 = Convert.ToDecimal(grade3.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded4 = Convert.ToDecimal(grade4.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded5 = Convert.ToDecimal(grade5.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded6 = Convert.ToDecimal(grade6.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade7_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded7 = Convert.ToDecimal(grade7.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }
        private void grade8_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                graded8 = Convert.ToDecimal(grade8.Text);
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error");
            }
        }



        private void Percentage_Selected(object sender, RoutedEventArgs e)
        {
            percentSelected = true;
            pointsSelected  = false;
            Percent.Text = "Percent of Final(%)";
            Percent.FontWeight = FontWeights.Bold;
            Grade.FontWeight = FontWeights.Bold;
            Grade.Text = "My Grade";
            
        }
        private void Points_Selected(object sender, RoutedEventArgs e)
        {
            percentSelected = false;
            pointsSelected = true;
            Percent.Text = "Point Value";
            Percent.FontWeight = FontWeights.Bold;
            Grade.FontWeight = FontWeights.Bold;
            Grade.Text = "My Points";     
            
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (percentSelected == true && PercentCheck() == true)
                {
                    decimal final1 = percentage1 * graded1;
                    decimal final2 = percentage2 * graded2;
                    decimal final3 = percentage3 * graded3;
                    decimal final4 = percentage4 * graded4;
                    decimal final5 = percentage5 * graded5;
                    decimal final6 = percentage6 * graded6;
                    decimal final7 = percentage7 * graded7;
                    decimal final8 = percentage8 * graded8;
                    decimal total = final1 + final2 + final3 + final4 + final5 + final6+ final7+ final8;
                    answer = answer = Math.Round(total, 4);
                    Output();


                }

                if (pointsSelected == true && PointsCheck() == true)
                {

                    decimal totalpoints = percentage1 + percentage2+ percentage3 + percentage4+ percentage5 + percentage6 +percentage7 + percentage8;
                    decimal receivedpoints = graded1 + graded2 + graded3 + graded4 + graded5 + graded6+ graded7+ graded8;
                    decimal total = receivedpoints / totalpoints;
                    answer = Math.Round(total,4);
                    Output();
                }
            }
           catch (Exception L)
            {
                MessageBox.Show("Make sure all of the boxes are filled","Error");
            } 
        }

        int caseSwitch;
        private void Output()
        {
            if (answer < 70)
            {
                caseSwitch = 1;
            }
            if (answer >= 70 && answer < 80)
            {
                caseSwitch = 2;
            }
            if (answer >= 80 && answer < 90)
            {
                caseSwitch = 3;
            }
            if (answer >= 90)
            {
                caseSwitch = 4;
            }
            
            switch (caseSwitch)
            {
                case 1:
                    OutputBox.Text = "EEK! You currently have a " + answer + "%"; 
                    break;
                case 2:
                    OutputBox.Text = "Passing. You currently have a " + answer + "%"; 
                    break;
                case 3:
                    OutputBox.Text = "You currently have a " + answer + "%"; 
                    break;
                case 4:
                    OutputBox.Text = "You have an A! " + answer + "%"; 
                    break;
            }

        }
        



    }
}
