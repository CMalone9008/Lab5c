using System;

class MainClass {
  public static void Main (string[] args) {
  
  for (int counter=1; counter<=2; counter++)
  
 {
   Console.WriteLine("Enter a number:");
  int num = Convert.ToInt32(Console.ReadLine());
  int a = 0;

 
   for (int i=1; i <= num; i++)
  {
    if (num %i == 0)
     a++;
   }
   if (a==2)
  {
    Console.WriteLine("The number entered is a Prime number");
  }
  else
  {
    Console.WriteLine("The number entered is not a Prime number");
    }
   }
  }
 } 