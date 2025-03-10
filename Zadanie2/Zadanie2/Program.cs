// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

double getAvg(int[] integers)
{
    int sum = 0;
    double avg = 0;
   for (int i = 0; i <= integers.Length; ++i)
    {
        sum += integers[i];
        avg = sum / (i + 1);
    }
    return avg;
}

int getMax(int[] integers)
{
    int max;
    for (int i = 0; i < integers.Length; i++)
    {
        if (max < integers[i])
        {
            max = integers[i];
        }
    }
    return max;
}