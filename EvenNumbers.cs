namespace HW1;

public class EvenNumbers
{
    private const int COUNT = 1;
    private GetUserNumbers _getUserNumbers = new GetUserNumbers();

    internal List<int> GetAllEvenNumbers()
    {
        List<int> evenNumbersSet = new List<int>();
        int userNumber = _getUserNumbers.GetNumbers(COUNT)[0];

        for (int i = 0; i <= userNumber; i += 2)
        {
            evenNumbersSet.Add(i);
        }
        
        return evenNumbersSet; 
    }
}