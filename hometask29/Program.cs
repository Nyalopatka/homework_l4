int[] Array01(int size)
    {
      int [] array01 = new int [size];
      for(int i = 0 ;i < size;i++)
      {
          Console.Write("введите число: ");
          array01[i] = Convert.ToInt32(Console.ReadLine());
      }
      return array01;
    }
void Elements(int [] array01)
{
  for(int i = 0;i < array01.Length;i++)
  {
Console.Write(array01[i] + " ");
  }
}



int [] arrayNew = Array01(8);
Elements(arrayNew);