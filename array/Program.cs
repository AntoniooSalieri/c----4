
using System.Data;
using System.Diagnostics.Contracts;
using System.Numerics;

void PrintArray(int[,] matr){
    for (int rows = 0; rows < matr.GetLength(0); rows ++){
        for (int colums = 0; colums < matr.GetLength(1); colums ++){
            Console.Write($"{matr[rows, colums]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] matr){
    Random random = new Random();
    for (int rows = 0; rows < matr.GetLength(0); rows++){
        for (int colums = 0; colums < matr.GetLength(1); colums++){
            matr[rows, colums] = new Random().Next(0, 10);
        }
    }
    return matr;
}

int[,] matrix = new int [ 5,5];
matrix = FillArray(matrix);
PrintArray(matrix);
