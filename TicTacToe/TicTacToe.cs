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
        public String currentPlayer;
        public int currentTurn = 0;
        public Button clickedTile;

        public TicTacToe()
        {
            InitializeComponent();
            TicTacToeEngine engine = new TicTacToeEngine();
            PromptPlayer(engine.Board());
        }

        // Play a turn
        private void TurnPlayed(object sender, EventArgs e)
        {
            clickedTile = (sender as Button);
            DeterminePlayer();
            if(ValidateTurn())
            {
                TagTile();
                ValidateField();
            }
            else
            {
                PromptPlayer("Unvalid move, try again!");
            }
        }

        // Set player based on turn 
        public void DeterminePlayer() { currentPlayer = (currentTurn % 2 == 1) ? "X" : "O"; }

        // Validates if the chosen tile is empty
        public Boolean ValidateTurn() { return clickedTile.Text.Equals(""); }

        // Tags the chosen tile with players name
        public void TagTile() {
            clickedTile.Text = currentPlayer;
            currentTurn++;
        }

        // Validate playing field
        public void ValidateField()
        {
            // 3 x horizontal, 2 x diagonal, 3 x vertical, final
            if (!(WinCondition(tile1, tile2, tile3)
                || WinCondition(tile4, tile5, tile6)
                || WinCondition(tile7, tile8, tile9) 
                || WinCondition(tile1, tile5, tile9) 
                || WinCondition(tile3, tile5, tile7) 
                || WinCondition(tile1, tile4, tile7) 
                || WinCondition(tile2, tile5, tile8) 
                || WinCondition(tile3, tile6, tile9))
                && currentTurn == 9)
            {
                PromptPlayer("No winner...");
                Reset();
            }
        }

        // Check for winning condition
        public Boolean WinCondition(Button tileX, Button tileY, Button tileZ)
        {
            if (tileX.Text.Equals(tileY.Text) && tileX.Text.Equals(tileZ.Text) && !tileX.Text.Equals(""))
            {
                PromptPlayer("Player \"" + currentPlayer + "\" wins!");
                Reset();
                return true;
            }
            else
                return false;
        }

        // Prompt current player with message
        public void PromptPlayer(String message) { System.Windows.Forms.MessageBox.Show(message);  }

        // Reset playingfield
        public void Reset()
        {
            tile1.Text = "";
            tile2.Text = "";
            tile3.Text = "";
            tile4.Text = "";
            tile5.Text = "";
            tile6.Text = "";
            tile7.Text = "";
            tile8.Text = "";
            tile9.Text = "";
            currentTurn = 0;
       }
    }
}
