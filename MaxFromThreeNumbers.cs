namespace HW1;

internal class MaxFromThreeNumbers
{
    private const int COUNT = 3;
    private GetUserNumbers _getUserNumbers = new GetUserNumbers();

    internal int GetMaxNumberFromThree()
    {
        int[] numbers = _getUserNumbers.GetNumbers(COUNT);
        int max = numbers[0];
        
        if (max < numbers[1]) max = numbers[1];
        if (max < numbers[2]) max = numbers[2];
        
        return max;
    }
}