using System;

namespace WindowsFormsApp1
{
    public class TicTacToeEngine
    {
        // Private Enumeration keeps track of the current state of the game
        private enum GameStatus { PlayerOPlays = 0, PlayerXPlays = 1, Equal = 2, PlayerOWins = 3, PlayerXWins = 4 }
        // Object repressentation of the tic tac toe gameboard
        public Object[] Board;

        // Constructor of the TicTacToe Engine used to provide the game mechanics 
        // for both the graphical, and the console version of our program
        public TicTacToeEngine()
        {
            setGameStatus(0);
        }

        // public getter of the game's state (returns integer)
        public int getGameStatus()
        {
            return this.GameStatus;
        }

        // private setter of the game's state (sets integer)
        private void setGameStatus(int state)
        {
            this.GameStatus = state;
        }

        public String Board()
        {
            return null;
        }

        public int ChooseCell(int cell)
        {
            return null;
        }

        public void Reset()
        {

        }
    }
}
