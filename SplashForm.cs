//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Project 5 - Capital State Game                                                                                  
//  File Name:      SplashForm.cs
//  Description:    Splash SCreen
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// Splash Screem
    /// </summary>
    public partial class Splash_Screen : Form
    {
        /// <summary>
        /// timer
        /// </summary>
        public int timeLeft { get; set; }
        /// <summary>
        /// intiilize
        /// </summary>
        public Splash_Screen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load
        /// </summary>
        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timeLeft = 15;
            Splash_Timer.Start();
        }
        /// <summary>
        /// timer counter
        /// </summary>
        private void Splash_Timer_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                Splash_Timer.Stop();
                new GameForm().Show(); //start program
                this.Hide(); //hide splash
            }
        }
        /// <summary>
        /// label click not used
        /// </summary>
        private void label4_Click(object sender, EventArgs e)
        {
            //void
        }
    }
}
