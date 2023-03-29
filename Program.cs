namespace HW1;

internal class Program
{
    private static void Main()
    {
        int maxNumber; 
        
        MaxFromTwoNumbers _maxFromTwoNumbers = new MaxFromTwoNumbers();
        MaxFromThreeNumbers _maxFromThreeNumbers = new MaxFromThreeNumbers();
        OddAndEven _oddAndEven = new OddAndEven();
        EvenNumbers _evenNumbers = new EvenNumbers();
        bool _odd;

        maxNumber = _maxFromTwoNumbers.GetMaxFromTwoNumbers();
        Console.WriteLine($"Максимальное число из двух - {maxNumber}");
        
        maxNumber = _maxFromThreeNumbers.GetMaxNumberFromThree();
        Console.WriteLine($"Mаксимальное число из трёх - {maxNumber}");
        
        _odd = _oddAndEven.isEven();
        Console.WriteLine(_odd ? "Да" : "Нет");
        
        List<int> _evenNumbersSet = _evenNumbers.GetAllEvenNumbers();
        foreach (var evenNumber in _evenNumbersSet)
            Console.Write($"{evenNumber}, ");
    }
}