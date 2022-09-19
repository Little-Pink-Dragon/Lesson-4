int [] N = new int[8];
Console.Write("[ ");

for (int i = 0; i < N.Length; i++)
 {
    N [i] = new Random().Next(0, 100);
    Console.Write(Rand (i) + ", ");
 }
Console.Write("]");

int Rand (int a)
{
    return N [a];
}