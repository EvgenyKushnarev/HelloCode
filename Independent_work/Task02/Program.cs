int A = new Random().Next(1, 1000);
Console.WriteLine(A);
int B = new Random().Next(1,1000); 
Console.WriteLine(B);


if(A > B)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}
