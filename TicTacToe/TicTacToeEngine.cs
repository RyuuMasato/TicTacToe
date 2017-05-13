using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    // Enumeration used for the status of the game
    public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }

    class TicTacToeEngine
    {
        // Keeps track of the state of the game
        public GameStatus Status { get; private set; }
        // Keeps track of the playing field
        public Dictionary<int, String> Cells;
        public int CurrentTurn = 0;
        public String Message;

        // Initialize engine for TicTacToe game
        public TicTacToeEngine()
        {
            Status = GameStatus.PlayerOPlays;
            Reset();
        }

        // Returns a String representation of the playing field
        public String Board()
        {
            String VDivider = "-----------";
            String HDivider = " | ";
            return VDivider + "\n"
                + HDivider + Cells[1] + HDivider + Cells[2] + HDivider + Cells[3] + HDivider + "\n"
                + VDivider + "\n"
                + HDivider + Cells[4] + HDivider + Cells[5] + HDivider + Cells[6] + HDivider + "\n"
                + VDivider + "\n"
                + HDivider + Cells[7] + HDivider + Cells[8] + HDivider + Cells[9] + HDivider + "\n"
                + VDivider;
        }

        // Plays one turn of TicTacToe
        public void PlayTurn(int Cell)
        {
            if (ChooseCell(Cell))
            {
                SetCell(Cell);
            }
            else
            {
                Message = "Unvalid move, try again!";
            }
                
        }

        // Validates if a chosen cell is playable
        public Boolean ChooseCell(int Cell)
        {
            return !(Cells[Cell].Equals("X") || Cells[Cell].Equals("O")) ? true : false;
        }

        // Sets cell to the current player
        public void SetCell(int Cell)
        {
            Cells[Cell] = (Status == GameStatus.PlayerOPlays) ? "O" :
                (Status == GameStatus.PlayerXPlays) ? "X" : null;
        }

        public void CheckWinConditions()
        {
            // 3 x horizontal, 2 x diagonal, 3 x vertical, final
            if (!(WinCondition(Cells[1], Cells[2], Cells[3])
                || WinCondition(Cells[4], Cells[5], Cells[6])
                || WinCondition(Cells[7], Cells[8], Cells[9])
                || WinCondition(Cells[1], Cells[5], Cells[9])
                || WinCondition(Cells[3], Cells[5], Cells[7])
                || WinCondition(Cells[1], Cells[4], Cells[7])
                || WinCondition(Cells[2], Cells[5], Cells[8])
                || WinCondition(Cells[3], Cells[6], Cells[9]))
                && CurrentTurn == 9)
            {
                // PromptPlayer("No winner...");
                Reset();
            }
        }

        // Check for winning condition
        public Boolean WinCondition(String CellX, String CellY, String CellZ)
        {
            // todo: check last equals!!!
            if (CellX.Equals(CellY) && CellX.Equals(CellZ) && (CellX.Equals("O") || CellX.Equals("X")))
            {
                // todo: game status = playerO or playerX wins
                //PromptPlayer("Player \"" + currentPlayer + "\" wins!");
                Reset();
                return true;
            }
            else
                return false;
        }

        // Resets the playing field
        public void Reset()
        {
            Cells = new Dictionary<int, String>();
            for (int i = 1; i < 10; i++)
                Cells.Add(i, i.ToString());
        }
    }
}
