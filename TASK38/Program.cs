// находит разницу между max и min членом массива из вещественных чисел
Console.WriteLine("введите кол-во элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
string MinMaxFunct (int N)
{
double [] array = new double [N];
for (int i = 0; i<N; i++)
{
Console.WriteLine("Введите число");
array [i]= Convert.ToDouble(Console.ReadLine());
}
double max = array [0];
double min = array [0];
for (int i2=1; i2<N; i2++)
{
if (array[i2]<min) min = array[i2];
if (array[i2]>max) max = array [i2];
}
return $"max-min={max-min}";
}
Console.WriteLine(MinMaxFunct(num));