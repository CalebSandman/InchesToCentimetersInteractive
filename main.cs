using System;

class Program {
  public static void Main (string[] args) {

    //the ratio of inches to centimeters
    //multiply inches by inToCm to convert
    const double inToCm = 2.54;

    //prompts user to imput a number of inches
    Console.WriteLine ("Enter a number of inches: ");
    var inches = Console.ReadLine();

    //checks if the input was a number or not
    double realInches;
    if(double.TryParse(inches, out realInches))
    {
      //prints the number of inches converted to centimeters
      Console.WriteLine("{0} inches is {1} centimeters", inches, realInches * inToCm);
    }
    else
    {
      //prints an error message if the input was not a number
      Console.WriteLine("Invalid input");
    }
  }
}