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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBoard = new string[9]; //array to hold the game board
        int currentTurn = 0; //keeping track of whose turn it is

        public String returnSymbol(int turn) //method that will return the symbol that is assigned to the button
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public System.Drawing.Color determineColor(String symbol) //method that will determine the color based on the symbol assigned
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.WhiteSmoke;
            }
            else if(symbol.Equals("X"))
            {
                return System.Drawing.Color.DimGray;

            }
            return System.Drawing.Color.LightGray;
        }

        public void checkForWinner() //method that will check which is the winner
        {
            for(int i=0; i<8; i++)
            {
                String combination = ""; //represents the line of combination for the switch case below
                int one = 0, two = 0, three =0; //initialize to nothing
                switch (i) //determines the combination wheter its diagonal, horizontal, or vertical
                { //gameboard[n] represents the buttons
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                    case 8:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                    case 9:
                        combination = gameBoard[6] + gameBoard[4] + gameBoard[2];
                        one = 6;
                        two = 4;
                        three = 2;
                        break;
                    case 10:
                        combination = gameBoard[8] + gameBoard[4] + gameBoard[0];
                        one = 8;
                        two = 4;
                        three = 0;
                        break;
                    case 11:
                        combination = gameBoard[2] + gameBoard[1] + gameBoard[0];
                        one = 2;
                        two = 1;
                        three = 0;
                        break;
                    case 12:
                        combination = gameBoard[5] + gameBoard[4] + gameBoard[3];
                        one = 5;
                        two = 4;
                        three = 3;
                        break;
                    case 13:
                        combination = gameBoard[8] + gameBoard[7] + gameBoard[6];
                        one = 8;
                        two = 7;
                        three = 6;
                        break;
                    case 14:
                        combination = gameBoard[6] + gameBoard[3] + gameBoard[0];
                        one = 6;
                        two = 3;
                        three = 0;
                        break;
                    case 15:
                        combination = gameBoard[7] + gameBoard[4] + gameBoard[1];
                        one = 7;
                        two = 4;
                        three = 1;
                        break;
                    case 16:
                        combination = gameBoard[8] + gameBoard[5] + gameBoard[2];
                        one = 7;
                        two = 4;
                        three = 1;
                        break;
                }


                //displays that O is the winner
                if (combination.Equals("OOO"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    MessageBox.Show("O has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);      
                }
                else if (combination.Equals("XXX")) //displays that X is the winner
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    MessageBox.Show("X has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
                }

                checkDraw();
            }


        }
        public void reset() //reset button
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = System.Drawing.Color.DimGray;
            button2.BackColor = System.Drawing.Color.DimGray;
            button3.BackColor = System.Drawing.Color.DimGray;
            button4.BackColor = System.Drawing.Color.DimGray;
            button5.BackColor = System.Drawing.Color.DimGray;
            button6.BackColor = System.Drawing.Color.DimGray;
            button7.BackColor = System.Drawing.Color.DimGray;
            button8.BackColor = System.Drawing.Color.DimGray;
            button9.BackColor = System.Drawing.Color.DimGray;
            
            gameBoard = new string[9];
            currentTurn = 0;
        }

        public void changeColor(int number) //method changes the color of the winner's combination to white
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 1:
                    button2.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 2:
                    button3.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 3:
                    button4.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 4:
                    button5.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 5:
                    button6.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 6:
                    button7.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 7:
                    button8.BackColor = System.Drawing.Color.AntiqueWhite; break;
                case 8:
                    button9.BackColor = System.Drawing.Color.AntiqueWhite; break;
            }
        }

        public void checkDraw()
        {
            int counter = 0;
            for (int i=0; i<gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) {counter++;}

                if(counter == 9)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    MessageBox.Show("That's a draw!", "No winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                }
            }    
        }
        private void button1_Click(object sender, EventArgs e) //checking if the game results into draw
        {
            currentTurn++;
            gameBoard[0] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[0]);
            button1.BackColor = buttonColor;
            button1.Text = gameBoard[0];
            button1.Enabled = false;
            checkForWinner();

        }
        //buttons
        private void button2_Click(object sender, EventArgs e)
        { //applies to all buttons
            currentTurn++; 
            gameBoard[1] = returnSymbol(currentTurn); //determines the turn whether its X or O
            Color buttonColor = determineColor(gameBoard[1]); //checks if the color of the button needs to be white or gray depending on the symbol
            button2.BackColor = buttonColor;
            button2.Text = gameBoard[1];;
            button2.Enabled = false; //disables the button after the click
            checkForWinner(); //checks the winner
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[2]);
            button3.BackColor = buttonColor;
            button3.Text = gameBoard[2];
            button3.Enabled = false;
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);

            Color buttonColor = determineColor(gameBoard[3]);
            button4.BackColor = buttonColor;
            button4.Text = gameBoard[3];
            button4.Enabled = false;
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[4]);
            button5.BackColor = buttonColor;
            button5.Text = gameBoard[4];
            button5.Enabled = false;
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[5]);
            button6.BackColor = buttonColor;
            button6.Text = gameBoard[5];
            button6.Enabled = false;
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[6]);
            button7.BackColor = buttonColor;
            button7.Text = gameBoard[6];
            button7.Enabled = false;
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[7]);
            button8.BackColor = buttonColor;
            button8.Text = gameBoard[7];
            button8.Enabled = false;
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[8]);
            button9.BackColor = buttonColor;
            button9.Text = gameBoard[8];
            button9.Enabled = false;
            checkForWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
