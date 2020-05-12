//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Project 5 - Capital State Game                                                                                  
//  File Name:      GameForm.cs
//  Description:    Runs the program using forms                                                                               
//  Course:         CSCI 2210-001                                                                            
//  Author:         Johnny Pack, packjc@etsu.edu, Department of Computing, East Tennessee State University
//                  
//  Created:        Monday, December 3, 2018                                                                      
//  Copyright:      Johnny Pack, 2018                                                                           
//                                                                                                              
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// Front-end and backend of the program, uses forms to display game
    /// </summary>
    public partial class GameForm : Form
    {
        /// <summary>
        /// Create SortedDictionary Game to hold states and capitals
        /// </summary>
        public static SortedDictionary<String, String> Game = new SortedDictionary<String, String>();
        /// <summary>
        /// Create states array for each state
        /// </summary>
        public static String[] States = new String[50];
        /// <summary>
        /// Create capitals array for each capital
        /// </summary>
        public static String[] Capitals = new String[50];
        /// <summary>
        /// the amount gotten correct
        /// </summary>
        public static int CorrectAmt = 0;
        /// <summary>
        /// number of attempts
        /// </summary>
        public static int AttemptAmt = 0;
        /// <summary>
        /// create random object for random numbers
        /// </summary>
        Random ran = new Random();
        /// <summary>
        /// used to hold one state
        /// </summary>
        public static String State { get; set; }
        /// <summary>
        /// used to hold on capital
        /// </summary>
        public static String Capital { get; set; }
        /// <summary>
        /// Index of the state and capital that will be randomly choosen
        /// </summary>
        public static int ranIndex = 0;
        /// <summary>
        /// the time left in seconds
        /// </summary>
        public static int timeLeft = 15; 
        /// <summary>
        /// the item selected in the ListBox
        /// </summary>
        public static String ItemSelected;

        /// <summary>
        /// Reads the data from file, fills the arrays needed for search
        /// </summary>
        public static void FillDiction()
        {
            int counter = 0; //used for arrays
            String strIn = String.Empty; //string that will be coming in
            StreamReader reader = new StreamReader(@"/StateGameProject/State Data/states.txt");
            //while reader still has data
            while (reader.Peek() != -1)
            {
                strIn = reader.ReadLine(); 
                String[] fields = strIn.Split(','); //split data using ,
                Capital = fields[0]; //add in key from fields
                State = fields[1].Trim(); //add in value from fields
                Capitals[counter] = Capital; //assign in array
                States[counter] = State; //assin in array
                Game.Add(Capital, State); //add in key and value
                counter++; //update counter used for arrays
            }
            reader.Close(); //close file read
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameForm()
        {
            FillDiction();
            InitializeComponent();           
        }
        /// <summary>
        /// when game form is loaded, execute these things
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            ranIndex = ran.Next(49);    //get new random number
            AttemptsBox.Text = AttemptAmt.ToString(); //update attempts box
            CorrectBox.Text = CorrectAmt.ToString(); //update correct box
            foreach(String Capital in Game.Keys)
            {
                CapitalBox.Items.Add(Capital);//add each capital to listbox 
            }
            StateBox.Text = Game[Capitals[ranIndex]]; //display first state
            String state = StateBox.Text.Trim();
            state = state.Replace(" ", "");
            StatePicture.ImageLocation = @"StateGameProject\State Pictures\" + state + "State.jpg";
            Timer.Start();  //start timer and game
        }
        /// <summary>
        /// when next button is clicked, update boxes and restart timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                //If game contains the key related to the value
                if (Game[ItemSelected].Contains(States[ranIndex]))
                {
                    CorrectAmt++;
                    CorrectBox.Text = Convert.ToString(CorrectAmt);
                }
                else
                {
                    AttemptAmt++;
                    AttemptsBox.Text = Convert.ToString(AttemptAmt);
                }
            }
            catch
            {
                MessageBox.Show("Please Select a Capital first!");
            }
            CapitalBox.Enabled = true; //enable controls again
            ranIndex = ran.Next(49); //get new random number
            StateBox.Text = Game[Capitals[ranIndex]]; //display new state
            String state = StateBox.Text;
            state = state.Replace(" ", "");
            StatePicture.ImageLocation = "C:/Users/ECHO/Desktop/Project5/State Pictures/" + state + "State.jpg";
            timeLeft = 15;  //reset timer
            Timer.Start();

        }
        /// <summary>
        /// When CapitalBox is selected get the item selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapitalBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ItemSelected = (String)CapitalBox.SelectedItem; //get the item selected from capital box

        }
        /// <summary>
        /// When Attempts box changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttemptsBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// when state box changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// when the timer ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                Timer.Start();
                timeLeft--;
                TimerBox.Text = Convert.ToString(timeLeft); //Display time left
            }
            else
            {
                Timer.Stop();       //Stop timer
                TimerBox.Text = "0";    //Set timer to 0
            }
            if (timeLeft == 0)
            {
                CapitalBox.Enabled = false; //Disable list box
                Timer.Stop();                //Stop timer
                 
            }
        }
        /// <summary>
        /// when text is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// when exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndGame_Click(object sender, EventArgs e)
        {
                int correct = Convert.ToInt32(CorrectBox.Text);
                int attempted = Convert.ToInt32(AttemptsBox.Text);
                double percentage = (8 / 12);
            double answer = percentage * 100;
            string convert = answer.ToString();
            string answerStr = "Thank you for trying your luck at the State Capital Matching Game.\nYour score was " + convert + "% on " + AttemptAmt + " attempts.";
            try
            {
                MessageBox.Show(answerStr);
                Application.Exit();

            }
            catch
            {
                MessageBox.Show("Thank you for trying your luck at the State Capital Matching Game.\nYour score was " + 0.0 + "% on " + 0 + " attempts.");
                Application.Exit();

            }
        }
    }
}
