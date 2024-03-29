﻿using System;
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

namespace RockPaperScissorsLizardSpock
{
    /*
       Written by Tichaona Zvidzayi
       Date Last Modified 25 Nov 2021

                            - Scissors cuts Paper
                            - Paper covers Rock
                            - Rock crushes Lizard
                            - Lizard poisons Spock
                            - Spock smashes Scissors
                            - Scissors decapitates Lizard
                            - Lizard eats Paper
                            - Paper disproves Spock
                            - Spock vaporizes Rock
      (and as it always has) Rock crushes Scissors


    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(@"WELCOME TO Rock, Paper, Scissors, Lizard && Spock 
                            - Scissors cuts Paper 
                            - Paper covers Rock     
                            - Rock crushes Lizard   
                            - Lizard poisons Spock  
                            - Spock smashes Scissors 
                            - Scissors decapitates Lizard 
                            - Lizard eats Paper    
                            - Paper disproves Spock  
                            - Spock vaporizes Rock  
                            - Rock crushes Scissors");                     //welcome message
        }
        short alienScore = 0, humanScore = 0, sets = 3;
        string[] xs = { "rock", "paper", "scissors", "lizard", "spock" };

        private string CompChoice()
        {
            Random rn = new Random(Guid.NewGuid().GetHashCode());            //Alien pick
            return xs[rn.Next(5)];
      
        }

        private void Results(string human, string alien )
        {

            bool win =false, draw = false;

            try
            {
                sets = Convert.ToInt16(nsets.Text);              //Validate number of sets
            }
            catch { sets = 3; }

                if (human == xs[0])
                { //User chooses rock
                    if (alien == xs[1] || alien == xs[4])          // paper or spock
                        alienScore += 3;

                    else if (alien == xs[2] || alien == xs[3])     // scissors or lizard
                    {
                        win = true;
                        humanScore += 3;
                    }
                    else
                    {
                        draw = true;
                        humanScore++;
                        alienScore++;
                    }
                }

                if (human == xs[1])
                { //User chooses paper
                    if (alien == xs[2] || alien == xs[3])         // scissors or lizard
                        alienScore += 3;

                    else if (alien == xs[0] || alien == xs[4])
                    {                                             // rock or spock
                        win = true;
                        humanScore += 3;
                    }
                    else
                    {
                        draw = true;
                        humanScore++;
                        alienScore++;
                    }
                }

                if (human == xs[2])
                { //User chooses rock
                    if (alien == xs[1] || alien == xs[4])           //paper or spock
                        alienScore += 3;


                    else if (alien == xs[0] || alien == xs[4])
                    {                                               // scissors or lizard
                        win = true;
                        humanScore += 3;
                    }

                    else
                    {
                        draw = true;
                        humanScore++;
                        alienScore++;
                    }
                }

                if (human == xs[3])
                { //User chooses lizard
                    if (alien == xs[0] || alien == xs[2])           // rock or scissors 
                        alienScore += 3;

                    else if (alien == xs[1] || alien == xs[4])
                    {// paper or spock
                      win = true;
                      humanScore += 3;
                }
                    else
                    {
                        draw = true;
                        humanScore++;
                        alienScore++;
                    }
                }

                if (human == xs[4])
                { //User chooses spock
                    if (alien == xs[3] || alien == xs[1])           // lizard or paper
                        alienScore += 3;

                    else if (alien == xs[0] || alien == xs[2])
                    {                                               //  User chooses scissors or rock
                        win = true;
                        humanScore += 3;
                    }
                    else
                    {
                        draw = true;
                        humanScore++;
                        alienScore++;
                    }
                }


            scrn.Text = draw ? String.Format(@"Mmmmh its a draw you both chose {0}", human) :
                             (win ? String.Format(@"Congrats :) YOU won this round! ALIEN chose {0} and YOU chose {1} ", alien, human) :
                               String.Format(@" Oops :( YOU lost the round. ALIEN chose {0} and YOU chose {1}", alien, human));

            hmn.Text = humanScore.ToString();
            cmp.Text = alienScore.ToString();
            sets--;
            nsets.Text = (sets).ToString(); 
          
            if (sets <= 0)
            {

                string k = humanScore == alienScore ? "The Game ended in a draw" : humanScore > alienScore ? String.Format(@"CONGRATS you won the game!
                                                          Your Score = {0}, ALIEN Score = {1}", humanScore, alienScore) : String.Format(@"
                                                          Oops YOU lost the game try again.
                                                          Your Score = {0}, ALIEN Score = {1}", humanScore, alienScore);
                MessageBox.Show(k);
                ResetGame();
            }

        }
        private void ResetGame()
        {
            alienScore = 0; humanScore = 0; sets =3;
            hmn.Text = humanScore.ToString();
            cmp.Text = alienScore.ToString();
            scrn.Text= "WELCOME TO Rock, Paper, Scissors, Lizard && Spock";
            nsets.Text = "3";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { //Rock 

         Results(xs[0], CompChoice());

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {// Paper
            Results(xs[1], CompChoice());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        { //Scissors
            Results(xs[2], CompChoice());
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {// Lizard
            Results(xs[3], CompChoice());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {//Spock
            Results(xs[4], CompChoice());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        { //reset scores
            ResetGame();
        }
    }
}
