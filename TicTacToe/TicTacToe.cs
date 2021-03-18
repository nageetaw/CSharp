using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool is_GameWinned = false;
        String UserChoice,SystemChoice;
        Button[,] MovesButtons = new Button[3, 3];
        public TicTacToe(String UserChoice)
        {
            InitializeComponent();
            this.UserChoice = UserChoice;
            if (UserChoice == "X") this.SystemChoice = "O";
            else this.SystemChoice = "X";
 
        }
        private void DisableAll() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    this.MovesButtons[i, j].Enabled = false;
                }
            }
        }
        private void EnableAll()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.MovesButtons[i, j].Enabled = true;
                }
            }
        }
        private void CheckForWinner() {

            is_GameWinned = false;
            // check winner in rows
            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < 1; j++) {

                    if (this.MovesButtons[i, j].Text != "" && (this.MovesButtons[i, j].Text == this.MovesButtons[i, j + 1].Text) && (this.MovesButtons[i, j + 1].Text == this.MovesButtons[i, j + 2].Text)) {
                        if (this.MovesButtons[i, j].Text == this.UserChoice)
                            this.labelResult.Text = "User Wins";
                        else
                            this.labelResult.Text = "System Wins";
                        DisableAll();
                        is_GameWinned = true;
                    }
                }
            }
            if (!is_GameWinned)
            {
                // in columns manner
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 1; j++)
                    {

                        if (this.MovesButtons[j, i].Text != "" && (this.MovesButtons[j, i].Text == this.MovesButtons[j+1, i ].Text) && (this.MovesButtons[j+1, i].Text == this.MovesButtons[j+2,i].Text))
                        {
                            if (this.MovesButtons[j, i].Text == this.UserChoice)
                                this.labelResult.Text = "User Wins";
                            else
                                this.labelResult.Text = "System Wins";
                            is_GameWinned = true;
                            DisableAll();
                        }
                    }
                }
            }
            // check in diagonal manner
            if (!is_GameWinned) {

                if (this.MovesButtons[0, 0].Text != "" && (this.MovesButtons[0, 0].Text == this.MovesButtons[1, 1].Text) && (this.MovesButtons[1, 1].Text == this.MovesButtons[2, 2].Text)) {
                    if (this.MovesButtons[1, 1].Text == this.UserChoice)
                        this.labelResult.Text = "User Wins";
                    else
                        this.labelResult.Text = "System Wins";
                    DisableAll();
                    is_GameWinned = true;
                }
                if (!is_GameWinned) {

                    if (this.MovesButtons[0, 2].Text != "" && (this.MovesButtons[0, 2].Text == this.MovesButtons[1, 1].Text) && (this.MovesButtons[1, 1].Text == this.MovesButtons[2, 0].Text))
                    {
                        if (this.MovesButtons[1, 1].Text == this.UserChoice)
                            this.labelResult.Text = "User Wins";
                        else
                            this.labelResult.Text = "System Wins";
                        DisableAll();
                        is_GameWinned = true;
                    }

                }
            } 
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.labelUser.Text = "User has selected " + this.UserChoice;
            this.labelSystem.Text = "Computer Symbol is "+this.SystemChoice;
            if (this.UserChoice == "X") this.labelTurns.Text = "User Plays First";
            else this.labelTurns.Text = "Computer plays First";
        
            for (int i = 0; i < 3; i++) {
                
                for (int j = 0; j < 3; j++) {
                    int indexRow = i;
                    int indexCol = j;
                    this.MovesButtons[i,j] = new Button();
                    this.MovesButtons[i, j].Name = "btn" + i + j;
                    this.MovesButtons[i, j].Size = new Size(120, 120);
                    this.MovesButtons[i, j].Location = new Point(20+150*j, 50+100*i+(i*20));
                    this.MovesButtons[i, j].Click += (sender1, ex) => this.Display(indexRow,indexCol);
                    this.Controls.Add(this.MovesButtons[i, j]);
                }
            
            }
            this.DisableAll();
            if (this.SystemChoice == "X") {
                this.EnableAll();
                DecideSystemMove();
            }
        }

        private void Display(int i, int j)
        {

            if (MovesButtons[i, j].Text != null)
            {
                //MessageBox.Show("" + i + " " + j);
                MovesButtons[i, j].Text = this.UserChoice;
                this.MovesButtons[i, j].Enabled = false;
                this.labelTurns.Text = "Computer Turns";
               
                CheckForWinner();
                if(!is_GameWinned)
                  DecideSystemMove();
                CheckForWinner();
                this.labelTurns.Text = "Users Turns";
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.EnableAll();
            this.btnStart.Enabled = false;
        }

        

        // Game Conditions for system


        /*
         first row represents first row of game and so on others.
         */
        private void WinMove() {

            //MessageBox.Show("in win move");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j <1; j++)
                {
                    //MessageBox.Show("i : " + i, " j : " + j);

                    if ((MovesButtons[i, j].Text == this.SystemChoice) && (MovesButtons[i, j].Text == MovesButtons[i, j + 1].Text)
                        && MovesButtons[i, j + 2].Text == "")
                    {

                        MovesButtons[i, j + 2].Text = this.SystemChoice;
                        this.MovesButtons[i, j+2].Enabled = false;
                      
                        IsSystemPlayedMove = true;
                        break;
                        // System wins
                    }
                    if (!IsSystemPlayedMove)
                    {

                        if ((MovesButtons[i, j+1].Text == this.SystemChoice) && (MovesButtons[i, j+1].Text == MovesButtons[i, j + 2].Text)
                        && MovesButtons[i, j].Text == "")
                        {

                            MovesButtons[i, j].Text = this.SystemChoice;
                            this.MovesButtons[i, j ].Enabled = false;
                        
                            IsSystemPlayedMove = true;
                            break;
                            // System wins
                        }
                    }
                    if (!IsSystemPlayedMove)
                    {

                        if ((MovesButtons[i, j+2].Text == this.SystemChoice) && (MovesButtons[i, j + 2].Text == MovesButtons[i, j].Text)
                        && MovesButtons[i, j+1].Text == "")
                        {

                            MovesButtons[i, j+1].Text = this.SystemChoice;
                            this.MovesButtons[i, j+1].Enabled = false;
                          
                            IsSystemPlayedMove = true;
                            break;
                            // System wins
                        }
                    }

                }
            }

        }

        private void BlockMove() {
            //MessageBox.Show("in block move");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    //MessageBox.Show("i : " + i, " j : " + j);
                    if ((MovesButtons[i, j].Text == this.UserChoice) && (MovesButtons[i, j].Text == MovesButtons[i, j + 1].Text)
                        && MovesButtons[i, j + 2].Text == "")
                    {

                        MovesButtons[i, j + 2].Text = this.SystemChoice;
                        this.labelResult.Text = "Computer uses Block move";
                        this.MovesButtons[i, j+2].Enabled = false;
                        IsSystemPlayedMove = true;
                        break;
                        // System wins
                    }
                    if (!IsSystemPlayedMove)
                    {

                        if ((MovesButtons[i, j + 1].Text == this.UserChoice) && (MovesButtons[i, j + 1].Text == MovesButtons[i, j + 2].Text)
                        && MovesButtons[i, j].Text == "")
                        {

                            MovesButtons[i, j].Text = this.SystemChoice;
                            this.MovesButtons[i, j].Enabled = false;
                            
                            IsSystemPlayedMove = true;
                            break;
                            // System wins
                        }
                    }
                    if (!IsSystemPlayedMove)
                    {

                        if ((MovesButtons[i, j + 2].Text == this.UserChoice) && (MovesButtons[i, j + 2].Text == MovesButtons[i, j].Text)
                        && MovesButtons[i, j + 1].Text == "")
                        {

                            MovesButtons[i, j + 1].Text = this.SystemChoice;
                            this.MovesButtons[i, j + 1].Enabled = false;
                            
                            IsSystemPlayedMove = true;
                            break;
                            // System wins
                        }
                    }
                }
            }
            if (!IsSystemPlayedMove)
            {
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 1; j++)
                    {
                       // //MessageBox.Show("i : " + i, " j : " + j);

                        if ((MovesButtons[j, i].Text == this.UserChoice) && (MovesButtons[j, i].Text == MovesButtons[j+1, i ].Text)
                            && MovesButtons[j+2, i].Text == "")
                        {

                            MovesButtons[j+2, i].Text = this.SystemChoice;
                            this.labelResult.Text = "System block user";
                            this.MovesButtons[j+2, i].Enabled = false;
                            IsSystemPlayedMove = true;
                            break;
                            // System wins
                        }
                        if (!IsSystemPlayedMove)
                        {

                            if ((MovesButtons[j + 1,i ].Text == this.UserChoice) && (MovesButtons[j+1, i].Text == MovesButtons[j+2, i].Text)
                            && MovesButtons[j, i].Text == "")
                            {

                                MovesButtons[j, i].Text = this.SystemChoice;
                                this.MovesButtons[j, i].Enabled = false;
                              
                                IsSystemPlayedMove = true;
                                break;
                                // System wins
                            }
                        }
                        if (!IsSystemPlayedMove)
                        {

                            if ((MovesButtons[j+2, i].Text == this.UserChoice) && (MovesButtons[j+2, i].Text == MovesButtons[j, i].Text)
                            && MovesButtons[j+1, i].Text == "")
                            {

                                MovesButtons[j+1,i].Text = this.SystemChoice;
                                this.MovesButtons[j+1, i].Enabled = false;
                                
                                IsSystemPlayedMove = true;
                                break;
                                // System wins
                            }
                        }
                    }
                }

            }
        }
        private void CentreMove() {
            //MessageBox.Show("in center move");
            if (this.MovesButtons[1, 1].Text == "")
            {
                this.MovesButtons[1, 1].Text = this.SystemChoice;
                this.MovesButtons[1, 1].Enabled = false;
                this.labelResult.Text = "Center move";
                IsSystemPlayedMove = true;
            }
        }
        private void CornerMove() {
           // //MessageBox.Show("in corner move");
            // first check if corners are empty or not, at least one
            if (this.MovesButtons[0, 0].Text != "" && this.MovesButtons[0, 2].Text != "" && this.MovesButtons[2, 0].Text != "" && this.MovesButtons[2, 2].Text !="")
            {
                return;
            }
            else
            {
                Random random = new Random();
                do
                {
                    int i = random.Next(0, 2);
                    int j = random.Next(0, 2);
                    if (i != 1 && j != 1)
                    {
                        if (this.MovesButtons[i, j].Text == "")
                        {
                            //MessageBox.Show("i : " + i, " j : " + j);

                            this.MovesButtons[i, j].Text = this.SystemChoice;
                            this.labelResult.Text = "Corner move";
                            this.MovesButtons[i, j].Enabled = false;
                            IsSystemPlayedMove = true;
                            break;
                        }
                    }
                } while (!IsSystemPlayedMove);
            }
        }
        private void RandomMove() {
            //MessageBox.Show("in random move");
            bool flag = true;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3 && flag; j++)
                {
                    //MessageBox.Show("i : " + i, " j : " + j);
                    if (MovesButtons[i, j].Text == "")
                    {

                        MovesButtons[i, j].Text = this.SystemChoice;
                        MovesButtons[i, j].Enabled = false;
                        this.labelResult.Text = "Random move";
                        flag = false;
                        break;
                        // System wins
                    }
                }
               
            }
        }
        bool IsSystemPlayedMove;
        private void DecideSystemMove() {

            IsSystemPlayedMove = false;
            // for Win move
            if(!IsSystemPlayedMove)
                this.WinMove();

            //for block move
           if (!IsSystemPlayedMove)
            
                this.BlockMove();

            if (!IsSystemPlayedMove)
                this.CentreMove();

            if (!IsSystemPlayedMove)
                this.CornerMove();

            if (!IsSystemPlayedMove)
                this.RandomMove();

        }

    }
}
