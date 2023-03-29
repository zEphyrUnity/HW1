namespace HW1;

internal class GetUserNumbers
{
    internal int[] GetNumbers(int count)
    {
        int[] numbers = new int[count];
        
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите число {i + 1}");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine($"Введите число {i + 1} пожалуйста");
            }
        }

        return numbers;
    }
}