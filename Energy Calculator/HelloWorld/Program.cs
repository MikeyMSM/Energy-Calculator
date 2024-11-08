using System;

class Program
{
    static void Main(string[] args)
    {
        // inputting the name of appliances

        Console.WriteLine("Enter appliance name: ");
        string Appliances = Convert.ToString(Console.ReadLine());
        
        //Enter the number of power rating

        Console.WriteLine("Enter appliances power rating (in kWh): ");
        double PowerRating = Convert.ToDouble(Console.ReadLine());
        
        // enter the number of hours used per day 

        Console.WriteLine("Enter the number of hours used per day the appliance is \nbeing used: ");
        double HoursUsedPerDay = Convert.ToDouble(Console.ReadLine());
        
        // calculation of DailyEnergyUsage, MonthlyEnergyUsage, YearlyEnergyUsage

        double DailyEnergyUsage = PowerRating * HoursUsedPerDay;
        double MonthlyEnergyUsage = DailyEnergyUsage * 30;
        double YearlyEnergyUsage = DailyEnergyUsage * 365;
    
        // output for DailyEnergyUsage, MonthlyEnergyUsage, YearlyEnergyUsage

        Console.WriteLine($"DailyEnergyUsage: {DailyEnergyUsage} kWh");
        Console.WriteLine($"MonthlyEnergyUsage: {MonthlyEnergyUsage} kWh");
        Console.WriteLine($"YearlyEnergyUsage: {YearlyEnergyUsage} kWh");
    }
}

