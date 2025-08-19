using System;
public class Array_Types
{
    public static void Run()
    {
        int[] oneDim = { 1, 2, 3, 4, 5 };
        Console.WriteLine("1D array elements:");
        foreach (int item in oneDim)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int[,] twoDim = {{1, 2, 3},{4, 5, 6}};
        Console.WriteLine("2D array elements:");
        for (int i = 0; i < twoDim.GetLength(0); i++) 
        {
            for (int j = 0; j < twoDim.GetLength(1); j++) 
            {
                Console.Write(twoDim[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[][] jagged = new int[3][];
        jagged[0] = new int[] {1, 2};
        jagged[1] = new int[] {3, 4, 5};
        jagged[2] = new int[] {6, 7, 8, 9};

        Console.WriteLine("Jagged array elements:");
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
