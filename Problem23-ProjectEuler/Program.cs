
List<double> abundantNumbers = new List<double>();
List<double> abundantSums = new List<double>();
List<double> abundantSumsOrdered = new List<double>();

for (double i = 1; i < 28123; i++)
{
    double sumDivisors = 0;
    for(double j = 1; j < i; j++)
    {
        if(i%j == 0)
        {
            sumDivisors = sumDivisors + j;
        }
    }
    if(sumDivisors > i)
        abundantNumbers.Add(i);
}

for(double i = 0; i < abundantNumbers.Count; i++)
{
    double sumAbundant = 0;
    for(double j = i; j < abundantNumbers.Count; j++)
    {
        sumAbundant = abundantNumbers[(int)i] + abundantNumbers[(int)j];
        if(!abundantSums.Contains(sumAbundant))
            abundantSums.Add(sumAbundant);
    }
}

double totalSum = 0;

for(double i = 1; i <= 28123; i++)
{
    if(!abundantSums.Contains(i))
        totalSum = totalSum + i;
}

Console.WriteLine("The sum of the positive integers which cannot be written as the sum of two abundant numbers is: " + totalSum);