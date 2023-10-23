using System;

class Program {
  public static void Main (string[] args) {
     Console.WriteLine ("Sales person's: danielle, edward, francis");
    string initial = "";
    
    double[] SalesPersonSales = new double[3];
    string[] SalesPersonInitial = new string[3];
    string[] SalesPersonNames = new string[3];

    for(int i=0;i<SalesPersonSales.Length;i++)
     SalesPersonSales[i] = 0;

    SalesPersonInitial[0] = "d";
    SalesPersonInitial[1] = "e";
    SalesPersonInitial[2] = "f";
    SalesPersonNames[0] = "danielle";
    SalesPersonNames[1] = "edward";
    SalesPersonNames[2] = "francis";

    double TotalSales = 0;
    
    //double d = 0.00;
    //double e = 0.00;
    //double f = 0.00;
    //double x = 0.00;
    int index;

    while (initial != "z"){
      Console.WriteLine("please enter a sales persons first initial(D,E,F, Z to exit): ");
      initial = Console.ReadLine().ToLower()[0];
      
      for(index=0;index<SalesPersonInitial.Length;index++){
        if(SalesPersonInitial[index] == initial ){
          break;
        }
      }
      

      if (index == SalesPersonInitial.Length){
        Console.WriteLine("enter number of sales: ");
        double sales = Convert.ToDouble(Console.ReadLine());
        SalesPersonSales[index] += sales;
      }  

      else{
        if(initial!="z")
      {
          Console.WriteLine("Error, invalid salesperson, please try again");
        }
      }  
    }

    for(index=0;index<SalesPersonSales.Length;index++){
      TotalSales+=SalesPersonSales[index];
      Console.WriteLine("{0} sold {1}",SalesPersonNames[index],SalesPersonSales[index]);
    }

    if(SalespersonSales[0]>SalesPersonSales[1] && SalespersonSales[0]>SalespersonSales[2]){
        Console.WriteLine("highest amount: D");
      }
    else if(SalespersonSales[1]>SalesPersonSales[0] && SalesPersonSales[1]>SalesPersonSales[2]){
        Console.WriteLine("highest amount: E");
      }
    else{
        Console.WriteLine("highest amount: F");
      }
  }
}