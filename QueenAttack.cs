using System;

class Program
{
  public class Queen
  {
    public static bool CanAttack(int queenX, int queenY, int computerX, int computerY)
    {
      bool horizontalMatch = queenX == computerX;
      bool verticalMatch = queenY == computerY;
      bool diagonalMatch = Math.Abs(queenX - computerX) == Math.Abs(queenY - computerY);
      
      if (horizontalMatch || verticalMatch || diagonalMatch)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
  
  public static void Main()
  {
    // Dictionary<string, int> xCoordinates = new Dictionary<string, int>() { {"A", 1}, {"B", 2}, {"C", 3}, {"D", 4} };

    Console.WriteLine("Please input Queen's X coordinate(1 - 4).");
    string inputQueenX = Console.ReadLine();
    int queenX = int.Parse(inputQueenX);
    Console.WriteLine("Please input Queen's Y coordinate(1 - 4).");
    string inputQueenY = Console.ReadLine();
    int queenY = int.Parse(inputQueenY);
    Console.WriteLine("Please input Computer's X coordinate(1 - 4).");
    string inputComputerX = Console.ReadLine();
    int computerX = int.Parse(inputComputerX);
    Console.WriteLine("Please input Computer's Y coordinate(1 - 4).");
    string inputComputerY = Console.ReadLine();
    int computerY = int.Parse(inputComputerY);

    bool result = Queen.CanAttack(queenX, queenY, computerX, computerY);
    if(result)
    {
      Console.WriteLine("Queen can attack.");
    }
    else
    {
      Console.WriteLine("Queen cannot attack.");
    }
  }
}