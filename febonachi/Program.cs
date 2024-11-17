int a = 0,
    b = 1,
    c;
void febonachi(int count){
    if (count>0){
        count--;
        Console.WriteLine(a);
        c = a + b;
        a = b;
        b = c;
        febonachi(count);
    }
}

febonachi(20);