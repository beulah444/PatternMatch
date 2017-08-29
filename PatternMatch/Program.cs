using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        //need to detect 525,528,530 to 599
        string pattern = @"\b(52[5,8])|(5[3-9][0-9])\b";

        string input = "600 789 558 524 525 526 527 528 531 530 540 541 555 543 567 560  570 598 599 888";

        foreach (Match match in Regex.Matches(input, pattern))
            Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);

        Console.WriteLine();
        Console.ReadKey();
    }
}