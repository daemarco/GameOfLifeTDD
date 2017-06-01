
namespace GameOfLife2
{
    public class GOLManager
    {
        public static bool GetNextIterationStatus(bool[][] matrix, int col, int row)
        {
            int cols = matrix.Length;
            int rows = matrix[0].Length;
            
            int iNeighbours = 0;

            for (int i = col - 1; i <= col + 1; i++)
            {
                for (int j = row - 1; j <= row + 1; j++)
                {
                    if (j == row && i == col) continue;
                    if (j < 0 || i < 0 || j >= rows || i >= cols) continue;

                    if (matrix[i][j]) iNeighbours++;

                    if (iNeighbours > 1 && matrix[col][row])
                        return true;
                    if (iNeighbours > 3)
                        return false;
                }
            }

            if (iNeighbours == 3 && !matrix[col][row])
                return true;
            
            return false;
        }


    }
}
