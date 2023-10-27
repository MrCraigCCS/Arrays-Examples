int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Array

for (int i = 0; i < numbers.Length; ++i)
{
    Console.WriteLine(numbers[i]);
}

//Get the last index of the array
int lastIndex = numbers[numbers.Length - 1];
Console.WriteLine(numbers[lastIndex]);

//Insert at the end of the array
numbers[numbers.Length] = 928348;

for (int i = 0; i < numbers.Length; ++i)
{
    Console.WriteLine(numbers[i]);
}