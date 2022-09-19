Console.Write("Введите первое число ");
 int A = int.Parse(Console.ReadLine());
 Console.Write("Введите второе число ");
 int B = int.Parse(Console.ReadLine());
 int result = 1;
 for (int i = 1; i <= B; i++)
 {
    result = result * A;
 }
 Console.Write(A + "," + B + " -> " + result);
