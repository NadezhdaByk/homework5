// находит сумму чисел, стоящих на нечётных позициях в массиве,
//заполненном случайными числами.
Console.WriteLine("Веедите кол-во элементов массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] Funct(int N)
{
int [] array = new int [N];
for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
int Summery(int[] arr)
{
Console.WriteLine(string.Join("|",arr));
int sum = 0;
    for (int i=1; i<arr.Length; i=i+2)
    {
      sum = sum + arr[i];
    }
    return sum;
    
}
Console.WriteLine(Summery(Funct(num)));





