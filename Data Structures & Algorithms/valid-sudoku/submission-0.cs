public class Solution {
    public bool IsValidSudoku(char[][] board) {
       var rows = new HashSet<char>[9];
 var cols = new HashSet<char>[9];
 var boxes = new HashSet<char>[9];

 for (int i = 0; i < 9; i++)
 {
     rows[i] = new HashSet<char>();
     cols[i] = new HashSet<char>();
     boxes[i] = new HashSet<char>();
 }

 for (int r = 0; r < 9; r++)
 {
     for (int c = 0; c < 9; c++)
     {
         var current = board[r ][c];

         if (current == '.')
             continue;

         int boxIndex = (r / 3) * 3 + (c / 3);

         if (!rows[r].Add(current) ||
        !cols[c].Add(current) ||
        !boxes[boxIndex].Add(current))
         {
             return false;
         }
     }
 }

 return true; 
    }
}
