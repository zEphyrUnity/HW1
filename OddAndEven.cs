namespace HW1;

internal class OddAndEven
{
    private const int COUNT = 1;
    private GetUserNumbers _getUserNumbers = new GetUserNumbers();

    internal bool isEven()
    {
        int userNumber = _getUserNumbers.GetNumbers(COUNT)[0];
        return userNumber % 2 == 0 ? true : false;
    }
}