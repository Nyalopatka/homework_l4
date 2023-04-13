void Count(int a)
{       int b = a;
        int b1 = a;
        int i = 1;
        while(a >= 10)
        {
        a = a / 10;
        i++;
        }
        int res = 0;
        int n1 = i;
        for(int t= 0;t < n1;t++)
        {
                
                for(int j=0;j<i-1;j++)
                {
                        b /= 10;
                }
                i--;
                res = res + b % 10;
                b = b1;
                
                
        }
         
        Console.WriteLine($"{b} -> {res}");
        }
Console.Write("введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Count(n1);

