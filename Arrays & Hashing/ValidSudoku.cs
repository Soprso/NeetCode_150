using System;
using System.Runtime.InteropServices.JavaScript;

namespace NeetCode_150.Arrays___Hashing;


// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

// Each row must contain the digits 1-9 without repetition.
// Each column must contain the digits 1-9 without repetition.
// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
// Note:

// A Sudoku board (partially filled) could be valid but is not necessarily solvable.
// Only the filled cells need to be validated according to the mentioned rules.


// Example 1:


// Input: board = 
// [["5","3",".",".","7",".",".",".","."]
// ,["6",".",".","1","9","5",".",".","."]
// ,[".","9","8",".",".",".",".","6","."]
// ,["8",".",".",".","6",".",".",".","3"]
// ,["4",".",".","8",".","3",".",".","1"]
// ,["7",".",".",".","2",".",".",".","6"]
// ,[".","6",".",".",".",".","2","8","."]
// ,[".",".",".","4","1","9",".",".","5"]
// ,[".",".",".",".","8",".",".","7","9"]]
// Output: true
// Example 2:

// Input: board = 
// [["8","3",".",".","7",".",".",".","."]
// ,["6",".",".","1","9","5",".",".","."]
// ,[".","9","8",".",".",".",".","6","."]
// ,["8",".",".",".","6",".",".",".","3"]
// ,["4",".",".","8",".","3",".",".","1"]
// ,["7",".",".",".","2",".",".",".","6"]
// ,[".","6",".",".",".",".","2","8","."]
// ,[".",".",".","4","1","9",".",".","5"]
// ,[".",".",".",".","8",".",".","7","9"]]
// Output: false
// Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.


// Constraints:

// board.length == 9
// board[i].length == 9
// board[i][j] is a digit 1-9 or '.'.
public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        int n = board.Length;
        for (int i = 0; i < n; i++) //check dupes in rows
        {
            HashSet<char> setRows = new HashSet<char>();
            HashSet<char> setColumns = new HashSet<char>();
            for (int j = 0; j < n; j++)
            {
                if ((board[i][j]) != '.')      //row dupe check
                {
                    if (setRows.Contains(board[i][j]))
                    {
                        return false;
                    }
                    setRows.Add(board[i][j]);
                }
                if (board[j][i] != '.')       //column dupe check
                {
                    if (setColumns.Contains(board[j][i]))
                    {
                        return false;
                    }
                    setColumns.Add(board[j][i]);
                }
            }
        }
        //boxSet logic
        //Identifies each 3×3 box by blockRow * 3 + i and blockCol * 3 + j — ✅
        // Fresh boxSet for each sub-box — ✅
        // Returns false on any repeated digit — ✅
        for (int blockRow = 0; blockRow < 3; blockRow++)
        {
            for (int blockCol = 0; blockCol < 3; blockCol++)
            {
                HashSet<char> boxSet = new HashSet<char>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        char val = board[blockRow * 3 + i][blockCol * 3 + j];
                        if (val != '.')
                        {
                            if (boxSet.Contains(val))
                            {
                                return false;
                            }
                            boxSet.Add(val);
                        }
                    }
                }
            }
        }
        return true;
    }
}
