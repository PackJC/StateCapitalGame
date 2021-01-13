//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Project 5 - Capital State Game                                                                                  
//  File Name:      GameForm.designer.cs
//  Description:    Runs the program using forms                                                                               
//  Course:         CSCI 2210-001                                                                            
//  Author:         Johnny Pack, packjc@etsu.edu, Department of Computing, East Tennessee State University
//                  
//  Created:        Sunday, April 23, 2018                                                                      
//  Copyright:      Johnny Pack, 2018                                                                           
//                                                                                                              
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project5
{
    /// <summary>
    /// create gameform
    /// </summary>
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.EndGame = new System.Windows.Forms.Button();
            this.TimerBox = new System.Windows.Forms.RichTextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.AttemptsBox = new System.Windows.Forms.TextBox();
            this.CorrectBox = new System.Windows.Forms.TextBox();
            this.CapitalBox = new System.Windows.Forms.ListBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.StatePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select The Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is the capital of:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Remaining";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attempts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correct";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(34, 324);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(105, 32);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next Question";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // EndGame
            // 
            this.EndGame.Location = new System.Drawing.Point(210, 324);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(105, 32);
            this.EndGame.TabIndex = 6;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // TimerBox
            // 
            this.TimerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBox.ForeColor = System.Drawing.Color.Red;
            this.TimerBox.Location = new System.Drawing.Point(48, 109);
            this.TimerBox.Multiline = false;
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TimerBox.Size = new System.Drawing.Size(50, 49);
            this.TimerBox.TabIndex = 9;
            this.TimerBox.Text = "";
            // 
            // StateBox
            // 
            this.StateBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.Location = new System.Drawing.Point(151, 39);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(193, 22);
            this.StateBox.TabIndex = 10;
            this.StateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttemptsBox
            // 
            this.AttemptsBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AttemptsBox.Location = new System.Drawing.Point(62, 298);
            this.AttemptsBox.Name = "AttemptsBox";
            this.AttemptsBox.Size = new System.Drawing.Size(39, 20);
            this.AttemptsBox.TabIndex = 11;
            this.AttemptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CorrectBox
            // 
            this.CorrectBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CorrectBox.Location = new System.Drawing.Point(247, 298);
            this.CorrectBox.Name = "CorrectBox";
            this.CorrectBox.Size = new System.Drawing.Size(39, 20);
            this.CorrectBox.TabIndex = 12;
            this.CorrectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CapitalBox
            // 
            this.CapitalBox.FormattingEnabled = true;
            this.CapitalBox.Location = new System.Drawing.Point(367, 30);
            this.CapitalBox.Name = "CapitalBox";
            this.CapitalBox.ScrollAlwaysVisible = true;
            this.CapitalBox.Size = new System.Drawing.Size(140, 329);
            this.CapitalBox.TabIndex = 13;
            this.CapitalBox.SelectedIndexChanged += new System.EventHandler(this.CapitalBox_SelectedIndexChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // StatePicture
            // 
            this.StatePicture.Location = new System.Drawing.Point(151, 65);
            this.StatePicture.Name = "StatePicture";
            this.StatePicture.Size = new System.Drawing.Size(193, 183);
            this.StatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StatePicture.TabIndex = 14;
            this.StatePicture.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 372);
            this.Controls.Add(this.StatePicture);
            this.Controls.Add(this.CapitalBox);
            this.Controls.Add(this.CorrectBox);
            this.Controls.Add(this.AttemptsBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capital Matching Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.RichTextBox TimerBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox AttemptsBox;
        private System.Windows.Forms.TextBox CorrectBox;
        private System.Windows.Forms.ListBox CapitalBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox StatePicture;
    }
}

