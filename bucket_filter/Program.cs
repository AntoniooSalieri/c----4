
int[,] picture = new int[,]
{
{0, 0, 0, 1, 1, 1, 0, 0},
{0, 0, 1, 0, 0, 0, 1, 0},
{0, 1, 0, 0, 1, 1, 0, 0},
{0, 0, 1, 0, 1, 1, 0, 0},
{0, 0, 1, 0, 0, 0, 1, 0},
{0, 0, 0, 1, 1, 1, 0, 0},
};

Console.Clear();

void Printer(){
    for (int i = 0; i < picture.GetLength(0); i++){
        for (int j = 0; j < picture.GetLength(1); j++){
            if (picture[i, j] == 0) Console.Write("  ");
            else Console.Write("+ ");
        }
        Console.WriteLine();
    }
}

void Bucket(int str, int line){
    if (picture[str, line] == 0){
        picture[str, line] = 1;
        Bucket(str-1, line);
        Bucket(str, line-1);
        Bucket(str+1, line);
        Bucket(str, line+1);
    }
}

Printer();
Bucket(4, 4);
Printer();