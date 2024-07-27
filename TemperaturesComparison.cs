using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        // Create a list to store temperatures
        List<double> temperatures = new List<double>();
        // Get 5 temperature inputs from the user
        for (int i = 0; i < 5; i++)
        {
            temperatures.Add(GetTemperatureInput());
        }
        // Initialize flags for ascending and descending order checks
        bool ascending = true;
        bool descending = true;
         // Check if the temperatures are in ascending or descending order
        for (int i = 0; i < temperatures.Count - 1; i++)
        {
            // Check if the temperatures are in ascending or descending order

            if (temperatures[i] > temperatures[i + 1])
                ascending = false;
            if (temperatures[i] < temperatures[i + 1])
                descending = false;
        }
        // Output the result based on the order of temperatures

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
         // Display the 5-day temperature readings
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
        // Calculate the average temperature
        double avgTemp = 0;
        foreach (double temp in temperatures)
        {
            avgTemp += temp;
        }
        avgTemp /= temperatures.Count;
        // Output the average temperature
        Console.WriteLine($"Average Temperature is {avgTemp:F1} degrees");
    }
    // Method to get valid temperature input from the user
    static double GetTemperatureInput()
    {
        while (true)
        {
            try
            {
                // Prompt the user to enter a temperature
                Console.Write("Enter a temperature (-30 to 130): ");
                double temp = Convert.ToDouble(Console.ReadLine());

                // Validate the temperature range
                if (temp < -30 || temp > 130)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return temp; // Return valid temperature
            }
            catch (Exception)
            {
                // Handle invalid input and prompt again
                Console.WriteLine("EXCEPTION Temperature -25 is invalid, Please enter a valid temperature between -30 and 130)");
            }
        }
    }
}
//2024/6/22_SenShoikot_Exercise 5.2