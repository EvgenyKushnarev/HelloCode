int A = new Random().Next(1, 1000);
Console.WriteLine(A);
int B = new Random().Next(1,1000); 
Console.WriteLine(B);
int result = A / B;

if(result == B)
{
    Console.WriteLine("Первое число является квадратом второго числа!!!");
}
else
{
    Console.WriteLine("Первое число, к сожалению, не является квадратом второго числа");
}
