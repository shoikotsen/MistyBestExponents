using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<double> temperatures = new List<double>();
        for (int i = 0; i < 5; i++)
        {
            temperatures.Add(GetTemperatureInput());
        }

        bool ascending = true;
        bool descending = true;
         // Check if the temperatures are in ascending or descending order
        for (int i = 0; i < temperatures.Count - 1; i++)
        {
            if (temperatures[i] > temperatures[i + 1])
                ascending = false;
            if (temperatures[i] < temperatures[i + 1])
                descending = false;
        }

        if (ascending)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (descending)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        Console.Write("5-day Temperature [");
        for (int i = 0; i < temperatures.Count; i++)
        {
            Console.Write(temperatures[i]);
            if (i < temperatures.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        double avgTemp = 0;
        foreach (double temp in temperatures)
        {
            avgTemp += temp;
        }
        avgTemp /= temperatures.Count;

        Console.WriteLine($"Average Temperature is {avgTemp:F1} degrees");
    }

    static double GetTemperatureInput()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter a temperature (-30 to 130): ");
                double temp = Convert.ToDouble(Console.ReadLine());
                if (temp < -30 || temp > 130)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return temp;
            }
            catch (Exception)
            {
                Console.WriteLine("EXCEPTION Temperature -25 is invalid, Please enter a valid temperature between -30 and 130)");
            }
        }
    }
}
//2024/6/22_SenShoikot_Exercise 5.2