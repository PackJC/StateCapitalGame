//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Project 5 - Capital State Game                                                                                  
//  File Name:      Driver.cs
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// Driver for the program, runs it
    /// </summary>
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash_Screen ());
        }
    }
}
