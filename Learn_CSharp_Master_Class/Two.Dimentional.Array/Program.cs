// See https://aka.ms/new-console-template for more information

char[,] huruf1 = new char[2,3];

huruf1[0, 0] = 'A';
huruf1[0, 1] = 'B';
huruf1[0, 2] = 'C';
huruf1[1, 0] = 'D';
huruf1[1, 1] = 'E';
huruf1[1, 2] = 'F';

for (int i = 0; i < huruf1.GetLength(0); i++)
{
    Console.WriteLine("i:" + i);
    for (int j = 0; j < huruf1.GetLength(1); j++)
    {
        Console.WriteLine("j:" + j);
        Console.WriteLine("isi dari i: {0} dan j: {1} adalah {2}", i, j, huruf1[i,j]);
    }
}

Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");

char[,] huruf2 = new char[,]
{
    {'a','b','c'},
    {'d','e','f'},
    {'g','h','i'}
};

for (int i = 0; i < huruf2.GetLength(0); i++)
{
    Console.WriteLine("i:" + i);
    for (int j = 0; j < huruf2.GetLength(1); j++)
    {
        Console.WriteLine("j:" + j);
        Console.WriteLine("isi dari i: {0} dan j: {1} adalah {2}", i, j, huruf2[i,j]);
    }
}