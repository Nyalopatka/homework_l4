//прием чисел а и б ,возведение а в степень б
void Stepen(int a,int b)
{
    double res = Math.Pow(a, b);
    Console.WriteLine($"{a}^{b} -> {res}");
}
Console.Write("введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень в которую нужно возвести это число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Stepen(n1,n2);