using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Sudoku
    {
        public static string DoneOrNot (int [][] board)
        {
            
            int[] rows = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] columns = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < rows.Length; i++)
            {
                Console.WriteLine(board[8][1]);
                Console.WriteLine($"{rows[i]}, {columns[i]}");
                if (rows[i] == rows[i])
                {
                    return "Try Again";
                }
                else if (rows[i] != rows[i] && rows[i] < rows[rows.Length])
                {
                    i++;
                    rows[rows.Length] 
                }
                
            }
            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i] == columns[i])
                {
                    return "Try Again";
                }
                else if (columns[i] != columns[i] && columns[i] < columns[columns.Length])
                {
                    i++;
                }
            }
            return "Finished!";
        }
    }
}
