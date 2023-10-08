// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void ArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("");
 }

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ArrayRandomNumbers(numbers);
Console.WriteLine(" ");
PrintArray(numbers);
double minarray = Int32.MaxValue;
double maxarray = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxarray)
        {
            maxarray = numbers[i];
        }
    if (numbers[i] < minarray)
        {
            minarray = numbers[i];
        }
}

Console.WriteLine($"-> {maxarray - minarray }");

