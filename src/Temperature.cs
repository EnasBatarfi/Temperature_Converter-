public class Temperature
{    // I Created this class to practice OOP concepts

    // Stores the temperature value
    private double tempValue;
    // Represents the unit of temperature
    private string tempUnit = "";

    // Constructor to set temperature value and unit
    public Temperature(double tempValue, string tempUnit)
    {
        this.tempValue = tempValue;
        this.tempUnit = tempUnit;
    }

    // Default constructor
    public Temperature()
    {

    }

    // Method to get the temperature value
    public double GetTempValue()
    {
        return this.tempValue;
    }

    // Method to set the temperature value
    public void SetTempValue(double tempValue)
    {
        this.tempValue = tempValue;
    }

    // Method to get the temperature unit
    public string GetTempUnit()
    {
        return this.tempUnit;
    }

    // Method to set the temperature unit
    public void SetTempUnit(string tempUnit)
    {
        this.tempUnit = tempUnit;
    }

    // Method to convert temperature from one unit to another
    public double TempConvert()
    {
        double result;
        // Convert Celsius to Fahrenheit if the unit is Celsius
        if (tempUnit == "c")
        {
            result = (tempValue * (9.0 / 5.0)) + 32;
            return result;
        }
        // Convert Fahrenheit to Celsius if the unit is Fahrenheit
        else
        {
            result = (tempValue - 32) * (5.0 / 9.0);
            return result;
        }
    }

}
