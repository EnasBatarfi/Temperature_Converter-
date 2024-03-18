using System;

class TemperatureConverter
{
    // The Main method is where the program execution begins.
    public static void Main(string[] args)
    {
        // This try and catch block to handles any runtime errors.
        try
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Welcome to the Temperature Converter!");
            Console.WriteLine("---------------------------------------------------------");

            // This while loop keeps the program running until the user chooses to exit.
            while (true)
            {
                Console.Write("Enter a temperature value followed by unit (e.g., 32 F or 100 C), or type 'exit' to quit: ");


                // Read user input, making sure it's not null.
                string input = Console.ReadLine() ?? "";
                // Trim spaces and convert to lowercase for easier processing
                input = input.Trim().ToLower();
                // If the user types 'exit' then terminate the program.
                if (input == "exit")
                {
                    Console.WriteLine("Thank you for using our app!");
                    Environment.Exit(0);
                }

                // Split the input into value and unit.
                string[] temperatureInput = input.Split(" ");

                // Check if the input array contains exactly 2 elements (value and unit).
                if (temperatureInput.Length != 2)
                {
                    Console.WriteLine("Invalid input. Please enter temperature value and unit separated by space.");
                    continue;
                }

                // Check if the value element can be converted into a double.
                if (!double.TryParse(temperatureInput[0], out double tempValue))
                {
                    Console.WriteLine("Invalid value. Please enter a valid number for temperature value.");
                    continue;
                }

                // Check if the unit element is 'c' (Celsius) or 'f' (Fahrenheit).
                if (temperatureInput[1] != "c" && temperatureInput[1] != "f")
                {
                    Console.WriteLine("Invalid unit. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                    continue;
                }

                // Create a Temperature object to handle temperature conversion. 
                Temperature temperature = new Temperature(tempValue, temperatureInput[1]);
                // Call the ConvertTemperature method to obtain the converted temperature value.
                double convertedTemp = temperature.ConvertTemperature();

                // Format and display the converted temperature.
                Console.WriteLine($"Converted temperature: {convertedTemp:F2} {(temperature.GetTempUnit() == "c" ? "F" : "C")}");
                Console.WriteLine("---------------------------------------------------------");

            }
        }
        catch (Exception error)
        {
            // If any exceptions occur during runtime, catch and display them.
            Console.WriteLine("Exception: " + error.Message);
        }
    }
}
