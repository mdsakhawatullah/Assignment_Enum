using System;
enum Months
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    Octobor,
    November,
    December
}

class Program
{
    public static void Main()
    {
        Months[] months = (Months[])Enum.GetValues(typeof(Months));
        foreach (var month in months)
        {
            
                Console.WriteLine($"Month name: {month}");
            
        }
    }

}
