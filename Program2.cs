Console.Write("Введите число ");
 int A = int.Parse(Console.ReadLine());
 int init = A;
 int sum = 0;
 while (A > 0)
 {
    int B = A % 10;
    A = A / 10;
    sum = sum + B;

 }
 Console.Write(init + " -> " + sum);