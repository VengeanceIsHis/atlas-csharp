namespace MyMath
{


public class Matrix
{
    public static int[,] Divide(int[,] matrix, int num)
    {
        int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }

            return result;
    }

}
}