namespace HW1;

internal class MaxFromTwoNumbers
{
    private const int COUNT = 2;
    private GetUserNumbers _getUserNumbers = new GetUserNumbers();
    
    internal int GetMaxFromTwoNumbers()
    {
        int[] numbers = _getUserNumbers.GetNumbers(COUNT);
        return numbers[0] > numbers[1] ? numbers[0] : numbers[1];
    }
}