// показывает кол-во четных чисел в массиве из заданных трехзначных чисел
Console.WriteLine("введите кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];
for (int i = 0; i<N; i++)
{
    Console.WriteLine("Введите число");
    array [i]= Convert.ToInt32(Console.ReadLine());
}
string EventNum(int [] arr, int N2)
{
int count=0;
for (int i = 0; i<N2; i++)
{
        if (arr[i]%2==0) 
    {
        count = count + 1;
    }
}
Console.WriteLine(count);
return "";
}
EventNum(array, N);