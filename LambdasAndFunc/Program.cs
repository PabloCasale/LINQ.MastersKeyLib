// See https://aka.ms/new-console-template for more information

var numbers = new[] { 1, 4, 6, 88, 45, 100, 325, 230 };
var letters = new[] { "a", "B", "c", "d" };
//With Func and Predicate
//bool isAnylargerThan100 = IsAny(numbers, IsLargerThan100);
//bool isAnyEven = IsAny(numbers, IsEven);


//With Lambdas
//bool isAnylargerThan100 = IsAny(numbers, number => number > 100);
//bool isAnyEven = IsAny(numbers, number => (number % 2 == 0) );

bool isAnyLargerThan100 = IsAny(numbers, number =>
{
    const int max = 100;
    return number > max;
});

Func<int, bool> isAnyEvenFunc = number => number % 2 == 0;
bool isAnyEven = IsAny(numbers, isAnyEvenFunc);

bool isAnyUppercase = IsAny(letters, letter => letter == letter.ToUpper());

Console.WriteLine($"Is any larger than 100: {isAnyLargerThan100}");
Console.WriteLine($"Is any Even: {isAnyEven}");
Console.WriteLine($"Is any Uppercase: {isAnyUppercase}");


bool IsAny<T>(IEnumerable<T> numbers, Func<T, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}

bool IsLargerThan100(int number)
{
    return number > 100;
}

bool IsLessThan5(int number)
{
    return number < 5;
}