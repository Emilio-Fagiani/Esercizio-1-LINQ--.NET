using Esercizio_1_LINQ__.NET;

internal class Program
{
    private static void Main(string[] args)
    {
        GenerateRandomNumb generateRandomNumb = new GenerateRandomNumb();
        List<int> randomNum = generateRandomNumb.GenerateNumb(10);
        Console.WriteLine();
        Console.WriteLine("Numeri dispari: \n");

        generateRandomNumb.SelectUnevenNumb(randomNum);
        
            
    
            
    }
}