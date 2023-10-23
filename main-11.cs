using System;
using System.Globalization;

class Program {
  public static void Main (string[] args) {
    
    string[] SalesPersonNames = {"Danielle","Edward","Francis"};
    char[] SalesPersonInitials = {'d','e','f'};
    double[] SalesPersonSales = {0,0,0};

    string input ="";
    while(true)
    {
      Console.WriteLine("Enter a Sales persons initials (d,e,f, or z to quit: ");
      input = Console.ReadLine().ToLower();

      if (input == "z")
      break;

      int index = Array.IndexOf(SalesPersonInitials, input[0]);

      if (index != -1)
      {
        Console.WriteLine("Enter the Amount of Sales: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        SalesPersonSales[index] += amount;
      }
      else
      {
        Console.WriteLine("Error, invalid salesperson selected, please try again");
      }
    }
    for (int i=0; i<SalesPersonNames.Length; i++)
    {
      Console.WriteLine($"{SalesPersonNames[i]} sold {SalesPersonSales[i].ToString("c",CultureInfo.GetCultureInfo("en-US"))}");
    }
    double totalAmount = SalesPersonSales[0] + SalesPersonSales[1] + SalesPersonSales[2];
    Console.WriteLine($"Grand Total {totalAmount.ToString("c", CultureInfo.GetCultureInfo("en-US"))}");
    int maxIndex = Array.IndexOf(SalesPersonSales, Math.Max(Math.Max(SalesPersonSales[0],SalesPersonSales[1]), SalesPersonSales[2]));
    int tieCount = 0;

    for (int i=0; i<SalesPersonSales.Length; i++)
    {
      if (SalesPersonSales[i] == SalesPersonSales[maxIndex])
      tieCount++;
    }
    if (tieCount > 1)
    {
      Console.WriteLine("Tie");
    }
    else
    {
      Console.WriteLine($"{SalesPersonNames[maxIndex]} sold the most");
    }

    

    
    

  }
}